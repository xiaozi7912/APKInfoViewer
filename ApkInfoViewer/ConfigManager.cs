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

        public String path_ADB { get; set; }
        public String path_AAPT { get; set; }
        public String path_SIGNAPK { get; set; }
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
                            if (readLine.Split('=')[0] == FIELD_ADB) {
                                path_ADB = readLine.Split('=')[1];
                            } else if (readLine.Split('=')[0] == FIELD_AAPT) {
                                path_AAPT = readLine.Split('=')[1];
                            } else if (readLine.Split('=')[0] == FIELD_SIGNAPK) {
                                path_SIGNAPK = readLine.Split('=')[1];
                            } else if (readLine.Split('=')[0] == FIELD_PLATFORM_KEY) {
                                String infos = readLine.Split('=')[1];

                                if (keyList == null) {
                                    keyList = new List<PlatformKey>();
                                }

                                PlatformKey platformKey = new PlatformKey();
                                platformKey.description = infos.Split('&')[0];
                                platformKey.path_pem = infos.Split('&')[1];
                                platformKey.path_pk8 = infos.Split('&')[2];
                                keyList.Add(platformKey);
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

            keyList.Add(platformKey);
            writeFile();
        }

        private void writeFile() {
            using (FileStream stream = File.OpenWrite(CONFIG_FILE_PATH)) {
                StreamWriter writer = new StreamWriter(stream);
                writer.WriteLine(FIELD_ADB + "=" + path_ADB);
                writer.WriteLine(FIELD_AAPT + "=" + path_AAPT);
                writer.WriteLine(FIELD_SIGNAPK + "=" + path_SIGNAPK);

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
