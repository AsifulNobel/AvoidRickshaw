S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPD6
Build-Date: 2016.04.28 20:23:28

Crash Information
Process Name: avoidrickshaw
PID: 2138
Date: 2016-07-29 22:35:12+0600
Executable File Path: /opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 2138, uid 5000)

Register Information
r0   = 0xb64ea180, r1   = 0xb2a34061
r2   = 0x00000032, r3   = 0xb64ea17f
r4   = 0xb2a3405a, r5   = 0x00000008
r6   = 0xbe830dd0, r7   = 0x00000008
r8   = 0x00000008, r9   = 0x00000008
r10  = 0xb67ec000, fp   = 0xbe830dc4
ip   = 0xb2a34064, sp   = 0xbe830878
lr   = 0xb66f41e8, pc   = 0xb6721b58
cpsr = 0x800d0010

Memory Information
MemTotal:   730440 KB
MemFree:     21308 KB
Buffers:     35900 KB
Cached:     231016 KB
VmPeak:     119940 KB
VmSize:     119936 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       25268 KB
VmRSS:       25268 KB
VmData:      44328 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36280 KB
VmPTE:          88 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 2138 TID = 2138
2138 2147 3469 3477 3518 

Maps Information
b0513000 b0d12000 rw-p [stack:3518]
b1301000 b1b00000 rw-p [stack:3477]
b1c83000 b1c8b000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.49
b1c9b000 b1c9d000 r-xp /usr/lib/liblbs-agps.so.0.1.0
b1cad000 b1cbb000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
b1cd2000 b1cd4000 r-xp /usr/lib/location/module/libwps.so.0.6.8_9
b1ce4000 b1ce7000 r-xp /usr/lib/location/module/libgps.so.0.6.8_9
b1cf8000 b24f7000 rw-p [stack:3469]
b2573000 b257b000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b258c000 b258d000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b259d000 b25b1000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b25c5000 b25c6000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b25d6000 b25d9000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b25ea000 b25eb000 r-xp /usr/lib/libxshmfence.so.1.0.0
b25fb000 b25fd000 r-xp /usr/lib/libxcb-present.so.0.0.0
b260d000 b260f000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b261f000 b262f000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b263f000 b264b000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b289b000 b289d000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b28ad000 b28b3000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b28c3000 b28d7000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b28e7000 b2901000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b2911000 b2917000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
b2927000 b292e000 r-xp /usr/lib/libeventsystem.so.0.0.1
b293e000 b2961000 r-xp /usr/lib/libSLP-location-product.so.0.9.0
b2972000 b2989000 r-xp /usr/lib/libSLP-location.so.0.11.5_5
b2999000 b29a0000 r-xp /usr/lib/libefl-extension.so.0.1.0
b29b1000 b29b9000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b29c9000 b29cd000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
b29de000 b29ed000 r-xp /usr/lib/libcapi-location-manager.so.0.6.1_3
b29fd000 b2a04000 r-xp /usr/lib/libcapi-appfw-preference.so.0.3.1.0
b2a16000 b2a1c000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2a2c000 b2a35000 r-xp /opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw
b2b57000 b2c3a000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2c71000 b2c99000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2cab000 b34aa000 rw-p [stack:2147]
b34aa000 b34ac000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b34bc000 b34c6000 r-xp /lib/libnss_files-2.20-2014.11.so
b34d7000 b34e0000 r-xp /lib/libnss_nis-2.20-2014.11.so
b34f1000 b3502000 r-xp /lib/libnsl-2.20-2014.11.so
b3515000 b351b000 r-xp /lib/libnss_compat-2.20-2014.11.so
b352c000 b352d000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3555000 b355c000 r-xp /usr/lib/libminizip.so.1.0.0
b356c000 b3571000 r-xp /usr/lib/libstorage.so.0.1
b3581000 b35d6000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b35ec000 b3600000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b3610000 b3654000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3664000 b366c000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b367c000 b36ac000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b36bf000 b3778000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b378c000 b37e0000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b37f1000 b380c000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b381c000 b38dd000 r-xp /usr/lib/libprotobuf.so.9.0.1
b38f0000 b3902000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3912000 b3916000 r-xp /usr/lib/libogg.so.0.7.1
b3926000 b3948000 r-xp /usr/lib/libvorbis.so.0.4.3
b3958000 b3a3c000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b3a58000 b3a65000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3a76000 b3ab9000 r-xp /usr/lib/libsndfile.so.1.0.25
b3ace000 b3b15000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3b26000 b3b2c000 r-xp /usr/lib/libjson-c.so.2.0.1
b3b3d000 b3b44000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3b54000 b3b94000 r-xp /usr/lib/libmdm.so.1.2.10
b3ba4000 b3bac000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3bbb000 b3bcb000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3bec000 b3c4c000 r-xp /usr/lib/libasound.so.2.0.0
b3c5e000 b3c94000 r-xp /usr/lib/libpulse.so.0.16.2
b3ca5000 b3ca8000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3cb8000 b3cbb000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3ccb000 b3cd0000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3ce0000 b3ce1000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3cf1000 b3cfc000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3d10000 b3d17000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3d27000 b3d2d000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3d3d000 b3d42000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3d52000 b3d6d000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3d7d000 b3d84000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3d94000 b3d97000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3da8000 b3dd6000 r-xp /usr/lib/libidn.so.11.5.44
b3de6000 b3dfc000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3e0d000 b3e17000 r-xp /usr/lib/libcares.so.2.1.0
b3e27000 b3e31000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3e41000 b3e43000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3e53000 b3e54000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3e64000 b3e68000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3e79000 b3ea1000 r-xp /usr/lib/libui-extension.so.0.1.0
b3eb2000 b3edb000 r-xp /usr/lib/libturbojpeg.so
b3efb000 b3f01000 r-xp /usr/lib/libgif.so.4.1.6
b3f11000 b3f57000 r-xp /usr/lib/libcurl.so.4.3.0
b3f68000 b3f89000 r-xp /usr/lib/libexif.so.12.3.3
b3fa4000 b3fb9000 r-xp /usr/lib/libtts.so
b3fca000 b3fd2000 r-xp /usr/lib/libfeedback.so.0.1.4
b3fe2000 b40a2000 r-xp /usr/lib/libdali-core.so.0.0.0
b40ad000 b41a0000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b41c0000 b429a000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b42b1000 b42b3000 r-xp /usr/lib/libboost_system.so.1.51.0
b42c3000 b42c9000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b42d9000 b42fc000 r-xp /usr/lib/libboost_thread.so.1.51.0
b430d000 b430f000 r-xp /usr/lib/libappsvc.so.0.1.0
b431f000 b4321000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4332000 b4337000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b434e000 b4350000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b4360000 b4367000 r-xp /usr/lib/libsensord-share.so
b4377000 b438f000 r-xp /usr/lib/libsensor.so.1.1.0
b43a0000 b43a3000 r-xp /usr/lib/libXv.so.1.0.0
b43b3000 b43b8000 r-xp /usr/lib/libutilX.so.1.1.0
b43c8000 b43cd000 r-xp /usr/lib/libappcore-common.so.1.1
b43dd000 b43e4000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b43f7000 b43fb000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b440c000 b44d6000 r-xp /usr/lib/libCOREGL.so.4.0
b44ed000 b44f0000 r-xp /usr/lib/libuuid.so.1.3.0
b4501000 b4518000 r-xp /usr/lib/libblkid.so.1.1.0
b4529000 b452b000 r-xp /usr/lib/libXau.so.6.0.0
b453b000 b453e000 r-xp /usr/lib/libEGL.so.1.4
b4546000 b454c000 r-xp /usr/lib/libxcb-render.so.0.0.0
b455c000 b455e000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b456f000 b457d000 r-xp /usr/lib/libGLESv2.so.2.0
b4586000 b45e8000 r-xp /usr/lib/libpixman-1.so.0.28.2
b45fd000 b4615000 r-xp /usr/lib/libmount.so.1.1.0
b4626000 b463a000 r-xp /usr/lib/libxcb.so.1.1.0
b464b000 b4652000 r-xp /lib/libcrypt-2.20-2014.11.so
b468a000 b469b000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b46ac000 b46ae000 r-xp /usr/lib/libiri.so
b46be000 b46c9000 r-xp /usr/lib/libgpg-error.so.0.15.0
b46da000 b46ef000 r-xp /lib/libexpat.so.1.5.2
b4701000 b47bf000 r-xp /usr/lib/libcairo.so.2.11200.14
b47d2000 b47da000 r-xp /usr/lib/libdrm.so.2.4.0
b47ea000 b47ed000 r-xp /usr/lib/libdri2.so.0.0.0
b47fe000 b484c000 r-xp /usr/lib/libssl.so.1.0.0
b4861000 b486d000 r-xp /usr/lib/libeeze.so.1.13.0
b487d000 b4886000 r-xp /usr/lib/libethumb.so.1.13.0
b4896000 b4899000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b48a9000 b4a60000 r-xp /usr/lib/libcrypto.so.1.0.0
b56b7000 b56c0000 r-xp /usr/lib/libXi.so.6.1.0
b56d0000 b56d2000 r-xp /usr/lib/libXgesture.so.7.0.0
b56e2000 b56e6000 r-xp /usr/lib/libXtst.so.6.1.0
b56f6000 b56fc000 r-xp /usr/lib/libXrender.so.1.3.0
b570c000 b5712000 r-xp /usr/lib/libXrandr.so.2.2.0
b5723000 b5725000 r-xp /usr/lib/libXinerama.so.1.0.0
b5735000 b5738000 r-xp /usr/lib/libXfixes.so.3.1.0
b5748000 b5753000 r-xp /usr/lib/libXext.so.6.4.0
b5763000 b5765000 r-xp /usr/lib/libXdamage.so.1.1.0
b5775000 b5777000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5788000 b586a000 r-xp /usr/lib/libX11.so.6.3.0
b587d000 b5884000 r-xp /usr/lib/libXcursor.so.1.0.2
b5894000 b58ac000 r-xp /usr/lib/libudev.so.1.6.0
b58ae000 b58b1000 r-xp /lib/libattr.so.1.1.0
b58c1000 b58e1000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58e3000 b58e8000 r-xp /usr/lib/libffi.so.6.0.2
b58f8000 b5910000 r-xp /lib/libz.so.1.2.8
b5920000 b5922000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5932000 b5a07000 r-xp /usr/lib/libxml2.so.2.9.2
b5a1c000 b5ab7000 r-xp /usr/lib/libstdc++.so.6.0.20
b5ad3000 b5ad6000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5ae6000 b5aff000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b10000 b5b21000 r-xp /lib/libresolv-2.20-2014.11.so
b5b35000 b5baf000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5bc4000 b5bc6000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bd6000 b5bdd000 r-xp /usr/lib/libembryo.so.1.13.0
b5bed000 b5c05000 r-xp /usr/lib/libpng12.so.0.50.0
b5c16000 b5c39000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c5a000 b5c6e000 r-xp /usr/lib/libector.so.1.13.0
b5c7f000 b5c97000 r-xp /usr/lib/liblua-5.1.so
b5ca8000 b5cff000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d13000 b5d3b000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d4c000 b5d5f000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d70000 b5da7000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5db8000 b5dc6000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5dd6000 b5dde000 r-xp /usr/lib/libtbm.so.1.0.0
b5dee000 b5dfb000 r-xp /usr/lib/libeio.so.1.13.0
b5e0b000 b5e0d000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e1d000 b5e22000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e32000 b5e49000 r-xp /usr/lib/libefreet.so.1.13.0
b5e5b000 b5e7b000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e8b000 b5eab000 r-xp /usr/lib/libecore_con.so.1.13.0
b5ead000 b5eb3000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5ec3000 b5ed4000 r-xp /usr/lib/libemotion.so.1.13.0
b5ee5000 b5eec000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5efc000 b5f0b000 r-xp /usr/lib/libeo.so.1.13.0
b5f1c000 b5f2e000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f3f000 b5f44000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f54000 b5f6d000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f7d000 b5f9a000 r-xp /usr/lib/libeet.so.1.13.0
b5fb3000 b5ffb000 r-xp /usr/lib/libeina.so.1.13.0
b600c000 b601c000 r-xp /usr/lib/libefl.so.1.13.0
b602d000 b6112000 r-xp /usr/lib/libicuuc.so.51.1
b612f000 b626f000 r-xp /usr/lib/libicui18n.so.51.1
b6286000 b62be000 r-xp /usr/lib/libecore_x.so.1.13.0
b62d0000 b62d3000 r-xp /lib/libcap.so.2.21
b62e3000 b630c000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b631d000 b6324000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6336000 b636d000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b637e000 b6469000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b647c000 b64f5000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6507000 b650c000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b651c000 b6526000 r-xp /usr/lib/libvconf.so.0.2.45
b6536000 b6538000 r-xp /usr/lib/libvasum.so.0.3.1
b6548000 b654a000 r-xp /usr/lib/libttrace.so.1.1
b655a000 b655d000 r-xp /usr/lib/libiniparser.so.0
b656d000 b6593000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65a3000 b65a8000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65b9000 b65d0000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65e1000 b664c000 r-xp /lib/libm-2.20-2014.11.so
b665d000 b6663000 r-xp /lib/librt-2.20-2014.11.so
b6674000 b6681000 r-xp /usr/lib/libunwind.so.8.0.1
b66b7000 b67db000 r-xp /lib/libc-2.20-2014.11.so
b67f0000 b6809000 r-xp /lib/libgcc_s-4.9.so.1
b6819000 b68fb000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b690c000 b6936000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6947000 b6983000 r-xp /usr/lib/libsystemd.so.0.4.0
b6985000 b6a07000 r-xp /usr/lib/libedje.so.1.13.0
b6a1a000 b6a38000 r-xp /usr/lib/libecore.so.1.13.0
b6a58000 b6bdf000 r-xp /usr/lib/libevas.so.1.13.0
b6c14000 b6c28000 r-xp /lib/libpthread-2.20-2014.11.so
b6c3c000 b6e71000 r-xp /usr/lib/libelementary.so.1.13.0
b6e9f000 b6ea3000 r-xp /usr/lib/libsmack.so.1.0.0
b6eb3000 b6eba000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6eca000 b6ecc000 r-xp /usr/lib/libdlog.so.0.0.0
b6edc000 b6edf000 r-xp /usr/lib/libbundle.so.0.1.22
b6eef000 b6ef1000 r-xp /lib/libdl-2.20-2014.11.so
b6f02000 b6f1a000 r-xp /usr/lib/libaul.so.0.1.0
b6f2e000 b6f33000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f44000 b6f51000 r-xp /usr/lib/liblptcp.so
b6f63000 b6f67000 r-xp /usr/lib/libsys-assert.so
b6f78000 b6f98000 r-xp /lib/ld-2.20-2014.11.so
b6fa9000 b6fae000 r-xp /usr/bin/launchpad-loader
b8acf000 b8e2f000 rw-p [heap]
be811000 be832000 rw-p [stack]
b8acf000 b8e2f000 rw-p [heap]
be811000 be832000 rw-p [stack]
End of Maps Information

