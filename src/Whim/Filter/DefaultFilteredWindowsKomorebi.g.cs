/* This file was generated from data with the following license:
 *
 * MIT License
 *
 * Copyright (c) 2024 Jade Iqbal
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

namespace Whim;

/// <summary>
/// This file is automatically generated by generate_app_rules.py. Do not edit it manually.
/// </summary>
internal static class DefaultFilteredWindowsKomorebi
{
	/// <summary>
	/// Load the windows ignored by Komorebi <see href="https://github.com/LGUG2Z/komorebi-application-specific-configuration"/>.
	/// </summary>
	/// <param name="filterManager"></param>
	public static void LoadWindowsIgnoredByKomorebi(IFilterManager filterManager)
	{
		// 1Password
		filterManager.AddProcessFileNameFilter("1Password.exe");

		// Ableton Live
		filterManager.Add((window) => (window.WindowClass.StartsWith("AbletonVstPlugClass") || window.WindowClass.EndsWith("AbletonVstPlugClass")));
		filterManager.Add((window) => (window.WindowClass.StartsWith("Vst3PlugWindow") || window.WindowClass.EndsWith("Vst3PlugWindow")));

		// Adobe Premiere Pro
		filterManager.AddWindowClassFilter("DroverLord - Window Class");

		// Affinity Designer 2
		filterManager.AddProcessFileNameFilter("Designer.exe");

		// Affinity Photo 2
		filterManager.AddProcessFileNameFilter("Photo.exe");

		// Affinity Publisher 2
		filterManager.AddProcessFileNameFilter("Publisher.exe");

		// Amazon Chime
		filterManager.Add((window) => window.Title.EndsWith("Meeting Controls"));

		// AutoDesk AutoCAD Suite
		filterManager.Add((window) => window.WindowClass.Contains("Afx:") && window.ProcessFileName.Equals("acad.exe"));
		filterManager.Add((window) => window.WindowClass.StartsWith("HwndWrapper[DefaultDomain") && window.ProcessFileName.Equals("acad.exe"));

		// AutoHotkey
		filterManager.Add((window) => window.Title.StartsWith("Window Spy"));
		filterManager.AddProcessFileNameFilter("AutoHotkeyUX.exe");

		// Bloxstrap
		filterManager.AddProcessFileNameFilter("Bloxstrap.exe");

		// CLion
		filterManager.AddWindowClassFilter("SunAwtDialog");

		// Calculator
		filterManager.AddTitleFilter("Calculator");

		// Citrix Receiver
		filterManager.AddProcessFileNameFilter("SelfService.exe");

		// Core Temp
		filterManager.AddProcessFileNameFilter("Core Temp.exe");

		// Credential Manager UI Host
		filterManager.AddProcessFileNameFilter("CredentialUIBroker.exe");

		// Delphi applications
		filterManager.Add((window) => (window.WindowClass.StartsWith("TApplication") || window.WindowClass.EndsWith("TApplication")));
		filterManager.Add((window) => (window.WindowClass.StartsWith("TWizardForm") || window.WindowClass.EndsWith("TWizardForm")));

		// Dropbox
		filterManager.AddProcessFileNameFilter("Dropbox.exe");

		// Elephicon
		filterManager.AddProcessFileNameFilter("Elephicon.exe");

		// Elgato Camera Hub
		filterManager.AddProcessFileNameFilter("Camera Hub.exe");

		// Elgato Control Center
		filterManager.AddProcessFileNameFilter("ControlCenter.exe");

		// Elgato Wave Link
		filterManager.AddProcessFileNameFilter("WaveLink.exe");

		// GOG Galaxy
		filterManager.Add((window) => (window.WindowClass.StartsWith("Chrome_RenderWidgetHostHWND") || window.WindowClass.EndsWith("Chrome_RenderWidgetHostHWND")));

		// GitHub Credential Manager
		filterManager.AddProcessFileNameFilter("git-credential-manager.exe");

		// Google Drive
		filterManager.AddProcessFileNameFilter("GoogleDriveFS.exe");

		// Guitar Rig 7
		filterManager.AddProcessFileNameFilter("Guitar Rig 7.exe");

		// IntelliJ IDEA
		// filterManager.AddWindowClassFilter("SunAwtDialog");  // duplicate rule

		// Keyviz
		filterManager.AddProcessFileNameFilter("keyviz.exe");

		// Logi Bolt
		filterManager.AddProcessFileNameFilter("LogiBolt.exe");

		// LogiTune
		filterManager.AddProcessFileNameFilter("LogiTune.exe");

		// Logitech Options
		filterManager.AddProcessFileNameFilter("LogiOptionsUI.exe");

		// Microsoft Active Accessibility
		filterManager.Add((window) => (window.WindowClass.StartsWith("#32770") || window.WindowClass.EndsWith("#32770")));

		// Microsoft Excel
		filterManager.Add((window) => (window.WindowClass.StartsWith("_WwB") || window.WindowClass.EndsWith("_WwB")));

		// Microsoft Outlook
		// filterManager.Add((window) => (window.WindowClass.StartsWith("_WwB") || window.WindowClass.EndsWith("_WwB")));  // duplicate rule
		filterManager.AddWindowClassFilter("MsoSplash");

		// Microsoft PC Manager
		filterManager.AddProcessFileNameFilter("MSPCManager.exe");

		// Microsoft PowerPoint
		// filterManager.Add((window) => (window.WindowClass.StartsWith("_WwB") || window.WindowClass.EndsWith("_WwB")));  // duplicate rule

		// Microsoft Teams classic
		filterManager.Add((window) => (window.Title.StartsWith("Microsoft Teams Notification") || window.Title.EndsWith("Microsoft Teams Notification")));
		filterManager.Add((window) => (window.Title.StartsWith("Microsoft Teams Call") || window.Title.EndsWith("Microsoft Teams Call")));

		// Microsoft Word
		// filterManager.Add((window) => (window.WindowClass.StartsWith("_WwB") || window.WindowClass.EndsWith("_WwB")));  // duplicate rule

		// Mozilla Firefox
		filterManager.Add((window) => (window.WindowClass.StartsWith("MozillaTaskbarPreviewClass") || window.WindowClass.EndsWith("MozillaTaskbarPreviewClass")));
		filterManager.Add((window) => window.Title.Equals("Picture-in-Picture") && window.ProcessFileName.Equals("firefox.exe"));

		// NohBoard
		filterManager.AddProcessFileNameFilter("NohBoard.exe");

		// OneDrive
		filterManager.Add((window) => (window.WindowClass.StartsWith("OneDriveReactNativeWin32WindowClass") || window.WindowClass.EndsWith("OneDriveReactNativeWin32WindowClass")));

		// Paradox Launcher
		filterManager.AddProcessFileNameFilter("Paradox Launcher.exe");

		// PhpStorm
		// filterManager.AddWindowClassFilter("SunAwtDialog");  // duplicate rule

		// Playnite
		filterManager.AddProcessFileNameFilter("Playnite.FullscreenApp.exe");

		// PowerToys
		filterManager.AddProcessFileNameFilter("PowerToys.ColorPickerUI.exe");
		filterManager.AddProcessFileNameFilter("PowerToys.CropAndLock.exe");
		filterManager.AddProcessFileNameFilter("PowerToys.ImageResizer.exe");
		filterManager.AddProcessFileNameFilter("PowerToys.Peek.UI.exe");
		filterManager.AddProcessFileNameFilter("PowerToys.PowerLauncher.exe");
		filterManager.AddProcessFileNameFilter("PowerToys.PowerAccent.exe");

		// Process Hacker
		filterManager.AddProcessFileNameFilter("ProcessHacker.exe");

		// PyCharm
		// filterManager.AddWindowClassFilter("SunAwtDialog");  // duplicate rule

		// QQ
		filterManager.Add((window) => (window.Title.StartsWith("图片查看器") || window.Title.EndsWith("图片查看器")));
		filterManager.Add((window) => (window.Title.StartsWith("群聊的聊天记录") || window.Title.EndsWith("群聊的聊天记录")));
		filterManager.Add((window) => (window.Title.StartsWith("语音通话") || window.Title.EndsWith("语音通话")));

		// QuickLook
		filterManager.AddProcessFileNameFilter("QuickLook.exe");

		// RepoZ
		filterManager.AddProcessFileNameFilter("RepoZ.exe");

		// Rider
		// filterManager.AddWindowClassFilter("SunAwtDialog");  // duplicate rule
		filterManager.Add((window) => (window.Title.StartsWith("PopupMessageWindow") || window.Title.EndsWith("PopupMessageWindow")));

		// RoundedTB
		filterManager.AddProcessFileNameFilter("RoundedTB.exe");

		// RustRover
		// filterManager.AddWindowClassFilter("SunAwtDialog");  // duplicate rule

		// Sideloadly
		filterManager.AddProcessFileNameFilter("sideloadly.exe");

		// Slack
		// filterManager.Add((window) => (window.WindowClass.StartsWith("Chrome_RenderWidgetHostHWND") || window.WindowClass.EndsWith("Chrome_RenderWidgetHostHWND")));  // duplicate rule

		// Slack
		// filterManager.Add((window) => (window.WindowClass.StartsWith("Chrome_RenderWidgetHostHWND") || window.WindowClass.EndsWith("Chrome_RenderWidgetHostHWND")));  // duplicate rule

		// Smart Install Maker
		filterManager.Add((window) => (window.WindowClass.StartsWith("obj_App") || window.WindowClass.EndsWith("obj_App")));
		filterManager.Add((window) => (window.WindowClass.StartsWith("obj_Form") || window.WindowClass.EndsWith("obj_Form")));

		// SnippingTool
		filterManager.AddProcessFileNameFilter("SnippingTool.exe");

		// Steam
		filterManager.Add((window) => window.ProcessFileName.Equals("steamwebhelper.exe") && !window.Title.Equals("Steam"));

		// Steam Beta
		filterManager.Add((window) => (window.Title.StartsWith("notificationtoasts_") || window.Title.EndsWith("notificationtoasts_")));

		// System Informer
		filterManager.AddProcessFileNameFilter("SystemInformer.exe");

		// SystemSettings
		filterManager.Add((window) => (window.WindowClass.StartsWith("Shell_Dialog") || window.WindowClass.EndsWith("Shell_Dialog")));

		// Task Manager
		filterManager.Add((window) => (window.WindowClass.StartsWith("TaskManagerWindow") || window.WindowClass.EndsWith("TaskManagerWindow")));

		// Total Commander
		filterManager.AddWindowClassFilter("TDLG2FILEACTIONMIN");

		// TouchCursor
		filterManager.AddProcessFileNameFilter("tcconfig.exe");

		// TranslucentTB
		filterManager.AddProcessFileNameFilter("TranslucentTB.exe");

		// WebStorm
		// filterManager.AddWindowClassFilter("SunAwtDialog");  // duplicate rule

		// WinZip (32-bit)
		filterManager.AddProcessFileNameFilter("winzip32.exe");

		// WinZip (64-bit)
		filterManager.AddProcessFileNameFilter("winzip64.exe");

		// Windows Explorer
		filterManager.Add((window) => (window.WindowClass.StartsWith("OperationStatusWindow") || window.WindowClass.EndsWith("OperationStatusWindow")));
		filterManager.Add((window) => (window.Title.StartsWith("Control Panel") || window.Title.EndsWith("Control Panel")));

		// Windows Installer
		filterManager.AddProcessFileNameFilter("msiexec.exe");

		// Windows Subsystem for Android
		filterManager.Add((window) => (window.WindowClass.StartsWith("android(splash)") || window.WindowClass.EndsWith("android(splash)")));

		// Windows Update Standalone Installer
		filterManager.AddProcessFileNameFilter("wusa.exe");

		// Wox
		filterManager.Add((window) => (window.Title.StartsWith("Hotkey sink") || window.Title.EndsWith("Hotkey sink")));

		// Zebar
		filterManager.AddProcessFileNameFilter("zebar.exe");

		// Zoom
		filterManager.AddProcessFileNameFilter("Zoom.exe");

		// komorebi-gui
		filterManager.AddProcessFileNameFilter("komorebi-gui.exe");

		// paint.net
		filterManager.AddProcessFileNameFilter("paintdotnet.exe");

		// pinentry
		filterManager.AddProcessFileNameFilter("pinentry.exe");

		// ueli
		filterManager.AddProcessFileNameFilter("ueli.exe");
	}
}
