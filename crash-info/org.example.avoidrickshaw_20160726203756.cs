S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPD6
Build-Date: 2016.04.28 20:23:28

Crash Information
Process Name: avoidrickshaw
PID: 14981
Date: 2016-07-26 20:37:56+0600
Executable File Path: /opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 14981, uid 5000)

Register Information
r0   = 0x000001e0, r1   = 0xb872dfb0
r2   = 0x00000001, r3   = 0x00000005
r4   = 0xb6ab752d, r5   = 0xb60326ec
r6   = 0xb601fe30, r7   = 0x00000001
r8   = 0x00000005, r9   = 0x00000000
r10  = 0xb8777320, fp   = 0x00000000
ip   = 0x00000001, sp   = 0xbe81f188
lr   = 0xb6018a17, pc   = 0xb6ab7546
cpsr = 0x600d0030

Memory Information
MemTotal:   730440 KB
MemFree:     44736 KB
Buffers:     46352 KB
Cached:     275548 KB
VmPeak:     117380 KB
VmSize:     117376 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24884 KB
VmRSS:       24884 KB
VmData:      42980 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36364 KB
VmPTE:          86 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 14981 TID = 14981
14981 14987 17294 17301 17464 

Maps Information
b00bd000 b08bc000 rw-p [stack:17464]
b12df000 b12f0000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b1301000 b1b00000 rw-p [stack:17301]
b1c1b000 b1c20000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b1c8c000 b1c94000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.49
b1ca4000 b1ca6000 r-xp /usr/lib/liblbs-agps.so.0.1.0
b1cb6000 b1cc4000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
b1cdb000 b1cdd000 r-xp /usr/lib/location/module/libwps.so.0.6.8_9
b1ced000 b1cf0000 r-xp /usr/lib/location/module/libgps.so.0.6.8_9
b1d01000 b2500000 rw-p [stack:17294]
b257c000 b2584000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2595000 b2596000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b25a6000 b25ba000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b25ce000 b25cf000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b25df000 b25e2000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b25f3000 b25f4000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2604000 b2606000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2616000 b2618000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2628000 b2638000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2648000 b2654000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b28a4000 b28a6000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b28b6000 b28bc000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b28cc000 b28e0000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b28f0000 b290a000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b291a000 b2920000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
b2930000 b2937000 r-xp /usr/lib/libeventsystem.so.0.0.1
b2947000 b296a000 r-xp /usr/lib/libSLP-location-product.so.0.9.0
b297b000 b2992000 r-xp /usr/lib/libSLP-location.so.0.11.5_5
b29a2000 b29a9000 r-xp /usr/lib/libefl-extension.so.0.1.0
b29ba000 b29c2000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b29d2000 b29d6000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
b29e7000 b29f6000 r-xp /usr/lib/libcapi-location-manager.so.0.6.1_3
b2a06000 b2a0d000 r-xp /usr/lib/libcapi-appfw-preference.so.0.3.1.0
b2a1f000 b2a25000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2a35000 b2a3d000 r-xp /opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw
b2b5e000 b2c41000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2c78000 b2ca0000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2cb2000 b34b1000 rw-p [stack:14987]
b34b1000 b34b3000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b34c3000 b34cd000 r-xp /lib/libnss_files-2.20-2014.11.so
b34de000 b34e7000 r-xp /lib/libnss_nis-2.20-2014.11.so
b34f8000 b3509000 r-xp /lib/libnsl-2.20-2014.11.so
b351c000 b3522000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3533000 b3534000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b355c000 b3563000 r-xp /usr/lib/libminizip.so.1.0.0
b3573000 b3578000 r-xp /usr/lib/libstorage.so.0.1
b3588000 b35dd000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b35f3000 b3607000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b3617000 b365b000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b366b000 b3673000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3683000 b36b3000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b36c6000 b377f000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3793000 b37e7000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b37f8000 b3813000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3823000 b38e4000 r-xp /usr/lib/libprotobuf.so.9.0.1
b38f7000 b3909000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3919000 b391d000 r-xp /usr/lib/libogg.so.0.7.1
b392d000 b394f000 r-xp /usr/lib/libvorbis.so.0.4.3
b395f000 b3a43000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b3a5f000 b3a6c000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3a7d000 b3ac0000 r-xp /usr/lib/libsndfile.so.1.0.25
b3ad5000 b3b1c000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3b2d000 b3b33000 r-xp /usr/lib/libjson-c.so.2.0.1
b3b44000 b3b4b000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3b5b000 b3b9b000 r-xp /usr/lib/libmdm.so.1.2.10
b3bab000 b3bb3000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3bc2000 b3bd2000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3bf3000 b3c53000 r-xp /usr/lib/libasound.so.2.0.0
b3c65000 b3c9b000 r-xp /usr/lib/libpulse.so.0.16.2
b3cac000 b3caf000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3cbf000 b3cc2000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3cd2000 b3cd7000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3ce7000 b3ce8000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3cf8000 b3d03000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3d17000 b3d1e000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3d2e000 b3d34000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3d44000 b3d49000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3d59000 b3d74000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3d84000 b3d8b000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3d9b000 b3d9e000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3daf000 b3ddd000 r-xp /usr/lib/libidn.so.11.5.44
b3ded000 b3e03000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3e14000 b3e1e000 r-xp /usr/lib/libcares.so.2.1.0
b3e2e000 b3e38000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3e48000 b3e4a000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3e5a000 b3e5b000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3e6b000 b3e6f000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3e80000 b3ea8000 r-xp /usr/lib/libui-extension.so.0.1.0
b3eb9000 b3ee2000 r-xp /usr/lib/libturbojpeg.so
b3f02000 b3f08000 r-xp /usr/lib/libgif.so.4.1.6
b3f18000 b3f5e000 r-xp /usr/lib/libcurl.so.4.3.0
b3f6f000 b3f90000 r-xp /usr/lib/libexif.so.12.3.3
b3fab000 b3fc0000 r-xp /usr/lib/libtts.so
b3fd1000 b3fd9000 r-xp /usr/lib/libfeedback.so.0.1.4
b3fe9000 b40a9000 r-xp /usr/lib/libdali-core.so.0.0.0
b40b4000 b41a7000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b41c7000 b42a1000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b42b8000 b42ba000 r-xp /usr/lib/libboost_system.so.1.51.0
b42ca000 b42d0000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b42e0000 b4303000 r-xp /usr/lib/libboost_thread.so.1.51.0
b4314000 b4316000 r-xp /usr/lib/libappsvc.so.0.1.0
b4326000 b4328000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4339000 b433e000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4355000 b4357000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b4367000 b436e000 r-xp /usr/lib/libsensord-share.so
b437e000 b4396000 r-xp /usr/lib/libsensor.so.1.1.0
b43a7000 b43aa000 r-xp /usr/lib/libXv.so.1.0.0
b43ba000 b43bf000 r-xp /usr/lib/libutilX.so.1.1.0
b43cf000 b43d4000 r-xp /usr/lib/libappcore-common.so.1.1
b43e4000 b43eb000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b43fe000 b4402000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b4413000 b44dd000 r-xp /usr/lib/libCOREGL.so.4.0
b44f4000 b44f7000 r-xp /usr/lib/libuuid.so.1.3.0
b4508000 b451f000 r-xp /usr/lib/libblkid.so.1.1.0
b4530000 b4532000 r-xp /usr/lib/libXau.so.6.0.0
b4542000 b4545000 r-xp /usr/lib/libEGL.so.1.4
b454d000 b4553000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4563000 b4565000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4576000 b4584000 r-xp /usr/lib/libGLESv2.so.2.0
b458d000 b45ef000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4604000 b461c000 r-xp /usr/lib/libmount.so.1.1.0
b462d000 b4641000 r-xp /usr/lib/libxcb.so.1.1.0
b4652000 b4659000 r-xp /lib/libcrypt-2.20-2014.11.so
b4691000 b46a2000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b46b3000 b46b5000 r-xp /usr/lib/libiri.so
b46c5000 b46d0000 r-xp /usr/lib/libgpg-error.so.0.15.0
b46e1000 b46f6000 r-xp /lib/libexpat.so.1.5.2
b4708000 b47c6000 r-xp /usr/lib/libcairo.so.2.11200.14
b47d9000 b47e1000 r-xp /usr/lib/libdrm.so.2.4.0
b47f1000 b47f4000 r-xp /usr/lib/libdri2.so.0.0.0
b4805000 b4853000 r-xp /usr/lib/libssl.so.1.0.0
b4868000 b4874000 r-xp /usr/lib/libeeze.so.1.13.0
b4884000 b488d000 r-xp /usr/lib/libethumb.so.1.13.0
b489d000 b48a0000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b48b0000 b4a67000 r-xp /usr/lib/libcrypto.so.1.0.0
b56be000 b56c7000 r-xp /usr/lib/libXi.so.6.1.0
b56d7000 b56d9000 r-xp /usr/lib/libXgesture.so.7.0.0
b56e9000 b56ed000 r-xp /usr/lib/libXtst.so.6.1.0
b56fd000 b5703000 r-xp /usr/lib/libXrender.so.1.3.0
b5713000 b5719000 r-xp /usr/lib/libXrandr.so.2.2.0
b572a000 b572c000 r-xp /usr/lib/libXinerama.so.1.0.0
b573c000 b573f000 r-xp /usr/lib/libXfixes.so.3.1.0
b574f000 b575a000 r-xp /usr/lib/libXext.so.6.4.0
b576a000 b576c000 r-xp /usr/lib/libXdamage.so.1.1.0
b577c000 b577e000 r-xp /usr/lib/libXcomposite.so.1.0.0
b578f000 b5871000 r-xp /usr/lib/libX11.so.6.3.0
b5884000 b588b000 r-xp /usr/lib/libXcursor.so.1.0.2
b589b000 b58b3000 r-xp /usr/lib/libudev.so.1.6.0
b58b5000 b58b8000 r-xp /lib/libattr.so.1.1.0
b58c8000 b58e8000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58ea000 b58ef000 r-xp /usr/lib/libffi.so.6.0.2
b58ff000 b5917000 r-xp /lib/libz.so.1.2.8
b5927000 b5929000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5939000 b5a0e000 r-xp /usr/lib/libxml2.so.2.9.2
b5a23000 b5abe000 r-xp /usr/lib/libstdc++.so.6.0.20
b5ada000 b5add000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5aed000 b5b06000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b17000 b5b28000 r-xp /lib/libresolv-2.20-2014.11.so
b5b3c000 b5bb6000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5bcb000 b5bcd000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bdd000 b5be4000 r-xp /usr/lib/libembryo.so.1.13.0
b5bf4000 b5c0c000 r-xp /usr/lib/libpng12.so.0.50.0
b5c1d000 b5c40000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c61000 b5c75000 r-xp /usr/lib/libector.so.1.13.0
b5c86000 b5c9e000 r-xp /usr/lib/liblua-5.1.so
b5caf000 b5d06000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d1a000 b5d42000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d53000 b5d66000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d77000 b5dae000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5dbf000 b5dcd000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5ddd000 b5de5000 r-xp /usr/lib/libtbm.so.1.0.0
b5df5000 b5e02000 r-xp /usr/lib/libeio.so.1.13.0
b5e12000 b5e14000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e24000 b5e29000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e39000 b5e50000 r-xp /usr/lib/libefreet.so.1.13.0
b5e62000 b5e82000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e92000 b5eb2000 r-xp /usr/lib/libecore_con.so.1.13.0
b5eb4000 b5eba000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5eca000 b5edb000 r-xp /usr/lib/libemotion.so.1.13.0
b5eec000 b5ef3000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f03000 b5f12000 r-xp /usr/lib/libeo.so.1.13.0
b5f23000 b5f35000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f46000 b5f4b000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f5b000 b5f74000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f84000 b5fa1000 r-xp /usr/lib/libeet.so.1.13.0
b5fba000 b6002000 r-xp /usr/lib/libeina.so.1.13.0
b6013000 b6023000 r-xp /usr/lib/libefl.so.1.13.0
b6034000 b6119000 r-xp /usr/lib/libicuuc.so.51.1
b6136000 b6276000 r-xp /usr/lib/libicui18n.so.51.1
b628d000 b62c5000 r-xp /usr/lib/libecore_x.so.1.13.0
b62d7000 b62da000 r-xp /lib/libcap.so.2.21
b62ea000 b6313000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6324000 b632b000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b633d000 b6374000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6385000 b6470000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6483000 b64fc000 r-xp /usr/lib/libsqlite3.so.0.8.6
b650e000 b6513000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6523000 b652d000 r-xp /usr/lib/libvconf.so.0.2.45
b653d000 b653f000 r-xp /usr/lib/libvasum.so.0.3.1
b654f000 b6551000 r-xp /usr/lib/libttrace.so.1.1
b6561000 b6564000 r-xp /usr/lib/libiniparser.so.0
b6574000 b659a000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65aa000 b65af000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65c0000 b65d7000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65e8000 b6653000 r-xp /lib/libm-2.20-2014.11.so
b6664000 b666a000 r-xp /lib/librt-2.20-2014.11.so
b667b000 b6688000 r-xp /usr/lib/libunwind.so.8.0.1
b66be000 b67e2000 r-xp /lib/libc-2.20-2014.11.so
b67f7000 b6810000 r-xp /lib/libgcc_s-4.9.so.1
b6820000 b6902000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6913000 b693d000 r-xp /usr/lib/libdbus-1.so.3.8.12
b694e000 b698a000 r-xp /usr/lib/libsystemd.so.0.4.0
b698c000 b6a0e000 r-xp /usr/lib/libedje.so.1.13.0
b6a21000 b6a3f000 r-xp /usr/lib/libecore.so.1.13.0
b6a5f000 b6be6000 r-xp /usr/lib/libevas.so.1.13.0
b6c1b000 b6c2f000 r-xp /lib/libpthread-2.20-2014.11.so
b6c43000 b6e78000 r-xp /usr/lib/libelementary.so.1.13.0
b6ea6000 b6eaa000 r-xp /usr/lib/libsmack.so.1.0.0
b6eba000 b6ec1000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6ed1000 b6ed3000 r-xp /usr/lib/libdlog.so.0.0.0
b6ee3000 b6ee6000 r-xp /usr/lib/libbundle.so.0.1.22
b6ef6000 b6ef8000 r-xp /lib/libdl-2.20-2014.11.so
b6f09000 b6f21000 r-xp /usr/lib/libaul.so.0.1.0
b6f35000 b6f3a000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f4b000 b6f58000 r-xp /usr/lib/liblptcp.so
b6f6a000 b6f6e000 r-xp /usr/lib/libsys-assert.so
b6f7f000 b6f9f000 r-xp /lib/ld-2.20-2014.11.so
b6fb0000 b6fb5000 r-xp /usr/bin/launchpad-loader
b855c000 b8880000 rw-p [heap]
be7ff000 be820000 rw-p [stack]
be7ff000 be820000 rw-p [stack]
End of Maps Information

