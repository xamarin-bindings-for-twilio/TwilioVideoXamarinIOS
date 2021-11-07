using System;
using CoreMedia;
using Foundation;
using Twilio.Video.iOS;

namespace Sample
{
    public class VideoViewDelegate : TVIVideoViewDelegate
    {
        #region Fields

        static VideoViewDelegate _instance;

        #endregion

        #region Properties

        public static VideoViewDelegate Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new VideoViewDelegate();
                }

                return _instance;
            }
        }

        #endregion

        #region Events

        public event EventHandler<TVIVideoView> VideoViewDidReceiveDataEvent;
        public event EventHandler<(TVIVideoView view, CMVideoDimensions dimensions)> VideoDimensionsDidChangeEvent;
        public event EventHandler<(TVIVideoView view, TVIVideoOrientation orientation)> VideoOrientationDidChangeEvent;

        #endregion

        #region Methods

        // @optional -(void)videoViewDidReceiveData:(TVIVideoView * _Nonnull)view;
        [Export("videoViewDidReceiveData:")]
        public override void VideoViewDidReceiveData(TVIVideoView view)
        {
            Console.WriteLine("VideoViewDidReceiveData");
            VideoViewDidReceiveDataEvent?.Invoke(this, view);
        }

        // @optional -(void)videoView:(TVIVideoView * _Nonnull)view videoDimensionsDidChange:(CMVideoDimensions)dimensions;
        [Export("videoView:videoDimensionsDidChange:")]
        public override void VideoViewVideoDimensionsDidChange(TVIVideoView view, CMVideoDimensions dimensions)
        {
            Console.WriteLine("VideoViewVideoDimensionsDidChange");
            VideoDimensionsDidChangeEvent?.Invoke(this, (view, dimensions));
        }

        // @optional -(void)videoView:(TVIVideoView * _Nonnull)view videoOrientationDidChange:(TVIVideoOrientation)orientation;
        [Export("videoView:videoOrientationDidChange:")]
        public override void VideoViewVideoOrientationDidChange(TVIVideoView view, TVIVideoOrientation orientation)
        {
            Console.WriteLine("VideoView");
            VideoOrientationDidChangeEvent?.Invoke(this, (view, orientation));
        }

        #endregion
    }
}
