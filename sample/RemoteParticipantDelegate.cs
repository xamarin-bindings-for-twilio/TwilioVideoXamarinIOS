using System;
using Foundation;
using Twilio.Video.iOS;

namespace Sample
{
    public class RemoteParticipantDelegate : TVIRemoteParticipantDelegate
    {
        #region Fields

        private static RemoteParticipantDelegate _instance;

        #endregion

        #region Properties

        public static RemoteParticipantDelegate Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RemoteParticipantDelegate();
                }

                return _instance;
            }
        }

        #endregion

        #region Events

        public event EventHandler<(TVIRemoteParticipant participant, TVIRemoteVideoTrackPublication publication)> RemoteParticipantDidPublishVideoTrackEvent;
        public event EventHandler<(TVIRemoteParticipant participant, TVIRemoteVideoTrackPublication publication)> RemoteParticipantDidUnpublishVideoTrackEvent;
        public event EventHandler<(TVIRemoteParticipant participant, TVIRemoteAudioTrackPublication publication)> RemoteParticipantDidPublishAudioTrackEvent;
        public event EventHandler<(TVIRemoteParticipant participant, TVIRemoteAudioTrackPublication publication)> RemoteParticipantDidUnpublishAudioTrackEvent;
        public event EventHandler<(TVIRemoteParticipant participant, TVIRemoteDataTrackPublication publication)> RemoteParticipantDidPublishDataTrackEvent;
        public event EventHandler<(TVIRemoteParticipant participant, TVIRemoteDataTrackPublication publication)> RemoteParticipantDidUnpublishDataTrackEvent;
        public event EventHandler<(TVIRemoteParticipant participant, TVIRemoteVideoTrackPublication publication)> RemoteParticipantDidEnableVideoTrackEvent;
        public event EventHandler<(TVIRemoteParticipant participant, TVIRemoteVideoTrackPublication publication)> RemoteParticipantDidDisableVideoTrackEvent;
        public event EventHandler<(TVIRemoteParticipant participant, TVIRemoteAudioTrackPublication publication)> RemoteParticipantDidEnableAudioTrackEvent;
        public event EventHandler<(TVIRemoteParticipant participant, TVIRemoteAudioTrackPublication publication)> RemoteParticipantDidDisableAudioTrackEvent;
        public event EventHandler<(TVIRemoteVideoTrack videoTrack, TVIRemoteVideoTrackPublication publication, TVIRemoteParticipant participant)> DidSubscribeToVideoTrackEvent;
        public event EventHandler<(TVIRemoteVideoTrackPublication publication, NSError error, TVIRemoteParticipant participant)> DidFailToSubscribeToVideoTrackEvent;
        public event EventHandler<(TVIRemoteVideoTrack videoTrack, TVIRemoteVideoTrackPublication publication, TVIRemoteParticipant participant)> DidUnsubscribeFromVideoTrackEvent;
        public event EventHandler<(TVIRemoteAudioTrack audioTrack, TVIRemoteAudioTrackPublication publication, TVIRemoteParticipant participant)> DidSubscribeToAudioTrackEvent;
        public event EventHandler<(TVIRemoteAudioTrackPublication publication, NSError error, TVIRemoteParticipant participant)> DidFailToSubscribeToAudioTrackEvent;
        public event EventHandler<(TVIRemoteAudioTrack audioTrack, TVIRemoteAudioTrackPublication publication, TVIRemoteParticipant participant)> DidUnsubscribeFromAudioTrackEvent;
        public event EventHandler<(TVIRemoteDataTrack dataTrack, TVIRemoteDataTrackPublication publication, TVIRemoteParticipant participant)> DidSubscribeToDataTrackEvent;
        public event EventHandler<(TVIRemoteDataTrackPublication publication, NSError error, TVIRemoteParticipant participant)> DidFailToSubscribeToDataTrackEvent;
        public event EventHandler<(TVIRemoteDataTrack dataTrack, TVIRemoteDataTrackPublication publication, TVIRemoteParticipant participant)> DidUnsubscribeFromDataTrackEvent;
        public event EventHandler<(TVIRemoteParticipant participant, TVINetworkQualityLevel networkQualityLevel)> RemoteParticipantNetworkQualityLevelDidChangeEvent;
        public event EventHandler<(TVIRemoteParticipant participant, TVIRemoteVideoTrack track)> RemoteParticipantSwitchedOffVideoTrackEvent;
        public event EventHandler<(TVIRemoteParticipant participant, TVIRemoteVideoTrack track)> RemoteParticipantSwitchedOnVideoTrackEvent;
        public event EventHandler<(TVIRemoteParticipant participant, string priority, TVIRemoteAudioTrackPublication publication)> RemoteParticipantDidChangePublishPriorityForAudioTrackEvent;
        public event EventHandler<(TVIRemoteParticipant participant, string priority, TVIRemoteVideoTrackPublication publication)> RemoteParticipantDidChangePublishPriorityForVideoTrackEvent;
        public event EventHandler<(TVIRemoteParticipant participant, string priority, TVIRemoteDataTrackPublication publication)> RemoteParticipantDidChangePublishPriorityForDataTrackEvent;

        #endregion

        #region Methods
        // @optional -(void)remoteParticipant:(TVIRemoteParticipant * _Nonnull)participant didPublishVideoTrack:(TVIRemoteVideoTrackPublication * _Nonnull)publication __attribute__((swift_name("remoteParticipantDidPublishVideoTrack(participant:publication:)")));
        [Export("remoteParticipant:didPublishVideoTrack:")]
        public override void RemoteParticipantDidPublishVideoTrack(TVIRemoteParticipant participant, TVIRemoteVideoTrackPublication publication)
        {
            Console.WriteLine("RemoteParticipantDidPublishVideoTrack");
            RemoteParticipantDidPublishVideoTrackEvent?.Invoke(this, (participant, publication));
        }

        // @optional -(void)remoteParticipant:(TVIRemoteParticipant * _Nonnull)participant didUnpublishVideoTrack:(TVIRemoteVideoTrackPublication * _Nonnull)publication __attribute__((swift_name("remoteParticipantDidUnpublishVideoTrack(participant:publication:)")));
        [Export("remoteParticipant:didUnpublishVideoTrack:")]
        public override void RemoteParticipantDidUnpublishVideoTrack(TVIRemoteParticipant participant, TVIRemoteVideoTrackPublication publication)
        {
            Console.WriteLine("RemoteParticipantDidUnpublishVideoTrack");
            RemoteParticipantDidUnpublishVideoTrackEvent?.Invoke(this, (participant, publication));
        }

        // @optional -(void)remoteParticipant:(TVIRemoteParticipant * _Nonnull)participant didPublishAudioTrack:(TVIRemoteAudioTrackPublication * _Nonnull)publication __attribute__((swift_name("remoteParticipantDidPublishAudioTrack(participant:publication:)")));
        [Export("remoteParticipant:didPublishAudioTrack:")]
        public override void RemoteParticipantDidPublishAudioTrack(TVIRemoteParticipant participant, TVIRemoteAudioTrackPublication publication)
        {
            Console.WriteLine("RemoteParticipantDidPublishAudioTrack");
            RemoteParticipantDidPublishAudioTrackEvent?.Invoke(this, (participant, publication));
        }

        // @optional -(void)remoteParticipant:(TVIRemoteParticipant * _Nonnull)participant didUnpublishAudioTrack:(TVIRemoteAudioTrackPublication * _Nonnull)publication __attribute__((swift_name("remoteParticipantDidUnpublishAudioTrack(participant:publication:)")));
        [Export("remoteParticipant:didUnpublishAudioTrack:")]
        public override void RemoteParticipantDidUnpublishAudioTrack(TVIRemoteParticipant participant, TVIRemoteAudioTrackPublication publication)
        {
            Console.WriteLine("RemoteParticipantDidUnpublishAudioTrack");
            RemoteParticipantDidUnpublishAudioTrackEvent?.Invoke(this, (participant, publication));
        }

        // @optional -(void)remoteParticipant:(TVIRemoteParticipant * _Nonnull)participant didPublishDataTrack:(TVIRemoteDataTrackPublication * _Nonnull)publication __attribute__((swift_name("remoteParticipantDidPublishDataTrack(participant:publication:)")));
        [Export("remoteParticipant:didPublishDataTrack:")]
        public override void RemoteParticipantDidPublishDataTrack(TVIRemoteParticipant participant, TVIRemoteDataTrackPublication publication)
        {
            Console.WriteLine("RemoteParticipantDidPublishDataTrack");
            RemoteParticipantDidPublishDataTrackEvent?.Invoke(this, (participant, publication));
        }

        // @optional -(void)remoteParticipant:(TVIRemoteParticipant * _Nonnull)participant didUnpublishDataTrack:(TVIRemoteDataTrackPublication * _Nonnull)publication __attribute__((swift_name("remoteParticipantDidUnpublishDataTrack(participant:publication:)")));
        [Export("remoteParticipant:didUnpublishDataTrack:")]
        public override void RemoteParticipantDidUnpublishDataTrack(TVIRemoteParticipant participant, TVIRemoteDataTrackPublication publication)
        {
            Console.WriteLine("RemoteParticipantDidUnpublishDataTrack");
            RemoteParticipantDidUnpublishDataTrackEvent?.Invoke(this, (participant, publication));
        }

        // @optional -(void)remoteParticipant:(TVIRemoteParticipant * _Nonnull)participant didEnableVideoTrack:(TVIRemoteVideoTrackPublication * _Nonnull)publication __attribute__((swift_name("remoteParticipantDidEnableVideoTrack(participant:publication:)")));
        [Export("remoteParticipant:didEnableVideoTrack:")]
        public override void RemoteParticipantDidEnableVideoTrack(TVIRemoteParticipant participant, TVIRemoteVideoTrackPublication publication)
        {
            Console.WriteLine("RemoteParticipantDidEnableVideoTrack");
            RemoteParticipantDidEnableVideoTrackEvent?.Invoke(this, (participant, publication));
        }

        // @optional -(void)remoteParticipant:(TVIRemoteParticipant * _Nonnull)participant didDisableVideoTrack:(TVIRemoteVideoTrackPublication * _Nonnull)publication __attribute__((swift_name("remoteParticipantDidDisableVideoTrack(participant:publication:)")));
        [Export("remoteParticipant:didDisableVideoTrack:")]
        public override void RemoteParticipantDidDisableVideoTrack(TVIRemoteParticipant participant, TVIRemoteVideoTrackPublication publication)
        {
            Console.WriteLine("RemoteParticipantDidDisableVideoTrack");
            RemoteParticipantDidDisableVideoTrackEvent?.Invoke(this, (participant, publication));
        }

        // @optional -(void)remoteParticipant:(TVIRemoteParticipant * _Nonnull)participant didEnableAudioTrack:(TVIRemoteAudioTrackPublication * _Nonnull)publication __attribute__((swift_name("remoteParticipantDidEnableAudioTrack(participant:publication:)")));
        [Export("remoteParticipant:didEnableAudioTrack:")]
        public override void RemoteParticipantDidEnableAudioTrack(TVIRemoteParticipant participant, TVIRemoteAudioTrackPublication publication)
        {
            Console.WriteLine("RemoteParticipantDidEnableAudioTrack");
            RemoteParticipantDidEnableAudioTrackEvent?.Invoke(this, (participant, publication));
        }

        // @optional -(void)remoteParticipant:(TVIRemoteParticipant * _Nonnull)participant didDisableAudioTrack:(TVIRemoteAudioTrackPublication * _Nonnull)publication __attribute__((swift_name("remoteParticipantDidDisableAudioTrack(participant:publication:)")));
        [Export("remoteParticipant:didDisableAudioTrack:")]
        public override void RemoteParticipantDidDisableAudioTrack(TVIRemoteParticipant participant, TVIRemoteAudioTrackPublication publication)
        {
            Console.WriteLine("RemoteParticipantDidDisableAudioTrack");
            RemoteParticipantDidDisableAudioTrackEvent?.Invoke(this, (participant, publication));
        }

        // @optional -(void)didSubscribeToVideoTrack:(TVIRemoteVideoTrack * _Nonnull)videoTrack publication:(TVIRemoteVideoTrackPublication * _Nonnull)publication forParticipant:(TVIRemoteParticipant * _Nonnull)participant __attribute__((swift_name("didSubscribeToVideoTrack(videoTrack:publication:participant:)")));
        [Export("didSubscribeToVideoTrack:publication:forParticipant:")]
        public override void DidSubscribeToVideoTrack(TVIRemoteVideoTrack videoTrack, TVIRemoteVideoTrackPublication publication, TVIRemoteParticipant participant)
        {
            Console.WriteLine("DidSubscribeToVideoTrack");
            DidSubscribeToVideoTrackEvent?.Invoke(this, (videoTrack, publication, participant));
        }

        // @optional -(void)didFailToSubscribeToVideoTrack:(TVIRemoteVideoTrackPublication * _Nonnull)publication error:(NSError * _Nonnull)error forParticipant:(TVIRemoteParticipant * _Nonnull)participant __attribute__((swift_name("didFailToSubscribeToVideoTrack(publication:error:participant:)")));
        [Export("didFailToSubscribeToVideoTrack:error:forParticipant:")]
        public override void DidFailToSubscribeToVideoTrack(TVIRemoteVideoTrackPublication publication, NSError error, TVIRemoteParticipant participant)
        {
            Console.WriteLine("DidFailToSubscribeToVideoTrack");
            DidFailToSubscribeToVideoTrackEvent?.Invoke(this, (publication, error, participant));
        }

        // @optional -(void)didUnsubscribeFromVideoTrack:(TVIRemoteVideoTrack * _Nonnull)videoTrack publication:(TVIRemoteVideoTrackPublication * _Nonnull)publication forParticipant:(TVIRemoteParticipant * _Nonnull)participant __attribute__((swift_name("didUnsubscribeFromVideoTrack(videoTrack:publication:participant:)")));
        [Export("didUnsubscribeFromVideoTrack:publication:forParticipant:")]
        public override void DidUnsubscribeFromVideoTrack(TVIRemoteVideoTrack videoTrack, TVIRemoteVideoTrackPublication publication, TVIRemoteParticipant participant)
        {
            Console.WriteLine("DidUnsubscribeFromVideoTrack");
            DidUnsubscribeFromVideoTrackEvent?.Invoke(this, (videoTrack, publication, participant));
        }

        // @optional -(void)didSubscribeToAudioTrack:(TVIRemoteAudioTrack * _Nonnull)audioTrack publication:(TVIRemoteAudioTrackPublication * _Nonnull)publication forParticipant:(TVIRemoteParticipant * _Nonnull)participant __attribute__((swift_name("didSubscribeToAudioTrack(audioTrack:publication:participant:)")));
        [Export("didSubscribeToAudioTrack:publication:forParticipant:")]
        public override void DidSubscribeToAudioTrack(TVIRemoteAudioTrack audioTrack, TVIRemoteAudioTrackPublication publication, TVIRemoteParticipant participant)
        {
            Console.WriteLine("DidSubscribeToAudioTrack");
            DidSubscribeToAudioTrackEvent?.Invoke(this, (audioTrack, publication, participant));
        }

        // @optional -(void)didFailToSubscribeToAudioTrack:(TVIRemoteAudioTrackPublication * _Nonnull)publication error:(NSError * _Nonnull)error forParticipant:(TVIRemoteParticipant * _Nonnull)participant __attribute__((swift_name("didFailToSubscribeToAudioTrack(publication:error:participant:)")));
        [Export("didFailToSubscribeToAudioTrack:error:forParticipant:")]
        public override void DidFailToSubscribeToAudioTrack(TVIRemoteAudioTrackPublication publication, NSError error, TVIRemoteParticipant participant)
        {
            Console.WriteLine("DidFailToSubscribeToAudioTrack");
            DidFailToSubscribeToAudioTrackEvent?.Invoke(this, (publication, error, participant));
        }

        // @optional -(void)didUnsubscribeFromAudioTrack:(TVIRemoteAudioTrack * _Nonnull)audioTrack publication:(TVIRemoteAudioTrackPublication * _Nonnull)publication forParticipant:(TVIRemoteParticipant * _Nonnull)participant __attribute__((swift_name("didUnsubscribeFromAudioTrack(audioTrack:publication:participant:)")));
        [Export("didUnsubscribeFromAudioTrack:publication:forParticipant:")]
        public override void DidUnsubscribeFromAudioTrack(TVIRemoteAudioTrack audioTrack, TVIRemoteAudioTrackPublication publication, TVIRemoteParticipant participant)
        {
            Console.WriteLine("DidUnsubscribeFromAudioTrack");
            DidUnsubscribeFromAudioTrackEvent?.Invoke(this, (audioTrack, publication, participant));
        }

        // @optional -(void)didSubscribeToDataTrack:(TVIRemoteDataTrack * _Nonnull)dataTrack publication:(TVIRemoteDataTrackPublication * _Nonnull)publication forParticipant:(TVIRemoteParticipant * _Nonnull)participant __attribute__((swift_name("didSubscribeToDataTrack(dataTrack:publication:participant:)")));
        [Export("didSubscribeToDataTrack:publication:forParticipant:")]
        public override void DidSubscribeToDataTrack(TVIRemoteDataTrack dataTrack, TVIRemoteDataTrackPublication publication, TVIRemoteParticipant participant)
        {
            Console.WriteLine("DidSubscribeToDataTrack");
            DidSubscribeToDataTrackEvent?.Invoke(this, (dataTrack, publication, participant));
        }

        // @optional -(void)didFailToSubscribeToDataTrack:(TVIRemoteDataTrackPublication * _Nonnull)publication error:(NSError * _Nonnull)error forParticipant:(TVIRemoteParticipant * _Nonnull)participant __attribute__((swift_name("didFailToSubscribeToDataTrack(publication:error:participant:)")));
        [Export("didFailToSubscribeToDataTrack:error:forParticipant:")]
        public override void DidFailToSubscribeToDataTrack(TVIRemoteDataTrackPublication publication, NSError error, TVIRemoteParticipant participant)
        {
            Console.WriteLine("DidFailToSubscribeToDataTrack");
            DidFailToSubscribeToDataTrackEvent?.Invoke(this, (publication, error, participant));
        }

        // @optional -(void)didUnsubscribeFromDataTrack:(TVIRemoteDataTrack * _Nonnull)dataTrack publication:(TVIRemoteDataTrackPublication * _Nonnull)publication forParticipant:(TVIRemoteParticipant * _Nonnull)participant __attribute__((swift_name("didUnsubscribeFromDataTrack(dataTrack:publication:participant:)")));
        [Export("didUnsubscribeFromDataTrack:publication:forParticipant:")]
        public override void DidUnsubscribeFromDataTrack(TVIRemoteDataTrack dataTrack, TVIRemoteDataTrackPublication publication, TVIRemoteParticipant participant)
        {
            Console.WriteLine("DidUnsubscribeFromDataTrack");
            DidUnsubscribeFromDataTrackEvent?.Invoke(this, (dataTrack, publication, participant));
        }

        // @optional -(void)remoteParticipant:(TVIRemoteParticipant * _Nonnull)participant networkQualityLevelDidChange:(TVINetworkQualityLevel)networkQualityLevel __attribute__((swift_name("remoteParticipantNetworkQualityLevelDidChange(participant:networkQualityLevel:)")));
        [Export("remoteParticipant:networkQualityLevelDidChange:")]
        public override void RemoteParticipantNetworkQualityLevelDidChange(TVIRemoteParticipant participant, TVINetworkQualityLevel networkQualityLevel)
        {
            Console.WriteLine("RemoteParticipantNetworkQualityLevelDidChange");
            RemoteParticipantNetworkQualityLevelDidChangeEvent?.Invoke(this, (participant, networkQualityLevel));
        }

        // @optional -(void)remoteParticipant:(TVIRemoteParticipant * _Nonnull)participant switchedOffVideoTrack:(TVIRemoteVideoTrack * _Nonnull)track __attribute__((swift_name("remoteParticipantSwitchedOffVideoTrack(participant:track:)")));
        [Export("remoteParticipant:switchedOffVideoTrack:")]
        public override void RemoteParticipantSwitchedOffVideoTrack(TVIRemoteParticipant participant, TVIRemoteVideoTrack track)
        {
            Console.WriteLine("RemoteParticipantSwitchedOffVideoTrack");
            RemoteParticipantSwitchedOffVideoTrackEvent?.Invoke(this, (participant, track));
        }

        // @optional -(void)remoteParticipant:(TVIRemoteParticipant * _Nonnull)participant switchedOnVideoTrack:(TVIRemoteVideoTrack * _Nonnull)track __attribute__((swift_name("remoteParticipantSwitchedOnVideoTrack(participant:track:)")));
        [Export("remoteParticipant:switchedOnVideoTrack:")]
        public override void RemoteParticipantSwitchedOnVideoTrack(TVIRemoteParticipant participant, TVIRemoteVideoTrack track)
        {
            Console.WriteLine("RemoteParticipantSwitchedOnVideoTrack");
            RemoteParticipantSwitchedOnVideoTrackEvent?.Invoke(this, (participant, track));
        }

        // @optional -(void)remoteParticipant:(TVIRemoteParticipant * _Nonnull)participant didChangePublishPriority:(TVITrackPriority _Nonnull)priority forAudioTrack:(TVIRemoteAudioTrackPublication * _Nonnull)publication __attribute__((swift_name("remoteParticipantDidChangeAudioTrackPublishPriority(participant:priority:publication:)")));
        [Export("remoteParticipant:didChangePublishPriority:forAudioTrack:")]
        public void RemoteParticipantDidChangePublishPriorityForAudioTrack(TVIRemoteParticipant participant, string priority, TVIRemoteAudioTrackPublication publication)
        {
            Console.WriteLine("RemoteParticipantDidChangePublishPriorityForAudioTrack");
            RemoteParticipantDidChangePublishPriorityForAudioTrackEvent?.Invoke(this, (participant, priority, publication));
        }

        // @optional -(void)remoteParticipant:(TVIRemoteParticipant * _Nonnull)participant didChangePublishPriority:(TVITrackPriority _Nonnull)priority forVideoTrack:(TVIRemoteVideoTrackPublication * _Nonnull)publication __attribute__((swift_name("remoteParticipantDidChangeVideoTrackPublishPriority(participant:priority:publication:)")));
        [Export("remoteParticipant:didChangePublishPriority:forVideoTrack:")]
        public override void RemoteParticipantDidChangePublishPriorityForVideoTrack(TVIRemoteParticipant participant, string priority, TVIRemoteVideoTrackPublication publication)
        {
            Console.WriteLine("RemoteParticipantDidChangePublishPriorityForVideoTrack");
            RemoteParticipantDidChangePublishPriorityForVideoTrackEvent?.Invoke(this, (participant, priority, publication));
        }

        // @optional -(void)remoteParticipant:(TVIRemoteParticipant * _Nonnull)participant didChangePublishPriority:(TVITrackPriority _Nonnull)priority forDataTrack:(TVIRemoteDataTrackPublication * _Nonnull)publication __attribute__((swift_name("remoteParticipantDidChangeDataTrackPublishPriority(participant:priority:publication:)")));
        [Export("remoteParticipant:didChangePublishPriority:forDataTrack:")]
        public override void RemoteParticipantDidChangePublishPriorityForDataTrack(TVIRemoteParticipant participant, string priority, TVIRemoteDataTrackPublication publication)
        {
            Console.WriteLine("RemoteParticipantDidChangePublishPriorityForDataTrack");
            RemoteParticipantDidChangePublishPriorityForDataTrackEvent?.Invoke(this, (participant, priority, publication));
        }
        #endregion
    }
}