Callstack Information (PID:14981)
Call Stack Count: 1
 0: (0xb6ab7546) [/usr/lib/libevas.so.1] + 0x58546
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
07-25 22:04:35.076+0600 D/avoidrickshaw(32394): event-values: 0.205783, -0.085543, 10.158729, 0.000000
07-25 22:04:35.136+0600 D/avoidrickshaw(32394): event-values: 0.250648, -0.090329, 10.155140, 0.000000
07-25 22:04:35.196+0600 D/avoidrickshaw(32394): event-values: 0.162712, -0.097508, 10.144372, 0.000000
07-25 22:04:35.256+0600 D/avoidrickshaw(32394): event-values: 0.200997, -0.069990, 10.178469, 0.000000
07-25 22:04:35.317+0600 D/avoidrickshaw(32394): event-values: 0.212363, -0.075972, 10.188639, 0.000000
07-25 22:04:35.377+0600 D/avoidrickshaw(32394): event-values: 0.196810, -0.079561, 10.164113, 0.000000
07-25 22:04:35.437+0600 D/avoidrickshaw(32394): event-values: 0.181855, -0.083151, 10.173683, 0.000000
07-25 22:04:35.497+0600 D/avoidrickshaw(32394): event-values: 0.196211, -0.081954, 10.170692, 0.000000
07-25 22:04:35.557+0600 D/avoidrickshaw(32394): event-values: 0.215952, -0.096311, 10.160523, 0.000000
07-25 22:04:35.617+0600 D/avoidrickshaw(32394): event-values: 0.196211, -0.102891, 10.164711, 0.000000
07-25 22:04:35.677+0600 D/avoidrickshaw(32394): event-values: 0.191426, -0.076570, 10.161720, 0.000000
07-25 22:04:35.737+0600 D/avoidrickshaw(32394): event-values: 0.197408, -0.085543, 10.167702, 0.000000
07-25 22:04:35.797+0600 D/avoidrickshaw(32394): event-values: 0.192622, -0.076570, 10.158729, 0.000000
07-25 22:04:35.857+0600 D/avoidrickshaw(32394): event-values: 0.207577, -0.074776, 10.165908, 0.000000
07-25 22:04:35.917+0600 D/avoidrickshaw(32394): event-values: 0.190229, -0.083151, 10.151550, 0.000000
07-25 22:04:35.977+0600 D/avoidrickshaw(32394): event-values: 0.186640, -0.084945, 10.152148, 0.000000
07-25 22:04:36.037+0600 D/avoidrickshaw(32394): event-values: 0.186640, -0.068195, 10.156934, 0.000000
07-25 22:04:36.097+0600 D/avoidrickshaw(32394): event-values: 0.187238, -0.084945, 10.152148, 0.000000
07-25 22:04:36.157+0600 D/avoidrickshaw(32394): event-values: 0.201595, -0.085543, 10.173084, 0.000000
07-25 22:04:36.217+0600 D/avoidrickshaw(32394): event-values: 0.195613, -0.087338, 10.177272, 0.000000
07-25 22:04:36.277+0600 D/avoidrickshaw(32394): event-values: 0.193220, -0.069990, 10.160523, 0.000000
07-25 22:04:36.338+0600 D/avoidrickshaw(32394): event-values: 0.204586, -0.055035, 10.157533, 0.000000
07-25 22:04:36.398+0600 D/avoidrickshaw(32394): event-values: 0.166899, -0.087338, 10.176076, 0.000000
07-25 22:04:36.458+0600 D/avoidrickshaw(32394): event-values: 0.144168, -0.083749, 10.128819, 0.000000
07-25 22:04:36.518+0600 D/avoidrickshaw(32394): event-values: 0.207577, -0.098704, 10.165908, 0.000000
07-25 22:04:36.578+0600 D/avoidrickshaw(32394): event-values: 0.198604, -0.070588, 10.174281, 0.000000
07-25 22:04:36.638+0600 D/avoidrickshaw(32394): event-values: 0.181855, -0.071186, 10.156934, 0.000000
07-25 22:04:36.698+0600 D/avoidrickshaw(32394): event-values: 0.178863, -0.081954, 10.185050, 0.000000
07-25 22:04:36.758+0600 D/avoidrickshaw(32394): event-values: 0.204586, -0.073579, 10.146765, 0.000000
07-25 22:04:36.818+0600 D/avoidrickshaw(32394): event-values: 0.228515, -0.087936, 10.157533, 0.000000
07-25 22:04:36.878+0600 D/avoidrickshaw(32394): event-values: 0.169292, -0.089133, 10.175477, 0.000000
07-25 22:04:36.878+0600 I/Tizen::Net::Wifi( 1305): (941) > The background scan result updated.
07-25 22:04:36.938+0600 D/avoidrickshaw(32394): event-values: 0.199801, -0.078365, 10.156336, 0.000000
07-25 22:04:36.998+0600 D/avoidrickshaw(32394): event-values: 0.183051, -0.084347, 10.159328, 0.000000
07-25 22:04:37.058+0600 D/avoidrickshaw(32394): event-values: 0.189631, -0.075374, 10.156336, 0.000000
07-25 22:04:37.118+0600 D/avoidrickshaw(32394): event-values: 0.212363, -0.072981, 10.172487, 0.000000
07-25 22:04:37.178+0600 D/avoidrickshaw(32394): event-values: 0.170489, -0.083749, 10.162319, 0.000000
07-25 22:04:37.238+0600 D/avoidrickshaw(32394): event-values: 0.194417, -0.077169, 10.164711, 0.000000
07-25 22:04:37.298+0600 D/avoidrickshaw(32394): event-values: 0.202193, -0.074178, 10.171290, 0.000000
07-25 22:04:37.358+0600 D/avoidrickshaw(32394): event-values: 0.174078, -0.063410, 10.153944, 0.000000
07-25 22:04:37.419+0600 D/avoidrickshaw(32394): event-values: 0.208176, -0.075374, 10.186844, 0.000000
07-25 22:04:37.479+0600 D/avoidrickshaw(32394): event-values: 0.163908, -0.075374, 10.172487, 0.000000
07-25 22:04:37.539+0600 D/avoidrickshaw(32394): event-values: 0.196211, -0.083749, 10.138390, 0.000000
07-25 22:04:37.599+0600 D/avoidrickshaw(32394): event-values: 0.193819, -0.079561, 10.170692, 0.000000
07-25 22:04:37.659+0600 D/avoidrickshaw(32394): event-values: 0.187238, -0.074178, 10.162916, 0.000000
07-25 22:04:37.719+0600 D/avoidrickshaw(32394): event-values: 0.200399, -0.068794, 10.146765, 0.000000
07-25 22:04:37.779+0600 D/avoidrickshaw(32394): event-values: 0.221336, -0.083749, 10.159925, 0.000000
07-25 22:04:37.839+0600 D/avoidrickshaw(32394): event-values: 0.179462, -0.072981, 10.173683, 0.000000
07-25 22:04:37.909+0600 D/avoidrickshaw(32394): horizontal_acc: 12.000000, vertical_acc: -1.000000
07-25 22:04:37.909+0600 D/avoidrickshaw(32394): previous lat: 23.742152, previous long: 90.411655
07-25 22:04:37.909+0600 D/avoidrickshaw(32394): current lat: 23.742152, current long: 90.411655
07-25 22:04:37.909+0600 D/avoidrickshaw(32394): because step count did not update, distance not updated.
07-25 22:04:37.909+0600 D/avoidrickshaw(32394): event-values: 0.194417, -0.072981, 10.154541, 0.000000
07-25 22:04:37.959+0600 D/avoidrickshaw(32394): event-values: 0.190229, -0.083749, 10.140782, 0.000000
07-25 22:04:38.019+0600 D/avoidrickshaw(32394): event-values: 0.197408, -0.075374, 10.160523, 0.000000
07-25 22:04:38.079+0600 D/avoidrickshaw(32394): event-values: 0.170489, -0.084945, 10.178469, 0.000000
07-25 22:04:38.139+0600 D/avoidrickshaw(32394): event-values: 0.201595, -0.071785, 10.190434, 0.000000
07-25 22:04:38.199+0600 D/avoidrickshaw(32394): event-values: 0.198604, -0.074178, 10.155738, 0.000000
07-25 22:04:38.259+0600 D/avoidrickshaw(32394): event-values: 0.184247, -0.068794, 10.180862, 0.000000
07-25 22:04:38.319+0600 D/avoidrickshaw(32394): event-values: 0.175274, -0.084945, 10.183254, 0.000000
07-25 22:04:38.379+0600 D/avoidrickshaw(32394): event-values: 0.220140, -0.062213, 10.186246, 0.000000
07-25 22:04:38.440+0600 D/avoidrickshaw(32394): event-values: 0.203988, -0.090927, 10.178469, 0.000000
07-25 22:04:38.500+0600 D/avoidrickshaw(32394): event-values: 0.197408, -0.081356, 10.166506, 0.000000
07-25 22:04:38.560+0600 D/avoidrickshaw(32394): event-values: 0.198006, -0.082552, 10.170692, 0.000000
07-25 22:04:38.620+0600 D/avoidrickshaw(32394): event-values: 0.185444, -0.086740, 10.162319, 0.000000
07-25 22:04:38.680+0600 D/avoidrickshaw(32394): event-values: 0.210568, -0.075374, 10.171888, 0.000000
07-25 22:04:38.740+0600 D/avoidrickshaw(32394): event-values: 0.187238, -0.075374, 10.155140, 0.000000
07-25 22:04:38.800+0600 D/avoidrickshaw(32394): event-values: 0.181256, -0.086740, 10.164711, 0.000000
07-25 22:04:38.860+0600 D/avoidrickshaw(32394): event-values: 0.196810, -0.064606, 10.177272, 0.000000
07-25 22:04:38.920+0600 D/avoidrickshaw(32394): event-values: 0.199202, -0.061017, 10.150353, 0.000000
07-25 22:04:38.980+0600 D/avoidrickshaw(32394): event-values: 0.197408, -0.081954, 10.162319, 0.000000
07-25 22:04:39.040+0600 D/avoidrickshaw(32394): event-values: 0.184846, -0.064606, 10.168897, 0.000000
07-25 22:04:39.100+0600 D/avoidrickshaw(32394): event-values: 0.212961, -0.074178, 10.185647, 0.000000
07-25 22:04:39.160+0600 D/avoidrickshaw(32394): event-values: 0.197408, -0.083749, 10.173683, 0.000000
07-25 22:04:39.220+0600 D/avoidrickshaw(32394): event-values: 0.188435, -0.066401, 10.168897, 0.000000
07-25 22:04:39.280+0600 D/avoidrickshaw(32394): event-values: 0.190828, -0.087338, 10.183254, 0.000000
07-25 22:04:39.340+0600 D/avoidrickshaw(32394): event-values: 0.230907, -0.066401, 10.202397, 0.000000
07-25 22:04:39.400+0600 D/avoidrickshaw(32394): event-values: 0.190229, -0.071785, 10.158729, 0.000000
07-25 22:04:39.461+0600 D/avoidrickshaw(32394): event-values: 0.200997, -0.078963, 10.159328, 0.000000
07-25 22:04:39.521+0600 D/avoidrickshaw(32394): event-values: 0.160917, -0.095115, 10.150353, 0.000000
07-25 22:04:39.581+0600 D/avoidrickshaw(32394): event-values: 0.199801, -0.059821, 10.171888, 0.000000
07-25 22:04:39.641+0600 D/avoidrickshaw(32394): event-values: 0.196810, -0.078963, 10.175477, 0.000000
07-25 22:04:39.701+0600 D/avoidrickshaw(32394): event-values: 0.184247, -0.082552, 10.164711, 0.000000
07-25 22:04:39.751+0600 D/avoidrickshaw(32394): event-values: 0.202193, -0.084347, 10.174281, 0.000000
07-25 22:04:39.811+0600 D/avoidrickshaw(32394): event-values: 0.196810, -0.076570, 10.169496, 0.000000
07-25 22:04:39.871+0600 D/avoidrickshaw(32394): event-values: 0.166301, -0.073579, 10.170094, 0.000000
07-25 22:04:39.931+0600 D/avoidrickshaw(32394): event-values: 0.188435, -0.081954, 10.171290, 0.000000
07-25 22:04:39.991+0600 D/avoidrickshaw(32394): event-values: 0.207577, -0.074776, 10.162916, 0.000000
07-25 22:04:40.051+0600 D/avoidrickshaw(32394): event-values: 0.195613, -0.083749, 10.181459, 0.000000
07-25 22:04:40.111+0600 D/avoidrickshaw(32394): event-values: 0.186640, -0.075374, 10.173683, 0.000000
07-25 22:04:40.171+0600 D/avoidrickshaw(32394): event-values: 0.193220, -0.064008, 10.174880, 0.000000
07-25 22:04:40.231+0600 D/avoidrickshaw(32394): event-values: 0.212363, -0.086142, 10.157533, 0.000000
07-25 22:04:40.291+0600 D/avoidrickshaw(32394): event-values: 0.203390, -0.075972, 10.197612, 0.000000
07-25 22:04:40.351+0600 D/avoidrickshaw(32394): event-values: 0.193819, -0.086740, 10.149756, 0.000000
07-25 22:04:40.411+0600 D/avoidrickshaw(32394): event-values: 0.201595, -0.074776, 10.180862, 0.000000
07-25 22:04:40.472+0600 D/avoidrickshaw(32394): event-values: 0.202193, -0.084347, 10.145569, 0.000000
07-25 22:04:40.532+0600 D/avoidrickshaw(32394): event-values: 0.185444, -0.070588, 10.176076, 0.000000
07-25 22:04:40.592+0600 D/avoidrickshaw(32394): event-values: 0.193819, -0.066401, 10.170692, 0.000000
07-25 22:04:40.652+0600 D/avoidrickshaw(32394): event-values: 0.205185, -0.073579, 10.167104, 0.000000
07-25 22:04:40.712+0600 D/avoidrickshaw(32394): event-values: 0.205185, -0.071186, 10.159328, 0.000000
07-25 22:04:40.772+0600 D/avoidrickshaw(32394): event-values: 0.187837, -0.077767, 10.182058, 0.000000
07-25 22:04:40.832+0600 D/avoidrickshaw(32394): event-values: 0.171685, -0.092124, 10.162319, 0.000000
07-25 22:04:40.892+0600 D/avoidrickshaw(32394): event-values: 0.198604, -0.075972, 10.161720, 0.000000
07-25 22:04:40.952+0600 D/avoidrickshaw(32394): event-values: 0.181855, -0.080758, 10.138390, 0.000000
07-25 22:04:41.012+0600 D/avoidrickshaw(32394): event-values: 0.184846, -0.072383, 10.159328, 0.000000
07-25 22:04:41.072+0600 D/avoidrickshaw(32394): event-values: 0.202792, -0.084945, 10.176675, 0.000000
07-25 22:04:41.132+0600 D/avoidrickshaw(32394): event-values: 0.190229, -0.102891, 10.162916, 0.000000
07-25 22:04:41.192+0600 D/avoidrickshaw(32394): event-values: 0.187238, -0.093320, 10.150952, 0.000000
07-25 22:04:41.252+0600 D/avoidrickshaw(32394): event-values: 0.204586, -0.069392, 10.196415, 0.000000
07-25 22:04:41.312+0600 D/avoidrickshaw(32394): event-values: 0.181855, -0.080758, 10.171888, 0.000000
07-25 22:04:41.372+0600 D/avoidrickshaw(32394): event-values: 0.201595, -0.072981, 10.188040, 0.000000
07-25 22:04:41.432+0600 D/avoidrickshaw(32394): event-values: 0.194417, -0.074776, 10.177272, 0.000000
07-25 22:04:41.493+0600 D/avoidrickshaw(32394): event-values: 0.198604, -0.077767, 10.170094, 0.000000
07-25 22:04:41.553+0600 D/avoidrickshaw(32394): event-values: 0.214158, -0.074178, 10.173084, 0.000000
07-25 22:04:41.613+0600 D/avoidrickshaw(32394): event-values: 0.199202, -0.068195, 10.177871, 0.000000
07-25 22:04:41.673+0600 D/avoidrickshaw(32394): event-values: 0.172881, -0.087936, 10.176675, 0.000000
07-25 22:04:41.733+0600 D/avoidrickshaw(32394): event-values: 0.198604, -0.064606, 10.170094, 0.000000
07-25 22:04:41.793+0600 D/avoidrickshaw(32394): event-values: 0.186640, -0.069990, 10.174880, 0.000000
07-25 22:04:41.853+0600 D/avoidrickshaw(32394): event-values: 0.207577, -0.070588, 10.153345, 0.000000
07-25 22:04:41.903+0600 D/avoidrickshaw(32394): horizontal_acc: 16.000000, vertical_acc: -1.000000
07-25 22:04:41.903+0600 D/avoidrickshaw(32394): previous lat: 23.742152, previous long: 90.411655
07-25 22:04:41.903+0600 D/avoidrickshaw(32394): current lat: 23.742152, current long: 90.411655
07-25 22:04:41.903+0600 D/avoidrickshaw(32394): because step count did not update, distance not updated.
07-25 22:04:41.913+0600 D/avoidrickshaw(32394): event-values: 0.195613, -0.084347, 10.168897, 0.000000
07-25 22:04:41.973+0600 D/avoidrickshaw(32394): event-values: 0.176471, -0.074178, 10.174880, 0.000000
07-25 22:04:42.033+0600 D/avoidrickshaw(32394): event-values: 0.192622, -0.078963, 10.176675, 0.000000
07-25 22:04:42.093+0600 D/avoidrickshaw(32394): event-values: 0.195015, -0.093320, 10.169496, 0.000000
07-25 22:04:42.153+0600 D/avoidrickshaw(32394): event-values: 0.203988, -0.064606, 10.155140, 0.000000
07-25 22:04:42.213+0600 D/avoidrickshaw(32394): event-values: 0.174078, -0.073579, 10.161720, 0.000000
07-25 22:04:42.273+0600 D/avoidrickshaw(32394): event-values: 0.174078, -0.079561, 10.172487, 0.000000
07-25 22:04:42.333+0600 D/avoidrickshaw(32394): event-values: 0.217149, -0.068794, 10.177272, 0.000000
07-25 22:04:42.393+0600 D/avoidrickshaw(32394): event-values: 0.208176, -0.069392, 10.177871, 0.000000
07-25 22:04:42.453+0600 D/avoidrickshaw(32394): event-values: 0.181256, -0.079561, 10.170094, 0.000000
07-25 22:04:42.514+0600 D/avoidrickshaw(32394): event-values: 0.182453, -0.069990, 10.162916, 0.000000
07-25 22:04:42.574+0600 D/avoidrickshaw(32394): event-values: 0.207577, -0.077767, 10.182058, 0.000000
07-25 22:04:42.634+0600 D/avoidrickshaw(32394): event-values: 0.174676, -0.061615, 10.134801, 0.000000
07-25 22:04:42.694+0600 D/avoidrickshaw(32394): event-values: 0.189631, -0.064606, 10.208379, 0.000000
07-25 22:04:42.754+0600 D/avoidrickshaw(32394): event-values: 0.207577, -0.074776, 10.194620, 0.000000
07-25 22:04:42.814+0600 D/avoidrickshaw(32394): event-values: 0.233898, -0.087338, 10.180264, 0.000000
07-25 22:04:42.874+0600 D/avoidrickshaw(32394): event-values: 0.169890, -0.107079, 10.164113, 0.000000
07-25 22:04:42.934+0600 D/avoidrickshaw(32394): event-values: 0.174078, -0.055633, 10.197612, 0.000000
07-25 22:04:42.994+0600 D/avoidrickshaw(32394): event-values: 0.198006, -0.093918, 10.147363, 0.000000
07-25 22:04:43.054+0600 D/avoidrickshaw(32394): event-values: 0.220738, -0.086142, 10.191031, 0.000000
07-25 22:04:43.114+0600 D/avoidrickshaw(32394): event-values: 0.212961, -0.059821, 10.176675, 0.000000
07-25 22:04:43.174+0600 D/avoidrickshaw(32394): event-values: 0.165105, -0.096311, 10.164113, 0.000000
07-25 22:04:43.234+0600 D/avoidrickshaw(32394): event-values: 0.190229, -0.081356, 10.187442, 0.000000
07-25 22:04:43.294+0600 D/avoidrickshaw(32394): event-values: 0.200399, -0.076570, 10.138988, 0.000000
07-25 22:04:43.354+0600 D/avoidrickshaw(32394): event-values: 0.214158, -0.081356, 10.174281, 0.000000
07-25 22:04:43.414+0600 D/avoidrickshaw(32394): event-values: 0.167498, -0.089133, 10.153944, 0.000000
07-25 22:04:43.474+0600 D/avoidrickshaw(32394): event-values: 0.192024, -0.082552, 10.166506, 0.000000
07-25 22:04:43.535+0600 D/avoidrickshaw(32394): event-values: 0.199801, -0.078963, 10.171888, 0.000000
07-25 22:04:43.595+0600 D/avoidrickshaw(32394): event-values: 0.183051, -0.075972, 10.155738, 0.000000
07-25 22:04:43.655+0600 D/avoidrickshaw(32394): event-values: 0.220140, -0.063410, 10.131809, 0.000000
07-25 22:04:43.715+0600 D/avoidrickshaw(32394): event-values: 0.186640, -0.084945, 10.180862, 0.000000
07-25 22:04:43.775+0600 D/avoidrickshaw(32394): event-values: 0.164507, -0.080758, 10.148559, 0.000000
07-25 22:04:43.835+0600 D/avoidrickshaw(32394): event-values: 0.198006, -0.075972, 10.164113, 0.000000
07-25 22:04:43.895+0600 D/avoidrickshaw(32394): event-values: 0.227318, -0.069392, 10.202995, 0.000000
07-25 22:04:43.955+0600 D/avoidrickshaw(32394): event-values: 0.180658, -0.084945, 10.189237, 0.000000
07-25 22:04:44.015+0600 D/avoidrickshaw(32394): event-values: 0.198604, -0.084347, 10.191629, 0.000000
07-25 22:04:44.075+0600 D/avoidrickshaw(32394): event-values: 0.188435, -0.070588, 10.171290, 0.000000
07-25 22:04:44.135+0600 D/avoidrickshaw(32394): event-values: 0.213559, -0.077169, 10.147363, 0.000000
07-25 22:04:44.195+0600 D/avoidrickshaw(32394): event-values: 0.165105, -0.066999, 10.141978, 0.000000
07-25 22:04:44.255+0600 D/avoidrickshaw(32394): event-values: 0.193220, -0.069990, 10.172487, 0.000000
07-25 22:04:44.315+0600 D/avoidrickshaw(32394): event-values: 0.175872, -0.084347, 10.162319, 0.000000
07-25 22:04:44.375+0600 D/avoidrickshaw(32394): event-values: 0.195015, -0.092722, 10.156336, 0.000000
07-25 22:04:44.435+0600 D/avoidrickshaw(32394): event-values: 0.198006, -0.087338, 10.163515, 0.000000
07-25 22:04:44.495+0600 D/avoidrickshaw(32394): event-values: 0.164507, -0.096909, 10.134202, 0.000000
07-25 22:04:44.556+0600 D/avoidrickshaw(32394): event-values: 0.226720, -0.059821, 10.183852, 0.000000
07-25 22:04:44.616+0600 D/avoidrickshaw(32394): event-values: 0.221934, -0.104686, 10.209577, 0.000000
07-25 22:04:44.676+0600 D/avoidrickshaw(32394): event-values: 0.187238, -0.067597, 10.148559, 0.000000
07-25 22:04:44.736+0600 D/avoidrickshaw(32394): event-values: 0.211167, -0.081954, 10.185647, 0.000000
07-25 22:04:44.796+0600 D/avoidrickshaw(32394): event-values: 0.204586, -0.089133, 10.178469, 0.000000
07-25 22:04:44.856+0600 D/avoidrickshaw(32394): event-values: 0.198006, -0.074776, 10.225129, 0.000000
07-25 22:04:44.916+0600 D/avoidrickshaw(32394): event-values: 0.183051, -0.078963, 10.145569, 0.000000
07-25 22:04:44.976+0600 D/avoidrickshaw(32394): event-values: 0.233898, -0.069392, 10.192826, 0.000000
07-25 22:04:45.036+0600 D/avoidrickshaw(32394): event-values: 0.211167, -0.091525, 10.153345, 0.000000
07-25 22:04:45.096+0600 D/avoidrickshaw(32394): event-values: 0.181855, -0.080160, 10.168897, 0.000000
07-25 22:04:45.156+0600 D/avoidrickshaw(32394): event-values: 0.142373, -0.090329, 10.109076, 0.000000
07-25 22:04:45.216+0600 D/avoidrickshaw(32394): event-values: 0.205185, -0.083749, 10.164113, 0.000000
07-25 22:04:45.276+0600 D/avoidrickshaw(32394): event-values: 0.194417, -0.070588, 10.150952, 0.000000
07-25 22:04:45.336+0600 D/avoidrickshaw(32394): event-values: 0.182453, -0.095115, 10.158132, 0.000000
07-25 22:04:45.396+0600 D/avoidrickshaw(32394): event-values: 0.181855, -0.075972, 10.173683, 0.000000
07-25 22:04:45.456+0600 D/avoidrickshaw(32394): event-values: 0.189033, -0.085543, 10.159925, 0.000000
07-25 22:04:45.516+0600 D/avoidrickshaw(32394): event-values: 0.215354, -0.061615, 10.182656, 0.000000
07-25 22:04:45.577+0600 D/avoidrickshaw(32394): event-values: 0.186640, -0.072383, 10.168301, 0.000000
07-25 22:04:45.637+0600 D/avoidrickshaw(32394): event-values: 0.223729, -0.078365, 10.171888, 0.000000
07-25 22:04:45.697+0600 D/avoidrickshaw(32394): event-values: 0.146560, -0.088534, 10.161720, 0.000000
07-25 22:04:45.757+0600 D/avoidrickshaw(32394): event-values: 0.234497, -0.074178, 10.180862, 0.000000
07-25 22:04:45.817+0600 D/avoidrickshaw(32394): event-values: 0.198604, -0.086740, 10.203594, 0.000000
07-25 22:04:45.877+0600 D/avoidrickshaw(32394): event-values: 0.215952, -0.077767, 10.165908, 0.000000
07-25 22:04:45.907+0600 D/avoidrickshaw(32394): horizontal_acc: 24.000000, vertical_acc: -1.000000
07-25 22:04:45.907+0600 D/avoidrickshaw(32394): previous lat: 23.742152, previous long: 90.411655
07-25 22:04:45.907+0600 D/avoidrickshaw(32394): current lat: 23.742152, current long: 90.411655
07-25 22:04:45.917+0600 D/avoidrickshaw(32394): because step count did not update, distance not updated.
07-25 22:04:45.937+0600 D/avoidrickshaw(32394): event-values: 0.141177, -0.092124, 10.149158, 0.000000
07-25 22:04:45.997+0600 D/avoidrickshaw(32394): event-values: 0.198006, -0.063410, 10.152746, 0.000000
07-25 22:04:46.057+0600 D/avoidrickshaw(32394): event-values: 0.235095, -0.087338, 10.179665, 0.000000
07-25 22:04:46.117+0600 D/avoidrickshaw(32394): event-values: 0.190229, -0.081356, 10.168897, 0.000000
07-25 22:04:46.177+0600 D/avoidrickshaw(32394): event-values: 0.199202, -0.102293, 10.186246, 0.000000
07-25 22:04:46.237+0600 D/avoidrickshaw(32394): event-values: 0.218943, -0.059821, 10.165309, 0.000000
07-25 22:04:46.297+0600 D/avoidrickshaw(32394): event-values: 0.193220, -0.082552, 10.158132, 0.000000
07-25 22:04:46.357+0600 D/avoidrickshaw(32394): event-values: 0.233300, -0.088534, 10.188040, 0.000000
07-25 22:04:46.417+0600 D/avoidrickshaw(32394): event-values: 0.181256, -0.089731, 10.152746, 0.000000
07-25 22:04:46.477+0600 D/avoidrickshaw(32394): event-values: 0.171685, -0.084347, 10.168897, 0.000000
07-25 22:04:46.537+0600 D/avoidrickshaw(32394): event-values: 0.228515, -0.071785, 10.173084, 0.000000
07-25 22:04:46.598+0600 D/avoidrickshaw(32394): event-values: 0.202193, -0.075374, 10.208379, 0.000000
07-25 22:04:46.658+0600 D/avoidrickshaw(32394): event-values: 0.178265, -0.055035, 10.170692, 0.000000
07-25 22:04:46.718+0600 D/avoidrickshaw(32394): event-values: 0.178863, -0.093320, 10.210175, 0.000000
07-25 22:04:46.778+0600 D/avoidrickshaw(32394): event-values: 0.171087, -0.084347, 10.154541, 0.000000
07-25 22:04:46.838+0600 D/avoidrickshaw(32394): event-values: 0.199202, -0.075374, 10.179665, 0.000000
07-25 22:04:46.898+0600 D/avoidrickshaw(32394): event-values: 0.181855, -0.087338, 10.169496, 0.000000
07-25 22:04:46.958+0600 D/avoidrickshaw(32394): event-values: 0.180060, -0.075374, 10.179665, 0.000000
07-25 22:04:47.018+0600 D/avoidrickshaw(32394): event-values: 0.226122, -0.072981, 10.172487, 0.000000
07-25 22:04:47.078+0600 D/avoidrickshaw(32394): event-values: 0.232104, -0.091525, 10.164711, 0.000000
07-25 22:04:47.138+0600 D/avoidrickshaw(32394): event-values: 0.198604, -0.080160, 10.167702, 0.000000
07-25 22:04:47.198+0600 D/avoidrickshaw(32394): event-values: 0.169890, -0.080758, 10.170692, 0.000000
07-25 22:04:47.258+0600 D/avoidrickshaw(32394): event-values: 0.208176, -0.098704, 10.169496, 0.000000
07-25 22:04:47.318+0600 D/avoidrickshaw(32394): event-values: 0.209372, -0.080758, 10.172487, 0.000000
07-25 22:04:47.378+0600 D/avoidrickshaw(32394): event-values: 0.193819, -0.081954, 10.196415, 0.000000
07-25 22:04:47.438+0600 D/avoidrickshaw(32394): event-values: 0.185444, -0.092722, 10.170692, 0.000000
07-25 22:04:47.498+0600 D/avoidrickshaw(32394): event-values: 0.200399, -0.089731, 10.176675, 0.000000
07-25 22:04:47.558+0600 D/avoidrickshaw(32394): event-values: 0.193819, -0.080758, 10.143176, 0.000000
07-25 22:04:47.619+0600 D/avoidrickshaw(32394): event-values: 0.195613, -0.090329, 10.174880, 0.000000
07-25 22:04:47.679+0600 D/avoidrickshaw(32394): event-values: 0.181855, -0.074776, 10.167702, 0.000000
07-25 22:04:47.739+0600 D/avoidrickshaw(32394): event-values: 0.218943, -0.092124, 10.182656, 0.000000
07-25 22:04:47.799+0600 D/avoidrickshaw(32394): event-values: 0.183649, -0.081356, 10.174880, 0.000000
07-25 22:04:47.859+0600 D/avoidrickshaw(32394): event-values: 0.181256, -0.077169, 10.183254, 0.000000
07-25 22:04:47.919+0600 D/avoidrickshaw(32394): event-values: 0.200399, -0.080160, 10.167702, 0.000000
07-25 22:04:47.979+0600 D/avoidrickshaw(32394): event-values: 0.201595, -0.068195, 10.128819, 0.000000
07-25 22:04:48.039+0600 D/avoidrickshaw(32394): event-values: 0.181855, -0.077169, 10.175477, 0.000000
07-25 22:04:48.099+0600 D/avoidrickshaw(32394): event-values: 0.169890, -0.068794, 10.160523, 0.000000
07-25 22:04:48.159+0600 D/avoidrickshaw(32394): event-values: 0.208774, -0.101097, 10.206585, 0.000000
07-25 22:04:48.219+0600 D/avoidrickshaw(32394): event-values: 0.223729, -0.065803, 10.168301, 0.000000
07-25 22:04:48.279+0600 D/avoidrickshaw(32394): event-values: 0.196810, -0.086142, 10.173084, 0.000000
07-25 22:04:48.339+0600 D/avoidrickshaw(32394): event-values: 0.163310, -0.064008, 10.175477, 0.000000
07-25 22:04:48.399+0600 D/avoidrickshaw(32394): event-values: 0.211765, -0.087936, 10.159328, 0.000000
07-25 22:04:48.459+0600 D/avoidrickshaw(32394): event-values: 0.197408, -0.080758, 10.167104, 0.000000
07-25 22:04:48.519+0600 D/avoidrickshaw(32394): event-values: 0.180658, -0.065204, 10.137791, 0.000000
07-25 22:04:48.579+0600 D/avoidrickshaw(32394): event-values: 0.175872, -0.099900, 10.166506, 0.000000
07-25 22:04:48.640+0600 D/avoidrickshaw(32394): event-values: 0.212363, -0.069990, 10.216157, 0.000000
07-25 22:04:48.700+0600 D/avoidrickshaw(32394): event-values: 0.197408, -0.077767, 10.155738, 0.000000
07-25 22:04:48.760+0600 D/avoidrickshaw(32394): event-values: 0.194417, -0.081954, 10.174880, 0.000000
07-25 22:04:48.820+0600 D/avoidrickshaw(32394): event-values: 0.180060, -0.077767, 10.156934, 0.000000
07-25 22:04:48.880+0600 D/avoidrickshaw(32394): event-values: 0.212961, -0.072981, 10.164113, 0.000000
07-25 22:04:48.940+0600 D/avoidrickshaw(32394): event-values: 0.224925, -0.094516, 10.173683, 0.000000
07-25 22:04:49.000+0600 D/avoidrickshaw(32394): event-values: 0.159721, -0.097508, 10.164711, 0.000000
07-25 22:04:49.060+0600 D/avoidrickshaw(32394): event-values: 0.187837, -0.078365, 10.168897, 0.000000
07-25 22:04:49.120+0600 D/avoidrickshaw(32394): event-values: 0.203988, -0.089731, 10.177272, 0.000000
07-25 22:04:49.180+0600 D/avoidrickshaw(32394): event-values: 0.217747, -0.076570, 10.184451, 0.000000
07-25 22:04:49.240+0600 D/avoidrickshaw(32394): event-values: 0.175872, -0.077169, 10.171888, 0.000000
07-25 22:04:49.300+0600 D/avoidrickshaw(32394): event-values: 0.178265, -0.052044, 10.178469, 0.000000
07-25 22:04:49.360+0600 D/avoidrickshaw(32394): event-values: 0.220738, -0.093918, 10.181459, 0.000000
07-25 22:04:49.420+0600 D/avoidrickshaw(32394): event-values: 0.195015, -0.087936, 10.168301, 0.000000
07-25 22:04:49.480+0600 D/avoidrickshaw(32394): event-values: 0.183649, -0.070588, 10.164113, 0.000000
07-25 22:04:49.540+0600 D/avoidrickshaw(32394): event-values: 0.174078, -0.075972, 10.165908, 0.000000
07-25 22:04:49.600+0600 D/avoidrickshaw(32394): event-values: 0.211167, -0.073579, 10.154541, 0.000000
07-25 22:04:49.660+0600 D/avoidrickshaw(32394): event-values: 0.179462, -0.065803, 10.173683, 0.000000
07-25 22:04:49.721+0600 D/avoidrickshaw(32394): event-values: 0.194417, -0.059222, 10.166506, 0.000000
07-25 22:04:49.781+0600 D/avoidrickshaw(32394): event-values: 0.212363, -0.055633, 10.175477, 0.000000
07-25 22:04:49.841+0600 D/avoidrickshaw(32394): event-values: 0.207577, -0.075374, 10.160523, 0.000000
07-25 22:04:49.911+0600 D/avoidrickshaw(32394): horizontal_acc: 12.000000, vertical_acc: -1.000000
07-25 22:04:49.911+0600 D/avoidrickshaw(32394): previous lat: 23.742152, previous long: 90.411655
07-25 22:04:49.911+0600 D/avoidrickshaw(32394): current lat: 23.742152, current long: 90.411655
07-25 22:04:49.911+0600 D/avoidrickshaw(32394): because step count did not update, distance not updated.
07-25 22:04:49.911+0600 D/avoidrickshaw(32394): event-values: 0.193220, -0.081954, 10.171888, 0.000000
07-25 22:04:49.951+0600 D/avoidrickshaw(32394): event-values: 0.176471, -0.095115, 10.188040, 0.000000
07-25 22:04:50.011+0600 D/avoidrickshaw(32394): event-values: 0.193220, -0.086142, 10.177272, 0.000000
07-25 22:04:50.071+0600 D/avoidrickshaw(32394): event-values: 0.200997, -0.072383, 10.168301, 0.000000
07-25 22:04:50.131+0600 D/avoidrickshaw(32394): event-values: 0.191426, -0.077169, 10.163515, 0.000000
07-25 22:04:50.191+0600 D/avoidrickshaw(32394): event-values: 0.183051, -0.061615, 10.165309, 0.000000
07-25 22:04:50.251+0600 D/avoidrickshaw(32394): event-values: 0.205185, -0.085543, 10.179665, 0.000000
07-25 22:04:50.311+0600 D/avoidrickshaw(32394): event-values: 0.202193, -0.089731, 10.141978, 0.000000
07-25 22:04:50.371+0600 D/avoidrickshaw(32394): event-values: 0.191426, -0.053240, 10.172487, 0.000000
07-25 22:04:50.431+0600 D/avoidrickshaw(32394): event-values: 0.193220, -0.091525, 10.165908, 0.000000
07-25 22:04:50.491+0600 D/avoidrickshaw(32394): event-values: 0.200997, -0.069392, 10.172487, 0.000000
07-25 22:04:50.551+0600 D/avoidrickshaw(32394): event-values: 0.212961, -0.072981, 10.183852, 0.000000
07-25 22:04:50.611+0600 D/avoidrickshaw(32394): event-values: 0.180658, -0.068195, 10.166506, 0.000000
07-25 22:04:50.671+0600 D/avoidrickshaw(32394): event-values: 0.208774, -0.078963, 10.164113, 0.000000
07-25 22:04:50.732+0600 D/avoidrickshaw(32394): event-values: 0.178863, -0.092722, 10.160523, 0.000000
07-25 22:04:50.792+0600 D/avoidrickshaw(32394): event-values: 0.196211, -0.075374, 10.176076, 0.000000
07-25 22:04:50.852+0600 D/avoidrickshaw(32394): event-values: 0.189033, -0.084347, 10.182058, 0.000000
07-25 22:04:50.872+0600 I/Tizen::Net::Wifi( 1305): (941) > The background scan result updated.
07-25 22:04:50.912+0600 D/avoidrickshaw(32394): event-values: 0.201595, -0.071785, 10.179067, 0.000000
07-25 22:04:50.972+0600 D/avoidrickshaw(32394): event-values: 0.192622, -0.082552, 10.188040, 0.000000
07-25 22:04:51.032+0600 D/avoidrickshaw(32394): event-values: 0.198006, -0.072383, 10.171290, 0.000000
07-25 22:04:51.092+0600 D/avoidrickshaw(32394): event-values: 0.188435, -0.078365, 10.173084, 0.000000
07-25 22:04:51.152+0600 D/avoidrickshaw(32394): event-values: 0.219541, -0.074776, 10.169496, 0.000000
07-25 22:04:51.212+0600 D/avoidrickshaw(32394): event-values: 0.195613, -0.081356, 10.177871, 0.000000
07-25 22:04:51.272+0600 D/avoidrickshaw(32394): event-values: 0.186042, -0.072981, 10.168897, 0.000000
07-25 22:04:51.332+0600 D/avoidrickshaw(32394): event-values: 0.190229, -0.083151, 10.173084, 0.000000
07-25 22:04:51.392+0600 D/avoidrickshaw(32394): event-values: 0.202193, -0.065204, 10.160523, 0.000000
07-25 22:04:51.452+0600 D/avoidrickshaw(32394): event-values: 0.183051, -0.086740, 10.172487, 0.000000
07-25 22:04:51.512+0600 D/avoidrickshaw(32394): event-values: 0.197408, -0.078963, 10.167104, 0.000000
07-25 22:04:51.572+0600 D/avoidrickshaw(32394): event-values: 0.202193, -0.068794, 10.167104, 0.000000
07-25 22:04:51.632+0600 D/avoidrickshaw(32394): event-values: 0.187837, -0.068794, 10.169496, 0.000000
07-25 22:04:51.692+0600 D/avoidrickshaw(32394): event-values: 0.169890, -0.068794, 10.176675, 0.000000
07-25 22:04:51.753+0600 D/avoidrickshaw(32394): event-values: 0.191426, -0.071785, 10.159925, 0.000000
07-25 22:04:51.813+0600 D/avoidrickshaw(32394): event-values: 0.189631, -0.096909, 10.174880, 0.000000
07-25 22:04:51.873+0600 D/avoidrickshaw(32394): event-values: 0.184247, -0.080758, 10.161720, 0.000000
07-25 22:04:51.933+0600 D/avoidrickshaw(32394): event-values: 0.186640, -0.065204, 10.164113, 0.000000
07-25 22:04:51.993+0600 D/avoidrickshaw(32394): event-values: 0.198006, -0.088534, 10.173084, 0.000000
07-25 22:04:52.053+0600 D/avoidrickshaw(32394): event-values: 0.193220, -0.066401, 10.163515, 0.000000
07-25 22:04:52.113+0600 D/avoidrickshaw(32394): event-values: 0.163310, -0.086142, 10.166506, 0.000000
07-25 22:04:52.173+0600 D/avoidrickshaw(32394): event-values: 0.198006, -0.086740, 10.189237, 0.000000
07-25 22:04:52.233+0600 D/avoidrickshaw(32394): event-values: 0.212961, -0.082552, 10.200603, 0.000000
07-25 22:04:52.293+0600 D/avoidrickshaw(32394): event-values: 0.185444, -0.086142, 10.162916, 0.000000
07-25 22:04:52.353+0600 D/avoidrickshaw(32394): event-values: 0.202193, -0.038285, 10.191031, 0.000000
07-25 22:04:52.413+0600 D/avoidrickshaw(32394): event-values: 0.198604, -0.059222, 10.180862, 0.000000
07-25 22:04:52.473+0600 D/avoidrickshaw(32394): event-values: 0.204586, -0.071186, 10.141978, 0.000000
07-25 22:04:52.533+0600 D/avoidrickshaw(32394): event-values: 0.200399, -0.075374, 10.172487, 0.000000
07-25 22:04:52.593+0600 D/avoidrickshaw(32394): event-values: 0.186640, -0.087338, 10.162916, 0.000000
07-25 22:04:52.653+0600 D/avoidrickshaw(32394): event-values: 0.194417, -0.072981, 10.142577, 0.000000
07-25 22:04:52.713+0600 D/avoidrickshaw(32394): event-values: 0.209970, -0.054437, 10.165908, 0.000000
07-25 22:04:52.774+0600 D/avoidrickshaw(32394): event-values: 0.187238, -0.087936, 10.183254, 0.000000
07-25 22:04:52.834+0600 D/avoidrickshaw(32394): event-values: 0.175872, -0.068195, 10.156934, 0.000000
07-25 22:04:52.894+0600 D/avoidrickshaw(32394): event-values: 0.206979, -0.079561, 10.176076, 0.000000
07-25 22:04:52.954+0600 D/avoidrickshaw(32394): event-values: 0.186640, -0.077767, 10.152148, 0.000000
07-25 22:04:53.014+0600 D/avoidrickshaw(32394): event-values: 0.193819, -0.076570, 10.158132, 0.000000
07-25 22:04:53.074+0600 D/avoidrickshaw(32394): event-values: 0.253041, -0.087338, 10.220345, 0.000000
07-25 22:04:53.134+0600 D/avoidrickshaw(32394): event-values: 0.194417, -0.071186, 10.197612, 0.000000
07-25 22:04:53.194+0600 D/avoidrickshaw(32394): event-values: 0.159721, -0.046660, 10.153345, 0.000000
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
07-25 22:05:01.963+0600 D/avoid
