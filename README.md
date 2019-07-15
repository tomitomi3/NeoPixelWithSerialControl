# NeoPixelWithSerialControl

NeoPixelをシリアルで制御するためのArduinoコードとプログラム

* 特徴

チェックサムを使ってチェックしているので受信時のミスが少ないと思われる。

## Arduinoへの送信
先頭に2バイト（符号なし整数）のチェックサムを入れている。

[CHECKSUM1][CHECKSUM2][BRIGHTNESS][CH1][CH1 R][CH1 G][CH1 B][CH2][CH2 R][CH2 G][CH2 B]
