using UnityEngine;

namespace io.adtrace.sdk
{
    [CreateAssetMenu(fileName = "AdTraceData", menuName = "PackageData/Create AdTraceData")]
    public class AdTraceStartupData : ScriptableObject
    {
        [SerializeField]
        private bool _isEnable;
        [SerializeField]
        private bool _eventBuffering = false;
        [SerializeField]
        private bool _sendInBackground = false;
        [SerializeField]
        private bool _launchDeferredDeeplink = true;
        [SerializeField]
        private string _appToken;
        [SerializeField]
        private AdTraceLogLevel _logLevel;
        [SerializeField]
        private AdTraceEnvironment _adTraceEnvironment;
        [SerializeField]
        private long _secretId;
        [SerializeField]
        private long _info1;
        [SerializeField]
        private long _info2;
        [SerializeField]
        private long _info3;
        [SerializeField]
        private long _info4;
        [SerializeField]
        private string _pushNotificationToken;

        public bool IsEnable => _isEnable;
        public bool EventBuffering => _eventBuffering;
        public bool SendInBackground => _sendInBackground;
        public bool LaunchDeferredDeeplink => _launchDeferredDeeplink;
        public string AppToken => _appToken;
        public AdTraceLogLevel LogLevel => _logLevel;
        public AdTraceEnvironment AdTraceEnvironment => _adTraceEnvironment;
        public long SecretId => _secretId;
        public long Info1 => _info1;
        public long Info2 => _info2;
        public long Info3 => _info3;
        public long Info4 => _info4;

        public void SetEnableState(bool enable)
        {
            _isEnable = enable;
        }
    }
}
