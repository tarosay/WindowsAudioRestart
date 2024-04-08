# WindowsAudioRestart
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

