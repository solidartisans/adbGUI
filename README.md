# shomronsAdbGui

## Based on [hexadezi's adbGUI](https://github.com/hexadezi/adbGUI)

This project builds upon the original work done by [hexadezi](https://github.com/hexadezi) and introduces several new features and improvements.

---

### SJD DLLs
We utilize SJD DLLs (developed by Shomrom Joseph David), a collection of bundled tools and extensions designed to ease the development process and minimize the need to rewrite code.

---

### Features & Improvements

#### Drag & Drop Functionality
- Added drag-and-drop support for Side Load, Files, and APK Info sections.

#### Code Refactoring
- Certain code blocks have been refactored into functions for cleaner, more maintainable code.

#### AAPT and AAPT2 Integration
- Integrated AAPT (Android Asset Packaging Tool) and AAPT2 into a new DLL: `sjd.apk.reader.dll`.
  - This allows for convenient information retrieval from APK packages.

#### Debugging Improvements
- Fixed a JIT Debugger - Exception Code issue that occurred on some PCs where the OEM codepage was set improperly.
- Added UTF-8 msdos codepage value insted to taking via OS.

#### APK Information
- More comprehensive APK details are now available:
  - APK Name
  - Version Name
  - Package Name
  - SDK Version
  - Target SDK Version
  - Version Code

#### Scrcpy 64-bit Support
- 64-bit support for scrcpy has been added, but more work is needed to fully integrate this feature.
- SCRCPY https://github.com/Genymobile/scrcpy

  
#### Screenshots

![new gui](screenshot/screenshot_2_1.png)  




# Release: ADB GUI by Shomron Joseph David (V 1.1.4)

- Official Website: [Shomron Joseph David's Website](www.shomrondavid.co.il)
- LinkedIn Profile: [Shomron Joseph David on LinkedIn](https://www.linkedin.com/in/shomrondavid)
- Built using: C# .NET Framework v4.8 (or later versions supported)

## Version Log

### Version 1.1.4
- Added https://github.com/Genymobile/scrcpy to the project

### Version 1.1.3
- Resolved JIT - Exception Code errors encountered on certain PCs with specific OEM codepage settings.

### Version 1.1.2
- Introduced Drag & Drop feature for Side Loading, File management, and APK Information.
- Modularized code through function refactoring.

### Version 1.1.1
- Assembly JIT disabled
  - `[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]`

### Version 1.1.0
- Integrated AAPT and AAPT2 within `sjd.apk.reader.dll` (AAPT - Android Asset Packaging Tool).
- New DLL enables extraction of APK package information:

  1. APK Title
  2. Version Identifier
  3. Package Identifier
  4. SDK Version
  5. Target SDK Version
  6. Version Code
  7. Native Code Support

### Version 1.0.0
- Codebase initiated and core issues resolved by Shomron Joseph David.
- Auto-download feature for ADB package if not present on the system.
- ADB tools are stored temporarily and unzipped; size is around 5-6 MB.
- Sources files directly from the official Android/Google servers, using the most up-to-date ADB package.

## Disclaimer
By utilizing ADB GUI, you consent to the understanding that Shomron Joseph David is not accountable for any potential damages or problems arising from the usage of this utility. You are solely responsible for using the tool in a secure and sensible manner.

## Acknowledgments
- Inspired by the work found at [adbGUI on GitHub](https://github.com/hexadezi/adbGUI)
- `sjd` DLLs are custom libraries by Shomron Joseph David that bundle various tools and extensions to simplify development tasks without requiring repetitive coding.
