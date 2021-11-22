using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Web.WebView2.Core;

namespace FireBrowser
{
    class DownloadI
    {
        enum CoreWebView2DownloadState
        {
            InProgress = 0,
            Interrupted = 1,
            Completed = 2,
        };
        enum CoreWebView2DownloadInterruptReason
        {
            None = 0,
            FileFailed = 1,
            FileAccessDenied = 2,
            FileNoSpace = 3,
            FileNameTooLong = 4,
            FileTooLarge = 5,
            FileMalicious = 6,
            FileTransientError = 7,
            FileBlockedByPolicy = 8,
            FileSecurityCheckFailed = 9,
            FileTooShort = 10,
            FileHashMismatch = 11,
            NetworkFailed = 13,
            NetworkTimeout = 14,
            NetworkDisconnected = 15,
            NetworkServerDown = 16,
            NetworkInvalidRequest = 17,
            ServerFailed = 18,
            ServerNoRange = 19,
            ServerBadContent = 20,
            ServerUnauthorized = 21,
            ServerCertificateProblem = 22,
            ServerForbidden = 23,
            ServerUnexpectedResponse = 24,
            ServerContentLengthMismatch = 25,
            ServerCrossOriginRedirect = 26,
            UserCanceled = 27,
            UserShutdown = 28,
            UserPaused = 29,
            DownloadProcessCrashed = 30,
        };     
    }
}

