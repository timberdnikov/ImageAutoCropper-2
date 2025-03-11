using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageAutoCropper
{
    public class Settings
    {
        public bool isFolder = false;
        public bool BC_isFolder = false;
        public string BC_outputPath = "";
        public string outputPath = "";
        public bool separate = false;
        public bool autoSettings = true;
        public string XDist = "0", YDist = "0";
        public string borderThikness = "0";
        public string minXSize = "100", minYSize = "100";
        public string threshold = "10";
        public string imageDilating = "2";
        public string imageEroding = "2";
        public string smooth = "0";
        public string brightness = "-35";
        public string contrast = "45";
        public bool disableSeparatingInPrewiew = true;
        public int saveFormat = 1;
        public string borderColor = "255|255|0|0";
        public int windowSizeX = 1545;
        public int windowSizeY = 887;
        public bool isMaximized = false;
        public bool autoRotate = true;
        public bool autoBC = false;
        public bool BC_autoBC = false;
        public string outputBrightness = "0";
        public string BC_Brightness = "0";
        public string outputContrast = "0";
        public string BC_Contrast = "0";
        public string tileGridSize = "40";
        public string BC_tileGridSize = "40";
        public string autoContrastIntensity = "0.6";
        public string BC_autoContrastIntensity = "0.6";
        public int BC_saveFormat = 1;
        public bool EENumeration = false;
        public string EENumerationIndex = "1";
        public int detectionResolution = 0;
        public bool isGrayView = true;
        public bool sortByName = false;
        public int presetIndex = 0;
        public bool saveToFolders = false;

        public void Save(string path)
        {
            var str = JsonConvert.SerializeObject(this);
            File.WriteAllText(path,str);
        }
        public void Load(string path)
        {
            if (!File.Exists(path)) return;
            try
            {
                Settings set = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(path));
                BC_isFolder = set.BC_isFolder;
                BC_outputPath = set.BC_outputPath;
                outputPath = set.outputPath;
                BC_autoBC = set.BC_autoBC;
                BC_Brightness = set.BC_Brightness;
                BC_Contrast = set.BC_Contrast;
                isFolder = set.isFolder;
                separate = set.separate;
                XDist = set.XDist;
                YDist = set.YDist;
                borderThikness = set.borderThikness;
                minXSize = set.minXSize;
                minYSize = set.minYSize;
                threshold = set.threshold;
                imageDilating = set.imageDilating;
                imageEroding = set.imageEroding;
                disableSeparatingInPrewiew = set.disableSeparatingInPrewiew;
                smooth = set.smooth;
                brightness = set.brightness;
                contrast = set.contrast;
                saveFormat = set.saveFormat;
                borderColor = set.borderColor;
                autoSettings = set.autoSettings;
                windowSizeX = set.windowSizeX;
                windowSizeY = set.windowSizeY;
                isMaximized = set.isMaximized;
                autoRotate = set.autoRotate;
                autoBC = set.autoBC;
                outputBrightness = set.outputBrightness;
                outputContrast = set.outputContrast;
                tileGridSize = set.tileGridSize;
                BC_tileGridSize = set.BC_tileGridSize;
                autoContrastIntensity = set.autoContrastIntensity;
                BC_autoContrastIntensity = set.BC_autoContrastIntensity;
                BC_saveFormat = set.BC_saveFormat;
                EENumeration = set.EENumeration;
                EENumerationIndex = set.EENumerationIndex;
                detectionResolution = set.detectionResolution;
                isGrayView = set.isGrayView;
                sortByName = set.sortByName;
                presetIndex = set.presetIndex;
                saveToFolders = set.saveToFolders;
            }
            catch { }
        }
    }
}
