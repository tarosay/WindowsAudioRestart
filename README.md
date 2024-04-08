# Windows Audio Reset Tool
Windows11で、突然音が出なくなることがあります。
サウンドの問題トラブルシューティングをしても、音は鳴りません。
YouTubeは再生しているにもかかわらず、動画は進みません。そして、スピーカーをオフにすると動画は進みますが、当然音はなりません。
このような現象が出るときは、Windowsのオーディオデバイスがハングアップしているか、動作が不安定になっているときです。
そのような場合、このプログラムを用いて、Windowsオーディオデバイスをリセットします。

プログラムはソースファイルの通りです。
net stop "Windows Audio"
して、
net start "Windows Audio""
しているだけです。


# Windows Audio Reset Tool

## Overview
In Windows 11, users may occasionally experience an issue where sound suddenly stops working. Standard sound troubleshooting steps often do not resolve the issue. During such incidents, even though YouTube videos appear to be playing, the video playback does not progress. If the speakers are turned off, the video resumes but, naturally, without sound. This indicates that the Windows audio device might be hung or is operating unstably.

## Purpose
This program is designed to reset the Windows audio device, which can help resolve these sound issues.

## How It Works
The operation of this tool is straightforward. It executes the following commands:

```bash
net stop "Windows Audio"
net start "Windows Audio"
```

These commands stop and then restart the Windows Audio service, effectively resetting the audio capabilities of the system.

## Usage
To use this tool, simply run the provided source file as an administrator. This is necessary to ensure that the commands have the required permissions to affect the Windows Audio service.

## Note
Please make sure to run this tool only when you encounter the described audio issues, as it will temporarily disable all audio services during the reset process.

