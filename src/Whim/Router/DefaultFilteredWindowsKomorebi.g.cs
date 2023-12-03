/* This file was generated from data with the following license:
 *
 * MIT License
 *
 * Copyright (c) 2021 Jade Iqbal
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
	/// Load the windows ignored by <see href="https://github.com/LGUG2Z/komorebi-application-specific-configuration"/>.
	/// </summary>
	/// <param name="filterManager"></param>
	public static void LoadWindowsIgnoredByKomorebi(IFilterManager filterManager)
	{

		// 1Password
		filterManager.AddProcessFileNameFilter("1Password.exe");

		// Ableton Live
		filterManager.AddWindowClassFilter("AbletonVstPlugClass");  // Targets VST2 windows
		filterManager.AddWindowClassFilter("Vst3PlugWindow");  // Targets VST3 windows

		// Affinity Photo 2
		filterManager.AddProcessFileNameFilter("Photo.exe");

		// AutoHotkey
		filterManager.AddTitleFilter("Window Spy");
		filterManager.AddProcessFileNameFilter("AutoHotkeyUX.exe");

		// Bloxstrap
		filterManager.AddProcessFileNameFilter("Bloxstrap.exe");

		// Calculator
		filterManager.AddTitleFilter("Calculator");

		// Citrix Receiver
		filterManager.AddProcessFileNameFilter("SelfService.exe");

		// Credential Manager UI Host
		filterManager.AddProcessFileNameFilter("CredentialUIBroker.exe");  // Targets the Windows popup prompting you for a PIN instead of a password on 1Password etc.

		// Delphi applications
		filterManager.AddWindowClassFilter("TApplication");  // Target hidden window spawned by Delphi applications
		filterManager.AddWindowClassFilter("TWizardForm");  // Target Inno Setup installers

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
		filterManager.AddWindowClassFilter("Chrome_RenderWidgetHostHWND");  // Targets a hidden window spawned by GOG Galaxy

		// Google Drive
		filterManager.AddProcessFileNameFilter("GoogleDriveFS.exe");

		// IntelliJ IDEA
		filterManager.AddWindowClassFilter("SunAwtDialog");  // Targets JetBrains IDE popups and floating windows

		// Keyviz
		filterManager.AddProcessFileNameFilter("keyviz.exe");

		// Logi Bolt
		filterManager.AddProcessFileNameFilter("LogiBolt.exe");

		// LogiTune
		filterManager.AddProcessFileNameFilter("LogiTune.exe");

		// Logitech Options
		filterManager.AddProcessFileNameFilter("LogiOptionsUI.exe");

		// Microsoft Active Accessibility
		filterManager.AddWindowClassFilter("#32770");  // Dialog Box

		// Microsoft Excel
		filterManager.AddWindowClassFilter("_WwB");  // Targets a hidden window spawned by Microsoft Office applications

		// Microsoft Outlook
		// filterManager.AddWindowClassFilter("_WwB");  // duplicate rule

		// Microsoft PC Manager
		filterManager.AddProcessFileNameFilter("MSPCManager.exe");

		// Microsoft PowerPoint
		// filterManager.AddWindowClassFilter("_WwB");  // duplicate rule

		// Microsoft Teams classic
		filterManager.AddTitleFilter("Microsoft Teams Notification");  // Target Teams pop-up notification windows
		filterManager.AddTitleFilter("Microsoft Teams Call");  // Target Teams call in progress windows

		// Microsoft Word
		// filterManager.AddWindowClassFilter("_WwB");  // duplicate rule

		// Mozilla Firefox
		filterManager.AddWindowClassFilter("MozillaTaskbarPreviewClass");  // Targets invisible windows spawned by Firefox to show tab previews in the taskbar

		// NohBoard
		filterManager.AddProcessFileNameFilter("NohBoard.exe");

		// OneDrive
		filterManager.AddWindowClassFilter("OneDriveReactNativeWin32WindowClass");

		// Paradox Launcher
		filterManager.AddProcessFileNameFilter("Paradox Launcher.exe");

		// Playnite
		filterManager.AddProcessFileNameFilter("Playnite.FullscreenApp.exe");  // Target fullscreen app

		// PowerToys
		filterManager.AddProcessFileNameFilter("PowerToys.ColorPickerUI.exe");  // Target color picker dialog
		filterManager.AddProcessFileNameFilter("PowerToys.ImageResizer.exe");  // Target image resizer dialog
		filterManager.AddProcessFileNameFilter("PowerToys.Peek.UI.exe");  // Target Peek popup

		// Process Hacker
		filterManager.AddProcessFileNameFilter("ProcessHacker.exe");

		// PyCharm
		// filterManager.AddWindowClassFilter("SunAwtDialog");  // duplicate rule

		// QQ
		filterManager.AddTitleFilter("图片查看器");
		filterManager.AddTitleFilter("群聊的聊天记录");
		filterManager.AddTitleFilter("语音通话");

		// QuickLook
		filterManager.AddProcessFileNameFilter("QuickLook.exe");

		// RepoZ
		filterManager.AddProcessFileNameFilter("RepoZ.exe");

		// Rider
		// filterManager.AddWindowClassFilter("SunAwtDialog");  // duplicate rule
		filterManager.AddTitleFilter("PopupMessageWindow");  // Targets JetBrains IDE popups

		// RoundedTB
		filterManager.AddProcessFileNameFilter("RoundedTB.exe");

		// RustRover
		// filterManager.AddWindowClassFilter("SunAwtDialog");  // duplicate rule

		// Sideloadly
		filterManager.AddProcessFileNameFilter("sideloadly.exe");

		// Slack
		// filterManager.AddWindowClassFilter("Chrome_RenderWidgetHostHWND");  // duplicate rule

		// Slack
		// filterManager.AddWindowClassFilter("Chrome_RenderWidgetHostHWND");  // duplicate rule

		// Smart Install Maker
		filterManager.AddWindowClassFilter("obj_App");  // Target hidden window spawned by installer
		filterManager.AddWindowClassFilter("obj_Form");  // Target installer

		// SnippingTool
		filterManager.AddProcessFileNameFilter("SnippingTool.exe");

		// Steam Beta
		filterManager.AddTitleFilter("notificationtoasts_");  // Target notification toast popups

		// System Informer
		filterManager.AddProcessFileNameFilter("SystemInformer.exe");

		// SystemSettings
		filterManager.AddWindowClassFilter("Shell_Dialog");

		// Task Manager
		filterManager.AddWindowClassFilter("TaskManagerWindow");

		// TouchCursor
		filterManager.AddProcessFileNameFilter("tcconfig.exe");

		// TranslucentTB
		filterManager.AddProcessFileNameFilter("TranslucentTB.exe");

		// WinZip (32-bit)
		filterManager.AddProcessFileNameFilter("winzip32.exe");

		// WinZip (64-bit)
		filterManager.AddProcessFileNameFilter("winzip64.exe");

		// Windows Explorer
		filterManager.AddWindowClassFilter("OperationStatusWindow");  // Targets copy/move operation windows
		filterManager.AddTitleFilter("Control Panel");

		// Windows Installer
		filterManager.AddProcessFileNameFilter("msiexec.exe");

		// Windows Subsystem for Android
		filterManager.AddWindowClassFilter("android(splash)");  // Targets splash/startup screen

		// Wox
		filterManager.AddTitleFilter("Hotkey sink");  // Targets a hidden window spawned by Wox

		// Zoom
		filterManager.AddProcessFileNameFilter("Zoom.exe");

		// paint.net
		filterManager.AddProcessFileNameFilter("paintdotnet.exe");

		// pinentry
		filterManager.AddProcessFileNameFilter("pinentry.exe");

		// ueli
		filterManager.AddProcessFileNameFilter("ueli.exe");
	}
}
