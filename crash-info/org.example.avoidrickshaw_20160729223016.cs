S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPD6
Build-Date: 2016.04.28 20:23:28

Crash Information
Process Name: avoidrickshaw
PID: 26961
Date: 2016-07-29 22:30:16+0600
Executable File Path: /opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 26961, uid 5000)

Register Information
r0   = 0xb64cf180, r1   = 0xb2a19001
r2   = 0x00000032, r3   = 0xb64cf17f
r4   = 0xb2a18ffa, r5   = 0x00000008
r6   = 0xbefc9de0, r7   = 0x00000008
r8   = 0x00000008, r9   = 0x00000008
r10  = 0xb67d1000, fp   = 0xbefc9dd4
ip   = 0xb2a19004, sp   = 0xbefc9888
lr   = 0xb66d91e8, pc   = 0xb6706b58
cpsr = 0x800d0010

Memory Information
MemTotal:   730440 KB
MemFree:     22096 KB
Buffers:     35900 KB
Cached:     230684 KB
VmPeak:     119940 KB
VmSize:     119936 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       25288 KB
VmRSS:       25288 KB
VmData:      44328 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36280 KB
VmPTE:          88 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 26961 TID = 26961
26961 26967 1899 1906 2039 

Maps Information
b0393000 b0b92000 rw-p [stack:2039]
b1301000 b1b00000 rw-p [stack:1906]
b1c68000 b1c70000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.49
b1c80000 b1c82000 r-xp /usr/lib/liblbs-agps.so.0.1.0
b1c92000 b1ca0000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
b1cb7000 b1cb9000 r-xp /usr/lib/location/module/libwps.so.0.6.8_9
b1cc9000 b1ccc000 r-xp /usr/lib/location/module/libgps.so.0.6.8_9
b1cdd000 b24dc000 rw-p [stack:1899]
b2558000 b2560000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2571000 b2572000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b2582000 b2596000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b25aa000 b25ab000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b25bb000 b25be000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b25cf000 b25d0000 r-xp /usr/lib/libxshmfence.so.1.0.0
b25e0000 b25e2000 r-xp /usr/lib/libxcb-present.so.0.0.0
b25f2000 b25f4000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2604000 b2614000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2624000 b2630000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b2880000 b2882000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b2892000 b2898000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b28a8000 b28bc000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b28cc000 b28e6000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b28f6000 b28fc000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
b290c000 b2913000 r-xp /usr/lib/libeventsystem.so.0.0.1
b2923000 b2946000 r-xp /usr/lib/libSLP-location-product.so.0.9.0
b2957000 b296e000 r-xp /usr/lib/libSLP-location.so.0.11.5_5
b297e000 b2985000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2996000 b299e000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b29ae000 b29b2000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
b29c3000 b29d2000 r-xp /usr/lib/libcapi-location-manager.so.0.6.1_3
b29e2000 b29e9000 r-xp /usr/lib/libcapi-appfw-preference.so.0.3.1.0
b29fb000 b2a01000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2a11000 b2a1a000 r-xp /opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw
b2b3c000 b2c1f000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2c56000 b2c7e000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2c90000 b348f000 rw-p [stack:26967]
b348f000 b3491000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b34a1000 b34ab000 r-xp /lib/libnss_files-2.20-2014.11.so
b34bc000 b34c5000 r-xp /lib/libnss_nis-2.20-2014.11.so
b34d6000 b34e7000 r-xp /lib/libnsl-2.20-2014.11.so
b34fa000 b3500000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3511000 b3512000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b353a000 b3541000 r-xp /usr/lib/libminizip.so.1.0.0
b3551000 b3556000 r-xp /usr/lib/libstorage.so.0.1
b3566000 b35bb000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b35d1000 b35e5000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b35f5000 b3639000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3649000 b3651000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3661000 b3691000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b36a4000 b375d000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3771000 b37c5000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b37d6000 b37f1000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3801000 b38c2000 r-xp /usr/lib/libprotobuf.so.9.0.1
b38d5000 b38e7000 r-xp /usr/lib/libefl-assist.so.0.1.0
b38f7000 b38fb000 r-xp /usr/lib/libogg.so.0.7.1
b390b000 b392d000 r-xp /usr/lib/libvorbis.so.0.4.3
b393d000 b3a21000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b3a3d000 b3a4a000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3a5b000 b3a9e000 r-xp /usr/lib/libsndfile.so.1.0.25
b3ab3000 b3afa000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3b0b000 b3b11000 r-xp /usr/lib/libjson-c.so.2.0.1
b3b22000 b3b29000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3b39000 b3b79000 r-xp /usr/lib/libmdm.so.1.2.10
b3b89000 b3b91000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3ba0000 b3bb0000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3bd1000 b3c31000 r-xp /usr/lib/libasound.so.2.0.0
b3c43000 b3c79000 r-xp /usr/lib/libpulse.so.0.16.2
b3c8a000 b3c8d000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3c9d000 b3ca0000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3cb0000 b3cb5000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3cc5000 b3cc6000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3cd6000 b3ce1000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3cf5000 b3cfc000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3d0c000 b3d12000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3d22000 b3d27000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3d37000 b3d52000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3d62000 b3d69000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3d79000 b3d7c000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3d8d000 b3dbb000 r-xp /usr/lib/libidn.so.11.5.44
b3dcb000 b3de1000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3df2000 b3dfc000 r-xp /usr/lib/libcares.so.2.1.0
b3e0c000 b3e16000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3e26000 b3e28000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3e38000 b3e39000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3e49000 b3e4d000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3e5e000 b3e86000 r-xp /usr/lib/libui-extension.so.0.1.0
b3e97000 b3ec0000 r-xp /usr/lib/libturbojpeg.so
b3ee0000 b3ee6000 r-xp /usr/lib/libgif.so.4.1.6
b3ef6000 b3f3c000 r-xp /usr/lib/libcurl.so.4.3.0
b3f4d000 b3f6e000 r-xp /usr/lib/libexif.so.12.3.3
b3f89000 b3f9e000 r-xp /usr/lib/libtts.so
b3faf000 b3fb7000 r-xp /usr/lib/libfeedback.so.0.1.4
b3fc7000 b4087000 r-xp /usr/lib/libdali-core.so.0.0.0
b4092000 b4185000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b41a5000 b427f000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b4296000 b4298000 r-xp /usr/lib/libboost_system.so.1.51.0
b42a8000 b42ae000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b42be000 b42e1000 r-xp /usr/lib/libboost_thread.so.1.51.0
b42f2000 b42f4000 r-xp /usr/lib/libappsvc.so.0.1.0
b4304000 b4306000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4317000 b431c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4333000 b4335000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b4345000 b434c000 r-xp /usr/lib/libsensord-share.so
b435c000 b4374000 r-xp /usr/lib/libsensor.so.1.1.0
b4385000 b4388000 r-xp /usr/lib/libXv.so.1.0.0
b4398000 b439d000 r-xp /usr/lib/libutilX.so.1.1.0
b43ad000 b43b2000 r-xp /usr/lib/libappcore-common.so.1.1
b43c2000 b43c9000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b43dc000 b43e0000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b43f1000 b44bb000 r-xp /usr/lib/libCOREGL.so.4.0
b44d2000 b44d5000 r-xp /usr/lib/libuuid.so.1.3.0
b44e6000 b44fd000 r-xp /usr/lib/libblkid.so.1.1.0
b450e000 b4510000 r-xp /usr/lib/libXau.so.6.0.0
b4520000 b4523000 r-xp /usr/lib/libEGL.so.1.4
b452b000 b4531000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4541000 b4543000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4554000 b4562000 r-xp /usr/lib/libGLESv2.so.2.0
b456b000 b45cd000 r-xp /usr/lib/libpixman-1.so.0.28.2
b45e2000 b45fa000 r-xp /usr/lib/libmount.so.1.1.0
b460b000 b461f000 r-xp /usr/lib/libxcb.so.1.1.0
b4630000 b4637000 r-xp /lib/libcrypt-2.20-2014.11.so
b466f000 b4680000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b4691000 b4693000 r-xp /usr/lib/libiri.so
b46a3000 b46ae000 r-xp /usr/lib/libgpg-error.so.0.15.0
b46bf000 b46d4000 r-xp /lib/libexpat.so.1.5.2
b46e6000 b47a4000 r-xp /usr/lib/libcairo.so.2.11200.14
b47b7000 b47bf000 r-xp /usr/lib/libdrm.so.2.4.0
b47cf000 b47d2000 r-xp /usr/lib/libdri2.so.0.0.0
b47e3000 b4831000 r-xp /usr/lib/libssl.so.1.0.0
b4846000 b4852000 r-xp /usr/lib/libeeze.so.1.13.0
b4862000 b486b000 r-xp /usr/lib/libethumb.so.1.13.0
b487b000 b487e000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b488e000 b4a45000 r-xp /usr/lib/libcrypto.so.1.0.0
b569c000 b56a5000 r-xp /usr/lib/libXi.so.6.1.0
b56b5000 b56b7000 r-xp /usr/lib/libXgesture.so.7.0.0
b56c7000 b56cb000 r-xp /usr/lib/libXtst.so.6.1.0
b56db000 b56e1000 r-xp /usr/lib/libXrender.so.1.3.0
b56f1000 b56f7000 r-xp /usr/lib/libXrandr.so.2.2.0
b5708000 b570a000 r-xp /usr/lib/libXinerama.so.1.0.0
b571a000 b571d000 r-xp /usr/lib/libXfixes.so.3.1.0
b572d000 b5738000 r-xp /usr/lib/libXext.so.6.4.0
b5748000 b574a000 r-xp /usr/lib/libXdamage.so.1.1.0
b575a000 b575c000 r-xp /usr/lib/libXcomposite.so.1.0.0
b576d000 b584f000 r-xp /usr/lib/libX11.so.6.3.0
b5862000 b5869000 r-xp /usr/lib/libXcursor.so.1.0.2
b5879000 b5891000 r-xp /usr/lib/libudev.so.1.6.0
b5893000 b5896000 r-xp /lib/libattr.so.1.1.0
b58a6000 b58c6000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58c8000 b58cd000 r-xp /usr/lib/libffi.so.6.0.2
b58dd000 b58f5000 r-xp /lib/libz.so.1.2.8
b5905000 b5907000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5917000 b59ec000 r-xp /usr/lib/libxml2.so.2.9.2
b5a01000 b5a9c000 r-xp /usr/lib/libstdc++.so.6.0.20
b5ab8000 b5abb000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5acb000 b5ae4000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5af5000 b5b06000 r-xp /lib/libresolv-2.20-2014.11.so
b5b1a000 b5b94000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5ba9000 b5bab000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bbb000 b5bc2000 r-xp /usr/lib/libembryo.so.1.13.0
b5bd2000 b5bea000 r-xp /usr/lib/libpng12.so.0.50.0
b5bfb000 b5c1e000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c3f000 b5c53000 r-xp /usr/lib/libector.so.1.13.0
b5c64000 b5c7c000 r-xp /usr/lib/liblua-5.1.so
b5c8d000 b5ce4000 r-xp /usr/lib/libfreetype.so.6.11.3
b5cf8000 b5d20000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d31000 b5d44000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d55000 b5d8c000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d9d000 b5dab000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5dbb000 b5dc3000 r-xp /usr/lib/libtbm.so.1.0.0
b5dd3000 b5de0000 r-xp /usr/lib/libeio.so.1.13.0
b5df0000 b5df2000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e02000 b5e07000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e17000 b5e2e000 r-xp /usr/lib/libefreet.so.1.13.0
b5e40000 b5e60000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e70000 b5e90000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e92000 b5e98000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5ea8000 b5eb9000 r-xp /usr/lib/libemotion.so.1.13.0
b5eca000 b5ed1000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5ee1000 b5ef0000 r-xp /usr/lib/libeo.so.1.13.0
b5f01000 b5f13000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f24000 b5f29000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f39000 b5f52000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f62000 b5f7f000 r-xp /usr/lib/libeet.so.1.13.0
b5f98000 b5fe0000 r-xp /usr/lib/libeina.so.1.13.0
b5ff1000 b6001000 r-xp /usr/lib/libefl.so.1.13.0
b6012000 b60f7000 r-xp /usr/lib/libicuuc.so.51.1
b6114000 b6254000 r-xp /usr/lib/libicui18n.so.51.1
b626b000 b62a3000 r-xp /usr/lib/libecore_x.so.1.13.0
b62b5000 b62b8000 r-xp /lib/libcap.so.2.21
b62c8000 b62f1000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6302000 b6309000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b631b000 b6352000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6363000 b644e000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6461000 b64da000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64ec000 b64f1000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6501000 b650b000 r-xp /usr/lib/libvconf.so.0.2.45
b651b000 b651d000 r-xp /usr/lib/libvasum.so.0.3.1
b652d000 b652f000 r-xp /usr/lib/libttrace.so.1.1
b653f000 b6542000 r-xp /usr/lib/libiniparser.so.0
b6552000 b6578000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6588000 b658d000 r-xp /usr/lib/libxdgmime.so.1.1.0
b659e000 b65b5000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65c6000 b6631000 r-xp /lib/libm-2.20-2014.11.so
b6642000 b6648000 r-xp /lib/librt-2.20-2014.11.so
b6659000 b6666000 r-xp /usr/lib/libunwind.so.8.0.1
b669c000 b67c0000 r-xp /lib/libc-2.20-2014.11.so
b67d5000 b67ee000 r-xp /lib/libgcc_s-4.9.so.1
b67fe000 b68e0000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68f1000 b691b000 r-xp /usr/lib/libdbus-1.so.3.8.12
b692c000 b6968000 r-xp /usr/lib/libsystemd.so.0.4.0
b696a000 b69ec000 r-xp /usr/lib/libedje.so.1.13.0
b69ff000 b6a1d000 r-xp /usr/lib/libecore.so.1.13.0
b6a3d000 b6bc4000 r-xp /usr/lib/libevas.so.1.13.0
b6bf9000 b6c0d000 r-xp /lib/libpthread-2.20-2014.11.so
b6c21000 b6e56000 r-xp /usr/lib/libelementary.so.1.13.0
b6e84000 b6e88000 r-xp /usr/lib/libsmack.so.1.0.0
b6e98000 b6e9f000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6eaf000 b6eb1000 r-xp /usr/lib/libdlog.so.0.0.0
b6ec1000 b6ec4000 r-xp /usr/lib/libbundle.so.0.1.22
b6ed4000 b6ed6000 r-xp /lib/libdl-2.20-2014.11.so
b6ee7000 b6eff000 r-xp /usr/lib/libaul.so.0.1.0
b6f13000 b6f18000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f29000 b6f36000 r-xp /usr/lib/liblptcp.so
b6f48000 b6f4c000 r-xp /usr/lib/libsys-assert.so
b6f5d000 b6f7d000 r-xp /lib/ld-2.20-2014.11.so
b6f8e000 b6f93000 r-xp /usr/bin/launchpad-loader
b8247000 b85a7000 rw-p [heap]
befaa000 befcb000 rw-p [stack]
b8247000 b85a7000 rw-p [heap]
befaa000 befcb000 rw-p [stack]
End of Maps Information

