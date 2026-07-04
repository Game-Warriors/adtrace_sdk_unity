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

        public bool IsEnable => _isEnable;
        public bool EventBuffering => _eventBuffering;
        public bool SendInBackground => _sendInBackground;
        public bool LaunchDeferredDeeplink => _launchDeferredDeeplink;
        public string AppToken => _appToken;
        public AdTraceLogLevel LogLevel => _logLevel;
        public AdTraceEnvironment AdTraceEnvironment => _adTraceEnvironment;

        public void SetEnableState(bool enable)
        {
            _isEnable = enable;
        }
    }
}
