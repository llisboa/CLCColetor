CD C:\VBNET\CLColetor_V03.29\CLColetor
CD BIN/RELEASE

rem NET USE \\10.0.0.51\C$ /USER:GOLDENGATE CADRIX
rem NET USE \\10.0.0.96\C$ /USER:GOLDENGATE CADRIX
rem NET USE \\10.2.0.96\C$ /USER:GOLDENGATE CADRIX
NET USE \\10.50.0.96\C$ /USER:GOLDENGATE CADRIX
NET USE \\10.50.0.97\C$ /USER:GOLDENGATE CADRIX
NET USE \\10.0.0.48\C$ /USER:ADMIN RC57UV39

rem COPY CLColetor.Exe \\10.0.0.51\c$\inetpub\wwwroot\Intermesa\Down\CLColetor.exe
rem COPY CLColetor.Exe \\10.0.0.96\c$\inetpub\wwwroot\Intermesa\Down\CLColetor.exe
rem COPY CLColetor.Exe \\10.2.0.96\c$\inetpub\wwwroot\Intermesa\Down\CLColetor.exe
COPY CLColetor.Exe \\10.50.0.96\c$\inetpub\wwwroot\Intermesa\Down\CLColetor.exe
COPY CLColetor.Exe \\10.50.0.97\c$\inetpub\wwwroot\Intermesa\Down\CLColetor.exe
COPY CLColetor.Exe \\10.0.0.48\c$\inetpub\wwwroot\Intermesa\Down\CLColetor.exe

PAUSE