Callstack Information (PID:26961)
Call Stack Count: 4
 0: _IO_default_xsputn + 0x58 (0xb6706b58) [/lib/libc.so.6] + 0x6ab58
 1: _IO_vfprintf + 0xb8 (0xb66d91e8) [/lib/libc.so.6] + 0x3d1e8
 2: vsprintf + 0x68 (0xb66fbd04) [/lib/libc.so.6] + 0x5fd04
 3: (0xb64cf180) [/usr/lib/libsqlite3.so.0] + 0x6e180
End of Call Stack

Package Information
Package Name: org.example.avoidrickshaw
Package ID : org.example.avoidrickshaw
Version: 1.0.0
Package Type: tpk
App Name: avoidrickshaw
App ID: org.example.avoidrickshaw
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
07-29 10:41:27.739+0600 D/avoidrickshaw(28893): event-values: 4.447659, 4.250850, 8.233703, 0.000000
07-29 10:41:27.799+0600 D/avoidrickshaw(28893): event-values: 4.549953, 4.010969, 8.158329, 0.000000
07-29 10:41:27.860+0600 D/avoidrickshaw(28893): event-values: 4.310670, 4.331607, 7.811967, 0.000000
07-29 10:41:27.920+0600 D/avoidrickshaw(28893): event-values: 4.111467, 4.065405, 8.187641, 0.000000
07-29 10:41:27.980+0600 D/avoidrickshaw(28893): event-values: 4.654638, 3.797409, 7.702496, 0.000000
07-29 10:41:28.040+0600 D/avoidrickshaw(28893): event-values: 4.171886, 4.484748, 8.249256, 0.000000
07-29 10:41:28.100+0600 D/avoidrickshaw(28893): event-values: 4.247260, 4.134200, 7.984849, 0.000000
07-29 10:41:28.160+0600 D/avoidrickshaw(28893): event-values: 4.725825, 3.736991, 7.987840, 0.000000
07-29 10:41:28.220+0600 D/avoidrickshaw(28893): event-values: 3.955336, 4.475775, 7.928020, 0.000000
07-29 10:41:28.280+0600 D/avoidrickshaw(28893): event-values: 4.490730, 3.702295, 7.995018, 0.000000
07-29 10:41:28.340+0600 D/avoidrickshaw(28893): event-values: 4.624130, 3.488137, 7.698309, 0.000000
07-29 10:41:28.400+0600 D/avoidrickshaw(28893): event-values: 4.141976, 4.634897, 8.127820, 0.000000
07-29 10:41:28.460+0600 D/avoidrickshaw(28893): event-values: 4.311867, 3.868596, 8.511868, 0.000000
07-29 10:41:28.520+0600 D/avoidrickshaw(28893): event-values: 4.620540, 3.466003, 8.446066, 0.000000
07-29 10:41:28.580+0600 D/avoidrickshaw(28893): event-values: 4.596014, 3.647260, 8.063214, 0.000000
07-29 10:41:28.640+0600 D/avoidrickshaw(28893): event-values: 4.237091, 4.004987, 7.912466, 0.000000
07-29 10:41:28.700+0600 D/avoidrickshaw(28893): event-values: 4.137789, 4.180261, 8.179266, 0.000000
07-29 10:41:28.760+0600 D/avoidrickshaw(28893): event-values: 4.411169, 3.880560, 8.539984, 0.000000
07-29 10:41:28.820+0600 D/avoidrickshaw(28893): event-values: 4.156333, 4.283751, 8.094320, 0.000000
07-29 10:41:28.881+0600 D/avoidrickshaw(28893): event-values: 4.282554, 4.262814, 8.065607, 0.000000
07-29 10:41:28.941+0600 D/avoidrickshaw(28893): event-values: 4.194020, 4.251448, 8.084749, 0.000000
07-29 10:41:29.001+0600 D/avoidrickshaw(28893): event-values: 4.410570, 4.116851, 8.021340, 0.000000
07-29 10:41:29.061+0600 D/avoidrickshaw(28893): event-values: 4.235894, 4.172484, 8.047063, 0.000000
07-29 10:41:29.121+0600 D/avoidrickshaw(28893): event-values: 4.301098, 4.264608, 7.883752, 0.000000
07-29 10:41:29.181+0600 D/avoidrickshaw(28893): event-values: 4.402195, 4.116851, 8.140981, 0.000000
07-29 10:41:29.241+0600 D/avoidrickshaw(28893): event-values: 4.214957, 4.200002, 7.601997, 0.000000
07-29 10:41:29.301+0600 D/avoidrickshaw(28893): event-values: 4.558327, 4.317250, 8.295916, 0.000000
07-29 10:41:29.361+0600 D/avoidrickshaw(28893): event-values: 4.466204, 4.104887, 8.030313, 0.000000
07-29 10:41:29.421+0600 D/avoidrickshaw(28893): event-values: 4.345366, 4.292126, 8.234900, 0.000000
07-29 10:41:29.481+0600 D/avoidrickshaw(28893): event-values: 4.518846, 4.053442, 7.980063, 0.000000
07-29 10:41:29.541+0600 D/avoidrickshaw(28893): event-values: 4.168297, 4.058825, 7.719246, 0.000000
07-29 10:41:29.601+0600 D/avoidrickshaw(28893): event-values: 4.337589, 4.523631, 7.412366, 0.000000
07-29 10:41:29.661+0600 D/avoidrickshaw(28893): event-values: 4.577469, 4.307081, 8.246862, 0.000000
07-29 10:41:29.721+0600 D/avoidrickshaw(28893): event-values: 4.533801, 3.976871, 8.008778, 0.000000
07-29 10:41:29.791+0600 D/avoidrickshaw(28893): event-values: 4.368098, 4.523033, 7.855636, 0.000000
07-29 10:41:29.851+0600 D/avoidrickshaw(28893): event-values: 4.518846, 4.194020, 8.215158, 0.000000
07-29 10:41:29.912+0600 D/avoidrickshaw(28893): event-values: 4.823930, 3.979264, 7.512267, 0.000000
07-29 10:41:29.972+0600 D/avoidrickshaw(28893): event-values: 4.481159, 4.324429, 7.955537, 0.000000
07-29 10:41:30.032+0600 D/avoidrickshaw(28893): event-values: 3.903890, 4.346562, 7.412366, 0.000000
07-29 10:41:30.092+0600 D/avoidrickshaw(28893): event-values: 5.014160, 4.180860, 8.469994, 0.000000
07-29 10:41:30.152+0600 D/avoidrickshaw(28893): event-values: 4.778467, 3.994219, 7.955537, 0.000000
07-29 10:41:30.212+0600 D/avoidrickshaw(28893): event-values: 3.917051, 4.500899, 7.436295, 0.000000
07-29 10:41:30.272+0600 D/avoidrickshaw(28893): event-values: 4.734797, 4.256832, 7.687541, 0.000000
07-29 10:41:30.332+0600 D/avoidrickshaw(28893): event-values: 4.521836, 4.208377, 7.858627, 0.000000
07-29 10:41:30.392+0600 D/avoidrickshaw(28893): event-values: 4.341178, 4.356732, 7.610372, 0.000000
07-29 10:41:30.452+0600 D/avoidrickshaw(28893): event-values: 4.741378, 4.521238, 8.088339, 0.000000
07-29 10:41:30.512+0600 D/avoidrickshaw(28893): event-values: 4.844868, 4.053442, 7.957930, 0.000000
07-29 10:41:30.572+0600 D/avoidrickshaw(28893): event-values: 4.701298, 3.905685, 8.075178, 0.000000
07-29 10:41:30.632+0600 D/avoidrickshaw(28893): event-values: 4.149154, 4.474578, 7.484749, 0.000000
07-29 10:41:30.692+0600 D/avoidrickshaw(28893): event-values: 4.581059, 4.290331, 8.210971, 0.000000
07-29 10:41:30.752+0600 D/avoidrickshaw(28893): event-values: 4.562515, 4.315456, 7.593025, 0.000000
07-29 10:41:30.812+0600 D/avoidrickshaw(28893): event-values: 4.548756, 4.447659, 8.330013, 0.000000
07-29 10:41:30.872+0600 D/avoidrickshaw(28893): event-values: 4.655835, 3.955934, 7.969894, 0.000000
07-29 10:41:30.933+0600 D/avoidrickshaw(28893): event-values: 4.688138, 4.145565, 7.517651, 0.000000
07-29 10:41:30.993+0600 D/avoidrickshaw(28893): event-values: 4.118646, 4.658825, 8.087741, 0.000000
07-29 10:41:31.053+0600 D/avoidrickshaw(28893): event-values: 4.664808, 3.827320, 8.120642, 0.000000
07-29 10:41:31.113+0600 D/avoidrickshaw(28893): event-values: 4.804190, 3.955336, 7.820941, 0.000000
07-29 10:41:31.173+0600 D/avoidrickshaw(28893): event-values: 3.918845, 4.908278, 7.795816, 0.000000
07-29 10:41:31.233+0600 D/avoidrickshaw(28893): event-values: 4.929813, 3.262614, 8.036893, 0.000000
07-29 10:41:31.293+0600 D/avoidrickshaw(28893): event-values: 4.561318, 4.779663, 8.078767, 0.000000
07-29 10:41:31.353+0600 D/avoidrickshaw(28893): event-values: 4.208377, 4.297509, 8.249256, 0.000000
07-29 10:41:31.413+0600 D/avoidrickshaw(28893): event-values: 4.646264, 3.638885, 8.231310, 0.000000
07-29 10:41:31.473+0600 D/avoidrickshaw(28893): event-values: 4.694718, 3.872783, 8.361719, 0.000000
07-29 10:41:31.533+0600 D/avoidrickshaw(28893): event-values: 4.247859, 4.049852, 8.065607, 0.000000
07-29 10:41:31.593+0600 D/avoidrickshaw(28893): event-values: 4.067799, 4.236493, 7.593025, 0.000000
07-29 10:41:31.653+0600 D/avoidrickshaw(28893): event-values: 4.113262, 4.206582, 8.468798, 0.000000
07-29 10:41:31.713+0600 D/avoidrickshaw(28893): event-values: 4.363910, 4.159324, 7.874779, 0.000000
07-29 10:41:31.773+0600 D/avoidrickshaw(28893): event-values: 4.390830, 4.246662, 8.187043, 0.000000
07-29 10:41:31.833+0600 D/avoidrickshaw(28893): event-values: 4.039084, 4.472186, 7.549953, 0.000000
07-29 10:41:31.893+0600 D/avoidrickshaw(28893): event-values: 4.317250, 4.540979, 8.356335, 0.000000
07-29 10:41:31.954+0600 D/avoidrickshaw(28893): event-values: 4.583452, 3.984648, 7.889136, 0.000000
07-29 10:41:32.014+0600 D/avoidrickshaw(28893): event-values: 4.231109, 4.392026, 8.163115, 0.000000
07-29 10:41:32.074+0600 D/avoidrickshaw(28893): event-values: 3.981059, 4.354339, 7.527820, 0.000000
07-29 10:41:32.134+0600 D/avoidrickshaw(28893): event-values: 4.386642, 3.985246, 8.199007, 0.000000
07-29 10:41:32.194+0600 D/avoidrickshaw(28893): event-values: 4.591826, 4.395017, 7.686344, 0.000000
07-29 10:41:32.254+0600 D/avoidrickshaw(28893): event-values: 4.023531, 4.195815, 7.885547, 0.000000
07-29 10:41:32.314+0600 D/avoidrickshaw(28893): event-values: 4.436892, 4.036692, 8.112267, 0.000000
07-29 10:41:32.374+0600 D/avoidrickshaw(28893): event-values: 4.201199, 4.829913, 7.961519, 0.000000
07-29 10:41:32.434+0600 D/avoidrickshaw(28893): event-values: 4.461418, 4.037290, 8.068598, 0.000000
07-29 10:41:32.494+0600 D/avoidrickshaw(28893): event-values: 4.366303, 4.231109, 8.369495, 0.000000
07-29 10:41:32.514+0600 I/Tizen::Net::Wifi( 1305): (1085) > _WifiService is not registered.
07-29 10:41:32.554+0600 D/avoidrickshaw(28893): event-values: 4.458426, 3.771089, 7.804790, 0.000000
07-29 10:41:32.614+0600 D/avoidrickshaw(28893): event-values: 4.281358, 4.457829, 7.786245, 0.000000
07-29 10:41:32.674+0600 D/avoidrickshaw(28893): event-values: 4.097709, 4.395017, 7.992626, 0.000000
07-29 10:41:32.734+0600 D/avoidrickshaw(28893): event-values: 4.368696, 4.219743, 8.096714, 0.000000
07-29 10:41:32.794+0600 D/avoidrickshaw(28893): event-values: 4.251448, 4.353143, 7.990233, 0.000000
07-29 10:41:32.854+0600 D/avoidrickshaw(28893): event-values: 4.438087, 4.438686, 7.813762, 0.000000
07-29 10:41:32.914+0600 D/avoidrickshaw(28893): event-values: 4.084548, 3.922434, 7.938190, 0.000000
07-29 10:41:32.975+0600 D/avoidrickshaw(28893): event-values: 4.279563, 4.233501, 8.026724, 0.000000
07-29 10:41:33.035+0600 D/avoidrickshaw(28893): event-values: 4.088736, 4.426124, 7.922636, 0.000000
07-29 10:41:33.095+0600 D/avoidrickshaw(28893): event-values: 4.442275, 4.326822, 8.001000, 0.000000
07-29 10:41:33.155+0600 D/avoidrickshaw(28893): event-values: 4.578068, 4.036692, 8.586644, 0.000000
07-29 10:41:33.215+0600 D/avoidrickshaw(28893): event-values: 4.132405, 4.133003, 7.985447, 0.000000
07-29 10:41:33.275+0600 D/avoidrickshaw(28893): event-values: 4.344169, 4.067799, 7.917850, 0.000000
07-29 10:41:33.335+0600 D/avoidrickshaw(28893): event-values: 3.703491, 4.446463, 7.416554, 0.000000
07-29 10:41:33.395+0600 D/avoidrickshaw(28893): event-values: 4.615755, 4.639683, 8.680562, 0.000000
07-29 10:41:33.455+0600 D/avoidrickshaw(28893): event-values: 4.483552, 3.940979, 8.299505, 0.000000
07-29 10:41:33.515+0600 D/avoidrickshaw(28893): event-values: 4.259224, 4.316054, 7.545766, 0.000000
07-29 10:41:33.525+0600 I/Tizen::Net::Wifi( 1305): (1085) > _WifiService is not registered.
07-29 10:41:33.575+0600 D/avoidrickshaw(28893): event-values: 4.184449, 4.604389, 8.337192, 0.000000
07-29 10:41:33.635+0600 D/avoidrickshaw(28893): event-values: 4.552943, 3.981657, 7.789834, 0.000000
07-29 10:41:33.695+0600 D/avoidrickshaw(28893): event-values: 4.209573, 4.200600, 8.170293, 0.000000
07-29 10:41:33.755+0600 D/avoidrickshaw(28893): event-values: 4.710271, 3.932006, 8.179864, 0.000000
07-29 10:41:33.815+0600 D/avoidrickshaw(28893): event-values: 4.149753, 4.680959, 7.764710, 0.000000
07-29 10:41:33.875+0600 D/avoidrickshaw(28893): event-values: 4.369893, 4.294518, 8.212167, 0.000000
07-29 10:41:33.935+0600 D/avoidrickshaw(28893): event-values: 4.357928, 3.823132, 7.846066, 0.000000
07-29 10:41:33.996+0600 D/avoidrickshaw(28893): event-values: 4.537988, 4.116851, 7.998608, 0.000000
07-29 10:41:34.056+0600 D/avoidrickshaw(28893): event-values: 3.888935, 4.843671, 8.014161, 0.000000
07-29 10:41:34.116+0600 D/avoidrickshaw(28893): event-values: 4.658227, 3.472584, 8.200801, 0.000000
07-29 10:41:34.176+0600 D/avoidrickshaw(28893): event-values: 4.413561, 4.360919, 7.809575, 0.000000
07-29 10:41:34.236+0600 D/avoidrickshaw(28893): event-values: 4.419543, 4.775476, 7.500901, 0.000000
07-29 10:41:34.296+0600 D/avoidrickshaw(28893): event-values: 4.230510, 4.144967, 8.505288, 0.000000
07-29 10:41:34.356+0600 D/avoidrickshaw(28893): event-values: 4.576273, 4.064807, 7.857431, 0.000000
07-29 10:41:34.416+0600 D/avoidrickshaw(28893): event-values: 5.041678, 4.417150, 7.621140, 0.000000
07-29 10:41:34.476+0600 D/avoidrickshaw(28893): event-values: 4.604987, 4.379464, 7.740183, 0.000000
07-29 10:41:34.536+0600 D/avoidrickshaw(28893): event-values: 5.494519, 3.388237, 7.936395, 0.000000
07-29 10:41:34.596+0600 D/avoidrickshaw(28893): event-values: 5.143373, 2.903690, 9.494122, 0.000000
07-29 10:41:34.656+0600 D/avoidrickshaw(28893): event-values: 4.596612, 3.326622, 8.933005, 0.000000
07-29 10:41:34.716+0600 D/avoidrickshaw(28893): event-values: 3.358925, 4.850850, 7.923234, 0.000000
07-29 10:41:34.776+0600 D/avoidrickshaw(28893): event-values: 3.230310, 5.015955, 7.627721, 0.000000
07-29 10:41:34.836+0600 D/avoidrickshaw(28893): event-values: 3.872185, 5.134997, 7.835896, 0.000000
07-29 10:41:34.896+0600 D/avoidrickshaw(28893): event-values: 4.386642, 4.587041, 6.869793, 0.000000
07-29 10:41:34.956+0600 D/avoidrickshaw(28893): event-values: 4.430909, 5.879764, 7.491330, 0.000000
07-29 10:41:35.017+0600 D/avoidrickshaw(28893): event-values: 4.171886, 4.945964, 7.194620, 0.000000
07-29 10:41:35.077+0600 D/avoidrickshaw(28893): event-values: 4.346562, 4.774878, 7.206583, 0.000000
07-29 10:41:35.137+0600 D/avoidrickshaw(28893): event-values: 3.995415, 5.428118, 7.683353, 0.000000
07-29 10:41:35.197+0600 D/avoidrickshaw(28893): event-values: 4.469194, 5.128417, 7.620542, 0.000000
07-29 10:41:35.257+0600 D/avoidrickshaw(28893): event-values: 4.342375, 4.944768, 7.214958, 0.000000
07-29 10:41:35.317+0600 D/avoidrickshaw(28893): event-values: 3.998406, 5.219344, 7.312466, 0.000000
07-29 10:41:35.377+0600 D/avoidrickshaw(28893): event-values: 4.119843, 5.068597, 6.763313, 0.000000
07-29 10:41:35.437+0600 D/avoidrickshaw(28893): event-values: 4.044468, 5.944968, 8.141580, 0.000000
07-29 10:41:35.487+0600 D/avoidrickshaw(28893): event-values: 4.382454, 5.165506, 7.700103, 0.000000
07-29 10:41:35.507+0600 I/Tizen::Net::Wifi( 1305): (1085) > _WifiService is not registered.
07-29 10:41:35.547+0600 D/avoidrickshaw(28893): event-values: 4.303492, 4.815556, 7.322037, 0.000000
07-29 10:41:35.607+0600 D/avoidrickshaw(28893): event-values: 4.709673, 5.003990, 7.469794, 0.000000
07-29 10:41:35.667+0600 D/avoidrickshaw(28893): event-values: 4.618746, 5.357530, 7.966305, 0.000000
07-29 10:41:35.727+0600 D/avoidrickshaw(28893): event-values: 4.723432, 4.803592, 8.034500, 0.000000
07-29 10:41:35.787+0600 D/avoidrickshaw(28893): event-values: 3.772883, 5.184649, 7.754540, 0.000000
07-29 10:41:35.847+0600 D/avoidrickshaw(28893): event-values: 2.091925, 5.916852, 7.819745, 0.000000
07-29 10:41:35.907+0600 D/avoidrickshaw(28893): event-values: 0.865005, 6.614360, 7.268797, 0.000000
07-29 10:41:35.967+0600 D/avoidrickshaw(28893): event-values: -0.162114, 7.150951, 7.155736, 0.000000
07-29 10:41:36.028+0600 D/avoidrickshaw(28893): event-values: -1.092324, 7.703692, 6.993622, 0.000000
07-29 10:41:36.088+0600 D/avoidrickshaw(28893): event-values: -2.246860, 8.809774, 7.186843, 0.000000
07-29 10:41:36.148+0600 D/avoidrickshaw(28893): event-values: -3.446861, 6.122635, 4.133601, 0.000000
07-29 10:41:36.208+0600 D/avoidrickshaw(28893): event-values: -4.820341, 6.234499, 3.625724, 0.000000
07-29 10:41:36.268+0600 D/avoidrickshaw(28893): event-values: -5.318048, 5.133202, 3.269194, 0.000000
07-29 10:41:36.328+0600 D/avoidrickshaw(28893): event-values: -6.923633, 5.627321, 3.288337, 0.000000
07-29 10:41:36.388+0600 D/avoidrickshaw(28893): event-values: -7.167102, 6.374479, 4.341178, 0.000000
07-29 10:41:36.448+0600 D/avoidrickshaw(28893): event-values: -6.718448, 6.321239, 5.166702, 0.000000
07-29 10:41:36.508+0600 D/avoidrickshaw(28893): event-values: -5.448457, 5.322834, 3.162115, 0.000000
07-29 10:41:36.568+0600 D/avoidrickshaw(28893): event-values: -3.767499, 6.906882, 4.593023, 0.000000
07-29 10:41:36.628+0600 D/avoidrickshaw(28893): event-values: 1.085145, 6.430710, 6.938588, 0.000000
07-29 10:41:36.688+0600 D/avoidrickshaw(28893): event-values: 4.929813, 4.785645, 5.901299, 0.000000
07-29 10:41:36.748+0600 D/avoidrickshaw(28893): event-values: 6.262017, 4.606184, 7.566703, 0.000000
07-29 10:41:36.808+0600 D/avoidrickshaw(28893): event-values: 5.424529, 5.579464, 6.512067, 0.000000
07-29 10:41:36.868+0600 D/avoidrickshaw(28893): event-values: 3.954139, 5.309673, 13.484153, 0.000000
07-29 10:41:36.928+0600 D/avoidrickshaw(28893): event-values: 3.133999, 7.495517, 9.613763, 0.000000
07-29 10:41:36.988+0600 D/avoidrickshaw(28893): event-values: 3.408576, 4.831707, 7.727620, 0.000000
07-29 10:41:37.049+0600 D/avoidrickshaw(28893): event-values: 2.287539, 3.113660, 8.755339, 0.000000
07-29 10:41:37.109+0600 D/avoidrickshaw(28893): event-values: 2.763112, 2.935395, 10.066007, 0.000000
07-29 10:41:37.169+0600 D/avoidrickshaw(28893): event-values: 1.444068, 1.798206, 11.227123, 0.000000
07-29 10:41:37.229+0600 D/avoidrickshaw(28893): event-values: 0.524626, 1.552942, 10.224532, 0.000000
07-29 10:41:37.289+0600 D/avoidrickshaw(28893): event-values: 0.089133, 3.204588, 8.038089, 0.000000
07-29 10:41:37.349+0600 D/avoidrickshaw(28893): event-values: -0.034098, 3.931407, 7.739585, 0.000000
07-29 10:41:37.409+0600 D/avoidrickshaw(28893): event-values: -1.014557, 3.741776, 9.422338, 0.000000
07-29 10:41:37.469+0600 D/avoidrickshaw(28893): event-values: -0.390030, 3.240480, 9.786645, 0.000000
07-29 10:41:37.529+0600 D/avoidrickshaw(28893): event-values: -0.272184, 2.915654, 9.229715, 0.000000
07-29 10:41:37.589+0600 D/avoidrickshaw(28893): event-values: 0.872184, 3.416951, 10.428518, 0.000000
07-29 10:41:37.649+0600 D/avoidrickshaw(28893): event-values: 0.899103, 3.471388, 10.125827, 0.000000
07-29 10:41:37.709+0600 D/avoidrickshaw(28893): event-values: 0.853041, 3.634099, 9.942179, 0.000000
07-29 10:41:37.769+0600 D/avoidrickshaw(28893): event-values: 1.135394, 2.849852, 9.905688, 0.000000
07-29 10:41:37.829+0600 D/avoidrickshaw(28893): event-values: 1.295713, 3.118446, 8.895318, 0.000000
07-29 10:41:37.889+0600 D/avoidrickshaw(28893): event-values: 0.425324, 3.144767, 8.819944, 0.000000
07-29 10:41:37.949+0600 D/avoidrickshaw(28893): event-values: -0.288933, 3.975675, 9.109475, 0.000000
07-29 10:41:38.009+0600 D/avoidrickshaw(28893): event-values: -0.983450, 4.201199, 10.462018, 0.000000
07-29 10:41:38.070+0600 D/avoidrickshaw(28893): event-values: -0.535992, 3.917649, 9.087940, 0.000000
07-29 10:41:38.130+0600 D/avoidrickshaw(28893): event-values: -0.286541, 4.176672, 8.483154, 0.000000
07-29 10:41:38.190+0600 D/avoidrickshaw(28893): event-values: -1.056431, 3.285345, 9.276974, 0.000000
07-29 10:41:38.250+0600 D/avoidrickshaw(28893): event-values: -1.005584, 3.338586, 8.136793, 0.000000
07-29 10:41:38.310+0600 D/avoidrickshaw(28893): event-values: -1.095913, 3.165704, 7.093523, 0.000000
07-29 10:41:38.370+0600 D/avoidrickshaw(28893): event-values: -1.113261, 3.806383, 8.513663, 0.000000
07-29 10:41:38.410+0600 I/Tizen::Net::Wifi( 1305): (941) > The background scan result updated.
07-29 10:41:38.430+0600 D/avoidrickshaw(28893): event-values: -3.337988, 4.497908, 15.087345, 0.000000
07-29 10:41:38.490+0600 D/avoidrickshaw(28893): event-values: -3.267998, 4.996214, 11.301301, 0.000000
07-29 10:41:38.550+0600 D/avoidrickshaw(28893): horizontal_acc: 31.000000, vertical_acc: -1.000000
07-29 10:41:38.550+0600 D/avoidrickshaw(28893): previous lat: 23.814995, previous long: 90.426570
07-29 10:41:38.550+0600 D/avoidrickshaw(28893): current lat: 23.814995, current long: 90.426570
07-29 10:41:38.560+0600 D/avoidrickshaw(28893): total distance: 0.000000 meters
07-29 10:41:38.560+0600 D/avoidrickshaw(28893): elapsed time; 0.100601
07-29 10:41:38.560+0600 D/avoidrickshaw(28893): event-values: -1.055235, 4.725227, 6.480960, 0.000000
07-29 10:41:38.610+0600 D/avoidrickshaw(28893): event-values: -0.320638, 4.791029, 7.740183, 0.000000
07-29 10:41:38.670+0600 D/avoidrickshaw(28893): event-values: 0.410369, 4.152744, 9.598209, 0.000000
07-29 10:41:38.730+0600 D/avoidrickshaw(28893): event-values: 0.631107, 2.181058, 11.171491, 0.000000
07-29 10:41:38.790+0600 D/avoidrickshaw(28893): event-values: 0.753739, 2.439482, 10.896316, 0.000000
07-29 10:41:38.850+0600 D/avoidrickshaw(28893): event-values: 0.311067, 2.459821, 9.704092, 0.000000
07-29 10:41:38.910+0600 D/avoidrickshaw(28893): event-values: -0.138784, 2.472384, 8.984450, 0.000000
07-29 10:41:38.970+0600 D/avoidrickshaw(28893): event-values: -0.328415, 4.118646, 9.471390, 0.000000
07-29 10:41:39.030+0600 D/avoidrickshaw(28893): event-values: -0.089731, 3.904488, 9.187840, 0.000000
07-29 10:41:39.090+0600 D/avoidrickshaw(28893): event-values: 0.367298, 4.165904, 8.886944, 0.000000
07-29 10:41:39.151+0600 D/avoidrickshaw(28893): event-values: 1.128216, 3.031108, 8.849854, 0.000000
07-29 10:41:39.211+0600 D/avoidrickshaw(28893): event-values: 0.973281, 3.085545, 9.473185, 0.000000
07-29 10:41:39.271+0600 D/avoidrickshaw(28893): event-values: 0.577867, 2.560320, 9.667602, 0.000000
07-29 10:41:39.331+0600 D/avoidrickshaw(28893): event-values: 0.834497, 2.510669, 9.511470, 0.000000
07-29 10:41:39.391+0600 D/avoidrickshaw(28893): event-values: 0.384048, 2.818147, 9.760324, 0.000000
07-29 10:41:39.451+0600 D/avoidrickshaw(28893): event-values: 0.952343, 2.809772, 9.412168, 0.000000
07-29 10:41:39.511+0600 D/avoidrickshaw(28893): event-values: 0.122034, 3.113660, 9.341579, 0.000000
07-29 10:41:39.571+0600 D/avoidrickshaw(28893): event-values: 0.452842, 2.968895, 8.882158, 0.000000
07-29 10:41:39.631+0600 D/avoidrickshaw(28893): event-values: 0.122632, 3.908676, 9.026923, 0.000000
07-29 10:41:39.691+0600 D/avoidrickshaw(28893): event-values: -0.138784, 4.720441, 9.135199, 0.000000
07-29 10:41:39.751+0600 D/avoidrickshaw(28893): event-values: -0.299701, 4.670192, 8.919247, 0.000000
07-29 10:41:39.811+0600 D/avoidrickshaw(28893): event-values: -0.613161, 4.943572, 9.021540, 0.000000
07-29 10:41:39.871+0600 D/avoidrickshaw(28893): event-values: -0.272184, 4.938188, 9.016156, 0.000000
07-29 10:41:39.931+0600 D/avoidrickshaw(28893): event-values: -0.468395, 4.782056, 8.743374, 0.000000
07-29 10:41:39.991+0600 D/avoidrickshaw(28893): event-values: -0.484547, 4.593621, 8.621340, 0.000000
07-29 10:41:40.051+0600 D/avoidrickshaw(28893): event-values: -0.369093, 4.561318, 8.901299, 0.000000
07-29 10:41:40.111+0600 D/avoidrickshaw(28893): event-values: -0.093320, 4.559524, 8.743972, 0.000000
07-29 10:41:40.172+0600 D/avoidrickshaw(28893): event-values: 0.042473, 4.613362, 9.043075, 0.000000
07-29 10:41:40.232+0600 D/avoidrickshaw(28893): event-values: 0.166301, 4.649853, 9.057432, 0.000000
07-29 10:41:40.292+0600 D/avoidrickshaw(28893): event-values: 0.490529, 4.505087, 9.510273, 0.000000
07-29 10:41:40.352+0600 D/avoidrickshaw(28893): event-values: 0.789631, 4.405186, 9.085547, 0.000000
07-29 10:41:40.412+0600 D/avoidrickshaw(28893): event-values: 0.547956, 4.255635, 8.900702, 0.000000
07-29 10:41:40.472+0600 D/avoidrickshaw(28893): event-values: 0.530608, 4.360321, 8.973085, 0.000000
07-29 10:41:40.532+0600 D/avoidrickshaw(28893): event-values: 0.455235, 3.954139, 9.029316, 0.000000
07-29 10:41:40.592+0600 D/avoidrickshaw(28893): event-values: 0.224925, 3.982255, 8.845668, 0.000000
07-29 10:41:40.652+0600 D/avoidrickshaw(28893): event-values: -0.215354, 4.118048, 8.775677, 0.000000
07-29 10:41:40.712+0600 D/avoidrickshaw(28893): event-values: -0.415753, 4.118048, 9.478568, 0.000000
07-29 10:41:40.772+0600 D/avoidrickshaw(28893): event-values: -0.778266, 3.939782, 9.833902, 0.000000
07-29 10:41:40.832+0600 D/avoidrickshaw(28893): event-values: -0.541376, 4.217350, 9.400802, 0.000000
07-29 10:41:40.892+0600 D/avoidrickshaw(28893): event-values: -0.467797, 4.255037, 9.098708, 0.000000
07-29 10:41:40.952+0600 D/avoidrickshaw(28893): event-values: -0.664008, 4.340580, 9.005986, 0.000000
07-29 10:41:41.012+0600 D/avoidrickshaw(28893): event-values: -0.404985, 4.114459, 9.005986, 0.000000
07-29 10:41:41.072+0600 D/avoidrickshaw(28893): event-values: -0.466600, 4.267001, 9.020942, 0.000000
07-29 10:41:41.132+0600 D/avoidrickshaw(28893): event-values: -0.494118, 4.262215, 8.886346, 0.000000
07-29 10:41:41.193+0600 D/avoidrickshaw(28893): event-values: -0.412762, 4.392026, 9.169894, 0.000000
07-29 10:41:41.253+0600 D/avoidrickshaw(28893): event-values: -0.412164, 4.467400, 9.123833, 0.000000
07-29 10:41:41.313+0600 D/avoidrickshaw(28893): event-values: -0.286541, 4.419543, 9.122636, 0.000000
07-29 10:41:41.373+0600 D/avoidrickshaw(28893): event-values: -0.217747, 4.381856, 9.153743, 0.000000
07-29 10:41:41.433+0600 D/avoidrickshaw(28893): event-values: -0.260818, 4.372883, 8.967701, 0.000000
07-29 10:41:41.493+0600 D/avoidrickshaw(28893): event-values: -0.402592, 4.319643, 8.906684, 0.000000
07-29 10:41:41.553+0600 D/avoidrickshaw(28893): event-values: -0.485145, 4.247859, 8.862417, 0.000000
07-29 10:41:41.613+0600 D/avoidrickshaw(28893): event-values: -0.348754, 4.205386, 9.326026, 0.000000
07-29 10:41:41.673+0600 D/avoidrickshaw(28893): event-values: -0.099900, 4.136592, 9.178867, 0.000000
07-29 10:41:41.733+0600 D/avoidrickshaw(28893): event-values: -0.090329, 4.168297, 9.115458, 0.000000
07-29 10:41:41.793+0600 D/avoidrickshaw(28893): event-values: -0.197408, 4.238287, 9.260223, 0.000000
07-29 10:41:41.853+0600 D/avoidrickshaw(28893): event-values: -0.248854, 4.243073, 9.270393, 0.000000
07-29 10:41:41.913+0600 D/avoidrickshaw(28893): event-values: -0.234497, 4.177868, 9.165708, 0.000000
07-29 10:41:41.973+0600 D/avoidrickshaw(28893): event-values: -0.122034, 4.204788, 8.993424, 0.000000
07-29 10:41:42.033+0600 D/avoidrickshaw(28893): event-values: -0.207577, 4.220341, 9.107681, 0.000000
07-29 10:41:42.093+0600 D/avoidrickshaw(28893): event-values: -0.360120, 4.196413, 9.371490, 0.000000
07-29 10:41:42.153+0600 D/avoidrickshaw(28893): event-values: -0.394816, 4.178466, 9.101101, 0.000000
07-29 10:41:42.214+0600 D/avoidrickshaw(28893): event-values: -0.351745, 4.103691, 8.811569, 0.000000
07-29 10:41:42.274+0600 D/avoidrickshaw(28893): event-values: -0.193220, 4.079762, 9.029914, 0.000000
07-29 10:41:42.334+0600 D/avoidrickshaw(28893): event-values: -0.200997, 4.071388, 9.266804, 0.000000
07-29 10:41:42.394+0600 D/avoidrickshaw(28893): event-values: -0.077169, 4.038486, 9.488738, 0.000000
07-29 10:41:42.454+0600 D/avoidrickshaw(28893): event-values: 0.141775, 4.055236, 9.442677, 0.000000
07-29 10:41:42.514+0600 D/avoidrickshaw(28893): event-values: 0.181855, 3.901497, 9.343374, 0.000000
07-29 10:41:42.574+0600 D/avoidrickshaw(28893): event-values: 0.247657, 3.918247, 9.295518, 0.000000
07-29 10:41:42.634+0600 D/avoidrickshaw(28893): event-values: 0.111266, 3.706482, 9.448060, 0.000000
07-29 10:41:42.694+0600 D/avoidrickshaw(28893): event-values: 0.113061, 3.433701, 9.510871, 0.000000
07-29 10:41:42.754+0600 D/avoidrickshaw(28893): event-values: 0.107079, 3.030510, 8.461619, 0.000000
07-29 10:41:42.814+0600 D/avoidrickshaw(28893): event-values: -0.226720, 3.719044, 9.280562, 0.000000
07-29 10:41:42.874+0600 D/avoidrickshaw(28893): event-values: -0.363111, 3.052643, 9.949955, 0.000000
07-29 10:41:42.934+0600 D/avoidrickshaw(28893): event-values: -0.278764, 3.055635, 8.413164, 0.000000
07-29 10:41:42.994+0600 D/avoidrickshaw(28893): event-values: -0.486341, 2.228316, 9.438489, 0.000000
07-29 10:41:43.054+0600 D/avoidrickshaw(28893): event-values: -0.527019, 2.505285, 9.839286, 0.000000
07-29 10:41:43.114+0600 D/avoidrickshaw(28893): event-values: -0.403789, 2.405983, 9.412168, 0.000000
07-29 10:41:43.174+0600 D/avoidrickshaw(28893): event-values: -0.031107, 2.368894, 9.497113, 0.000000
07-29 10:41:43.235+0600 D/avoidrickshaw(28893): event-values: -0.566501, 2.313261, 9.818949, 0.000000
07-29 10:41:43.295+0600 D/avoidrickshaw(28893): event-values: -0.823131, 2.017748, 9.899706, 0.000000
07-29 10:41:43.355+0600 D/avoidrickshaw(28893): event-values: -0.606581, 1.843072, 9.911072, 0.000000
07-29 10:41:43.415+0600 D/avoidrickshaw(28893): event-values: -0.287737, 1.556531, 9.957133, 0.000000
07-29 10:41:43.475+0600 D/avoidrickshaw(28893): event-values: -0.473181, 1.716252, 9.990633, 0.000000
07-29 10:41:43.535+0600 D/avoidrickshaw(28893): event-values: -0.354736, 1.683949, 10.092925, 0.000000
07-29 10:41:43.595+0600 D/avoidrickshaw(28893): event-values: -1.191028, 2.205584, 10.000204, 0.000000
07-29 10:41:43.655+0600 D/avoidrickshaw(28893): event-values: -0.884746, 2.067399, 9.871590, 0.000000
07-29 10:41:43.715+0600 D/avoidrickshaw(28893): event-values: -0.878764, 2.283949, 9.829715, 0.000000
07-29 10:41:43.775+0600 D/avoidrickshaw(28893): event-values: -0.851845, 2.087738, 9.562318, 0.000000
07-29 10:41:43.835+0600 D/avoidrickshaw(28893): event-values: -0.867996, 2.263012, 9.945767, 0.000000
07-29 10:41:43.895+0600 D/avoidrickshaw(28893): event-values: -0.589831, 1.983650, 10.015757, 0.000000
07-29 10:41:43.955+0600 D/avoidrickshaw(28893): event-values: -0.898505, 2.568695, 9.893126, 0.000000
07-29 10:41:44.015+0600 D/avoidrickshaw(28893): event-values: -0.766301, 2.532803, 9.613763, 0.000000
07-29 10:41:44.075+0600 D/avoidrickshaw(28893): event-values: -0.760918, 2.507080, 9.671191, 0.000000
07-29 10:41:44.135+0600 D/avoidrickshaw(28893): event-values: -0.687338, 2.494518, 9.571291, 0.000000
07-29 10:41:44.195+0600 D/avoidrickshaw(28893): event-values: -0.709472, 2.425126, 9.846465, 0.000000
07-29 10:41:44.256+0600 D/avoidrickshaw(28893): event-values: -0.683749, 2.354537, 9.608379, 0.000000
07-29 10:41:44.316+0600 D/avoidrickshaw(28893): event-values: -0.674776, 2.462813, 9.719646, 0.000000
07-29 10:41:44.376+0600 D/avoidrickshaw(28893): event-values: -0.658026, 2.598605, 9.732207, 0.000000
07-29 10:41:44.436+0600 D/avoidrickshaw(28893): event-values: -0.635893, 2.595016, 9.754940, 0.000000
07-29 10:41:44.496+0600 D/avoidrickshaw(28893): event-values: -0.576072, 2.446661, 9.777073, 0.000000
07-29 10:41:44.556+0600 D/avoidrickshaw(28893): event-values: -0.633500, 2.490330, 9.722636, 0.000000
07-29 10:41:44.616+0600 D/avoidrickshaw(28893): event-values: -0.638884, 2.438286, 9.703494, 0.000000
07-29 10:41:44.676+0600 D/avoidrickshaw(28893): event-values: -0.461217, 2.364707, 9.838689, 0.000000
07-29 10:41:44.736+0600 D/avoidrickshaw(28893): event-values: -0.517448, 2.331208, 9.617950, 0.000000
07-29 10:41:44.796+0600 D/avoidrickshaw(28893): event-values: -0.363709, 2.251646, 9.841081, 0.000000
07-29 10:41:44.856+0600 D/avoidrickshaw(28893): event-values: -0.308076, 2.358725, 9.817153, 0.000000
07-29 10:41:44.916+0600 D/avoidrickshaw(28893): event-values: -0.336192, 2.416751, 9.686744, 0.000000
07-29 10:41:44.976+0600 D/avoidrickshaw(28893): event-values: -0.333799, 2.508276, 9.962516, 0.000000
07-29 10:41:45.036+0600 D/avoidrickshaw(28893): event-values: -0.339781, 2.467000, 9.665209, 0.000000
07-29 10:41:45.096+0600 D/avoidrickshaw(28893): event-values: -0.361316, 2.462813, 9.902099, 0.000000
07-29 10:41:45.156+0600 D/avoidrickshaw(28893): event-values: -0.129212, 2.331208, 9.982258, 0.000000
07-29 10:41:45.216+0600 D/avoidrickshaw(28893): event-values: -0.201595, 2.371886, 9.781260, 0.000000
07-29 10:41:45.277+0600 D/avoidrickshaw(28893): event-values: -0.095115, 2.324029, 9.669994, 0.000000
07-29 10:41:45.337+0600 D/avoidrickshaw(28893): event-values: 0.285942, 2.365903, 9.337392, 0.000000
07-29 10:41:45.397+0600 D/avoidrickshaw(28893): event-values: 0.508475, 2.289333, 8.829515, 0.000000
07-29 10:41:45.457+0600 D/avoidrickshaw(28893): event-values: 0.926022, 1.977070, 10.018150, 0.000000
07-29 10:41:45.517+0600 D/avoidrickshaw(28893): event-values: 0.631705, 2.105684, 10.701301, 0.000000
07-29 10:41:45.577+0600 D/avoidrickshaw(28893): event-values: 0.436092, 2.129014, 10.566107, 0.000000
07-29 10:41:45.637+0600 D/avoidrickshaw(28893): event-values: 0.248255, 2.700300, 9.708879, 0.000000
07-29 10:41:45.697+0600 D/avoidrickshaw(28893): event-values: 0.412164, 2.889931, 10.049855, 0.000000
07-29 10:41:45.747+0600 D/avoidrickshaw(28893): event-values: 0.497707, 2.694318, 9.521640, 0.000000
07-29 10:41:45.807+0600 D/avoidrickshaw(28893): event-values: 0.804587, 2.946761, 9.533006, 0.000000
07-29 10:41:45.867+0600 D/avoidrickshaw(28893): event-values: 0.586840, 2.745764, 10.008579, 0.000000
07-29 10:41:45.927+0600 D/avoidrickshaw(28893): event-values: 0.379861, 2.090131, 9.716056, 0.000000
07-29 10:41:45.987+0600 D/avoidrickshaw(28893): event-values: 0.768694, 2.275574, 10.048061, 0.000000
07-29 10:41:46.047+0600 D/avoidrickshaw(28893): event-values: 0.376870, 2.459821, 9.814162, 0.000000
07-29 10:41:46.107+0600 D/avoidrickshaw(28893): event-values: 0.148355, 2.461616, 9.499505, 0.000000
07-29 10:41:46.167+0600 D/avoidrickshaw(28893): event-values: -0.037687, 2.553740, 9.049655, 0.000000
07-29 10:41:46.227+0600 D/avoidrickshaw(28893): event-values: -0.183051, 2.468795, 9.643075, 0.000000
07-29 10:41:46.288+0600 D/avoidrickshaw(28893): event-values: -0.369691, 1.631307, 10.716256, 0.000000
07-29 10:41:46.348+0600 D/avoidrickshaw(28893): event-values: -0.113659, 1.768894, 10.753943, 0.000000
07-29 10:41:46.408+0600 D/avoidrickshaw(28893): event-values: -0.617348, 1.928017, 9.584452, 0.000000
07-29 10:41:46.468+0600 D/avoidrickshaw(28893): event-values: -0.643669, 2.242075, 8.840283, 0.000000
07-29 10:41:46.528+0600 D/avoidrickshaw(28893): event-values: -0.645464, 2.334198, 8.838489, 0.000000
07-29 10:41:46.588+0600 D/avoidrickshaw(28893): event-values: -0.504287, 2.365305, 9.562318, 0.000000
07-29 10:41:46.648+0600 D/avoidrickshaw(28893): event-values: -0.886541, 2.154139, 10.076776, 0.000000
07-29 10:41:46.708+0600 D/avoidrickshaw(28893): event-values: -1.402194, 2.124228, 10.158132, 0.000000
07-29 10:41:46.768+0600 D/avoidrickshaw(28893): event-values: -1.457827, 2.171487, 9.927821, 0.000000
07-29 10:41:46.828+0600 D/avoidrickshaw(28893): event-values: -1.655833, 2.179263, 9.700503, 0.000000
07-29 10:41:46.888+0600 D/avoidrickshaw(28893): event-values: -1.467398, 2.103291, 9.743573, 0.000000
07-29 10:41:46.948+0600 D/avoidrickshaw(28893): event-values: -1.307678, 2.221138, 9.543175, 0.000000
07-29 10:41:47.008+0600 D/avoidrickshaw(28893): event-values: -1.115055, 2.231307, 9.655638, 0.000000
07-29 10:41:47.068+0600 D/avoidrickshaw(28893): event-values: -1.197010, 2.149951, 9.559924, 0.000000
07-29 10:41:47.128+0600 D/avoidrickshaw(28893): event-values: -1.538585, 1.919044, 9.862617, 0.000000
07-29 10:41:47.188+0600 D/avoidrickshaw(28893): event-values: -1.909473, 1.816751, 9.437891, 0.000000
07-29 10:41:47.248+0600 D/avoidrickshaw(28893): event-values: -1.114457, 1.610968, 8.498708, 0.000000
07-29 10:41:47.309+0600 D/avoidrickshaw(28893): event-values: -1.063610, 1.539183, 9.597013, 0.000000
07-29 10:41:47.369+0600 D/avoidrickshaw(28893): event-values: -1.016950, 1.582852, 10.735399, 0.000000
07-29 10:41:47.429+0600 D/avoidrickshaw(28893): event-values: -1.296910, 1.810769, 10.121639, 0.000000
07-29 10:41:47.489+0600 D/avoidrickshaw(28893): event-values: -1.530808, 2.041676, 9.302696, 0.000000
07-29 10:41:47.549+0600 D/avoidrickshaw(28893): event-values: -1.768894, 1.895714, 9.638887, 0.000000
07-29 10:41:47.609+0600 D/avoidrickshaw(28893): event-values: -1.594816, 1.410569, 10.177272, 0.000000
07-29 10:41:47.669+0600 D/avoidrickshaw(28893): event-values: -2.199602, 1.120439, 12.192628, 0.000000
07-29 10:41:47.729+0600 D/avoidrickshaw(28893): event-values: -1.855036, 0.594018, 10.104291, 0.000000
07-29 10:41:47.789+0600 D/avoidrickshaw(28893): event-values: -1.805385, 0.854836, 8.930015, 0.000000
07-29 10:41:47.849+0600 D/avoidrickshaw(28893): event-values: -1.672583, 1.083350, 9.756136, 0.000000
07-29 10:41:47.909+0600 D/avoidrickshaw(28893): event-values: -1.488934, 1.582254, 10.478768, 0.000000
07-29 10:41:47.969+0600 D/avoidrickshaw(28893): event-values: -1.507478, 2.017748, 10.393824, 0.000000
07-29 10:41:48.029+0600 D/avoidrickshaw(28893): event-values: -1.100100, 2.018944, 9.154939, 0.000000
07-29 10:41:48.089+0600 D/avoidrickshaw(28893): event-values: -1.052244, 1.570290, 9.796216, 0.000000
07-29 10:41:48.149+0600 D/avoidrickshaw(28893): event-values: -0.964308, 0.811167, 10.789237, 0.000000
07-29 10:41:48.209+0600 D/avoidrickshaw(28893): event-values: -0.983450, 0.512662, 10.171888, 0.000000
07-29 10:41:48.269+0600 D/avoidrickshaw(28893): event-values: -1.358525, 0.926621, 9.436096, 0.000000
07-29 10:41:48.330+0600 D/avoidrickshaw(28893): event-values: -1.409971, 1.406381, 8.627921, 0.000000
07-29 10:41:48.390+0600 D/avoidrickshaw(28893): event-values: -1.548754, 1.799403, 8.749954, 0.000000
07-29 10:41:48.450+0600 D/avoidrickshaw(28893): event-values: -1.275973, 1.892723, 9.862019, 0.000000
07-29 10:41:48.500+0600 I/Tizen::Net::Wifi( 1305): (1085) > _WifiService is not registered.
07-29 10:41:48.510+0600 D/avoidrickshaw(28893): event-values: -0.723231, 2.652444, 11.527423, 0.000000
07-29 10:41:48.570+0600 D/avoidrickshaw(28893): event-values: 0.028714, 2.620141, 11.490334, 0.000000
07-29 10:41:48.630+0600 D/avoidrickshaw(28893): event-values: -0.457627, 3.032902, 10.710274, 0.000000
07-29 10:41:48.690+0600 D/avoidrickshaw(28893): event-values: -0.862613, 2.485545, 9.443872, 0.000000
07-29 10:41:48.760+0600 D/avoidrickshaw(28893): event-values: -1.371686, 2.261816, 9.248857, 0.000000
07-29 10:41:48.820+0600 D/avoidrickshaw(28893): event-values: -1.144367, 1.725823, 8.958728, 0.000000
07-29 10:41:48.880+0600 D/avoidrickshaw(28893): event-values: -1.003191, 2.435893, 8.593225, 0.000000
07-29 10:41:48.940+0600 D/avoidrickshaw(28893): event-values: -0.786042, 2.749353, 9.324232, 0.000000
07-29 10:41:49.000+0600 D/avoidrickshaw(28893): event-values: -1.191626, 2.976671, 9.991829, 0.000000
07-29 10:41:49.060+0600 D/avoidrickshaw(28893): event-values: -0.820140, 2.676970, 9.625129, 0.000000
07-29 10:41:49.120+0600 D/avoidrickshaw(28893): event-values: -1.039083, 3.241676, 9.612567, 0.000000
07-29 10:41:49.180+0600 D/avoidrickshaw(28893): event-values: -0.644267, 2.742773, 9.705887, 0.000000
07-29 10:41:49.240+0600 D/avoidrickshaw(28893): event-values: -0.589233, 3.026322, 9.978669, 0.000000
07-29 10:41:49.300+0600 D/avoidrickshaw(28893): event-values: -1.322034, 3.005983, 10.118051, 0.000000
07-29 10:41:49.361+0600 D/avoidrickshaw(28893): event-values: -1.246661, 2.733202, 9.833902, 0.000000
07-29 10:41:49.421+0600 D/avoidrickshaw(28893): event-values: -1.448854, 2.929413, 9.322437, 0.000000
07-29 10:41:49.481+0600 D/avoidrickshaw(28893): event-values: -1.854438, 2.542374, 8.688338, 0.000000
07-29 10:41:49.511+0600 I/Tizen::Net::Wifi( 1305): (1085) > _WifiService is not registered.
07-29 10:41:49.541+0600 D/avoidrickshaw(28893): event-values: -1.197010, 2.624927, 9.943973, 0.000000
07-29 10:41:49.601+0600 D/avoidrickshaw(28893): event-values: -0.178265, 1.403390, 9.519246, 0.000000
07-29 10:41:49.661+0600 D/avoidrickshaw(28893): event-values: -0.448654, 1.161117, 10.147961, 0.000000
07-29 10:41:49.721+0600 D/avoidrickshaw(28893): event-values: -0.133998, 1.150349, 10.137791, 0.000000
07-29 10:41:49.781+0600 D/avoidrickshaw(28893): event-values: -0.195613, 1.473381, 9.823136, 0.000000
07-29 10:41:49.841+0600 D/avoidrickshaw(28893): event-values: 0.321835, 1.354936, 10.187442, 0.000000
07-29 10:41:49.901+0600 D/avoidrickshaw(28893): event-values: -0.031705, 1.365704, 10.024132, 0.000000
07-29 10:41:49.961+0600 D/avoidrickshaw(28893): event-values: 0.089731, 1.510469, 10.102496, 0.000000
07-29 10:41:50.021+0600 D/avoidrickshaw(28893): event-values: -0.300897, 1.545763, 10.103095, 0.000000
07-29 10:41:50.081+0600 D/avoidrickshaw(28893): event-values: -0.184247, 1.579263, 10.133603, 0.000000
07-29 10:41:50.141+0600 D/avoidrickshaw(28893): event-values: -0.058026, 1.424926, 10.180862, 0.000000
07-29 10:41:50.201+0600 D/avoidrickshaw(28893): event-values: -0.141177, 1.704886, 9.644272, 0.000000
07-29 10:41:50.261+0600 D/avoidrickshaw(28893): event-values: 0.128016, 1.803590, 9.448060, 0.000000
07-29 10:41:50.321+0600 D/avoidrickshaw(28893): event-values: 0.065204, 2.142773, 9.909277, 0.000000
07-29 10:41:50.382+0600 D/avoidrickshaw(28893): event-values: 0.087338, 2.190031, 9.679565, 0.000000
07-29 10:41:50.442+0600 D/avoidrickshaw(28893): event-values: -0.099900, 2.274378, 10.061221, 0.000000
07-29 10:41:50.502+0600 D/avoidrickshaw(28893): event-values: -0.439681, 2.747559, 9.271590, 0.000000
07-29 10:41:50.522+0600 I/Tizen::Net::Wifi( 1305): (1085) > _WifiService is not registered.
07-29 10:41:50.562+0600 D/avoidrickshaw(28893): event-values: -0.664607, 2.999403, 9.235697, 0.000000
07-29 10:41:50.622+0600 D/avoidrickshaw(28893): event-values: -1.085145, 3.293720, 8.959326, 0.000000
07-29 10:41:50.682+0600 D/avoidrickshaw(28893): event-values: -1.442872, 4.007978, 9.019745, 0.000000
07-29 10:41:50.742+0600 D/avoidrickshaw(28893): event-values: -2.183451, 4.431508, 9.152546, 0.000000
07-29 10:41:50.802+0600 D/avoidrickshaw(28893): event-values: -2.013560, 4.356732, 9.449257, 0.000000
07-29 10:41:50.862+0600 D/avoidrickshaw(28893): event-values: -1.741377, 3.999603, 8.806186, 0.000000
07-29 10:41:50.922+0600 D/avoidrickshaw(28893): event-values: -1.588834, 3.591627, 9.064013, 0.000000
07-29 10:41:50.982+0600 D/avoidrickshaw(28893): event-values: -1.497907, 3.415156, 9.148957, 0.000000
07-29 10:41:51.042+0600 D/avoidrickshaw(28893): event-values: -1.927419, 3.606582, 9.614960, 0.000000
07-29 10:41:51.102+0600 D/avoidrickshaw(28893): event-values: -1.649253, 3.617948, 9.422935, 0.000000
07-29 10:41:51.162+0600 D/avoidrickshaw(28893): event-values: -1.762912, 3.611966, 9.589834, 0.000000
07-29 10:41:51.222+0600 D/avoidrickshaw(28893): event-values: -1.432104, 3.346961, 9.347562, 0.000000
07-29 10:41:51.282+0600 D/avoidrickshaw(28893): event-values: -1.204786, 3.130410, 9.315857, 0.000000
07-29 10:41:51.342+0600 D/avoidrickshaw(28893): event-values: -1.325026, 3.154338, 9.594621, 0.000000
07-29 10:41:51.403+0600 D/avoidrickshaw(28893): event-values: -1.353141, 3.208775, 9.324232, 0.000000
07-29 10:41:51.463+0600 D/avoidrickshaw(28893): event-values: -1.339981, 3.104687, 9.373284, 0.000000
07-29 10:41:51.523+0600 D/avoidrickshaw(28893): event-values: -1.144367, 3.129214, 9.169296, 0.000000
07-29 10:41:51.583+0600 D/avoidrickshaw(28893): event-values: -1.203590, 3.111268, 9.399008, 0.000000
07-29 10:41:51.643+0600 D/avoidrickshaw(28893): event-values: -1.156332, 3.314658, 9.605987, 0.000000
07-29 10:41:51.703+0600 D/avoidrickshaw(28893): event-values: -1.035494, 3.309274, 9.640682, 0.000000
07-29 10:41:51.763+0600 D/avoidrickshaw(28893): event-values: -1.165305, 3.218945, 9.319447, 0.000000
07-29 10:41:51.823+0600 D/avoidrickshaw(28893): event-values: -1.174876, 3.201597, 9.413363, 0.000000
07-29 10:41:51.883+0600 D/avoidrickshaw(28893): event-values: -1.086342, 3.120241, 9.379865, 0.000000
07-29 10:41:51.943+0600 D/avoidrickshaw(28893): event-values: -1.025324, 3.302095, 9.194421, 0.000000
07-29 10:41:52.003+0600 D/avoidrickshaw(28893): event-values: -0.844068, 3.272783, 9.371490, 0.000000
07-29 10:41:52.063+0600 D/avoidrickshaw(28893): event-values: -0.949352, 3.197409, 9.778270, 0.000000
07-29 10:41:52.123+0600 D/avoidrickshaw(28893): event-values: -1.122234, 3.199204, 9.747761, 0.000000
07-29 10:41:52.183+0600 D/avoidrickshaw(28893): event-values: -1.179662, 3.125026, 9.398410, 0.000000
07-29 10:41:52.243+0600 D/avoidrickshaw(28893): event-values: -1.010968, 3.189034, 9.441480, 0.000000
07-29 10:41:52.303+0600 D/avoidrickshaw(28893): event-values: -1.025923, 3.296113, 9.485149, 0.000000
07-29 10:41:52.363+0600 D/avoidrickshaw(28893): event-values: -0.937388, 3.101098, 9.438489, 0.000000
07-29 10:41:52.424+0600 D/avoidrickshaw(28893): event-values: -1.099502, 2.758326, 9.653843, 0.000000
07-29 10:41:52.484+0600 D/avoidrickshaw(28893): event-values: -1.346561, 2.804388, 9.599406, 0.000000
07-29 10:41:52.544+0600 D/avoidrickshaw(28893): event-values: -1.551147, 2.718845, 9.765707, 0.000000
07-29 10:41:52.604+0600 D/avoidrickshaw(28893): event-values: -1.083949, 2.822933, 9.351151, 0.000000
07-29 10:41:52.664+0600 D/avoidrickshaw(28893): event-values: -0.780658, 2.856432, 9.433703, 0.000000
07-29 10:41:52.724+0600 D/avoidrickshaw(28893): event-values: -0.559920, 2.566302, 9.561121, 0.000000
07-29 10:41:52.784+0600 D/avoidrickshaw(28893): event-values: -0.743570, 2.562115, 9.766305, 0.000000
07-29 10:41:52.844+0600 D/avoidrickshaw(28893): event-values: -0.573081, 2.569891, 9.687342, 0.000000
07-29 10:41:52.904+0600 D/avoidrickshaw(28893): event-values: -0.667598, 2.667399, 9.608977, 0.000000
07-29 10:41:52.964+0600 D/avoidrickshaw(28893): event-values: -0.444467, 2.477768, 9.588638, 0.000000
07-29 10:41:53.024+0600 D/avoidrickshaw(28893): event-values: -0.578465, 2.559722, 9.731011, 0.000000
07-29 10:41:53.084+0600 D/avoidrickshaw(28893): event-values: -0.635294, 2.543570, 9.809376, 0.000000
07-29 10:41:53.144+0600 D/avoidrickshaw(28893): event-values: -0.626920, 2.615953, 9.835098, 0.000000
07-29 10:41:53.204+0600 D/avoidrickshaw(28893): event-values: -0.589831, 2.648257, 9.649057, 0.000000
07-29 10:41:53.264+0600 D/avoidrickshaw(28893): event-values: -0.520439, 2.622534, 9.729815, 0.000000
07-29 10:41:53.324+0600 D/avoidrickshaw(28893): event-values: -0.489930, 2.709872, 9.700503, 0.000000
07-29 10:41:53.384+0600 D/avoidrickshaw(28893): event-values: -0.485145, 2.670988, 9.801002, 0.000000
07-29 10:41:53.414+0600 I/Tizen::Net::Wifi( 1305): (941) > The background scan result updated.
07-29 10:41:53.445+0600 D/avoidrickshaw(28893): event-values: -0.480957, 2.694916, 9.774082, 0.000000
07-29 10:41:53.505+0600 D/avoidrickshaw(28893): event-values: -0.483350, 2.754737, 9.693923, 0.000000
07-29 10:41:53.575+0600 D/avoidrickshaw(28893): horizontal_acc: 31.000000, vertical_acc: -1.000000
07-29 10:41:53.575+0600 D/avoidrickshaw(28893): previous lat: 23.814995, previous long: 90.426570
07-29 10:41:53.575+0600 D/avoidrickshaw(28893): current lat: 23.814995, current long: 90.426570
07-29 10:41:53.585+0600 D/avoidrickshaw(28893): total distance: 0.000000 meters
07-29 10:41:53.585+0600 D/avoidrickshaw(28893): elapsed time; 0.104773
07-29 10:41:53.585+0600 D/avoidrickshaw(28893): event-values: -0.512662, 2.740380, 9.565309, 0.000000
07-29 10:41:53.625+0600 D/avoidrickshaw(28893): event-values: -0.299701, 2.796013, 9.270991, 0.000000
07-29 10:41:53.685+0600 D/avoidrickshaw(28893): event-values: -0.288933, 2.742175, 9.895518, 0.000000
07-29 10:41:53.745+0600 D/avoidrickshaw(28893): event-values: -0.563510, 2.848655, 10.457233, 0.000000
07-29 10:41:53.805+0600 D/avoidrickshaw(28893): event-values: -0.483948, 2.737987, 9.032307, 0.000000
07-29 10:41:53.865+0600 D/avoidrickshaw(28893): event-values: -0.362513, 2.873182, 9.230313, 0.000000
07-29 10:41:53.925+0600 D/avoidrickshaw(28893): event-values: -0.667598, 2.768496, 10.226924, 0.000000
07-29 10:41:53.985+0600 D/avoidrickshaw(28893): event-values: -0.760319, 3.104687, 9.540783, 0.000000
07-29 10:41:54.045+0600 D/avoidrickshaw(28893): event-values: -0.613161, 3.011966, 9.358928, 0.000000
07-29 10:41:54.105+0600 D/avoidrickshaw(28893): event-values: -0.658026, 2.909074, 9.791430, 0.000000
07-29 10:41:54.165+0600 D/avoidrickshaw(28893): event-values: -0.594616, 2.956931, 9.630512, 0.000000
07-29 10:41:54.225+0600 D/avoidrickshaw(28893): event-values: -0.588036, 2.996412, 9.474979, 0.000000
07-29 10:41:54.285+0600 D/avoidrickshaw(28893): event-values: -0.508475, 2.764308, 9.553344, 0.000000
07-29 10:41:54.345+0600 D/avoidrickshaw(28893): event-values: -0.589831, 2.818147, 9.633504, 0.000000
07-29 10:41:54.405+0600 D/avoidrickshaw(28893): event-values: -0.527019, 2.712265, 9.527621, 0.000000
07-29 10:41:54.465+0600 D/avoidrickshaw(28893): event-values: -0.614955, 2.809772, 9.583853, 0.000000
07-29 10:41:54.526+0600 D/avoidrickshaw(28893): event-values: -0.614955, 2.858825, 9.801600, 0.000000
07-29 10:41:54.586+0600 D/avoidrickshaw(28893): event-values: -0.627518, 2.919842, 9.716056, 0.000000
07-29 10:41:54.646+0600 D/avoidrickshaw(28893): event-values: -0.559920, 2.863611, 9.585647, 0.000000
07-29 10:41:54.706+0600 D/avoidrickshaw(28893): event-values: -0.491127, 2.744568, 9.719048, 0.000000
07-29 10:41:54.766+0600 D/avoidrickshaw(28893): event-values: -0.486341, 2.721836, 9.787243, 0.000000
07-29 10:41:54.826+0600 D/avoidrickshaw(28893): event-values: -0.561715, 2.810968, 9.741779, 0.000000
07-29 10:41:54.886+0600 D/avoidrickshaw(28893): event-values: -0.638884, 2.845066, 9.603594, 0.000000
07-29 10:41:54.946+0600 D/avoidrickshaw(28893): event-values: -0.582054, 2.830111, 9.615558, 0.000000
07-29 10:41:55.006+0600 D/avoidrickshaw(28893): event-values: -0.588634, 2.739782, 9.621540, 0.000000
07-29 10:41:55.066+0600 D/avoidrickshaw(28893): event-values: -0.590429, 2.849253, 9.623933, 0.000000
07-29 10:41:55.126+0600 D/avoidrickshaw(28893): event-values: -0.614955, 2.882155, 9.622737, 0.000000
07-29 10:41:55.186+0600 D/avoidrickshaw(28893): event-values: -0.533599, 2.894119, 9.643075, 0.000000
07-29 10:41:55.246+0600 D/avoidrickshaw(28893): event-values: -0.588036, 2.924029, 9.691529, 0.000000
07-29 10:41:55.306+0600 D/avoidrickshaw(28893): event-values: -0.665803, 2.877967, 9.610174, 0.000000
07-29 10:41:55.366+0600 D/avoidrickshaw(28893): event-values: -0.641276, 2.845664, 9.466006, 0.000000
07-29 10:41:55.426+0600 D/avoidrickshaw(28893): event-values: -0.613759, 2.801995, 9.768698, 0.000000
07-29 10:41:55.486+0600 D/avoidrickshaw(28893): event-values: -0.691526, 2.914458, 9.586843, 0.000000
07-29 10:41:55.547+0600 D/avoidrickshaw(28893): event-values: -0.674776, 2.851646, 9.568897, 0.000000
07-29 10:41:55.607+0600 D/avoidrickshaw(28893): event-values: -0.626321, 2.758924, 9.534202, 0.000000
07-29 10:41:55.667+0600 D/avoidrickshaw(28893): event-values: -0.620339, 2.791826, 9.690333, 0.000000
07-29 10:41:55.727+0600 D/avoidrickshaw(28893): event-values: -0.611366, 2.850450, 9.614960, 0.000000
07-29 10:41:55.787+0600 D/avoidrickshaw(28
