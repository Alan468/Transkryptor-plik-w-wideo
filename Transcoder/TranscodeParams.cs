using System.ComponentModel;

namespace Transcoder
{
    public class TranscodeParams
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string Format { get; set; }
        public int FPS { get; set; }

        public bool SetSize { get; set; } // true WxH // false scale
        public int Width { get; set; }
        public int Height { get; set; }
        public float Scale { get; set; }

        public int VideoBitrate { get; set; }
        public int AudioBitrate { get; set; }

        public string Container { get; set; }

        public VideoCodec VideoCodec { get; set; }
        public AudioCodec AudioCodec { get; set; }

        public double OriginalSize { get; set; }
        public double TranscodedSize { get; set; }
        public long Time { get; set; }

    }

    public enum VideoCodec
    {
        [Description("")]
        mp1v,
        mp2v,
        mp4v,
        SVQ1,
        SVQ3,
        DVDv,
        WMV1,
        MWV2,
        DVSD,
        MJPG,
        H263,
        h264,
        theo,
        IV20,
        IV40,
        RV10,
        cvid,
        VP31,
        FLV1,
        CYUV,
        HFYU,
        MSVC,
        MRLE,
        AASC,
        FLIC,
        QPEG,
        VP8,
    }

    public enum AudioCodec
    {
        mpga,
        mp3,
        mp4a,
        a52,
        vorb,
        spx,
        flac,
        fl32,
    }

    public enum Containers
    {
        ts,
        ps,
        ogg,
        asf,
        mp4,
        mov,
        mpmjpeg,
        rtp,
        raw,
    }
}
