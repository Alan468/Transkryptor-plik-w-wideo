using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transcoder
{
    public class TranscodeData
    {
        public string FullPath { get; set; }
        public string Path { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public double Size { get; set; }

        public DateTime CreationDate { get; set; }
        public DateTime ModifyDate { get; set; }
        
        public int VideoChanels { get; set; }
        public int VideoBiterate { get; set; }

        public int Height { get; set; }
        public int Width { get; set; }
        public float Fps { get; set; }
        
        public int AudioChanels { get; set; }
        public int AudioBiterate { get; set; }

        public float Length { get; set; }
        public int Chanels { get; set; }
    }
}
