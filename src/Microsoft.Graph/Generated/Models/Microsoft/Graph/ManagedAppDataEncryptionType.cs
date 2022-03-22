namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceAppManagement singleton.</summary>
    public enum ManagedAppDataEncryptionType {
        UseDeviceSettings,
        AfterDeviceRestart,
        WhenDeviceLockedExceptOpenFiles,
        WhenDeviceLocked,
    }
}