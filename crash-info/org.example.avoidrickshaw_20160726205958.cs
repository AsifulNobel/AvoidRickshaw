S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPD6
Build-Date: 2016.04.28 20:23:28

Crash Information
Process Name: avoidrickshaw
PID: 22524
Date: 2016-07-26 20:59:58+0600
Executable File Path: /opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 22524, uid 5000)

Register Information
r0   = 0x80030b86, r1   = 0x00000001
r2   = 0xb4302000, r3   = 0xb4302010
r4   = 0xb29ed133, r5   = 0xb8457660
r6   = 0xb84634f0, r7   = 0xbee6a208
r8   = 0x800168b5, r9   = 0xb5ed3708
r10  = 0xb84624e0, fp   = 0x00000000
ip   = 0xb5fc3120, sp   = 0xbee6a1c8
lr   = 0xb5f87bd9, pc   = 0xb29ec338
cpsr = 0x80000030

Memory Information
MemTotal:   730440 KB
MemFree:     41892 KB
Buffers:     46444 KB
Cached:     276340 KB
VmPeak:     123616 KB
VmSize:     123612 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24072 KB
VmRSS:       24072 KB
VmData:      50980 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36276 KB
VmPTE:          86 KB
VmSwap:          0 KB

Threads Information
Threads: 6
PID = 22524 TID = 22524
22524 22527 22937 22938 22946 22961 

Maps Information
afb13000 b0312000 rw-p [stack:22961]
b0b01000 b1300000 rw-p [stack:22946]
b143d000 b1445000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.49
b1455000 b1457000 r-xp /usr/lib/liblbs-agps.so.0.1.0
b1467000 b1475000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
b148c000 b148e000 r-xp /usr/lib/location/module/libwps.so.0.6.8_9
b149e000 b14a1000 r-xp /usr/lib/location/module/libgps.so.0.6.8_9
b14b2000 b1cb1000 rw-p [stack:22938]
b1cb2000 b24b1000 rw-p [stack:22937]
b252d000 b2535000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2546000 b2547000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b2557000 b256b000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b257f000 b2580000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2590000 b2593000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b25a4000 b25a5000 r-xp /usr/lib/libxshmfence.so.1.0.0
b25b5000 b25b7000 r-xp /usr/lib/libxcb-present.so.0.0.0
b25c7000 b25c9000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b25d9000 b25e9000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b25f9000 b2605000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b2855000 b2857000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b2867000 b286d000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b287d000 b2891000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b28a1000 b28bb000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b28cb000 b28d1000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
b28e1000 b28e8000 r-xp /usr/lib/libeventsystem.so.0.0.1
b28f8000 b291b000 r-xp /usr/lib/libSLP-location-product.so.0.9.0
b292c000 b2943000 r-xp /usr/lib/libSLP-location.so.0.11.5_5
b2953000 b295a000 r-xp /usr/lib/libefl-extension.so.0.1.0
b296b000 b2973000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b2983000 b2987000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
b2998000 b29a7000 r-xp /usr/lib/libcapi-location-manager.so.0.6.1_3
b29b7000 b29be000 r-xp /usr/lib/libcapi-appfw-preference.so.0.3.1.0
b29d0000 b29d6000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b29e6000 b29ee000 r-xp /opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw
b2b0f000 b2bf2000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2c29000 b2c51000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2c63000 b3462000 rw-p [stack:22527]
b3462000 b3464000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3474000 b347e000 r-xp /lib/libnss_files-2.20-2014.11.so
b348f000 b3498000 r-xp /lib/libnss_nis-2.20-2014.11.so
b34a9000 b34ba000 r-xp /lib/libnsl-2.20-2014.11.so
b34cd000 b34d3000 r-xp /lib/libnss_compat-2.20-2014.11.so
b34e4000 b34e5000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b350d000 b3514000 r-xp /usr/lib/libminizip.so.1.0.0
b3524000 b3529000 r-xp /usr/lib/libstorage.so.0.1
b3539000 b358e000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b35a4000 b35b8000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b35c8000 b360c000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b361c000 b3624000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3634000 b3664000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3677000 b3730000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3744000 b3798000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b37a9000 b37c4000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b37d4000 b3895000 r-xp /usr/lib/libprotobuf.so.9.0.1
b38a8000 b38ba000 r-xp /usr/lib/libefl-assist.so.0.1.0
b38ca000 b38ce000 r-xp /usr/lib/libogg.so.0.7.1
b38de000 b3900000 r-xp /usr/lib/libvorbis.so.0.4.3
b3910000 b39f4000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b3a10000 b3a1d000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3a2e000 b3a71000 r-xp /usr/lib/libsndfile.so.1.0.25
b3a86000 b3acd000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3ade000 b3ae4000 r-xp /usr/lib/libjson-c.so.2.0.1
b3af5000 b3afc000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3b0c000 b3b4c000 r-xp /usr/lib/libmdm.so.1.2.10
b3b5c000 b3b64000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3b73000 b3b83000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3ba4000 b3c04000 r-xp /usr/lib/libasound.so.2.0.0
b3c16000 b3c4c000 r-xp /usr/lib/libpulse.so.0.16.2
b3c5d000 b3c60000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3c70000 b3c73000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3c83000 b3c88000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3c98000 b3c99000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3ca9000 b3cb4000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3cc8000 b3ccf000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3cdf000 b3ce5000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3cf5000 b3cfa000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3d0a000 b3d25000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3d35000 b3d3c000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3d4c000 b3d4f000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3d60000 b3d8e000 r-xp /usr/lib/libidn.so.11.5.44
b3d9e000 b3db4000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3dc5000 b3dcf000 r-xp /usr/lib/libcares.so.2.1.0
b3ddf000 b3de9000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3df9000 b3dfb000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3e0b000 b3e0c000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3e1c000 b3e20000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3e31000 b3e59000 r-xp /usr/lib/libui-extension.so.0.1.0
b3e6a000 b3e93000 r-xp /usr/lib/libturbojpeg.so
b3eb3000 b3eb9000 r-xp /usr/lib/libgif.so.4.1.6
b3ec9000 b3f0f000 r-xp /usr/lib/libcurl.so.4.3.0
b3f20000 b3f41000 r-xp /usr/lib/libexif.so.12.3.3
b3f5c000 b3f71000 r-xp /usr/lib/libtts.so
b3f82000 b3f8a000 r-xp /usr/lib/libfeedback.so.0.1.4
b3f9a000 b405a000 r-xp /usr/lib/libdali-core.so.0.0.0
b4065000 b4158000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b4178000 b4252000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b4269000 b426b000 r-xp /usr/lib/libboost_system.so.1.51.0
b427b000 b4281000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b4291000 b42b4000 r-xp /usr/lib/libboost_thread.so.1.51.0
b42c5000 b42c7000 r-xp /usr/lib/libappsvc.so.0.1.0
b42d7000 b42d9000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b42ea000 b42ef000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4306000 b4308000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b4318000 b431f000 r-xp /usr/lib/libsensord-share.so
b432f000 b4347000 r-xp /usr/lib/libsensor.so.1.1.0
b4358000 b435b000 r-xp /usr/lib/libXv.so.1.0.0
b436b000 b4370000 r-xp /usr/lib/libutilX.so.1.1.0
b4380000 b4385000 r-xp /usr/lib/libappcore-common.so.1.1
b4395000 b439c000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b43af000 b43b3000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b43c4000 b448e000 r-xp /usr/lib/libCOREGL.so.4.0
b44a5000 b44a8000 r-xp /usr/lib/libuuid.so.1.3.0
b44b9000 b44d0000 r-xp /usr/lib/libblkid.so.1.1.0
b44e1000 b44e3000 r-xp /usr/lib/libXau.so.6.0.0
b44f3000 b44f6000 r-xp /usr/lib/libEGL.so.1.4
b44fe000 b4504000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4514000 b4516000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4527000 b4535000 r-xp /usr/lib/libGLESv2.so.2.0
b453e000 b45a0000 r-xp /usr/lib/libpixman-1.so.0.28.2
b45b5000 b45cd000 r-xp /usr/lib/libmount.so.1.1.0
b45de000 b45f2000 r-xp /usr/lib/libxcb.so.1.1.0
b4603000 b460a000 r-xp /lib/libcrypt-2.20-2014.11.so
b4642000 b4653000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b4664000 b4666000 r-xp /usr/lib/libiri.so
b4676000 b4681000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4692000 b46a7000 r-xp /lib/libexpat.so.1.5.2
b46b9000 b4777000 r-xp /usr/lib/libcairo.so.2.11200.14
b478a000 b4792000 r-xp /usr/lib/libdrm.so.2.4.0
b47a2000 b47a5000 r-xp /usr/lib/libdri2.so.0.0.0
b47b6000 b4804000 r-xp /usr/lib/libssl.so.1.0.0
b4819000 b4825000 r-xp /usr/lib/libeeze.so.1.13.0
b4835000 b483e000 r-xp /usr/lib/libethumb.so.1.13.0
b484e000 b4851000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4861000 b4a18000 r-xp /usr/lib/libcrypto.so.1.0.0
b566f000 b5678000 r-xp /usr/lib/libXi.so.6.1.0
b5688000 b568a000 r-xp /usr/lib/libXgesture.so.7.0.0
b569a000 b569e000 r-xp /usr/lib/libXtst.so.6.1.0
b56ae000 b56b4000 r-xp /usr/lib/libXrender.so.1.3.0
b56c4000 b56ca000 r-xp /usr/lib/libXrandr.so.2.2.0
b56db000 b56dd000 r-xp /usr/lib/libXinerama.so.1.0.0
b56ed000 b56f0000 r-xp /usr/lib/libXfixes.so.3.1.0
b5700000 b570b000 r-xp /usr/lib/libXext.so.6.4.0
b571b000 b571d000 r-xp /usr/lib/libXdamage.so.1.1.0
b572d000 b572f000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5740000 b5822000 r-xp /usr/lib/libX11.so.6.3.0
b5835000 b583c000 r-xp /usr/lib/libXcursor.so.1.0.2
b584c000 b5864000 r-xp /usr/lib/libudev.so.1.6.0
b5866000 b5869000 r-xp /lib/libattr.so.1.1.0
b5879000 b5899000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b589b000 b58a0000 r-xp /usr/lib/libffi.so.6.0.2
b58b0000 b58c8000 r-xp /lib/libz.so.1.2.8
b58d8000 b58da000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58ea000 b59bf000 r-xp /usr/lib/libxml2.so.2.9.2
b59d4000 b5a6f000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a8b000 b5a8e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a9e000 b5ab7000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5ac8000 b5ad9000 r-xp /lib/libresolv-2.20-2014.11.so
b5aed000 b5b67000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b7c000 b5b7e000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b8e000 b5b95000 r-xp /usr/lib/libembryo.so.1.13.0
b5ba5000 b5bbd000 r-xp /usr/lib/libpng12.so.0.50.0
b5bce000 b5bf1000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c12000 b5c26000 r-xp /usr/lib/libector.so.1.13.0
b5c37000 b5c4f000 r-xp /usr/lib/liblua-5.1.so
b5c60000 b5cb7000 r-xp /usr/lib/libfreetype.so.6.11.3
b5ccb000 b5cf3000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d04000 b5d17000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d28000 b5d5f000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d70000 b5d7e000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d8e000 b5d96000 r-xp /usr/lib/libtbm.so.1.0.0
b5da6000 b5db3000 r-xp /usr/lib/libeio.so.1.13.0
b5dc3000 b5dc5000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5dd5000 b5dda000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5dea000 b5e01000 r-xp /usr/lib/libefreet.so.1.13.0
b5e13000 b5e33000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e43000 b5e63000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e65000 b5e6b000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e7b000 b5e8c000 r-xp /usr/lib/libemotion.so.1.13.0
b5e9d000 b5ea4000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5eb4000 b5ec3000 r-xp /usr/lib/libeo.so.1.13.0
b5ed4000 b5ee6000 r-xp /usr/lib/libecore_input.so.1.13.0
b5ef7000 b5efc000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f0c000 b5f25000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f35000 b5f52000 r-xp /usr/lib/libeet.so.1.13.0
b5f6b000 b5fb3000 r-xp /usr/lib/libeina.so.1.13.0
b5fc4000 b5fd4000 r-xp /usr/lib/libefl.so.1.13.0
b5fe5000 b60ca000 r-xp /usr/lib/libicuuc.so.51.1
b60e7000 b6227000 r-xp /usr/lib/libicui18n.so.51.1
b623e000 b6276000 r-xp /usr/lib/libecore_x.so.1.13.0
b6288000 b628b000 r-xp /lib/libcap.so.2.21
b629b000 b62c4000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62d5000 b62dc000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62ee000 b6325000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6336000 b6421000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6434000 b64ad000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64bf000 b64c4000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64d4000 b64de000 r-xp /usr/lib/libvconf.so.0.2.45
b64ee000 b64f0000 r-xp /usr/lib/libvasum.so.0.3.1
b6500000 b6502000 r-xp /usr/lib/libttrace.so.1.1
b6512000 b6515000 r-xp /usr/lib/libiniparser.so.0
b6525000 b654b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b655b000 b6560000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6571000 b6588000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6599000 b6604000 r-xp /lib/libm-2.20-2014.11.so
b6615000 b661b000 r-xp /lib/librt-2.20-2014.11.so
b662c000 b6639000 r-xp /usr/lib/libunwind.so.8.0.1
b666f000 b6793000 r-xp /lib/libc-2.20-2014.11.so
b67a8000 b67c1000 r-xp /lib/libgcc_s-4.9.so.1
b67d1000 b68b3000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68c4000 b68ee000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68ff000 b693b000 r-xp /usr/lib/libsystemd.so.0.4.0
b693d000 b69bf000 r-xp /usr/lib/libedje.so.1.13.0
b69d2000 b69f0000 r-xp /usr/lib/libecore.so.1.13.0
b6a10000 b6b97000 r-xp /usr/lib/libevas.so.1.13.0
b6bcc000 b6be0000 r-xp /lib/libpthread-2.20-2014.11.so
b6bf4000 b6e29000 r-xp /usr/lib/libelementary.so.1.13.0
b6e57000 b6e5b000 r-xp /usr/lib/libsmack.so.1.0.0
b6e6b000 b6e72000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e82000 b6e84000 r-xp /usr/lib/libdlog.so.0.0.0
b6e94000 b6e97000 r-xp /usr/lib/libbundle.so.0.1.22
b6ea7000 b6ea9000 r-xp /lib/libdl-2.20-2014.11.so
b6eba000 b6ed2000 r-xp /usr/lib/libaul.so.0.1.0
b6ee6000 b6eeb000 r-xp /usr/lib/libappcore-efl.so.1.1
b6efc000 b6f09000 r-xp /usr/lib/liblptcp.so
b6f1b000 b6f1f000 r-xp /usr/lib/libsys-assert.so
b6f30000 b6f50000 r-xp /lib/ld-2.20-2014.11.so
b6f61000 b6f66000 r-xp /usr/bin/launchpad-loader
b8247000 b8540000 rw-p [heap]
bee4a000 bee6b000 rw-p [stack]
b8247000 b8540000 rw-p [heap]
bee4a000 bee6b000 rw-p [stack]
End of Maps Information