Callstack Information (PID:2138)
Call Stack Count: 4
 0: _IO_default_xsputn + 0x58 (0xb6721b58) [/lib/libc.so.6] + 0x6ab58
 1: _IO_vfprintf + 0xb8 (0xb66f41e8) [/lib/libc.so.6] + 0x3d1e8
 2: vsprintf + 0x68 (0xb6716d04) [/lib/libc.so.6] + 0x5fd04
 3: (0xb64ea180) [/usr/lib/libsqlite3.so.0] + 0x6e180
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
07-29 10:41:55.787+0600 D/avoidrickshaw(28893): event-values: -0.632303, 2.803192, 9.544970, 0.000000
07-29 10:41:55.847+0600 D/avoidrickshaw(28893): event-values: -0.619143, 2.746960, 9.772885, 0.000000
07-29 10:41:55.907+0600 D/avoidrickshaw(28893): event-values: -0.614955, 2.789433, 9.631709, 0.000000
07-29 10:41:55.967+0600 D/avoidrickshaw(28893): event-values: -0.583251, 2.824129, 9.491730, 0.000000
07-29 10:41:56.017+0600 D/avoidrickshaw(28893): event-values: -0.586242, 2.872583, 9.870394, 0.000000
07-29 10:41:56.077+0600 D/avoidrickshaw(28893): event-values: -0.509671, 2.911467, 9.719646, 0.000000
07-29 10:41:56.137+0600 D/avoidrickshaw(28893): event-values: -0.523430, 2.887539, 9.671191, 0.000000
07-29 10:41:56.197+0600 D/avoidrickshaw(28893): event-values: -0.410369, 2.810370, 9.507282, 0.000000
07-29 10:41:56.257+0600 D/avoidrickshaw(28893): event-values: -0.483350, 2.828316, 9.667602, 0.000000
07-29 10:41:56.317+0600 D/avoidrickshaw(28893): event-values: -0.513260, 2.855834, 9.524033, 0.000000
07-29 10:41:56.377+0600 D/avoidrickshaw(28893): event-values: -0.559920, 3.061616, 9.667004, 0.000000
07-29 10:41:56.437+0600 D/avoidrickshaw(28893): event-values: -0.520439, 2.992225, 9.518648, 0.000000
07-29 10:41:56.497+0600 D/avoidrickshaw(28893): event-values: -0.588634, 3.039483, 9.795020, 0.000000
07-29 10:41:56.558+0600 D/avoidrickshaw(28893): event-values: -0.464806, 3.000001, 9.568897, 0.000000
07-29 10:41:56.618+0600 D/avoidrickshaw(28893): event-values: -0.420539, 3.053242, 9.780663, 0.000000
07-29 10:41:56.678+0600 D/avoidrickshaw(28893): event-values: -0.426521, 3.005385, 9.661021, 0.000000
07-29 10:41:56.738+0600 D/avoidrickshaw(28893): event-values: -0.519243, 2.976671, 9.479765, 0.000000
07-29 10:41:56.798+0600 D/avoidrickshaw(28893): event-values: -0.594616, 2.980261, 9.577871, 0.000000
07-29 10:41:56.858+0600 D/avoidrickshaw(28893): event-values: -0.613161, 3.112464, 9.611969, 0.000000
07-29 10:41:56.918+0600 D/avoidrickshaw(28893): event-values: -0.538983, 3.040679, 9.611969, 0.000000
07-29 10:41:56.978+0600 D/avoidrickshaw(28893): event-values: -0.474377, 2.985046, 9.498309, 0.000000
07-29 10:41:57.038+0600 D/avoidrickshaw(28893): event-values: -0.416949, 2.959922, 9.524631, 0.000000
07-29 10:41:57.098+0600 D/avoidrickshaw(28893): event-values: -0.474975, 2.940779, 9.552746, 0.000000
07-29 10:41:57.158+0600 D/avoidrickshaw(28893): event-values: -0.570090, 3.081357, 9.708879, 0.000000
07-29 10:41:57.218+0600 D/avoidrickshaw(28893): event-values: -0.528216, 3.117848, 9.642477, 0.000000
07-29 10:41:57.278+0600 D/avoidrickshaw(28893): event-values: -0.535992, 2.992225, 9.645468, 0.000000
07-29 10:41:57.338+0600 D/avoidrickshaw(28893): event-values: -0.461815, 2.938386, 9.323634, 0.000000
07-29 10:41:57.398+0600 D/avoidrickshaw(28893): event-values: -0.494118, 2.874378, 9.672387, 0.000000
07-29 10:41:57.458+0600 D/avoidrickshaw(28893): event-values: -0.693320, 3.133401, 9.902697, 0.000000
07-29 10:41:57.518+0600 D/avoidrickshaw(28893): event-values: -0.800399, 3.165106, 9.587442, 0.000000
07-29 10:41:57.579+0600 D/avoidrickshaw(28893): event-values: -0.649651, 3.067000, 9.208777, 0.000000
07-29 10:41:57.639+0600 D/avoidrickshaw(28893): event-values: -0.594018, 3.020340, 9.416355, 0.000000
07-29 10:41:57.699+0600 D/avoidrickshaw(28893): event-values: -0.713061, 3.186641, 9.776475, 0.000000
07-29 10:41:57.759+0600 D/avoidrickshaw(28893): event-values: -0.751945, 3.168695, 9.690931, 0.000000
07-29 10:41:57.819+0600 D/avoidrickshaw(28893): event-values: -0.687338, 3.166303, 9.128020, 0.000000
07-29 10:41:57.879+0600 D/avoidrickshaw(28893): event-values: -0.682553, 3.142375, 9.738789, 0.000000
07-29 10:41:57.939+0600 D/avoidrickshaw(28893): event-values: -0.817149, 3.283551, 9.686744, 0.000000
07-29 10:41:57.999+0600 D/avoidrickshaw(28893): event-values: -0.827318, 3.317649, 9.344570, 0.000000
07-29 10:41:58.059+0600 D/avoidrickshaw(28893): event-values: -0.695713, 3.072384, 9.205787, 0.000000
07-29 10:41:58.119+0600 D/avoidrickshaw(28893): event-values: -0.728615, 3.096312, 9.622138, 0.000000
07-29 10:41:58.179+0600 D/avoidrickshaw(28893): event-values: -0.782453, 3.167499, 9.484551, 0.000000
07-29 10:41:58.239+0600 D/avoidrickshaw(28893): event-values: -0.876970, 3.267399, 9.492926, 0.000000
07-29 10:41:58.299+0600 D/avoidrickshaw(28893): event-values: -0.853041, 3.168695, 9.451052, 0.000000
07-29 10:41:58.359+0600 D/avoidrickshaw(28893): event-values: -0.738784, 3.039483, 9.029316, 0.000000
07-29 10:41:58.419+0600 D/avoidrickshaw(28893): event-values: -0.528216, 3.092125, 9.559326, 0.000000
07-29 10:41:58.479+0600 D/avoidrickshaw(28893): event-values: -0.759123, 3.338586, 10.633105, 0.000000
07-29 10:41:58.539+0600 D/avoidrickshaw(28893): event-values: -0.865005, 3.235694, 9.572487, 0.000000
07-29 10:41:58.600+0600 D/avoidrickshaw(28893): event-values: -0.577268, 3.046063, 8.260622, 0.000000
07-29 10:41:58.660+0600 D/avoidrickshaw(28893): event-values: -0.637687, 2.709872, 9.648459, 0.000000
07-29 10:41:58.730+0600 D/avoidrickshaw(28893): event-values: -0.899701, 3.043072, 10.181459, 0.000000
07-29 10:41:58.790+0600 D/avoidrickshaw(28893): event-values: -0.512662, 3.342175, 8.769694, 0.000000
07-29 10:41:58.850+0600 D/avoidrickshaw(28893): event-values: -0.498904, 3.095116, 10.008579, 0.000000
07-29 10:41:58.910+0600 D/avoidrickshaw(28893): event-values: -0.692722, 3.075375, 10.132407, 0.000000
07-29 10:41:58.970+0600 D/avoidrickshaw(28893): event-values: -0.537787, 3.119045, 9.172886, 0.000000
07-29 10:41:59.030+0600 D/avoidrickshaw(28893): event-values: -0.565903, 2.904887, 9.856036, 0.000000
07-29 10:41:59.090+0600 D/avoidrickshaw(28893): event-values: -0.732802, 3.090929, 10.009177, 0.000000
07-29 10:41:59.150+0600 D/avoidrickshaw(28893): event-values: -0.579661, 3.026921, 9.273982, 0.000000
07-29 10:41:59.210+0600 D/avoidrickshaw(28893): event-values: -0.672981, 3.057429, 9.509077, 0.000000
07-29 10:41:59.270+0600 D/avoidrickshaw(28893): event-values: -0.788435, 2.942574, 9.670593, 0.000000
07-29 10:41:59.330+0600 D/avoidrickshaw(28893): event-values: -0.780658, 3.084348, 9.451052, 0.000000
07-29 10:41:59.390+0600 D/avoidrickshaw(28893): event-values: -0.824327, 3.025724, 9.434900, 0.000000
07-29 10:41:59.450+0600 D/avoidrickshaw(28893): event-values: -0.769292, 2.979662, 9.270393, 0.000000
07-29 10:41:59.510+0600 D/avoidrickshaw(28893): event-values: -0.873380, 3.231507, 9.690931, 0.000000
07-29 10:41:59.520+0600 I/Tizen::Net::Wifi( 1305): (1085) > _WifiService is not registered.
07-29 10:41:59.570+0600 D/avoidrickshaw(28893): event-values: -0.877568, 3.223730, 9.755538, 0.000000
07-29 10:41:59.631+0600 D/avoidrickshaw(28893): event-values: -0.933201, 3.118446, 9.524631, 0.000000
07-29 10:41:59.691+0600 D/avoidrickshaw(28893): event-values: -0.524028, 3.065804, 8.767900, 0.000000
07-29 10:41:59.751+0600 D/avoidrickshaw(28893): event-values: -0.729213, 2.888137, 10.175477, 0.000000
07-29 10:41:59.811+0600 D/avoidrickshaw(28893): event-values: -0.983450, 3.227319, 9.775279, 0.000000
07-29 10:41:59.871+0600 D/avoidrickshaw(28893): event-values: -1.015753, 3.072982, 9.335597, 0.000000
07-29 10:41:59.931+0600 D/avoidrickshaw(28893): event-values: -1.012164, 2.966502, 9.226127, 0.000000
07-29 10:41:59.991+0600 D/avoidrickshaw(28893): event-values: -0.829711, 2.825325, 9.320642, 0.000000
07-29 10:42:00.051+0600 D/avoidrickshaw(28893): event-values: -1.019342, 3.012564, 10.048658, 0.000000
07-29 10:42:00.111+0600 D/avoidrickshaw(28893): event-values: -1.033699, 3.080759, 9.635897, 0.000000
07-29 10:42:00.171+0600 D/avoidrickshaw(28893): event-values: -0.949951, 2.981457, 9.218947, 0.000000
07-29 10:42:00.231+0600 D/avoidrickshaw(28893): event-values: -0.958325, 2.879164, 9.444471, 0.000000
07-29 10:42:00.291+0600 D/avoidrickshaw(28893): event-values: -1.063610, 2.855834, 9.661619, 0.000000
07-29 10:42:00.351+0600 D/avoidrickshaw(28893): event-values: -0.917647, 2.930609, 9.739387, 0.000000
07-29 10:42:00.411+0600 D/avoidrickshaw(28893): event-values: -0.949352, 3.008376, 9.536595, 0.000000
07-29 10:42:00.471+0600 D/avoidrickshaw(28893): event-values: -0.943370, 2.944967, 9.746565, 0.000000
07-29 10:42:00.531+0600 D/avoidrickshaw(28893): event-values: -1.073779, 2.964109, 9.496515, 0.000000
07-29 10:42:00.591+0600 D/avoidrickshaw(28893): event-values: -1.103689, 2.918646, 9.479765, 0.000000
07-29 10:42:00.652+0600 D/avoidrickshaw(28893): event-values: -1.090529, 2.919842, 9.592826, 0.000000
07-29 10:42:00.712+0600 D/avoidrickshaw(28893): event-values: -1.067797, 2.961118, 9.552148, 0.000000
07-29 10:42:00.772+0600 D/avoidrickshaw(28893): event-values: -0.980459, 2.961716, 9.637691, 0.000000
07-29 10:42:00.832+0600 D/avoidrickshaw(28893): event-values: -0.943370, 2.974278, 9.531211, 0.000000
07-29 10:42:00.892+0600 D/avoidrickshaw(28893): event-values: -1.057029, 2.962913, 9.533604, 0.000000
07-29 10:42:00.952+0600 D/avoidrickshaw(28893): event-values: -0.969691, 3.028117, 9.488738, 0.000000
07-29 10:42:01.012+0600 D/avoidrickshaw(28893): event-values: -0.905683, 2.897110, 9.649057, 0.000000
07-29 10:42:01.072+0600 D/avoidrickshaw(28893): event-values: -0.957129, 2.962314, 9.499505, 0.000000
07-29 10:42:01.132+0600 D/avoidrickshaw(28893): event-values: -1.022334, 3.050251, 9.501899, 0.000000
07-29 10:42:01.192+0600 D/avoidrickshaw(28893): event-values: -0.959522, 3.112464, 9.558130, 0.000000
07-29 10:42:01.252+0600 D/avoidrickshaw(28893): event-values: -0.869193, 3.049652, 9.658031, 0.000000
07-29 10:42:01.312+0600 D/avoidrickshaw(28893): event-values: -0.884746, 3.003591, 9.630512, 0.000000
07-29 10:42:01.372+0600 D/avoidrickshaw(28893): event-values: -0.905683, 3.058626, 9.498907, 0.000000
07-29 10:42:01.432+0600 D/avoidrickshaw(28893): event-values: -0.924826, 3.013162, 9.521640, 0.000000
07-29 10:42:01.492+0600 D/avoidrickshaw(28893): event-values: -0.942174, 2.968895, 9.490533, 0.000000
07-29 10:42:01.522+0600 I/Tizen::Net::Wifi( 1305): (1085) > _WifiService is not registered.
07-29 10:42:01.552+0600 D/avoidrickshaw(28893): event-values: -1.059422, 3.110071, 9.547362, 0.000000
07-29 10:42:01.612+0600 D/avoidrickshaw(28893): event-values: -1.043869, 3.164508, 9.620941, 0.000000
07-29 10:42:01.673+0600 D/avoidrickshaw(28893): event-values: -0.984646, 3.115455, 9.429516, 0.000000
07-29 10:42:01.733+0600 D/avoidrickshaw(28893): event-values: -0.949352, 3.083750, 9.661619, 0.000000
07-29 10:42:01.793+0600 D/avoidrickshaw(28893): event-values: -0.967299, 3.050849, 9.514461, 0.000000
07-29 10:42:01.853+0600 D/avoidrickshaw(28893): event-values: -1.020539, 3.077768, 9.492328, 0.000000
07-29 10:42:01.913+0600 D/avoidrickshaw(28893): event-values: -0.998405, 3.151945, 9.333204, 0.000000
07-29 10:42:01.973+0600 D/avoidrickshaw(28893): event-values: -1.015155, 3.163311, 9.717851, 0.000000
07-29 10:42:02.033+0600 D/avoidrickshaw(28893): event-values: -1.006780, 3.285345, 9.425328, 0.000000
07-29 10:42:02.093+0600 D/avoidrickshaw(28893): event-values: -1.197608, 3.208775, 9.125628, 0.000000
07-29 10:42:02.153+0600 D/avoidrickshaw(28893): event-values: -1.261616, 3.430111, 8.362915, 0.000000
07-29 10:42:02.213+0600 D/avoidrickshaw(28893): event-values: -0.942174, 2.928217, 10.082158, 0.000000
07-29 10:42:02.273+0600 D/avoidrickshaw(28893): event-values: -0.497707, 2.227718, 9.203992, 0.000000
07-29 10:42:02.333+0600 D/avoidrickshaw(28893): event-values: -0.524028, 2.333002, 8.709875, 0.000000
07-29 10:42:02.393+0600 D/avoidrickshaw(28893): event-values: -0.550349, 4.316652, 7.449455, 0.000000
07-29 10:42:02.453+0600 D/avoidrickshaw(28893): event-values: -1.413560, 5.227121, 7.203593, 0.000000
07-29 10:42:02.513+0600 D/avoidrickshaw(28893): event-values: 3.061616, 1.570888, 12.303895, 0.000000
07-29 10:42:02.523+0600 I/Tizen::Net::Wifi( 1305): (1085) > _WifiService is not registered.
07-29 10:42:02.573+0600 D/avoidrickshaw(28893): event-values: -1.923829, -0.162712, 16.857435, 0.000000
07-29 10:42:02.633+0600 D/avoidrickshaw(28893): event-values: 1.097109, 1.804786, 10.365707, 0.000000
07-29 10:42:02.694+0600 D/avoidrickshaw(28893): event-values: 3.038287, 1.446461, 8.974281, 0.000000
07-29 10:42:02.754+0600 D/avoidrickshaw(28893): event-values: 1.620539, 3.238685, 7.972287, 0.000000
07-29 10:42:02.814+0600 D/avoidrickshaw(28893): event-values: 0.290728, 2.380858, 10.062418, 0.000000
07-29 10:42:02.874+0600 D/avoidrickshaw(28893): event-values: 0.681356, 3.457629, 8.449655, 0.000000
07-29 10:42:02.934+0600 D/avoidrickshaw(28893): event-values: 0.499502, 4.591228, 10.538589, 0.000000
07-29 10:42:02.994+0600 D/avoidrickshaw(28893): event-values: 0.509671, 3.185445, 10.971091, 0.000000
07-29 10:42:03.054+0600 D/avoidrickshaw(28893): event-values: 1.476372, 2.148755, 9.239286, 0.000000
07-29 10:42:03.114+0600 D/avoidrickshaw(28893): event-values: 1.002593, 2.067997, 9.911669, 0.000000
07-29 10:42:03.174+0600 D/avoidrickshaw(28893): event-values: 2.095514, 0.713659, 9.847064, 0.000000
07-29 10:42:03.234+0600 D/avoidrickshaw(28893): event-values: 1.791028, 1.135993, 9.833304, 0.000000
07-29 10:42:03.294+0600 D/avoidrickshaw(28893): event-values: 2.153540, 1.038485, 9.887741, 0.000000
07-29 10:42:03.354+0600 D/avoidrickshaw(28893): event-values: 1.096511, 1.851447, 10.428518, 0.000000
07-29 10:42:03.414+0600 D/avoidrickshaw(28893): event-values: 0.025125, 1.771885, 10.745568, 0.000000
07-29 10:42:03.474+0600 D/avoidrickshaw(28893): event-values: 1.287937, 1.159921, 11.376078, 0.000000
07-29 10:42:03.524+0600 I/Tizen::Net::Wifi( 1305): (1085) > _WifiService is not registered.
07-29 10:42:03.534+0600 D/avoidrickshaw(28893): event-values: 1.631307, 1.967498, 9.381061, 0.000000
07-29 10:42:03.594+0600 D/avoidrickshaw(28893): event-values: 1.482952, 1.895115, 9.391231, 0.000000
07-29 10:42:03.654+0600 D/avoidrickshaw(28893): event-values: -0.065204, 2.904289, 8.732008, 0.000000
07-29 10:42:03.715+0600 D/avoidrickshaw(28893): event-values: 1.072583, 2.120041, 10.221540, 0.000000
07-29 10:42:03.775+0600 D/avoidrickshaw(28893): event-values: 0.709472, 2.764308, 8.907283, 0.000000
07-29 10:42:03.835+0600 D/avoidrickshaw(28893): event-values: -0.583251, 2.755335, 10.028918, 0.000000
07-29 10:42:03.895+0600 D/avoidrickshaw(28893): event-values: 0.781257, 2.632703, 9.044869, 0.000000
07-29 10:42:03.955+0600 D/avoidrickshaw(28893): event-values: 2.029712, 2.938386, 9.320642, 0.000000
07-29 10:42:04.015+0600 D/avoidrickshaw(28893): event-values: 1.542174, 2.940779, 9.575478, 0.000000
07-29 10:42:04.075+0600 D/avoidrickshaw(28893): event-values: 2.189433, 3.049054, 10.157533, 0.000000
07-29 10:42:04.135+0600 D/avoidrickshaw(28893): event-values: 1.827518, 2.323431, 9.297312, 0.000000
07-29 10:42:04.195+0600 D/avoidrickshaw(28893): event-values: 1.694118, 2.352743, 10.463813, 0.000000
07-29 10:42:04.255+0600 D/avoidrickshaw(28893): event-values: 0.131007, 2.654238, 9.483953, 0.000000
07-29 10:42:04.315+0600 D/avoidrickshaw(28893): event-values: -0.007777, 2.229512, 9.729217, 0.000000
07-29 10:42:04.375+0600 D/avoidrickshaw(28893): event-values: 0.743570, 2.916252, 9.334401, 0.000000
07-29 10:42:04.435+0600 D/avoidrickshaw(28893): event-values: 1.373480, 2.433501, 10.221540, 0.000000
07-29 10:42:04.495+0600 D/avoidrickshaw(28893): event-values: 1.125823, 2.717648, 9.708280, 0.000000
07-29 10:42:04.555+0600 D/avoidrickshaw(28893): event-values: 0.728615, 2.666203, 9.406784, 0.000000
07-29 10:42:04.615+0600 D/avoidrickshaw(28893): event-values: 0.294915, 2.654837, 9.732806, 0.000000
07-29 10:42:04.675+0600 D/avoidrickshaw(28893): event-values: 0.705883, 2.480160, 9.707682, 0.000000
07-29 10:42:04.736+0600 D/avoidrickshaw(28893): event-values: 0.575474, 2.570490, 10.194620, 0.000000
07-29 10:42:04.796+0600 D/avoidrickshaw(28893): event-values: 0.358325, 2.571088, 9.411570, 0.000000
07-29 10:42:04.856+0600 D/avoidrickshaw(28893): event-values: 0.665205, 2.642275, 9.680163, 0.000000
07-29 10:42:04.916+0600 D/avoidrickshaw(28893): event-values: 0.049053, 2.417349, 9.885946, 0.000000
07-29 10:42:04.976+0600 D/avoidrickshaw(28893): event-values: 0.493520, 2.593221, 9.525827, 0.000000
07-29 10:42:05.036+0600 D/avoidrickshaw(28893): event-values: 0.255434, 2.540580, 10.028319, 0.000000
07-29 10:42:05.096+0600 D/avoidrickshaw(28893): event-values: 0.340977, 2.503491, 10.138988, 0.000000
07-29 10:42:05.156+0600 D/avoidrickshaw(28893): event-values: 1.433899, 3.025126, 9.217153, 0.000000
07-29 10:42:05.216+0600 D/avoidrickshaw(28893): event-values: 1.167099, 2.280360, 9.814761, 0.000000
07-29 10:42:05.276+0600 D/avoidrickshaw(28893): event-values: 1.290330, 2.377269, 9.340384, 0.000000
07-29 10:42:05.336+0600 D/avoidrickshaw(28893): event-values: 2.095514, 2.370689, 10.271790, 0.000000
07-29 10:42:05.396+0600 D/avoidrickshaw(28893): event-values: 2.242075, 2.840879, 9.922437, 0.000000
07-29 10:42:05.456+0600 D/avoidrickshaw(28893): event-values: 3.173481, 2.328217, 9.177073, 0.000000
07-29 10:42:05.516+0600 D/avoidrickshaw(28893): event-values: 2.778665, 3.156133, 9.414560, 0.000000
07-29 10:42:05.576+0600 D/avoidrickshaw(28893): event-values: 2.880360, 3.004787, 9.287143, 0.000000
07-29 10:42:05.636+0600 D/avoidrickshaw(28893): event-values: 2.400599, 3.297310, 9.474380, 0.000000
07-29 10:42:05.696+0600 D/avoidrickshaw(28893): event-values: 1.973480, 3.257828, 9.266804, 0.000000
07-29 10:42:05.757+0600 D/avoidrickshaw(28893): event-values: 2.456232, 3.154937, 9.062218, 0.000000
07-29 10:42:05.817+0600 D/avoidrickshaw(28893): event-values: 2.221736, 3.492923, 8.526225, 0.000000
07-29 10:42:05.877+0600 D/avoidrickshaw(28893): event-values: 2.794817, 3.679563, 9.399008, 0.000000
07-29 10:42:05.937+0600 D/avoidrickshaw(28893): event-values: 2.367100, 4.031906, 8.838489, 0.000000
07-29 10:42:05.997+0600 D/avoidrickshaw(28893): event-values: 2.909074, 3.426522, 9.171689, 0.000000
07-29 10:42:06.057+0600 D/avoidrickshaw(28893): event-values: 3.055036, 3.740580, 8.712267, 0.000000
07-29 10:42:06.117+0600 D/avoidrickshaw(28893): event-values: 2.493919, 3.605385, 8.788837, 0.000000
07-29 10:42:06.177+0600 D/avoidrickshaw(28893): event-values: 2.642873, 3.596412, 9.211170, 0.000000
07-29 10:42:06.237+0600 D/avoidrickshaw(28893): event-values: 2.359323, 3.822534, 9.182457, 0.000000
07-29 10:42:06.297+0600 D/avoidrickshaw(28893): event-values: 2.467598, 3.535994, 9.005986, 0.000000
07-29 10:42:06.347+0600 D/avoidrickshaw(28893): event-values: 2.915056, 3.629912, 8.974879, 0.000000
07-29 10:42:06.407+0600 D/avoidrickshaw(28893): event-values: 2.465804, 3.688536, 8.831908, 0.000000
07-29 10:42:06.467+0600 D/avoidrickshaw(28893): event-values: 2.690729, 3.473182, 9.052647, 0.000000
07-29 10:42:06.527+0600 D/avoidrickshaw(28893): event-values: 2.688336, 3.872185, 9.201001, 0.000000
07-29 10:42:06.587+0600 D/avoidrickshaw(28893): event-values: 2.276771, 3.645465, 8.901299, 0.000000
07-29 10:42:06.647+0600 D/avoidrickshaw(28893): event-values: 3.050849, 3.329014, 8.888738, 0.000000
07-29 10:42:06.707+0600 D/avoidrickshaw(28893): event-values: 2.125425, 3.644867, 9.170492, 0.000000
07-29 10:42:06.768+0600 D/avoidrickshaw(28893): event-values: 2.697907, 3.591029, 9.258429, 0.000000
07-29 10:42:06.828+0600 D/avoidrickshaw(28893): event-values: 2.600998, 3.463611, 8.472386, 0.000000
07-29 10:42:06.888+0600 D/avoidrickshaw(28893): event-values: 2.333600, 3.240480, 8.992826, 0.000000
07-29 10:42:06.948+0600 D/avoidrickshaw(28893): event-values: 2.574079, 3.702893, 9.202198, 0.000000
07-29 10:42:07.008+0600 D/avoidrickshaw(28893): event-values: 3.077768, 3.456432, 8.621938, 0.000000
07-29 10:42:07.068+0600 D/avoidrickshaw(28893): event-values: 3.150749, 3.446263, 9.232706, 0.000000
07-29 10:42:07.128+0600 D/avoidrickshaw(28893): event-values: 3.040679, 3.474977, 8.957531, 0.000000
07-29 10:42:07.188+0600 D/avoidrickshaw(28893): event-values: 2.501098, 3.500700, 9.448060, 0.000000
07-29 10:42:07.248+0600 D/avoidrickshaw(28893): event-values: 2.568097, 3.593421, 8.301898, 0.000000
07-29 10:42:07.308+0600 D/avoidrickshaw(28893): event-values: 2.905485, 3.445665, 9.308679, 0.000000
07-29 10:42:07.368+0600 D/avoidrickshaw(28893): event-values: 2.754139, 3.508476, 8.592626, 0.000000
07-29 10:42:07.428+0600 D/avoidrickshaw(28893): event-values: 2.906083, 3.748357, 9.515657, 0.000000
07-29 10:42:07.488+0600 D/avoidrickshaw(28893): event-values: 2.638087, 3.375674, 9.041879, 0.000000
07-29 10:42:07.548+0600 D/avoidrickshaw(28893): event-values: 2.825923, 3.363710, 8.453244, 0.000000
07-29 10:42:07.608+0600 D/avoidrickshaw(28893): event-values: 2.939583, 3.663411, 9.428319, 0.000000
07-29 10:42:07.668+0600 D/avoidrickshaw(28893): event-values: 2.865405, 3.555136, 8.928818, 0.000000
07-29 10:42:07.728+0600 D/avoidrickshaw(28893): event-values: 2.327618, 3.187838, 8.577671, 0.000000
07-29 10:42:07.788+0600 D/avoidrickshaw(28893): event-values: 2.854039, 3.792026, 9.866804, 0.000000
07-29 10:42:07.849+0600 D/avoidrickshaw(28893): event-values: 2.825325, 3.547958, 9.002995, 0.000000
07-29 10:42:07.909+0600 D/avoidrickshaw(28893): event-values: 3.231507, 3.295515, 9.300901, 0.000000
07-29 10:42:07.969+0600 D/avoidrickshaw(28893): event-values: 2.881557, 3.432504, 8.675776, 0.000000
07-29 10:42:08.029+0600 D/avoidrickshaw(28893): event-values: 3.044867, 3.710670, 9.620941, 0.000000
07-29 10:42:08.089+0600 D/avoidrickshaw(28893): event-values: 2.372484, 3.382853, 8.750552, 0.000000
07-29 10:42:08.149+0600 D/avoidrickshaw(28893): event-values: 2.773880, 3.452843, 9.154939, 0.000000
07-29 10:42:08.209+0600 D/avoidrickshaw(28893): event-values: 2.617748, 3.658626, 8.601001, 0.000000
07-29 10:42:08.269+0600 D/avoidrickshaw(28893): event-values: 2.834298, 3.589832, 9.071191, 0.000000
07-29 10:42:08.329+0600 D/avoidrickshaw(28893): event-values: 2.692524, 3.390031, 8.982058, 0.000000
07-29 10:42:08.389+0600 D/avoidrickshaw(28893): event-values: 2.611168, 3.400201, 9.035896, 0.000000
07-29 10:42:08.389+0600 I/Tizen::Net::Wifi( 1305): (941) > The background scan result updated.
07-29 10:42:08.449+0600 D/avoidrickshaw(28893): event-values: 2.526222, 3.675974, 9.187840, 0.000000
07-29 10:42:08.539+0600 D/avoidrickshaw(28893): horizontal_acc: 31.000000, vertical_acc: -1.000000
07-29 10:42:08.539+0600 D/avoidrickshaw(28893): previous lat: 23.814995, previous long: 90.426570
07-29 10:42:08.539+0600 D/avoidrickshaw(28893): current lat: 23.814995, current long: 90.426570
07-29 10:42:08.539+0600 D/avoidrickshaw(28893): total distance: 0.000000 meters
07-29 10:42:08.539+0600 D/avoidrickshaw(28893): elapsed time; 0.108931
07-29 10:42:08.549+0600 D/avoidrickshaw(28893): event-values: 2.950948, 3.476771, 8.574680, 0.000000
07-29 10:42:08.569+0600 D/avoidrickshaw(28893): event-values: 2.661417, 3.139383, 9.034101, 0.000000
07-29 10:42:08.629+0600 D/avoidrickshaw(28893): event-values: 2.909074, 3.636492, 9.147163, 0.000000
07-29 10:42:08.689+0600 D/avoidrickshaw(28893): event-values: 2.496910, 3.845266, 9.205787, 0.000000
07-29 10:42:08.749+0600 D/avoidrickshaw(28893): event-values: 2.478366, 3.302095, 9.198010, 0.000000
07-29 10:42:08.809+0600 D/avoidrickshaw(28893): event-values: 2.563311, 3.320640, 8.478967, 0.000000
07-29 10:42:08.870+0600 D/avoidrickshaw(28893): event-values: 2.596811, 3.203391, 9.128020, 0.000000
07-29 10:42:08.930+0600 D/avoidrickshaw(28893): event-values: 2.693122, 3.478566, 9.158528, 0.000000
07-29 10:42:08.990+0600 D/avoidrickshaw(28893): event-values: 2.423331, 3.580859, 9.192627, 0.000000
07-29 10:42:09.050+0600 D/avoidrickshaw(28893): event-values: 2.527419, 3.664010, 9.187243, 0.000000
07-29 10:42:09.110+0600 D/avoidrickshaw(28893): event-values: 2.897708, 3.476771, 9.349357, 0.000000
07-29 10:42:09.170+0600 D/avoidrickshaw(28893): event-values: 2.598007, 3.388835, 9.070592, 0.000000
07-29 10:42:09.230+0600 D/avoidrickshaw(28893): event-values: 2.549552, 3.296711, 9.086744, 0.000000
07-29 10:42:09.290+0600 D/avoidrickshaw(28893): event-values: 2.516053, 3.388835, 9.106485, 0.000000
07-29 10:42:09.350+0600 D/avoidrickshaw(28893): event-values: 2.216352, 3.635894, 9.315857, 0.000000
07-29 10:42:09.410+0600 D/avoidrickshaw(28893): event-values: 2.467000, 3.457629, 9.108279, 0.000000
07-29 10:42:09.470+0600 D/avoidrickshaw(28893): event-values: 2.624927, 3.487539, 9.356535, 0.000000
07-29 10:42:09.530+0600 D/avoidrickshaw(28893): event-values: 2.170290, 3.400799, 8.825328, 0.000000
07-29 10:42:09.590+0600 D/avoidrickshaw(28893): event-values: 2.435893, 3.236293, 9.017352, 0.000000
07-29 10:42:09.650+0600 D/avoidrickshaw(28893): event-values: 2.422733, 3.724428, 9.261420, 0.000000
07-29 10:42:09.710+0600 D/avoidrickshaw(28893): event-values: 3.000001, 3.253641, 9.536595, 0.000000
07-29 10:42:09.770+0600 D/avoidrickshaw(28893): event-values: 3.037090, 3.269792, 8.795418, 0.000000
07-29 10:42:09.830+0600 D/avoidrickshaw(28893): event-values: 2.504687, 3.443870, 9.614960, 0.000000
07-29 10:42:09.891+0600 D/avoidrickshaw(28893): event-values: 1.729412, 3.312863, 8.686544, 0.000000
07-29 10:42:09.951+0600 D/avoidrickshaw(28893): event-values: 3.205784, 3.362514, 9.387043, 0.000000
07-29 10:42:10.011+0600 D/avoidrickshaw(28893): event-values: 2.675774, 3.451647, 9.092726, 0.000000
07-29 10:42:10.071+0600 D/avoidrickshaw(28893): event-values: 2.461018, 3.200400, 8.675776, 0.000000
07-29 10:42:10.131+0600 D/avoidrickshaw(28893): event-values: 2.313859, 3.142973, 9.120842, 0.000000
07-29 10:42:10.191+0600 D/avoidrickshaw(28893): event-values: 2.146960, 3.546761, 9.952348, 0.000000
07-29 10:42:10.251+0600 D/avoidrickshaw(28893): event-values: 2.863013, 3.389433, 9.315857, 0.000000
07-29 10:42:10.311+0600 D/avoidrickshaw(28893): event-values: 2.542972, 3.513860, 8.501699, 0.000000
07-29 10:42:10.371+0600 D/avoidrickshaw(28893): event-values: 2.910271, 3.286542, 9.157930, 0.000000
07-29 10:42:10.431+0600 D/avoidrickshaw(28893): event-values: 2.613560, 3.397808, 9.244670, 0.000000
07-29 10:42:10.491+0600 D/avoidrickshaw(28893): event-values: 2.995814, 3.314658, 9.374481, 0.000000
07-29 10:42:10.551+0600 D/avoidrickshaw(28893): event-values: 3.538386, 2.919842, 9.352347, 0.000000
07-29 10:42:10.611+0600 D/avoidrickshaw(28893): event-values: 3.575475, 2.892324, 8.787642, 0.000000
07-29 10:42:10.671+0600 D/avoidrickshaw(28893): event-values: 3.877569, 2.895913, 9.119047, 0.000000
07-29 10:42:10.731+0600 D/avoidrickshaw(28893): event-values: 3.154338, 3.318247, 9.305089, 0.000000
07-29 10:42:10.791+0600 D/avoidrickshaw(28893): event-values: 2.664408, 3.346961, 9.339187, 0.000000
07-29 10:42:10.851+0600 D/avoidrickshaw(28893): event-values: 2.516651, 3.466003, 8.338986, 0.000000
07-29 10:42:10.912+0600 D/avoidrickshaw(28893): event-values: 3.255435, 3.309274, 7.568498, 0.000000
07-29 10:42:10.972+0600 D/avoidrickshaw(28893): event-values: 3.563511, 2.863013, 8.467601, 0.000000
07-29 10:42:11.032+0600 D/avoidrickshaw(28893): event-values: 3.963113, 2.954537, 9.674182, 0.000000
07-29 10:42:11.092+0600 D/avoidrickshaw(28893): event-values: 3.710670, 2.755934, 8.880961, 0.000000
07-29 10:42:11.152+0600 D/avoidrickshaw(28893): event-values: 3.319443, 2.674577, 8.854042, 0.000000
07-29 10:42:11.212+0600 D/avoidrickshaw(28893): event-values: 3.156731, 2.925226, 9.049057, 0.000000
07-29 10:42:11.272+0600 D/avoidrickshaw(28893): event-values: 2.805584, 2.782853, 9.477970, 0.000000
07-29 10:42:11.332+0600 D/avoidrickshaw(28893): event-values: 2.508276, 2.155335, 9.500104, 0.000000
07-29 10:42:11.392+0600 D/avoidrickshaw(28893): event-values: 3.245864, 2.606981, 9.560523, 0.000000
07-29 10:42:11.452+0600 D/avoidrickshaw(28893): event-values: 2.979662, 2.446063, 9.670593, 0.000000
07-29 10:42:11.512+0600 D/avoidrickshaw(28893): event-values: 2.630310, 2.570490, 9.535996, 0.000000
07-29 10:42:11.572+0600 D/avoidrickshaw(28893): event-values: 2.551347, 2.498705, 9.547960, 0.000000
07-29 10:42:11.632+0600 D/avoidrickshaw(28893): event-values: 2.240878, 2.510669, 9.782457, 0.000000
07-29 10:42:11.692+0600 D/avoidrickshaw(28893): event-values: 2.756532, 2.370689, 9.303893, 0.000000
07-29 10:42:11.752+0600 D/avoidrickshaw(28893): event-values: 2.774478, 2.313261, 9.075378, 0.000000
07-29 10:42:11.812+0600 D/avoidrickshaw(28893): event-values: 3.029912, 2.204986, 9.351151, 0.000000
07-29 10:42:11.872+0600 D/avoidrickshaw(28893): event-values: 3.139982, 2.629712, 9.525827, 0.000000
07-29 10:42:11.933+0600 D/avoidrickshaw(28893): event-values: 3.348157, 2.989832, 9.398410, 0.000000
07-29 10:42:11.993+0600 D/avoidrickshaw(28893): event-values: 3.178267, 2.918646, 9.067601, 0.000000
07-29 10:42:12.053+0600 D/avoidrickshaw(28893): event-values: 3.303292, 2.492723, 8.927622, 0.000000
07-29 10:42:12.113+0600 D/avoidrickshaw(28893): event-values: 3.135794, 2.745166, 8.867203, 0.000000
07-29 10:42:12.173+0600 D/avoidrickshaw(28893): event-values: 3.156133, 2.828316, 9.032307, 0.000000
07-29 10:42:12.233+0600 D/avoidrickshaw(28893): event-values: 3.029912, 3.162115, 8.831908, 0.000000
07-29 10:42:12.293+0600 D/avoidrickshaw(28893): event-values: 2.797210, 3.499503, 9.282356, 0.000000
07-29 10:42:12.353+0600 D/avoidrickshaw(28893): event-values: 2.591427, 3.761517, 9.428319, 0.000000
07-29 10:42:12.413+0600 D/avoidrickshaw(28893): event-values: 2.943770, 3.287140, 8.739785, 0.000000
07-29 10:42:12.473+0600 D/avoidrickshaw(28893): event-values: 2.996412, 2.904887, 8.824730, 0.000000
07-29 10:42:12.533+0600 D/avoidrickshaw(28893): event-values: 2.012962, 3.464807, 8.888140, 0.000000
07-29 10:42:12.593+0600 D/avoidrickshaw(28893): event-values: 1.995016, 4.146761, 9.109475, 0.000000
07-29 10:42:12.653+0600 D/avoidrickshaw(28893): event-values: 2.335395, 3.420540, 9.300303, 0.000000
07-29 10:42:12.713+0600 D/avoidrickshaw(28893): event-values: 2.422733, 3.457629, 9.305687, 0.000000
07-29 10:42:12.773+0600 D/avoidrickshaw(28893): event-values: 1.911865, 3.835097, 8.902496, 0.000000
07-29 10:42:12.833+0600 D/avoidrickshaw(28893): event-values: 2.367698, 3.790829, 8.794221, 0.000000
07-29 10:42:12.893+0600 D/avoidrickshaw(28893): event-values: 2.108675, 3.732803, 8.834301, 0.000000
07-29 10:42:12.954+0600 D/avoidrickshaw(28893): event-values: 1.883750, 3.733402, 9.360125, 0.000000
07-29 10:42:13.014+0600 D/avoidrickshaw(28893): event-values: 1.639083, 3.884149, 8.880363, 0.000000
07-29 10:42:13.074+0600 D/avoidrickshaw(28893): event-values: 1.794617, 3.750750, 9.514461, 0.000000
07-29 10:42:13.134+0600 D/avoidrickshaw(28893): event-values: 1.869393, 3.668795, 9.233305, 0.000000
07-29 10:42:13.194+0600 D/avoidrickshaw(28893): event-values: 1.809572, 3.504887, 9.183653, 0.000000
07-29 10:42:13.254+0600 D/avoidrickshaw(28893): event-values: 1.631905, 3.644867, 9.212367, 0.000000
07-29 10:42:13.314+0600 D/avoidrickshaw(28893): event-values: 1.366900, 3.786642, 9.257233, 0.000000
07-29 10:42:13.374+0600 D/avoidrickshaw(28893): event-values: 1.607977, 3.723830, 9.226725, 0.000000
07-29 10:42:13.434+0600 D/avoidrickshaw(28893): event-values: 1.517648, 3.613760, 9.424730, 0.000000
07-29 10:42:13.494+0600 D/avoidrickshaw(28893): event-values: 1.415953, 3.693322, 9.153145, 0.000000
07-29 10:42:13.554+0600 D/avoidrickshaw(28893): event-values: 1.343570, 3.738187, 9.187840, 0.000000
07-29 10:42:13.614+0600 D/avoidrickshaw(28893): event-values: 1.417747, 3.706482, 9.156136, 0.000000
07-29 10:42:13.674+0600 D/avoidrickshaw(28893): event-values: 1.444667, 3.689733, 9.176475, 0.000000
07-29 10:42:13.734+0600 D/avoidrickshaw(28893): event-values: 1.467997, 3.826123, 9.080164, 0.000000
07-29 10:42:13.794+0600 D/avoidrickshaw(28893): event-values: 1.403390, 3.801597, 9.496515, 0.000000
07-29 10:42:13.854+0600 D/avoidrickshaw(28893): event-values: 1.520041, 3.885346, 9.173484, 0.000000
07-29 10:42:13.914+0600 D/avoidrickshaw(28893): event-values: 1.743770, 3.742374, 9.186645, 0.000000
07-29 10:42:13.975+0600 D/avoidrickshaw(28893): event-values: 1.606780, 3.723830, 9.218349, 0.000000
07-29 10:42:14.035+0600 D/avoidrickshaw(28893): event-values: 1.414158, 3.856632, 9.069994, 0.000000
07-29 10:42:14.095+0600 D/avoidrickshaw(28893): event-values: 1.477568, 3.696911, 9.163912, 0.000000
07-29 10:42:14.155+0600 D/avoidrickshaw(28893): event-values: 1.693520, 3.806383, 9.244670, 0.000000
07-29 10:42:14.215+0600 D/avoidrickshaw(28893): event-values: 1.837688, 3.630510, 9.251849, 0.000000
07-29 10:42:14.275+0600 D/avoidrickshaw(28893): event-values: 1.680360, 3.373282, 9.555139, 0.000000
07-29 10:42:14.335+0600 D/avoidrickshaw(28893): event-values: 1.392025, 3.443870, 9.245268, 0.000000
07-29 10:42:14.395+0600 D/avoidrickshaw(28893): event-values: 1.319044, 3.345764, 9.488140, 0.000000
07-29 10:42:14.455+0600 D/avoidrickshaw(28893): event-values: 1.350150, 3.302095, 9.451052, 0.000000
07-29 10:42:14.515+0600 D/avoidrickshaw(28893): event-values: 1.391426, 3.536592, 9.580862, 0.000000
07-29 10:42:14.575+0600 D/avoidrickshaw(28893): event-values: 1.130609, 3.721437, 10.030114, 0.000000
07-29 10:42:14.635+0600 D/avoidrickshaw(28893): event-values: 1.193420, 2.862414, 10.136595, 0.000000
07-29 10:42:14.695+0600 D/avoidrickshaw(28893): event-values: 1.326222, 2.723032, 9.364910, 0.000000
07-29 10:42:14.755+0600 D/avoidrickshaw(28893): event-values: 1.180260, 2.618944, 9.637093, 0.000000
07-29 10:42:14.815+0600 D/avoidrickshaw(28893): event-values: 1.046860, 2.804388, 8.827123, 0.000000
07-29 10:42:14.875+0600 D/avoidrickshaw(28893): event-values: 1.103091, 3.458227, 9.623335, 0.000000
07-29 10:42:14.935+0600 D/avoidrickshaw(28893): event-values: 2.681158, 3.173481, 9.934402, 0.000000
07-29 10:42:14.996+0600 D/avoidrickshaw(28893): event-values: 2.649453, 3.163910, 9.083753, 0.000000
07-29 10:42:15.056+0600 D/avoidrickshaw(28893): event-values: 3.005385, 2.849253, 9.420543, 0.000000
07-29 10:42:15.116+0600 D/avoidrickshaw(28893): event-va
