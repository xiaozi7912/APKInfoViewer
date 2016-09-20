using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApkInfoViewer {
    class ConfigManager {
        private static String CONFIG_FILE_PATH = Directory.GetCurrentDirectory() + @"\config.ini";
        private const String FIELD_ADB = "ADB";
        private const String FIELD_AAPT = "AAPT";
        private const String FIELD_SIGNAPK = "SIGNAPK";
        private const String FIELD_PLATFORM_KEY = "PLATFORM_KEY";
        private const String FIELD_LAST_SELECTED_FOLDER = "LAST_SELECTED_FOLDER";

        public String path_ADB { get; set; }
        public String path_AAPT { get; set; }
        public String path_SIGNAPK { get; set; }
        public String path_last_selected_folder { get; set; }
        public List<PlatformKey> keyList { get; set; }

        public ConfigManager() {
            FileInfo fileInfo = new FileInfo(CONFIG_FILE_PATH);

            if (!fileInfo.Exists) {
                using (FileStream stream = fileInfo.Create()) {
                    stream.Close();
                }
                new ToolForm().Show();
            } else {
                using (FileStream stream = fileInfo.OpenRead()) {
                    StreamReader reader = new StreamReader(stream);
                    while (!reader.EndOfStream) {
                        String readLine = reader.ReadLine();
                        Console.WriteLine("readLine : " + readLine);

                        if (readLine.Contains("=")) {
                            String keyString = readLine.Split('=')[0];
                            String valueString = readLine.Split('=')[1];
                            Console.WriteLine("keyString : " + keyString);
                            Console.WriteLine("valueString : " + valueString);

                            if (keyString.Equals(FIELD_ADB)) {
                                path_ADB = valueString;
                            } else if (keyString.Equals(FIELD_AAPT)) {
                                path_AAPT = valueString;
                            } else if (keyString.Equals(FIELD_SIGNAPK)) {
                                path_SIGNAPK = valueString;
                            } else if (keyString.Equals(FIELD_PLATFORM_KEY)) {
                                String infos = valueString;

                                if (keyList == null) {
                                    keyList = new List<PlatformKey>();
                                }

                                PlatformKey platformKey = new PlatformKey();
                                platformKey.description = infos.Split('&')[0];
                                platformKey.path_pem = infos.Split('&')[1];
                                platformKey.path_pk8 = infos.Split('&')[2];
                                keyList.Add(platformKey);
                            } else if (keyString.Equals(FIELD_LAST_SELECTED_FOLDER)) {
                                path_last_selected_folder = valueString;
                            }
                        }
                    }
                    reader.Close();
                    stream.Close();
                }
            }
        }

        public void setADBPath(String path) {
            path_ADB = path;
            writeFile();
        }

        public void setAAPTPath(String path) {
            path_AAPT = path;
            writeFile();
        }

        public void setSIGNAPKPath(String path) {
            path_SIGNAPK = path;
            writeFile();
        }

        public void addPlatformKey(PlatformKey platformKey) {
            if (keyList == null) {
                keyList = new List<PlatformKey>();
            }

            bool exists = false;
            foreach (PlatformKey item in keyList) {
                if (item.description.Equals(platformKey.description)) {
                    item.path_pem = platformKey.path_pem;
                    item.path_pk8 = platformKey.path_pk8;
                    exists = true;
                    break;
                }
            }
            if (!exists) {
                keyList.Add(platformKey);
            }
            writeFile();
        }

        public void setLastSelectedPath(String path) {
            path_last_selected_folder = path;
            writeFile();
        }

        private void writeFile() {
            using (FileStream stream = File.OpenWrite(CONFIG_FILE_PATH)) {
                StreamWriter writer = new StreamWriter(stream);
                writer.WriteLine(FIELD_ADB + "=" + path_ADB);
                writer.WriteLine(FIELD_AAPT + "=" + path_AAPT);
                writer.WriteLine(FIELD_SIGNAPK + "=" + path_SIGNAPK);
                writer.WriteLine(FIELD_LAST_SELECTED_FOLDER + "=" + path_last_selected_folder);

                if (keyList != null && keyList.Count > 0) {
                    foreach (PlatformKey platformKey in keyList) {
                        writer.WriteLine(String.Format("{0}={1}&{2}&{3}",
                            FIELD_PLATFORM_KEY,
                            platformKey.description,
                            platformKey.path_pem,
                            platformKey.path_pk8));
                    }
                }

                writer.Flush();
                writer.Close();
                stream.Close();
            }
        }
    }
}