Callstack Information (PID:22524)
Call Stack Count: 21
 0: view_history_create + 0x23 (0xb29ec338) [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw] + 0x6338
 1: _show_history_cb + 0x7a (0xb29ebfa3) [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw] + 0x5fa3
 2: (0xb6a767ed) [/usr/lib/libevas.so.1] + 0x667ed
 3: (0xb5ebf219) [/usr/lib/libeo.so.1] + 0xb219
 4: eo_event_callback_call + 0x68 (0xb5ebdfb9) [/usr/lib/libeo.so.1] + 0x9fb9
 5: evas_object_smart_callback_call + 0x38 (0xb6a77edd) [/usr/lib/libevas.so.1] + 0x67edd
 6: (0xb6993dd7) [/usr/lib/libedje.so.1] + 0x56dd7
 7: (0xb699811f) [/usr/lib/libedje.so.1] + 0x5b11f
 8: (0xb6994791) [/usr/lib/libedje.so.1] + 0x57791
 9: (0xb6994b61) [/usr/lib/libedje.so.1] + 0x57b61
10: (0xb6994cb5) [/usr/lib/libedje.so.1] + 0x57cb5
11: (0xb69e1d11) [/usr/lib/libecore.so.1] + 0xfd11
12: (0xb69ddc4b) [/usr/lib/libecore.so.1] + 0xbc4b
13: (0xb69e3a5d) [/usr/lib/libecore.so.1] + 0x11a5d
14: ecore_main_loop_begin + 0x3e (0xb69e3c83) [/usr/lib/libecore.so.1] + 0x11c83
15: appcore_efl_main + 0x20c (0xb6ee92bd) [/usr/lib/libappcore-efl.so.1] + 0x32bd
16: ui_app_main + 0xc0 (0xb43b1909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
17: main + 0x9a (0xb29eb613) [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw] + 0x5613
18: (0xb6f62baf) [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw] + 0x1baf
19: __libc_start_main + 0x114 (0xb66854bc) [/lib/libc.so.6] + 0x164bc
20: (0xb6f62e94) [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw] + 0x1e94
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
07-25 22:04:53.254+0600 D/avoidrickshaw(32394): event-values: 0.214756, -0.092124, 10.202397, 0.000000
07-25 22:04:53.314+0600 D/avoidrickshaw(32394): event-values: 0.236889, -0.076570, 10.167702, 0.000000
07-25 22:04:53.374+0600 D/avoidrickshaw(32394): event-values: 0.177069, -0.061017, 10.177871, 0.000000
07-25 22:04:53.434+0600 D/avoidrickshaw(32394): event-values: 0.178265, -0.010169, 10.149158, 0.000000
07-25 22:04:53.494+0600 D/avoidrickshaw(32394): event-values: 0.209372, -0.088534, 10.162916, 0.000000
07-25 22:04:53.554+0600 D/avoidrickshaw(32394): event-values: 0.208774, -0.105284, 10.135997, 0.000000
07-25 22:04:53.614+0600 D/avoidrickshaw(32394): event-values: 0.192024, -0.080160, 10.139585, 0.000000
07-25 22:04:53.674+0600 D/avoidrickshaw(32394): event-values: 0.174676, -0.064008, 10.139585, 0.000000
07-25 22:04:53.734+0600 D/avoidrickshaw(32394): event-values: 0.198604, -0.068794, 10.155738, 0.000000
07-25 22:04:53.795+0600 D/avoidrickshaw(32394): event-values: 0.208176, -0.071785, 10.168301, 0.000000
07-25 22:04:53.855+0600 D/avoidrickshaw(32394): event-values: 0.191426, -0.075972, 10.175477, 0.000000
07-25 22:04:53.925+0600 D/avoidrickshaw(32394): horizontal_acc: 16.000000, vertical_acc: -1.000000
07-25 22:04:53.925+0600 D/avoidrickshaw(32394): previous lat: 23.742152, previous long: 90.411655
07-25 22:04:53.925+0600 D/avoidrickshaw(32394): current lat: 23.742152, current long: 90.411655
07-25 22:04:53.925+0600 D/avoidrickshaw(32394): because step count did not update, distance not updated.
07-25 22:04:53.925+0600 D/avoidrickshaw(32394): event-values: 0.172283, -0.080758, 10.167702, 0.000000
07-25 22:04:53.975+0600 D/avoidrickshaw(32394): event-values: 0.189631, -0.078365, 10.194022, 0.000000
07-25 22:04:54.035+0600 D/avoidrickshaw(32394): event-values: 0.211765, -0.064606, 10.163515, 0.000000
07-25 22:04:54.095+0600 D/avoidrickshaw(32394): event-values: 0.178265, -0.083749, 10.170692, 0.000000
07-25 22:04:54.155+0600 D/avoidrickshaw(32394): event-values: 0.169890, -0.086142, 10.170094, 0.000000
07-25 22:04:54.215+0600 D/avoidrickshaw(32394): event-values: 0.175872, -0.071785, 10.186246, 0.000000
07-25 22:04:54.275+0600 D/avoidrickshaw(32394): event-values: 0.206979, -0.086142, 10.169496, 0.000000
07-25 22:04:54.335+0600 D/avoidrickshaw(32394): event-values: 0.208774, -0.081356, 10.158729, 0.000000
07-25 22:04:54.395+0600 D/avoidrickshaw(32394): event-values: 0.174078, -0.084347, 10.188639, 0.000000
07-25 22:04:54.455+0600 D/avoidrickshaw(32394): event-values: 0.186640, -0.105882, 10.166506, 0.000000
07-25 22:04:54.515+0600 D/avoidrickshaw(32394): event-values: 0.203390, -0.085543, 10.146765, 0.000000
07-25 22:04:54.575+0600 D/avoidrickshaw(32394): event-values: 0.203390, -0.084347, 10.165309, 0.000000
07-25 22:04:54.635+0600 D/avoidrickshaw(32394): event-values: 0.175872, -0.063410, 10.188040, 0.000000
07-25 22:04:54.695+0600 D/avoidrickshaw(32394): event-values: 0.199801, -0.074776, 10.168301, 0.000000
07-25 22:04:54.755+0600 D/avoidrickshaw(32394): event-values: 0.211167, -0.075972, 10.176076, 0.000000
07-25 22:04:54.816+0600 D/avoidrickshaw(32394): event-values: 0.186042, -0.081954, 10.178469, 0.000000
07-25 22:04:54.876+0600 D/avoidrickshaw(32394): event-values: 0.185444, -0.069990, 10.170094, 0.000000
07-25 22:04:54.936+0600 D/avoidrickshaw(32394): event-values: 0.171087, -0.066401, 10.171290, 0.000000
07-25 22:04:54.996+0600 D/avoidrickshaw(32394): event-values: 0.232702, -0.060419, 10.178469, 0.000000
07-25 22:04:55.056+0600 D/avoidrickshaw(32394): event-values: 0.174676, -0.068195, 10.140184, 0.000000
07-25 22:04:55.116+0600 D/avoidrickshaw(32394): event-values: 0.184247, -0.076570, 10.192826, 0.000000
07-25 22:04:55.176+0600 D/avoidrickshaw(32394): event-values: 0.193819, -0.062812, 10.159328, 0.000000
07-25 22:04:55.236+0600 D/avoidrickshaw(32394): event-values: 0.221934, -0.091525, 10.143773, 0.000000
07-25 22:04:55.296+0600 D/avoidrickshaw(32394): event-values: 0.242871, -0.077767, 10.177871, 0.000000
07-25 22:04:55.356+0600 D/avoidrickshaw(32394): event-values: 0.150150, -0.075374, 10.150952, 0.000000
07-25 22:04:55.416+0600 D/avoidrickshaw(32394): event-values: 0.174676, -0.083151, 10.153944, 0.000000
07-25 22:04:55.476+0600 D/avoidrickshaw(32394): event-values: 0.223729, -0.080758, 10.173084, 0.000000
07-25 22:04:55.536+0600 D/avoidrickshaw(32394): event-values: 0.206381, -0.092124, 10.166506, 0.000000
07-25 22:04:55.596+0600 D/avoidrickshaw(32394): event-values: 0.175872, -0.065803, 10.168897, 0.000000
07-25 22:04:55.656+0600 D/avoidrickshaw(32394): event-values: 0.177667, -0.078365, 10.163515, 0.000000
07-25 22:04:55.716+0600 D/avoidrickshaw(32394): event-values: 0.212961, -0.095115, 10.177272, 0.000000
07-25 22:04:55.776+0600 D/avoidrickshaw(32394): event-values: 0.210568, -0.075374, 10.168897, 0.000000
07-25 22:04:55.837+0600 D/avoidrickshaw(32394): event-values: 0.171685, -0.059821, 10.163515, 0.000000
07-25 22:04:55.897+0600 D/avoidrickshaw(32394): event-values: 0.172283, -0.081356, 10.156934, 0.000000
07-25 22:04:55.957+0600 D/avoidrickshaw(32394): event-values: 0.226720, -0.085543, 10.167104, 0.000000
07-25 22:04:56.017+0600 D/avoidrickshaw(32394): event-values: 0.202193, -0.075374, 10.167702, 0.000000
07-25 22:04:56.077+0600 D/avoidrickshaw(32394): event-values: 0.185444, -0.081954, 10.164711, 0.000000
07-25 22:04:56.137+0600 D/avoidrickshaw(32394): event-values: 0.180658, -0.081954, 10.161720, 0.000000
07-25 22:04:56.197+0600 D/avoidrickshaw(32394): event-values: 0.207577, -0.068794, 10.167104, 0.000000
07-25 22:04:56.257+0600 D/avoidrickshaw(32394): event-values: 0.209372, -0.081954, 10.174281, 0.000000
07-25 22:04:56.317+0600 D/avoidrickshaw(32394): event-values: 0.183649, -0.078365, 10.162916, 0.000000
07-25 22:04:56.377+0600 D/avoidrickshaw(32394): event-values: 0.157328, -0.077169, 10.186844, 0.000000
07-25 22:04:56.437+0600 D/avoidrickshaw(32394): event-values: 0.219541, -0.084945, 10.188040, 0.000000
07-25 22:04:56.497+0600 D/avoidrickshaw(32394): event-values: 0.228515, -0.089133, 10.156934, 0.000000
07-25 22:04:56.557+0600 D/avoidrickshaw(32394): event-values: 0.197408, -0.071186, 10.173084, 0.000000
07-25 22:04:56.617+0600 D/avoidrickshaw(32394): event-values: 0.154935, -0.068794, 10.162916, 0.000000
07-25 22:04:56.677+0600 D/avoidrickshaw(32394): event-values: 0.224327, -0.074776, 10.173084, 0.000000
07-25 22:04:56.737+0600 D/avoidrickshaw(32394): event-values: 0.217747, -0.058026, 10.189237, 0.000000
07-25 22:04:56.797+0600 D/avoidrickshaw(32394): event-values: 0.199801, -0.076570, 10.127622, 0.000000
07-25 22:04:56.858+0600 D/avoidrickshaw(32394): event-values: 0.174676, -0.072383, 10.175477, 0.000000
07-25 22:04:56.918+0600 D/avoidrickshaw(32394): event-values: 0.200997, -0.070588, 10.155738, 0.000000
07-25 22:04:56.978+0600 D/avoidrickshaw(32394): event-values: 0.213559, -0.089731, 10.152746, 0.000000
07-25 22:04:57.038+0600 D/avoidrickshaw(32394): event-values: 0.183051, -0.084945, 10.165309, 0.000000
07-25 22:04:57.098+0600 D/avoidrickshaw(32394): event-values: 0.185444, -0.102293, 10.168897, 0.000000
07-25 22:04:57.158+0600 D/avoidrickshaw(32394): event-values: 0.221934, -0.077169, 10.169496, 0.000000
07-25 22:04:57.218+0600 D/avoidrickshaw(32394): event-values: 0.177069, -0.069392, 10.147363, 0.000000
07-25 22:04:57.278+0600 D/avoidrickshaw(32394): event-values: 0.197408, -0.081954, 10.189835, 0.000000
07-25 22:04:57.338+0600 D/avoidrickshaw(32394): event-values: 0.225524, -0.076570, 10.188040, 0.000000
07-25 22:04:57.398+0600 D/avoidrickshaw(32394): event-values: 0.192024, -0.078365, 10.177272, 0.000000
07-25 22:04:57.458+0600 D/avoidrickshaw(32394): event-values: 0.209372, -0.099302, 10.156336, 0.000000
07-25 22:04:57.518+0600 D/avoidrickshaw(32394): event-values: 0.179462, -0.063410, 10.167702, 0.000000
07-25 22:04:57.578+0600 D/avoidrickshaw(32394): event-values: 0.220140, -0.082552, 10.190434, 0.000000
07-25 22:04:57.638+0600 D/avoidrickshaw(32394): event-values: 0.162114, -0.094516, 10.107283, 0.000000
07-25 22:04:57.698+0600 D/avoidrickshaw(32394): event-values: 0.225524, -0.069990, 10.180862, 0.000000
07-25 22:04:57.758+0600 D/avoidrickshaw(32394): event-values: 0.191426, -0.070588, 10.165309, 0.000000
07-25 22:04:57.818+0600 D/avoidrickshaw(32394): event-values: 0.190229, -0.077767, 10.159328, 0.000000
07-25 22:04:57.909+0600 D/avoidrickshaw(32394): horizontal_acc: 32.000000, vertical_acc: -1.000000
07-25 22:04:57.909+0600 D/avoidrickshaw(32394): previous lat: 23.742152, previous long: 90.411655
07-25 22:04:57.909+0600 D/avoidrickshaw(32394): current lat: 23.742101, current long: 90.411688
07-25 22:04:57.909+0600 D/avoidrickshaw(32394): because step count did not update, saving position only.
07-25 22:04:57.909+0600 D/avoidrickshaw(32394): event-values: 0.172881, -0.078963, 10.163515, 0.000000
07-25 22:04:57.949+0600 D/avoidrickshaw(32394): event-values: 0.210568, -0.052044, 10.181459, 0.000000
07-25 22:04:58.009+0600 D/avoidrickshaw(32394): event-values: 0.205783, -0.076570, 10.174281, 0.000000
07-25 22:04:58.069+0600 D/avoidrickshaw(32394): event-values: 0.183649, -0.083151, 10.109076, 0.000000
07-25 22:04:58.129+0600 D/avoidrickshaw(32394): event-values: 0.212363, -0.087338, 10.180264, 0.000000
07-25 22:04:58.189+0600 D/avoidrickshaw(32394): event-values: 0.215354, -0.064606, 10.159925, 0.000000
07-25 22:04:58.249+0600 D/avoidrickshaw(32394): event-values: 0.205185, -0.075972, 10.177272, 0.000000
07-25 22:04:58.309+0600 D/avoidrickshaw(32394): event-values: 0.178265, -0.088534, 10.187442, 0.000000
07-25 22:04:58.369+0600 D/avoidrickshaw(32394): event-values: 0.195015, -0.077169, 10.147961, 0.000000
07-25 22:04:58.429+0600 D/avoidrickshaw(32394): event-values: 0.235693, -0.083749, 10.170692, 0.000000
07-25 22:04:58.489+0600 D/avoidrickshaw(32394): event-values: 0.178863, -0.068794, 10.176675, 0.000000
07-25 22:04:58.549+0600 D/avoidrickshaw(32394): event-values: 0.192622, -0.062213, 10.153944, 0.000000
07-25 22:04:58.609+0600 D/avoidrickshaw(32394): event-values: 0.238684, -0.072981, 10.200603, 0.000000
07-25 22:04:58.669+0600 D/avoidrickshaw(32394): event-values: 0.217149, -0.086740, 10.148559, 0.000000
07-25 22:04:58.729+0600 D/avoidrickshaw(32394): event-values: 0.215354, -0.063410, 10.137194, 0.000000
07-25 22:04:58.789+0600 D/avoidrickshaw(32394): event-values: 0.119043, -0.099302, 10.151550, 0.000000
07-25 22:04:58.849+0600 D/avoidrickshaw(32394): event-values: 0.226122, -0.066999, 10.210175, 0.000000
07-25 22:04:58.910+0600 D/avoidrickshaw(32394): event-values: 0.192622, -0.061017, 10.135997, 0.000000
07-25 22:04:58.970+0600 D/avoidrickshaw(32394): event-values: 0.196810, -0.072383, 10.170692, 0.000000
07-25 22:04:59.030+0600 D/avoidrickshaw(32394): event-values: 0.186042, -0.084945, 10.171888, 0.000000
07-25 22:04:59.090+0600 D/avoidrickshaw(32394): event-values: 0.168096, -0.072383, 10.141381, 0.000000
07-25 22:04:59.150+0600 D/avoidrickshaw(32394): event-values: 0.254237, -0.078365, 10.206585, 0.000000
07-25 22:04:59.210+0600 D/avoidrickshaw(32394): event-values: 0.175872, -0.099900, 10.157533, 0.000000
07-25 22:04:59.270+0600 D/avoidrickshaw(32394): event-values: 0.170489, -0.084347, 10.174281, 0.000000
07-25 22:04:59.330+0600 D/avoidrickshaw(32394): event-values: 0.200399, -0.056830, 10.154541, 0.000000
07-25 22:04:59.390+0600 D/avoidrickshaw(32394): event-values: 0.225524, -0.053839, 10.204790, 0.000000
07-25 22:04:59.450+0600 D/avoidrickshaw(32394): event-values: 0.196810, -0.069990, 10.176076, 0.000000
07-25 22:04:59.510+0600 D/avoidrickshaw(32394): event-values: 0.172881, -0.071785, 10.188040, 0.000000
07-25 22:04:59.570+0600 D/avoidrickshaw(32394): event-values: 0.195613, -0.074776, 10.153345, 0.000000
07-25 22:04:59.630+0600 D/avoidrickshaw(32394): event-values: 0.207577, -0.080160, 10.153944, 0.000000
07-25 22:04:59.690+0600 D/avoidrickshaw(32394): event-values: 0.201595, -0.072383, 10.176675, 0.000000
07-25 22:04:59.750+0600 D/avoidrickshaw(32394): event-values: 0.192024, -0.096909, 10.168301, 0.000000
07-25 22:04:59.810+0600 D/avoidrickshaw(32394): event-values: 0.217149, -0.044267, 10.229916, 0.000000
07-25 22:04:59.870+0600 D/avoidrickshaw(32394): event-values: 0.162114, -0.074776, 10.169496, 0.000000
07-25 22:04:59.931+0600 D/avoidrickshaw(32394): event-values: 0.184846, -0.095115, 10.155140, 0.000000
07-25 22:04:59.991+0600 D/avoidrickshaw(32394): event-values: 0.181256, -0.075374, 10.162319, 0.000000
07-25 22:05:00.051+0600 D/avoidrickshaw(32394): event-values: 0.221934, -0.089731, 10.156336, 0.000000
07-25 22:05:00.111+0600 D/avoidrickshaw(32394): event-values: 0.189631, -0.074178, 10.181459, 0.000000
07-25 22:05:00.161+0600 D/avoidrickshaw(32394): event-values: 0.166301, -0.071785, 10.168301, 0.000000
07-25 22:05:00.231+0600 D/avoidrickshaw(32394): event-values: 0.192024, -0.086142, 10.132407, 0.000000
07-25 22:05:00.281+0600 D/avoidrickshaw(32394): event-values: 0.175274, -0.064008, 10.144970, 0.000000
07-25 22:05:00.341+0600 D/avoidrickshaw(32394): event-values: 0.176471, -0.067597, 10.185050, 0.000000
07-25 22:05:00.401+0600 D/avoidrickshaw(32394): event-values: 0.203988, -0.093918, 10.170094, 0.000000
07-25 22:05:00.461+0600 D/avoidrickshaw(32394): event-values: 0.186042, -0.075374, 10.168897, 0.000000
07-25 22:05:00.521+0600 D/avoidrickshaw(32394): event-values: 0.213559, -0.082552, 10.185647, 0.000000
07-25 22:05:00.581+0600 D/avoidrickshaw(32394): event-values: 0.214158, -0.079561, 10.152148, 0.000000
07-25 22:05:00.641+0600 D/avoidrickshaw(32394): event-values: 0.193220, -0.087936, 10.176076, 0.000000
07-25 22:05:00.701+0600 D/avoidrickshaw(32394): event-values: 0.183051, -0.078365, 10.189835, 0.000000
07-25 22:05:00.761+0600 D/avoidrickshaw(32394): event-values: 0.208774, -0.065204, 10.177871, 0.000000
07-25 22:05:00.821+0600 D/avoidrickshaw(32394): event-values: 0.163310, -0.098106, 10.122238, 0.000000
07-25 22:05:00.881+0600 D/avoidrickshaw(32394): event-values: 0.213559, -0.082552, 10.177272, 0.000000
07-25 22:05:00.942+0600 D/avoidrickshaw(32394): event-values: 0.198006, -0.075374, 10.173084, 0.000000
07-25 22:05:01.002+0600 D/avoidrickshaw(32394): event-values: 0.182453, -0.061017, 10.167702, 0.000000
07-25 22:05:01.062+0600 D/avoidrickshaw(32394): event-values: 0.196211, -0.084945, 10.159925, 0.000000
07-25 22:05:01.122+0600 D/avoidrickshaw(32394): event-values: 0.181256, -0.092722, 10.182656, 0.000000
07-25 22:05:01.182+0600 D/avoidrickshaw(32394): event-values: 0.183649, -0.062213, 10.165309, 0.000000
07-25 22:05:01.242+0600 D/avoidrickshaw(32394): event-values: 0.218345, -0.066999, 10.165908, 0.000000
07-25 22:05:01.302+0600 D/avoidrickshaw(32394): event-values: 0.163908, -0.093320, 10.159925, 0.000000
07-25 22:05:01.362+0600 D/avoidrickshaw(32394): event-values: 0.199801, -0.035294, 10.164711, 0.000000
07-25 22:05:01.422+0600 D/avoidrickshaw(32394): event-values: 0.206381, -0.059821, 10.174281, 0.000000
07-25 22:05:01.482+0600 D/avoidrickshaw(32394): event-values: 0.182453, -0.074776, 10.177272, 0.000000
07-25 22:05:01.542+0600 D/avoidrickshaw(32394): event-values: 0.169292, -0.062213, 10.158729, 0.000000
07-25 22:05:01.602+0600 D/avoidrickshaw(32394): event-values: 0.165105, -0.081954, 10.179067, 0.000000
07-25 22:05:01.662+0600 D/avoidrickshaw(32394): event-values: 0.199801, -0.074178, 10.152746, 0.000000
07-25 22:05:01.722+0600 D/avoidrickshaw(32394): event-values: 0.179462, -0.092722, 10.150353, 0.000000
07-25 22:05:01.782+0600 D/avoidrickshaw(32394): event-values: 0.203390, -0.074178, 10.180862, 0.000000
07-25 22:05:01.842+0600 D/avoidrickshaw(32394): event-values: 0.206979, -0.078963, 10.167702, 0.000000
07-25 22:05:01.902+0600 D/avoidrickshaw(32394): horizontal_acc: 16.000000, vertical_acc: -1.000000
07-25 22:05:01.902+0600 D/avoidrickshaw(32394): previous lat: 23.742101, previous long: 90.411688
07-25 22:05:01.902+0600 D/avoidrickshaw(32394): current lat: 23.742100, current long: 90.411683
07-25 22:05:01.902+0600 D/avoidrickshaw(32394): because step count did not update, distance not updated.
07-25 22:05:01.902+0600 D/avoidrickshaw(32394): event-values: 0.187238, -0.081356, 10.175477, 0.000000
07-25 22:05:01.963+0600 D/avoidrickshaw(32394): event-values: 0.203988, -0.068794, 10.150952, 0.000000
07-25 22:05:02.023+0600 D/avoidrickshaw(32394): event-values: 0.203390, -0.058624, 10.164711, 0.000000
07-25 22:05:02.083+0600 D/avoidrickshaw(32394): event-values: 0.185444, -0.045464, 10.177871, 0.000000
07-25 22:05:02.143+0600 D/avoidrickshaw(32394): event-values: 0.174676, -0.079561, 10.171888, 0.000000
07-25 22:05:02.203+0600 D/avoidrickshaw(32394): event-values: 0.192622, -0.086142, 10.177272, 0.000000
07-25 22:05:02.263+0600 D/avoidrickshaw(32394): event-values: 0.214756, -0.071186, 10.179067, 0.000000
07-25 22:05:02.323+0600 D/avoidrickshaw(32394): event-values: 0.198604, -0.058026, 10.176076, 0.000000
07-25 22:05:02.383+0600 D/avoidrickshaw(32394): event-values: 0.162712, -0.099302, 10.176076, 0.000000
07-25 22:05:02.443+0600 D/avoidrickshaw(32394): event-values: 0.220738, -0.102293, 10.171290, 0.000000
07-25 22:05:02.503+0600 D/avoidrickshaw(32394): event-values: 0.189033, -0.083151, 10.182058, 0.000000
07-25 22:05:02.563+0600 D/avoidrickshaw(32394): event-values: 0.187238, -0.073579, 10.168301, 0.000000
07-25 22:05:02.623+0600 D/avoidrickshaw(32394): event-values: 0.181855, -0.074776, 10.176675, 0.000000
07-25 22:05:02.683+0600 D/avoidrickshaw(32394): event-values: 0.223729, -0.075374, 10.178469, 0.000000
07-25 22:05:02.743+0600 D/avoidrickshaw(32394): event-values: 0.200997, -0.096311, 10.173084, 0.000000
07-25 22:05:02.803+0600 D/avoidrickshaw(32394): event-values: 0.159721, -0.073579, 10.169496, 0.000000
07-25 22:05:02.863+0600 D/avoidrickshaw(32394): event-values: 0.206381, -0.076570, 10.166506, 0.000000
07-25 22:05:02.923+0600 D/avoidrickshaw(32394): event-values: 0.208774, -0.065803, 10.168897, 0.000000
07-25 22:05:02.983+0600 D/avoidrickshaw(32394): event-values: 0.192622, -0.077767, 10.165309, 0.000000
07-25 22:05:03.044+0600 D/avoidrickshaw(32394): event-values: 0.189033, -0.059222, 10.183852, 0.000000
07-25 22:05:03.104+0600 D/avoidrickshaw(32394): event-values: 0.203390, -0.090329, 10.182058, 0.000000
07-25 22:05:03.164+0600 D/avoidrickshaw(32394): event-values: 0.201595, -0.077169, 10.169496, 0.000000
07-25 22:05:03.224+0600 D/avoidrickshaw(32394): event-values: 0.191426, -0.075972, 10.182656, 0.000000
07-25 22:05:03.284+0600 D/avoidrickshaw(32394): event-values: 0.165703, -0.075972, 10.174281, 0.000000
07-25 22:05:03.344+0600 D/avoidrickshaw(32394): event-values: 0.214756, -0.067597, 10.165309, 0.000000
07-25 22:05:03.404+0600 D/avoidrickshaw(32394): event-values: 0.199801, -0.054437, 10.189237, 0.000000
07-25 22:05:03.464+0600 D/avoidrickshaw(32394): event-values: 0.177069, -0.061615, 10.187442, 0.000000
07-25 22:05:03.524+0600 D/avoidrickshaw(32394): event-values: 0.195015, -0.059222, 10.157533, 0.000000
07-25 22:05:03.584+0600 D/avoidrickshaw(32394): event-values: 0.215952, -0.059821, 10.176675, 0.000000
07-25 22:05:03.644+0600 D/avoidrickshaw(32394): event-values: 0.212961, -0.069990, 10.167104, 0.000000
07-25 22:05:03.704+0600 D/avoidrickshaw(32394): event-values: 0.189033, -0.077767, 10.164113, 0.000000
07-25 22:05:03.764+0600 D/avoidrickshaw(32394): event-values: 0.185444, -0.081954, 10.180264, 0.000000
07-25 22:05:03.824+0600 D/avoidrickshaw(32394): event-values: 0.206979, -0.081356, 10.188040, 0.000000
07-25 22:05:03.884+0600 D/avoidrickshaw(32394): event-values: 0.205783, -0.065803, 10.171290, 0.000000
07-25 22:05:03.944+0600 D/avoidrickshaw(32394): event-values: 0.186042, -0.083151, 10.176675, 0.000000
07-25 22:05:04.004+0600 D/avoidrickshaw(32394): event-values: 0.210568, -0.069990, 10.165908, 0.000000
07-25 22:05:04.065+0600 D/avoidrickshaw(32394): event-values: 0.207577, -0.081954, 10.171290, 0.000000
07-25 22:05:04.125+0600 D/avoidrickshaw(32394): event-values: 0.198006, -0.074178, 10.162319, 0.000000
07-25 22:05:04.185+0600 D/avoidrickshaw(32394): event-values: 0.190229, -0.066999, 10.182058, 0.000000
07-25 22:05:04.245+0600 D/avoidrickshaw(32394): event-values: 0.189631, -0.086142, 10.167702, 0.000000
07-25 22:05:04.305+0600 D/avoidrickshaw(32394): event-values: 0.204586, -0.072383, 10.165309, 0.000000
07-25 22:05:04.365+0600 D/avoidrickshaw(32394): event-values: 0.172283, -0.065803, 10.179665, 0.000000
07-25 22:05:04.425+0600 D/avoidrickshaw(32394): event-values: 0.224925, -0.078963, 10.174880, 0.000000
07-25 22:05:04.485+0600 D/avoidrickshaw(32394): event-values: 0.198006, -0.095115, 10.171888, 0.000000
07-25 22:05:04.545+0600 D/avoidrickshaw(32394): event-values: 0.177069, -0.086142, 10.167104, 0.000000
07-25 22:05:04.605+0600 D/avoidrickshaw(32394): event-values: 0.189631, -0.071186, 10.156336, 0.000000
07-25 22:05:04.665+0600 D/avoidrickshaw(32394): event-values: 0.195613, -0.083151, 10.168897, 0.000000
07-25 22:05:04.725+0600 D/avoidrickshaw(32394): event-values: 0.198006, -0.082552, 10.191031, 0.000000
07-25 22:05:04.785+0600 D/avoidrickshaw(32394): event-values: 0.196810, -0.079561, 10.191031, 0.000000
07-25 22:05:04.845+0600 D/avoidrickshaw(32394): event-values: 0.174078, -0.080758, 10.174880, 0.000000
07-25 22:05:04.905+0600 D/avoidrickshaw(32394): event-values: 0.200997, -0.058624, 10.166506, 0.000000
07-25 22:05:04.965+0600 D/avoidrickshaw(32394): event-values: 0.188435, -0.058026, 10.197014, 0.000000
07-25 22:05:05.025+0600 D/avoidrickshaw(32394): event-values: 0.208176, -0.068794, 10.169496, 0.000000
07-25 22:05:05.086+0600 D/avoidrickshaw(32394): event-values: 0.177667, -0.074776, 10.155738, 0.000000
07-25 22:05:05.146+0600 D/avoidrickshaw(32394): event-values: 0.190229, -0.075972, 10.175477, 0.000000
07-25 22:05:05.206+0600 D/avoidrickshaw(32394): event-values: 0.215354, -0.081954, 10.172487, 0.000000
07-25 22:05:05.266+0600 D/avoidrickshaw(32394): event-values: 0.203988, -0.087936, 10.176675, 0.000000
07-25 22:05:05.326+0600 D/avoidrickshaw(32394): event-values: 0.176471, -0.066401, 10.147961, 0.000000
07-25 22:05:05.386+0600 D/avoidrickshaw(32394): event-values: 0.215354, -0.052642, 10.190434, 0.000000
07-25 22:05:05.446+0600 D/avoidrickshaw(32394): event-values: 0.186042, -0.089731, 10.191629, 0.000000
07-25 22:05:05.506+0600 D/avoidrickshaw(32394): event-values: 0.193819, -0.073579, 10.155738, 0.000000
07-25 22:05:05.566+0600 D/avoidrickshaw(32394): event-values: 0.181256, -0.069990, 10.158132, 0.000000
07-25 22:05:05.626+0600 D/avoidrickshaw(32394): event-values: 0.194417, -0.061017, 10.183254, 0.000000
07-25 22:05:05.686+0600 D/avoidrickshaw(32394): event-values: 0.197408, -0.062213, 10.169496, 0.000000
07-25 22:05:05.746+0600 D/avoidrickshaw(32394): event-values: 0.195613, -0.074776, 10.171290, 0.000000
07-25 22:05:05.806+0600 D/avoidrickshaw(32394): event-values: 0.191426, -0.081356, 10.180862, 0.000000
07-25 22:05:05.846+0600 I/Tizen::Net::Wifi( 1305): (941) > The background scan result updated.
07-25 22:05:05.876+0600 D/avoidrickshaw(32394): event-values: 0.195015, -0.080160, 10.168897, 0.000000
07-25 22:05:05.936+0600 D/avoidrickshaw(32394): horizontal_acc: 24.000000, vertical_acc: -1.000000
07-25 22:05:05.936+0600 D/avoidrickshaw(32394): previous lat: 23.742101, previous long: 90.411688
07-25 22:05:05.936+0600 D/avoidrickshaw(32394): current lat: 23.742100, current long: 90.411683
07-25 22:05:05.946+0600 D/avoidrickshaw(32394): because step count did not update, distance not updated.
07-25 22:05:05.946+0600 D/avoidrickshaw(32394): event-values: 0.187238, -0.066999, 10.174880, 0.000000
07-25 22:05:05.996+0600 D/avoidrickshaw(32394): event-values: 0.205185, -0.074178, 10.164711, 0.000000
07-25 22:05:06.056+0600 D/avoidrickshaw(32394): event-values: 0.204586, -0.078963, 10.200004, 0.000000
07-25 22:05:06.117+0600 D/avoidrickshaw(32394): event-values: 0.185444, -0.080160, 10.150952, 0.000000
07-25 22:05:06.177+0600 D/avoidrickshaw(32394): event-values: 0.197408, -0.069990, 10.190434, 0.000000
07-25 22:05:06.237+0600 D/avoidrickshaw(32394): event-values: 0.193819, -0.072383, 10.156934, 0.000000
07-25 22:05:06.297+0600 D/avoidrickshaw(32394): event-values: 0.189033, -0.077767, 10.175477, 0.000000
07-25 22:05:06.357+0600 D/avoidrickshaw(32394): event-values: 0.186042, -0.068794, 10.183852, 0.000000
07-25 22:05:06.417+0600 D/avoidrickshaw(32394): event-values: 0.198604, -0.063410, 10.174880, 0.000000
07-25 22:05:06.477+0600 D/avoidrickshaw(32394): event-values: 0.196810, -0.076570, 10.183254, 0.000000
07-25 22:05:06.537+0600 D/avoidrickshaw(32394): event-values: 0.196810, -0.079561, 10.183852, 0.000000
07-25 22:05:06.597+0600 D/avoidrickshaw(32394): event-values: 0.199801, -0.082552, 10.177272, 0.000000
07-25 22:05:06.657+0600 D/avoidrickshaw(32394): event-values: 0.197408, -0.084945, 10.179665, 0.000000
07-25 22:05:06.717+0600 D/avoidrickshaw(32394): event-values: 0.183051, -0.081954, 10.188639, 0.000000
07-25 22:05:06.777+0600 D/avoidrickshaw(32394): event-values: 0.198604, -0.054437, 10.177871, 0.000000
07-25 22:05:06.837+0600 D/avoidrickshaw(32394): event-values: 0.221336, -0.077169, 10.188040, 0.000000
07-25 22:05:06.897+0600 D/avoidrickshaw(32394): event-values: 0.192622, -0.077169, 10.181459, 0.000000
07-25 22:05:06.957+0600 D/avoidrickshaw(32394): event-values: 0.192024, -0.069990, 10.167702, 0.000000
07-25 22:05:07.017+0600 D/avoidrickshaw(32394): event-values: 0.133400, -0.058624, 10.183254, 0.000000
07-25 22:05:07.077+0600 D/avoidrickshaw(32394): event-values: 0.166301, -0.056231, 10.197014, 0.000000
07-25 22:05:07.138+0600 D/avoidrickshaw(32394): event-values: 0.206381, -0.062213, 10.193424, 0.000000
07-25 22:05:07.198+0600 D/avoidrickshaw(32394): event-values: 0.212363, -0.086740, 10.153944, 0.000000
07-25 22:05:07.258+0600 D/avoidrickshaw(32394): event-values: 0.200997, -0.068794, 10.171290, 0.000000
07-25 22:05:07.318+0600 D/avoidrickshaw(32394): event-values: 0.194417, -0.075374, 10.180862, 0.000000
07-25 22:05:07.378+0600 D/avoidrickshaw(32394): event-values: 0.202792, -0.076570, 10.167104, 0.000000
07-25 22:05:07.438+0600 D/avoidrickshaw(32394): event-values: 0.221336, -0.072383, 10.185050, 0.000000
07-25 22:05:07.498+0600 D/avoidrickshaw(32394): event-values: 0.163908, -0.081954, 10.153345, 0.000000
07-25 22:05:07.558+0600 D/avoidrickshaw(32394): event-values: 0.196810, -0.082552, 10.170094, 0.000000
07-25 22:05:07.618+0600 D/avoidrickshaw(32394): event-values: 0.222532, -0.054437, 10.189835, 0.000000
07-25 22:05:07.678+0600 D/avoidrickshaw(32394): event-values: 0.206381, -0.094516, 10.157533, 0.000000
07-25 22:05:07.738+0600 D/avoidrickshaw(32394): event-values: 0.187837, -0.073579, 10.177871, 0.000000
07-25 22:05:07.798+0600 D/avoidrickshaw(32394): event-values: 0.184247, -0.075972, 10.170094, 0.000000
07-25 22:05:07.858+0600 D/avoidrickshaw(32394): event-values: 0.226122, -0.076570, 10.189237, 0.000000
07-25 22:05:07.918+0600 D/avoidrickshaw(32394): event-values: 0.167498, -0.064008, 10.184451, 0.000000
07-25 22:05:07.978+0600 D/avoidrickshaw(32394): event-values: 0.181256, -0.067597, 10.195816, 0.000000
07-25 22:05:08.038+0600 D/avoidrickshaw(32394): event-values: 0.217747, -0.064606, 10.181459, 0.000000
07-25 22:05:08.098+0600 D/avoidrickshaw(32394): event-values: 0.199801, -0.084347, 10.172487, 0.000000
07-25 22:05:08.159+0600 D/avoidrickshaw(32394): event-values: 0.198604, -0.056231, 10.164113, 0.000000
07-25 22:05:08.219+0600 D/avoidrickshaw(32394): event-values: 0.182453, -0.071785, 10.183852, 0.000000
07-25 22:05:08.279+0600 D/avoidrickshaw(32394): event-values: 0.212363, -0.081356, 10.168301, 0.000000
07-25 22:05:08.339+0600 D/avoidrickshaw(32394): event-values: 0.233898, -0.049651, 10.178469, 0.000000
07-25 22:05:08.399+0600 D/avoidrickshaw(32394): event-values: 0.179462, -0.078963, 10.159925, 0.000000
07-25 22:05:08.459+0600 D/avoidrickshaw(32394): event-values: 0.162114, -0.069392, 10.176076, 0.000000
07-25 22:05:08.519+0600 D/avoidrickshaw(32394): event-values: 0.221934, -0.093320, 10.185050, 0.000000
07-25 22:05:08.579+0600 D/avoidrickshaw(32394): event-values: 0.200997, -0.092124, 10.170692, 0.000000
07-25 22:05:08.639+0600 D/avoidrickshaw(32394): event-values: 0.193220, -0.060419, 10.150952, 0.000000
07-25 22:05:08.699+0600 D/avoidrickshaw(32394): event-values: 0.177667, -0.054437, 10.178469, 0.000000
07-25 22:05:08.759+0600 D/avoidrickshaw(32394): event-values: 0.224327, -0.100499, 10.180862, 0.000000
07-25 22:05:08.819+0600 D/avoidrickshaw(32394): event-values: 0.201595, -0.056830, 10.177871, 0.000000
07-25 22:05:08.879+0600 D/avoidrickshaw(32394): event-values: 0.165703, -0.083749, 10.164113, 0.000000
07-25 22:05:08.939+0600 D/avoidrickshaw(32394): event-values: 0.180060, -0.067597, 10.176076, 0.000000
07-25 22:05:08.999+0600 D/avoidrickshaw(32394): event-values: 0.209970, -0.083151, 10.174880, 0.000000
07-25 22:05:09.059+0600 D/avoidrickshaw(32394): event-values: 0.214158, -0.106481, 10.201799, 0.000000
07-25 22:05:09.119+0600 D/avoidrickshaw(32394): event-values: 0.178863, -0.056231, 10.176076, 0.000000
07-25 22:05:09.180+0600 D/avoidrickshaw(32394): event-values: 0.156132, -0.075374, 10.155738, 0.000000
07-25 22:05:09.240+0600 D/avoidrickshaw(32394): event-values: 0.205783, -0.068794, 10.166506, 0.000000
07-25 22:05:09.300+0600 D/avoidrickshaw(32394): event-values: 0.218345, -0.084347, 10.176675, 0.000000
07-25 22:05:09.360+0600 D/avoidrickshaw(32394): event-values: 0.184846, -0.076570, 10.157533, 0.000000
07-25 22:05:09.420+0600 D/avoidrickshaw(32394): event-values: 0.169292, -0.075972, 10.159925, 0.000000
07-25 22:05:09.480+0600 D/avoidrickshaw(32394): event-values: 0.198604, -0.076570, 10.161720, 0.000000
07-25 22:05:09.540+0600 D/avoidrickshaw(32394): event-values: 0.218345, -0.063410, 10.165309, 0.000000
07-25 22:05:09.600+0600 D/avoidrickshaw(32394): event-values: 0.192622, -0.062213, 10.176076, 0.000000
07-25 22:05:09.660+0600 D/avoidrickshaw(32394): event-values: 0.186042, -0.101097, 10.172487, 0.000000
07-25 22:05:09.720+0600 D/avoidrickshaw(32394): event-values: 0.193819, -0.059821, 10.192227, 0.000000
07-25 22:05:09.780+0600 D/avoidrickshaw(32394): event-values: 0.187837, -0.075972, 10.168301, 0.000000
07-25 22:05:09.840+0600 D/avoidrickshaw(32394): event-values: 0.179462, -0.080160, 10.167104, 0.000000
07-25 22:05:09.910+0600 D/avoidrickshaw(32394): horizontal_acc: 24.000000, vertical_acc: -1.000000
07-25 22:05:09.910+0600 D/avoidrickshaw(32394): previous lat: 23.742101, previous long: 90.411688
07-25 22:05:09.910+0600 D/avoidrickshaw(32394): current lat: 23.742104, current long: 90.411684
07-25 22:05:09.920+0600 D/avoidrickshaw(32394): because step count did not update, distance not updated.
07-25 22:05:09.920+0600 D/avoidrickshaw(32394): event-values: 0.190229, -0.052044, 10.180862, 0.000000
07-25 22:05:09.960+0600 D/avoidrickshaw(32394): event-values: 0.193220, -0.066999, 10.190434, 0.000000
07-25 22:05:10.020+0600 D/avoidrickshaw(32394): event-values: 0.193220, -0.069392, 10.179665, 0.000000
07-25 22:05:10.080+0600 D/avoidrickshaw(32394): event-values: 0.179462, -0.078365, 10.174880, 0.000000
07-25 22:05:10.140+0600 D/avoidrickshaw(32394): event-values: 0.190229, -0.081954, 10.178469, 0.000000
07-25 22:05:10.201+0600 D/avoidrickshaw(32394): event-values: 0.192024, -0.084347, 10.173084, 0.000000
07-25 22:05:10.261+0600 D/avoidrickshaw(32394): event-values: 0.206979, -0.064606, 10.174880, 0.000000
07-25 22:05:10.321+0600 D/avoidrickshaw(32394): event-values: 0.200399, -0.088534, 10.162319, 0.000000
07-25 22:05:10.381+0600 D/avoidrickshaw(32394): event-values: 0.209970, -0.069392, 10.165309, 0.000000
07-25 22:05:10.441+0600 D/avoidrickshaw(32394): event-values: 0.180658, -0.079561, 10.175477, 0.000000
07-25 22:05:10.491+0600 D/avoidrickshaw(32394): event-values: 0.191426, -0.072981, 10.180264, 0.000000
07-25 22:05:10.551+0600 D/avoidrickshaw(32394): event-values: 0.210568, -0.082552, 10.171888, 0.000000
07-25 22:05:10.611+0600 D/avoidrickshaw(32394): event-values: 0.173480, -0.085543, 10.156934, 0.000000
07-25 22:05:10.671+0600 D/avoidrickshaw(32394): event-values: 0.185444, -0.078963, 10.165309, 0.000000
07-25 22:05:10.731+0600 D/avoidrickshaw(32394): event-values: 0.196810, -0.071186, 10.170094, 0.000000
07-25 22:05:10.791+0600 D/avoidrickshaw(32394): event-values: 0.215952, -0.068195, 10.162916, 0.000000
07-25 22:05:10.851+0600 D/avoidrickshaw(32394): event-values: 0.206381, -0.102891, 10.170094, 0.000000
07-25 22:05:10.911+0600 D/avoidrickshaw(32394): event-values: 0.229113, -0.070588, 10.182656, 0.000000
07-25 22:05:10.971+0600 D/avoidrickshaw(32394): event-values: 0.211167, -0.059821, 10.191031, 0.000000
07-25 22:05:11.031+0600 D/avoidrickshaw(32394): event-values: 0.206979, -0.071785, 10.165908, 0.000000
07-25 22:05:11.091+0600 D/avoidrickshaw(32394): event-values: 0.210568, -0.064008, 10.167702, 0.000000
07-25 22:05:11.151+0600 D/avoidrickshaw(32394): event-values: 0.220738, -0.075374, 10.153944, 0.000000
07-25 22:05:11.212+0600 D/avoidrickshaw(32394): event-values: 0.156730, -0.082552, 10.130613, 0.000000
07-25 22:05:11.272+0600 D/avoidrickshaw(32394): event-values: 0.201595, -0.067597, 10.202397, 0.000000
07-25 22:05:11.332+0600 D/avoidrickshaw(32394): event-values: 0.193819, -0.077169, 10.175477, 0.000000
07-25 22:05:11.392+0600 D/avoidrickshaw(32394): event-values: 0.207577, -0.065803, 10.176076, 0.000000
07-25 22:05:11.452+0600 D/avoidrickshaw(32394): event-values: 0.220738, -0.087338, 10.183254, 0.000000
07-25 22:05:11.512+0600 D/avoidrickshaw(32394): event-values: 0.199801, -0.082552, 10.174880, 0.000000
07-25 22:05:11.572+0600 D/avoidrickshaw(32394): event-values: 0.203390, -0.083749, 10.163515, 0.000000
07-25 22:05:11.632+0600 D/avoidrickshaw(32394): event-values: 0.202193, -0.087936, 10.182058, 0.000000
07-25 22:05:11.692+0600 D/avoidrickshaw(32394): event-values: 0.200399, -0.064008, 10.174880, 0.000000
07-25 22:05:11.752+0600 D/avoidrickshaw(32394): event-values: 0.192024, -0.068794, 10.162916, 0.000000
07-25 22:05:11.812+0600 D/avoidrickshaw(32394): event-values: 0.186042, -0.095115, 10.200004, 0.000000
07-25 22:05:11.872+0600 D/avoidrickshaw(32394): event-values: 0.188435, -0.079561, 10.174281, 0.000000
07-25 22:05:11.932+0600 D/avoidrickshaw(32394): event-values: 0.192622, -0.074776, 10.167702, 0.000000
07-25 22:05:11.992+0600 D/avoidrickshaw(32394): event-values: 0.195613, -0.071785, 10.189237, 0.000000
07-25 22:05:12.052+0600 D/avoidrickshaw(32394): event-values: 0.204586, -0.082552, 10.153345, 0.000000
07-25 22:05:12.112+0600 D/avoidrickshaw(32394): event-values: 0.197408, -0.085543, 10.169496, 0.000000
07-25 22:05:12.172+0600 D/avoidrickshaw(32394): event-values: 0.200997, -0.078963, 10.170094, 0.000000
07-25 22:05:12.233+0600 D/avoidrickshaw(32394): event-values: 0.200997, -0.071186, 10.176675, 0.000000
07-25 22:05:12.293+0600 D/avoidrickshaw(32394): event-values: 0.189033, -0.057428, 10.158132, 0.000000
07-25 22:05:12.353+0600 D/avoidrickshaw(32394): event-values: 0.203390, -0.049651, 10.160523, 0.000000
07-25 22:05:12.413+0600 D/avoidrickshaw(32394): event-values: 0.215952, -0.069990, 10.167702, 0.000000
07-25 22:05:12.473+0600 D/avoidrickshaw(32394): event-values: 0.204586, -0.071785, 10.162916, 0.000000
07-25 22:05:12.533+0600 D/avoidrickshaw(32394): event-values: 0.213559, -0.080758, 10.187442, 0.000000
07-25 22:05:12.593+0600 D/avoidrickshaw(32394): event-values: 0.189033, -0.086142, 10.169496, 0.000000
07-25 22:05:12.653+0600 D/avoidrickshaw(32394): event-values: 0.175274, -0.078963, 10.182058, 0.000000
07-25 22:05:12.713+0600 D/avoidrickshaw(32394): event-values: 0.195015, -0.072383, 10.171888, 0.000000
07-25 22:05:12.773+0600 D/avoidrickshaw(32394): event-values: 0.172283, -0.087338, 10.168897, 0.000000
07-25 22:05:12.833+0600 D/avoidrickshaw(32394): event-values: 0.218943, -0.065204, 10.197612, 0.000000
07-25 22:05:12.893+0600 D/avoidrickshaw(32394): event-values: 0.214158, -0.081954, 10.195219, 0.000000
07-25 22:05:12.953+0600 D/avoidrickshaw(32394): event-values: 0.199801, -0.092722, 10.161121, 0.000000
07-25 22:05:13.013+0600 D/avoidrickshaw(32394): event-values: 0.195613, -0.072383, 10.158729, 0.000000
07-25 22:05:13.073+0600 D/avoidrickshaw(32394): event-values: 0.212961, -0.075972, 10.191031, 0.000000
07-25 22:05:13.133+0600 D/avoidrickshaw(32394): event-values: 0.200399, -0.081356, 10.153345, 0.000000
07-25 22:05:13.193+0600 D/avoidrickshaw(32394): event-values: 0.192024, -0.077767, 10.156336, 0.000000
07-25 22:05:13.254+0600 D/avoidrickshaw(32394): event-values: 0.191426, -0.084945, 10.161121, 0.000000
07-25 22:05:13.314+0600 D/avoidrickshaw(32394): event-values: 0.211765, -0.073579, 10.158132, 0.000000
07-25 22:05:13.374+0600 D/avoidrickshaw(32394): event-values: 0.184846, -0.069392, 10.181459, 0.000000
07-25 22:05:13.434+0600 D/avoidrickshaw(32394): event-values: 0.184247, -0.076570, 10.167702, 0.000000
07-25 22:05:13.494+0600 D/avoidrickshaw(32394): event-values: 0.226122, -0.058624, 10.180862, 0.000000
07-25 22:05:13.554+0600 D/avoidrickshaw(32394): event-values: 0.257827, -0.092124, 10.179067, 0.000000
07-25 22:05:13.614+0600 D/avoidrickshaw(32394): event-values: 0.171087, -0.070588, 10.168897, 0.000000
07-25 22:05:13.674+0600 D/avoidrickshaw(32394): event-values: 0.183051, -0.071186, 10.159328, 0.000000
07-25 22:05:13.734+0600 D/avoidrickshaw(32394): event-values: 0.205783, -0.074178, 10.167104, 0.000000
07-25 22:05:13.794+0600 D/avoidrickshaw(32394): event-values: 0.198604, -0.069990, 10.169496, 0.000000
07-25 22:05:13.854+0600 D/avoidrickshaw(32394): event-values: 0.191426, -0.072383, 10.171290, 0.000000
07-25 22:05:13.904+0600 D/avoidrickshaw(32394): horizontal_acc: 24.000000, vertical_acc: -1.000000
07-25 22:05:13.904+0600 D/avoidrickshaw(32394): previous lat: 23.742101, previous long: 90.411688
07-25 22:05:13.904+0600 D/avoidrickshaw(32394): current lat: 23.742104, current long: 90.411684
07-25 22:05:13.904+0600 D/avoidrickshaw(32394): because step count did not update, distance not updated.
07-25 22:05:13.914+0600 D/avoidrickshaw(32394): event-values: 0.198604, -0.066999, 10.161720, 0.000000
07-25 22:05:13.974+0600 D/avoidrickshaw(32394): event-values: 0.242273, -0.075972, 10.220345, 0.000000
07-25 22:05:14.034+0600 D/avoidrickshaw(32394): event-values: 0.183051, -0.080758, 10.115059, 0.000000
07-25 22:05:14.094+0600 D/avoidrickshaw(32394): event-values: 0.220738, -0.074776, 10.160523, 0.000000
07-25 22:05:14.154+0600 D/avoidrickshaw(32394): event-values: 0.183649, -0.065204, 10.189835, 0.000000
07-25 22:05:14.214+0600 D/avoidrickshaw(32394): event-values: 0.193819, -0.074776, 10.133603, 0.000000
07-25 22:05:14.275+0600 D/avoidrickshaw(32394): event-values: 0.212961, -0.075374, 10.183852, 0.000000
07-25 22:05:14.335+0600 D/avoidrickshaw(32394): event-values: 0.193819, -0.053240, 10.188040, 0.000000
07-25 22:05:14.395+0600 D/avoidrickshaw(32394): event-values: 0.193220, -0.078365, 10.182656, 0.000000
07-25 22:05:14.455+0600 D/avoidrickshaw(32394): event-values: 0.216550, -0.082552, 10.185647, 0.000000
07-25 22:05:14.515+0600 D/avoidrickshaw(32394): event-values: 0.196211, -0.057428, 10.175477, 0.000000
07-25 22:05:14.575+0600 D/avoidrickshaw(32394): event-values: 0.198006, -0.064008, 10.178469, 0.000000
07-25 22:05:14.635+0600 D/avoidrickshaw(32394): event-values: 0.184846, -0.080758, 10.179665, 0.000000
07-25 22:05:14.695+0600 D/avoidrickshaw(32394): event-values: 0.160319, -0.084347, 10.177272, 0.000000
07-25 22:05:14.755+0600 D/avoidrickshaw(32394): event-values: 0.196211, -0.065204, 10.180862, 0.000000
07-25 22:05:14.815+0600 D/avoidrickshaw(32394): event-values: 0.208774, -0.070588, 10.172487, 0.000000
07-25 22:05:14.875+0600 D/avoidrickshaw(32394): event-values: 0.190229, -0.080160, 10.174281, 0.000000
07-25 22:05:14.935+0600 D/avoidrickshaw(32394): event-values: 0.192024, -0.078365, 10.188040, 0.000000
07-25 22:05:14.995+0600 D/avoidrickshaw(32394): event-values: 0.194417, -0.072383, 10.173084, 0.000000
07-25 22:05:15.055+0600 D/avoidrickshaw(32394): event-values: 0.196211, -0.069392, 10.180264, 0.000000
07-25 22:05:15.115+0600 D/avoidrickshaw(32394): event-values: 0.180658, -0.080160, 10.164711, 0.000000
07-25 22:05:15.175+0600 D/avoidrickshaw(32394): event-values: 0.212961, -0.063410, 10.182656, 0.000000
07-25 22:05:15.235+0600 D/avoidrickshaw(32394): event-values: 0.203390, -0.087936, 10.170692, 0.000000
07-25 22:05:15.296+0600 D/avoidrickshaw(32394): event-values: 0.180658, -0.046660, 10.162916, 0.000000
07-25 22:05:15.356+0600 D/avoidrickshaw(32394): event-values: 0.186640, -0.076570, 10.167104, 0.000000
07-25 22:05:15.416+0600 D/avoidrickshaw(32394): event-values: 0.199801, -0.074776, 10.176076, 0.000000
07-25 22:05:15.476+0600 D/avoidrickshaw(32394): event-values: 0.187238, -0.057428, 10.168301, 0.000000
07-25 22:05:15.536+0600 D/avoidrickshaw(32394): event-values: 0.178265, -0.089731, 10.176076, 0.000000
07-25 22:05:15.596+0600 D/avoidrickshaw(32394): event-values: 0.202193, -0.072383, 10.159328, 0.000000
07-25 22:05:15.656+0600 D/avoidrickshaw(32394): event-values: 0.200399, -0.066999, 10.173084, 0.000000
07-25 22:05:15.716+0600 D/avoidrickshaw(32394): event-values: 0.190828, -0.077767, 10.185050, 0.000000
07-25 22:05:15.776+0600 D/avoidrickshaw(32394): event-values: 0.192024, -0.059821, 10.174880, 0.000000
07-25 22:05:15.836+0600 D/avoidrickshaw(32394): event-values: 0.206381, -0.075972, 10.185050, 0.000000
07-25 22:05:15.896+0600 D/avoidrickshaw(32394): event-values: 0.219541, -0.080758, 10.182058, 0.000000
07-25 22:05:15.956+0600 D/avoidrickshaw(32394): event-values: 0.186042, -0.072383, 10.139585, 0.000000
07-25 22:05:16.016+0600 D/avoidrickshaw(32394): event-values: 0.189631, -0.079561, 10.197612, 0.000000
07-25 22:05:16.076+0600 D/avoidrickshaw(32394): event-values: 0.214158, -0.072383, 10.171888, 0.000000
07-25 22:05:16.136+0600 D/avoidrickshaw(32394): event-values: 0.190229, -0.072981, 10.168897, 0.000000
07-25 22:05:16.196+0600 D/avoidrickshaw(32394): event-values: 0.190828, -0.085543, 10.197612, 0.000000
07-25 22:05:16.256+0600 D/avoidrickshaw(32394): event-values: 0.198604, -0.061615, 10.176675, 0.000000
07-25 22:05:16.317+0600 D/avoidrickshaw(32394): event-values: 0.179462, -0.081954, 10.197014, 0.000000
07-25 22:05:16.377+0600 D/avoidrickshaw(32394): event-values: 0.205185, -0.068195, 10.194022, 0.000000
07-25 22:05:16.437+0600 D/avoidrickshaw(32394): event-values: 0.207577, -0.084347, 10.182058, 0.000000
07-25 22:05:16.497+0600 D/avoidrickshaw(32394): event-values: 0.180060, -0.077767, 10.173683, 0.000000
07-25 22:05:16.557+0600 D/avoidrickshaw(32394): event-values: 0.196211, -0.070588, 10.133006, 0.000000
07-25 22:05:16.617+0600 D/avoidrickshaw(32394): event-values: 0.190229, -0.092124, 10.147961, 0.000000
07-25 22:05:16.677+0600 D/avoidrickshaw(32394): event-values: 0.183649, -0.072981, 10.158132, 0.000000
07-25 22:05:16.737+0600 D/avoidrickshaw(32394): event-values: 0.192024, -0.063410, 10.167702, 0.000000
07-25 22:05:16.797+0600 D/avoidrickshaw(32394): event-values: 0.193819, -0.099302, 10.184451, 0.000000
07-25 22:05:16.857+0600 D/avoidrickshaw(32394): event-values: 0.215354, -0.066401, 10.162916, 0.000000
07-25 22:05:16.917+0600 D/avoidrickshaw(32394): event-values: 0.160917, -0.071785, 10.193424, 0.000000
07-25 22:05:16.977+0600 D/avoidrickshaw(32394): event-values: 0.178863, -0.067597, 10.196415, 0.000000
07-25 22:05:17.037+0600 D/avoidrickshaw(32394): event-values: 0.213559, -0.078963, 10.164113, 0.000000
07-25 22:05:17.097+0600 D/avoidrickshaw(32394): event-values: 0.215952, -0.078963, 10.179067, 0.000000
07-25 22:05:17.157+0600 D/avoidrickshaw(32394): event-values: 0.223729, -0.083749, 10.153345, 0.000000
07-25 22:05:17.217+0600 D/avoidrickshaw(32394): event-values: 0.172881, -0.083749, 10.170094, 0.000000
07-25 22:05:17.277+0600 D/avoidrickshaw(32394): event-values: 0.183051, -0.068794, 10.164113, 0.000000
07-25 22:05:17.338+0600 D/avoidrickshaw(32394): event-values: 0.217149, -0.061017, 10.186246, 0.000000
07-25 22:05:17.398+0600 D/avoidrickshaw(32394): event-values: 0.190229, -0.068195, 10.176675, 0.000000
07-25 22:05:17.458+0600 D/avoidrickshaw(32394): event-values: 0.174676, -0.086740, 10.161121, 0.000000
07-25 22:05:17.518+0600 D/avoidrickshaw(32394): event-values: 0.211765, -0.084347, 10.171888, 0.000000
07-25 22:05:17.578+0600 D/avoidrickshaw(32394): event-values: 0.193220, -0.092722, 10.176076, 0.000000
07-25 22:05:17.638+0600 D/avoidrickshaw(32394): event-values: 0.186042, -0.055633, 10.194620, 0.000000
07-25 22:05:17.698+0600 D/avoidrickshaw(32394): event-values: 0.180060, -0.081356, 10.185647, 0.000000
07-25 22:05:17.758+0600 D/avoidrickshaw(32394): event-values: 0.206979, -0.089133, 10.179665, 0.000000
07-25 22:05:17.818+0600 D/avoidrickshaw(32394): event-values: 0.186640, -0.069392, 10.177272, 0.000000
07-25 22:05:17.878+0600 D/avoidrickshaw(32394): event-values: 0.195015, -0.098704, 10.183254, 0.000000
07-25 22:05:17.908+0600 D/avoidrickshaw(32394): horizontal_acc: 32.000000, vertical_acc: -1.000000
07-25 22:05:17.908+0600 D/avoidrickshaw(32394): previous lat: 23.742101, previous long: 90.411688
07-25 22:05:17.908+0600 D/avoidrickshaw(32394): current lat: 23.742104, current long: 90.411684
07-25 22:05:17.908+0600 D/avoidrickshaw(32394): because step count did not update, distance not updated.
07-25 22:05:17.938+0600 D/avoidrickshaw(32394): event-values: 0.210568, -0.080758, 10.185050, 0.000000
07-25 22:05:17.998+0600 D/avoidrickshaw(32394): event-values: 0.192622, -0.076570, 10.178469, 0.000000
07-25 22:05:18.058+0600 D/avoidrickshaw(32394): event-values: 0.169890, -0.081954, 10.166506, 0.000000
07-25 22:05:18.118+0600 D/avoidrickshaw(32394): event-values: 0.196810, -0.068195, 10.177871, 0.000000
07-25 22:05:18.178+0600 D/avoidrickshaw(32394): event-values: 0.199202, -0.082552, 10.186844, 0.000000
07-25 22:05:18.238+0600 D/avoidrickshaw(32394): event-values: 0.198604, -0.066999, 10.159328, 0.000000
07-25 22:05:18.298+0600 D/avoidrickshaw(32394): event-values: 0.166899, -0.096909, 10.190434, 0.000000
07-25 22:05:18.358+0600 D/avoidrickshaw(32394): event-values: 0.190828, -0.090927, 10.156336, 0.000000
07-25 22:05:18.419+0600 D/avoidrickshaw(32394): event-values: 0.214158, -0.083749, 10.176675, 0.000000
07-25 22:05:18.479+0600 D/avoidrickshaw(32394): event-values: 0.188435, -0.090329, 10.171290, 0.000000
07-25 22:05:18.539+0600 D/avoidrickshaw(32394): event-values: 0.181256, -0.066401, 10.168301, 0.000000
07-25 22:05:18.599+0600 D/avoidrickshaw(32394): event-values: 0.191426, -0.075972, 10.162319, 0.000000
07-25 22:05:18.659+0600 D/avoidrickshaw(32394): event-values: 0.215952, -0.083749, 10.196415, 0.000000
07-25 22:05:18.719+0600 D/avoidrickshaw(32394): event-values: 0.193220, -0.083151, 10.138988, 0.000000
07-25 22:05:18.779+0600 D/avoidrickshaw(32394): event-values: 0.203988, -0.084347, 10.163515, 0.000000
07-25 22:05:18.839+0600 D/avoidrickshaw(32394): event-values: 0.201595, -0.071186, 10.188040, 0.000000
07-25 22:05:18.899+0600 D/avoidrickshaw(32394): event-values: 0.209970, -0.089731, 10.176076, 0.000000
07-25 22:05:18.959+0600 D/avoidrickshaw(32394): event-values: 0.193220, -0.089133, 10.170692, 0.000000
07-25 22:05:19.019+0600 D/avoidrickshaw(32394): event-values: 0.180658, -0.078365, 10.165908, 0.000000
07-25 22:05:19.079+0600 D/avoidrickshaw(32394): event-values: 0.179462, -0.074776, 10.172487, 0.000000
07-25 22:05:19.139+0600 D/avoidrickshaw(32394): event-values: 0.204586, -0.070588, 10.144970, 0.000000
07-25 22:05:19.199+0600 D/avoidrickshaw(32394): event-values: 0.191426, -0.080758, 10.189237, 0.000000
07-25 22:05:19.259+0600 D/avoidrickshaw(32394): event-values: 0.180060, -0.089133, 10.167104, 0.000000
07-25 22:05:19.319+0600 D/avoidrickshaw(32394): event-values: 0.215354, -0.075374, 10.204191, 0.000000
07-25 22:05:19.379+0600 D/avoidrickshaw(32394): event-values: 0.207577, -0.075374, 10.176076, 0.000000
07-25 22:05:19.440+0600 D/avoidrickshaw(32394): event-values: 0.192024, -0.079561, 10.164711, 0.000000
07-25 22:05:19.500+0600 D/avoidrickshaw(32394): event-values: 0.198604, -0.069990, 10.191629, 0.000000
07-25 22:05:19.560+0600 D/avoidrickshaw(32394): event-values: 0.201595, -0.079561, 10.179665, 0.000000
07-25 22:05:19.620+0600 D/avoidrickshaw(32394): event-values: 0.185444, -0.059222, 10.185647, 0.000000
07-25 22:05:19.680+0600 D/avoidrickshaw(32394): event-values: 0.223729, -0.075972, 10.201201, 0.000000
07-25 22:05:19.740+0600 D/avoidrickshaw(32394): event-values: 0.183051, -0.083749, 10.203594, 0.000000
07-25 22:05:19.800+0600 D/avoidrickshaw(32394): event-values: 0.227318, -0.072383, 10.170692, 0.000000
07-25 22:05:19.860+0600 D/avoidrickshaw(32394): event-values: 0.186640, -0.080758, 10.193424, 0.000000
07-25 22:05:19.920+0600 D/avoidrickshaw(32394): event-values: 0.190828, -0.066401, 10.159925, 0.000000
07-25 22:05:19.960+0600 I/Tizen::Net::Wifi( 1305): (941) > The background scan result updated.
07-25 22:05:19.980+0600 D/avoidrickshaw(32394): event-values: 0.227318, -0.077169, 10.195219, 0.000000
07-25 22:05:20.040+0600 D/avoidrickshaw(32394): event-values: 0.200399, -0.084347, 10.165908, 0.000000
07-25 22:05:20.100+0600 D/avoidrickshaw(32394): event-values: 0.205185, -0.068794, 10.163515, 0.000000
07-25 22:05:20.160+0600 D/avoid
