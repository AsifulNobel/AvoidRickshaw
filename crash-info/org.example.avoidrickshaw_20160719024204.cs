S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPD6
Build-Date: 2016.04.28 20:23:28

Crash Information
Process Name: avoidrickshaw
PID: 3394
Date: 2016-07-19 02:42:04+0600
Executable File Path: /opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 3394, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000d42
r2   = 0x00000006, r3   = 0xb44f64c0
r4   = 0x00000002, r5   = 0xb44f6000
r6   = 0xb67fb09c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0x00000002
r10  = 0x00000007, fp   = 0xbed93150
ip   = 0x00000000, sp   = 0xbed92f14
lr   = 0xb66f1f18, pc   = 0xb66f0b84
cpsr = 0x200e0010

Memory Information
MemTotal:   730440 KB
MemFree:     31628 KB
Buffers:     44812 KB
Cached:     242628 KB
VmPeak:     119304 KB
VmSize:     119300 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24528 KB
VmRSS:       24528 KB
VmData:      43964 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36236 KB
VmPTE:          86 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 3394 TID = 3394
3394 3409 3769 3776 3809 

Maps Information
b0586000 b0d85000 rw-p [stack:3809]
b13a0000 b1b9f000 rw-p [stack:3776]
b1b9f000 b1ba7000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.49
b1bb7000 b1bb9000 r-xp /usr/lib/liblbs-agps.so.0.1.0
b1bc9000 b1bd7000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
b1bee000 b1bf0000 r-xp /usr/lib/location/module/libwps.so.0.6.8_9
b1d05000 b1d08000 r-xp /usr/lib/location/module/libgps.so.0.6.8_9
b1d19000 b2518000 rw-p [stack:3769]
b259d000 b25a5000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b25b6000 b25b7000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b25c7000 b25db000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b25ef000 b25f0000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2600000 b2603000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2614000 b2615000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2625000 b2627000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2637000 b2639000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2649000 b2659000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2669000 b2675000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b28c5000 b28c7000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b28d7000 b28dd000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b28ed000 b2901000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b2911000 b292b000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b293b000 b2941000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
b2951000 b2958000 r-xp /usr/lib/libeventsystem.so.0.0.1
b2968000 b298b000 r-xp /usr/lib/libSLP-location-product.so.0.9.0
b299c000 b29b3000 r-xp /usr/lib/libSLP-location.so.0.11.5_5
b29c3000 b29ca000 r-xp /usr/lib/libefl-extension.so.0.1.0
b29db000 b29e3000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b29f3000 b29f7000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
b2a08000 b2a17000 r-xp /usr/lib/libcapi-location-manager.so.0.6.1_3
b2a29000 b2a2f000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2a3f000 b2a44000 r-xp /opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw
b2b65000 b2c48000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2c7f000 b2ca7000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2cb9000 b34b8000 rw-p [stack:3409]
b34b8000 b34ba000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b34ca000 b34d4000 r-xp /lib/libnss_files-2.20-2014.11.so
b34e5000 b34ee000 r-xp /lib/libnss_nis-2.20-2014.11.so
b34ff000 b3510000 r-xp /lib/libnsl-2.20-2014.11.so
b3523000 b3529000 r-xp /lib/libnss_compat-2.20-2014.11.so
b353a000 b353b000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3563000 b356a000 r-xp /usr/lib/libminizip.so.1.0.0
b357a000 b357f000 r-xp /usr/lib/libstorage.so.0.1
b358f000 b35e4000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b35fa000 b360e000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b361e000 b3662000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3672000 b367a000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b368a000 b36ba000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b36cd000 b3786000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b379a000 b37ee000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b37ff000 b381a000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b382a000 b38eb000 r-xp /usr/lib/libprotobuf.so.9.0.1
b38fe000 b3910000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3920000 b3924000 r-xp /usr/lib/libogg.so.0.7.1
b3934000 b3956000 r-xp /usr/lib/libvorbis.so.0.4.3
b3966000 b3a4a000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b3a66000 b3a73000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3a84000 b3ac7000 r-xp /usr/lib/libsndfile.so.1.0.25
b3adc000 b3b23000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3b34000 b3b3a000 r-xp /usr/lib/libjson-c.so.2.0.1
b3b4b000 b3b52000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3b62000 b3ba2000 r-xp /usr/lib/libmdm.so.1.2.10
b3bb2000 b3bba000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3bc9000 b3bd9000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3bfa000 b3c5a000 r-xp /usr/lib/libasound.so.2.0.0
b3c6c000 b3ca2000 r-xp /usr/lib/libpulse.so.0.16.2
b3cb3000 b3cb6000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3cc6000 b3cc9000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3cd9000 b3cde000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3cee000 b3cef000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3cff000 b3d0a000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3d1e000 b3d25000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3d35000 b3d3b000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3d4b000 b3d50000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3d60000 b3d7b000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3d8b000 b3d92000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3da2000 b3da5000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3db6000 b3de4000 r-xp /usr/lib/libidn.so.11.5.44
b3df4000 b3e0a000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3e1b000 b3e25000 r-xp /usr/lib/libcares.so.2.1.0
b3e35000 b3e3f000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3e4f000 b3e51000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3e61000 b3e62000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3e72000 b3e76000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3e87000 b3eaf000 r-xp /usr/lib/libui-extension.so.0.1.0
b3ec0000 b3ee9000 r-xp /usr/lib/libturbojpeg.so
b3f09000 b3f0f000 r-xp /usr/lib/libgif.so.4.1.6
b3f1f000 b3f65000 r-xp /usr/lib/libcurl.so.4.3.0
b3f76000 b3f97000 r-xp /usr/lib/libexif.so.12.3.3
b3fb2000 b3fc7000 r-xp /usr/lib/libtts.so
b3fd8000 b3fe0000 r-xp /usr/lib/libfeedback.so.0.1.4
b3ff0000 b40b0000 r-xp /usr/lib/libdali-core.so.0.0.0
b40bb000 b41ae000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b41ce000 b42a8000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b42bf000 b42c1000 r-xp /usr/lib/libboost_system.so.1.51.0
b42d1000 b42d7000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b42e7000 b430a000 r-xp /usr/lib/libboost_thread.so.1.51.0
b431b000 b431d000 r-xp /usr/lib/libappsvc.so.0.1.0
b432d000 b432f000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4340000 b4345000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b435c000 b435e000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b436e000 b4375000 r-xp /usr/lib/libsensord-share.so
b4385000 b439d000 r-xp /usr/lib/libsensor.so.1.1.0
b43ae000 b43b1000 r-xp /usr/lib/libXv.so.1.0.0
b43c1000 b43c6000 r-xp /usr/lib/libutilX.so.1.1.0
b43d6000 b43db000 r-xp /usr/lib/libappcore-common.so.1.1
b43eb000 b43f2000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b4405000 b4409000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b441a000 b44e4000 r-xp /usr/lib/libCOREGL.so.4.0
b44fb000 b44fe000 r-xp /usr/lib/libuuid.so.1.3.0
b450f000 b4526000 r-xp /usr/lib/libblkid.so.1.1.0
b4537000 b4539000 r-xp /usr/lib/libXau.so.6.0.0
b4549000 b454c000 r-xp /usr/lib/libEGL.so.1.4
b4554000 b455a000 r-xp /usr/lib/libxcb-render.so.0.0.0
b456a000 b456c000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b457d000 b458b000 r-xp /usr/lib/libGLESv2.so.2.0
b4594000 b45f6000 r-xp /usr/lib/libpixman-1.so.0.28.2
b460b000 b4623000 r-xp /usr/lib/libmount.so.1.1.0
b4634000 b4648000 r-xp /usr/lib/libxcb.so.1.1.0
b4659000 b4660000 r-xp /lib/libcrypt-2.20-2014.11.so
b4698000 b46a9000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b46ba000 b46bc000 r-xp /usr/lib/libiri.so
b46cc000 b46d7000 r-xp /usr/lib/libgpg-error.so.0.15.0
b46e8000 b46fd000 r-xp /lib/libexpat.so.1.5.2
b470f000 b47cd000 r-xp /usr/lib/libcairo.so.2.11200.14
b47e0000 b47e8000 r-xp /usr/lib/libdrm.so.2.4.0
b47f8000 b47fb000 r-xp /usr/lib/libdri2.so.0.0.0
b480c000 b485a000 r-xp /usr/lib/libssl.so.1.0.0
b486f000 b487b000 r-xp /usr/lib/libeeze.so.1.13.0
b488b000 b4894000 r-xp /usr/lib/libethumb.so.1.13.0
b48a4000 b48a7000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b48b7000 b4a6e000 r-xp /usr/lib/libcrypto.so.1.0.0
b56c5000 b56ce000 r-xp /usr/lib/libXi.so.6.1.0
b56de000 b56e0000 r-xp /usr/lib/libXgesture.so.7.0.0
b56f0000 b56f4000 r-xp /usr/lib/libXtst.so.6.1.0
b5704000 b570a000 r-xp /usr/lib/libXrender.so.1.3.0
b571a000 b5720000 r-xp /usr/lib/libXrandr.so.2.2.0
b5731000 b5733000 r-xp /usr/lib/libXinerama.so.1.0.0
b5743000 b5746000 r-xp /usr/lib/libXfixes.so.3.1.0
b5756000 b5761000 r-xp /usr/lib/libXext.so.6.4.0
b5771000 b5773000 r-xp /usr/lib/libXdamage.so.1.1.0
b5783000 b5785000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5796000 b5878000 r-xp /usr/lib/libX11.so.6.3.0
b588b000 b5892000 r-xp /usr/lib/libXcursor.so.1.0.2
b58a2000 b58ba000 r-xp /usr/lib/libudev.so.1.6.0
b58bc000 b58bf000 r-xp /lib/libattr.so.1.1.0
b58cf000 b58ef000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58f1000 b58f6000 r-xp /usr/lib/libffi.so.6.0.2
b5906000 b591e000 r-xp /lib/libz.so.1.2.8
b592e000 b5930000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5940000 b5a15000 r-xp /usr/lib/libxml2.so.2.9.2
b5a2a000 b5ac5000 r-xp /usr/lib/libstdc++.so.6.0.20
b5ae1000 b5ae4000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5af4000 b5b0d000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b1e000 b5b2f000 r-xp /lib/libresolv-2.20-2014.11.so
b5b43000 b5bbd000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5bd2000 b5bd4000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5be4000 b5beb000 r-xp /usr/lib/libembryo.so.1.13.0
b5bfb000 b5c13000 r-xp /usr/lib/libpng12.so.0.50.0
b5c24000 b5c47000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c68000 b5c7c000 r-xp /usr/lib/libector.so.1.13.0
b5c8d000 b5ca5000 r-xp /usr/lib/liblua-5.1.so
b5cb6000 b5d0d000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d21000 b5d49000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d5a000 b5d6d000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d7e000 b5db5000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5dc6000 b5dd4000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5de4000 b5dec000 r-xp /usr/lib/libtbm.so.1.0.0
b5dfc000 b5e09000 r-xp /usr/lib/libeio.so.1.13.0
b5e19000 b5e1b000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e2b000 b5e30000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e40000 b5e57000 r-xp /usr/lib/libefreet.so.1.13.0
b5e69000 b5e89000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e99000 b5eb9000 r-xp /usr/lib/libecore_con.so.1.13.0
b5ebb000 b5ec1000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5ed1000 b5ee2000 r-xp /usr/lib/libemotion.so.1.13.0
b5ef3000 b5efa000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f0a000 b5f19000 r-xp /usr/lib/libeo.so.1.13.0
b5f2a000 b5f3c000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f4d000 b5f52000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f62000 b5f7b000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f8b000 b5fa8000 r-xp /usr/lib/libeet.so.1.13.0
b5fc1000 b6009000 r-xp /usr/lib/libeina.so.1.13.0
b601a000 b602a000 r-xp /usr/lib/libefl.so.1.13.0
b603b000 b6120000 r-xp /usr/lib/libicuuc.so.51.1
b613d000 b627d000 r-xp /usr/lib/libicui18n.so.51.1
b6294000 b62cc000 r-xp /usr/lib/libecore_x.so.1.13.0
b62de000 b62e1000 r-xp /lib/libcap.so.2.21
b62f1000 b631a000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b632b000 b6332000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6344000 b637b000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b638c000 b6477000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b648a000 b6503000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6515000 b651a000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b652a000 b6534000 r-xp /usr/lib/libvconf.so.0.2.45
b6544000 b6546000 r-xp /usr/lib/libvasum.so.0.3.1
b6556000 b6558000 r-xp /usr/lib/libttrace.so.1.1
b6568000 b656b000 r-xp /usr/lib/libiniparser.so.0
b657b000 b65a1000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65b1000 b65b6000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65c7000 b65de000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65ef000 b665a000 r-xp /lib/libm-2.20-2014.11.so
b666b000 b6671000 r-xp /lib/librt-2.20-2014.11.so
b6682000 b668f000 r-xp /usr/lib/libunwind.so.8.0.1
b66c5000 b67e9000 r-xp /lib/libc-2.20-2014.11.so
b67fe000 b6817000 r-xp /lib/libgcc_s-4.9.so.1
b6827000 b6909000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b691a000 b6944000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6955000 b6991000 r-xp /usr/lib/libsystemd.so.0.4.0
b6993000 b6a15000 r-xp /usr/lib/libedje.so.1.13.0
b6a28000 b6a46000 r-xp /usr/lib/libecore.so.1.13.0
b6a66000 b6bed000 r-xp /usr/lib/libevas.so.1.13.0
b6c22000 b6c36000 r-xp /lib/libpthread-2.20-2014.11.so
b6c4a000 b6e7f000 r-xp /usr/lib/libelementary.so.1.13.0
b6ead000 b6eb1000 r-xp /usr/lib/libsmack.so.1.0.0
b6ec1000 b6ec8000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6ed8000 b6eda000 r-xp /usr/lib/libdlog.so.0.0.0
b6eea000 b6eed000 r-xp /usr/lib/libbundle.so.0.1.22
b6efd000 b6eff000 r-xp /lib/libdl-2.20-2014.11.so
b6f10000 b6f28000 r-xp /usr/lib/libaul.so.0.1.0
b6f3c000 b6f41000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f52000 b6f5f000 r-xp /usr/lib/liblptcp.so
b6f71000 b6f75000 r-xp /usr/lib/libsys-assert.so
b6f86000 b6fa6000 r-xp /lib/ld-2.20-2014.11.so
b6fb7000 b6fbc000 r-xp /usr/bin/launchpad-loader
b78d4000 b7be7000 rw-p [heap]
bed73000 bed94000 rw-p [stack]
b78d4000 b7be7000 rw-p [heap]
bed73000 bed94000 rw-p [stack]
End of Maps Information

Callstack Information (PID:3394)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb66f0b84) [/lib/libc.so.6] + 0x2bb84
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
07-16 02:15:10.054+0600 I/Tizen::App( 1367): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.avoidrickshaw]
07-16 02:15:10.074+0600 I/Tizen::App( 1367): (416) > appName = [avoidrickshaw]
07-16 02:15:10.074+0600 I/Tizen::App( 1367): (509) > exe = [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw], displayName = [avoidrickshaw], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
07-16 02:15:10.074+0600 I/Tizen::App( 1367): (683) > Application count(1) in this package
07-16 02:15:10.074+0600 I/Tizen::App( 1367): (840) > Enter.
07-16 02:15:10.084+0600 I/Tizen::App( 1367): (703) > Exit.
07-16 02:15:10.084+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.avoidrickshaw], Key = [end], Value = [ok], install = [1]
07-16 02:15:10.084+0600 I/Tizen::App( 1367): (416) > appName = [avoidrickshaw]
07-16 02:15:10.084+0600 I/Tizen::App( 1367): (509) > exe = [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw], displayName = [avoidrickshaw], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
07-16 02:15:10.084+0600 I/Tizen::App( 1367): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.avoidrickshaw.info]
07-16 02:15:10.084+0600 I/Tizen::App( 1367): (131) > Enter
07-16 02:15:10.094+0600 I/Tizen::App( 1367): (137) > org.example.avoidrickshaw does not have launch condition
07-16 02:15:10.094+0600 I/Tizen::App( 1367): (883) > Exit.
07-16 02:15:14.689+0600 E/avoidrickshaw(16902): GPS not enabled
07-16 02:15:14.699+0600 E/avoidrickshaw(16902): GPS not enabled
07-16 02:15:14.699+0600 D/avoidrickshaw(16902): not detected text
07-16 02:15:14.819+0600 I/Tizen::System( 1367): (259) > Active app [org.exampl], current [com.samsun] 
07-16 02:15:14.819+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-16 02:15:14.839+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-16 02:15:15.600+0600 I/Tizen::App( 1367): (499) > LaunchedApp(org.example.avoidrickshaw)
07-16 02:15:15.600+0600 I/Tizen::App( 1367): (733) > Finished invoking application event listener for org.example.avoidrickshaw, 16902.
07-16 02:15:49.243+0600 I/Tizen::System( 1367): (259) > Active app [com.samsun], current [org.exampl] 
07-16 02:15:49.243+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-16 02:15:49.253+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-16 02:19:02.932+0600 I/Tizen::System( 1367): (259) > Active app [org.exampl], current [com.samsun] 
07-16 02:19:02.932+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-16 02:19:02.932+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-16 02:19:03.592+0600 I/Tizen::App( 1367): (499) > LaunchedApp(org.example.uicomponents)
07-16 02:19:03.592+0600 I/Tizen::App( 1367): (733) > Finished invoking application event listener for org.example.uicomponents, 17268.
07-16 02:31:57.437+0600 I/uicomponents(17268): Hover button is clicked and 'clicked' callback is called.
07-16 02:31:59.719+0600 I/uicomponents(17268): 'selected' callback is called. (selected item : Mobile)
07-16 02:32:00.000+0600 I/uicomponents(17268): 'dismissed' callback is called.
07-16 02:32:01.221+0600 I/uicomponents(17268): Hover button is clicked and 'clicked' callback is called.
07-16 02:32:02.762+0600 I/uicomponents(17268): 'dismissed' callback is called.
07-16 02:32:08.648+0600 I/uicomponents(17268): Hover button is clicked and 'clicked' callback is called.
07-16 02:32:09.729+0600 I/uicomponents(17268): 'dismissed' callback is called.
07-16 02:32:11.671+0600 I/uicomponents(17268): Hover button is clicked and 'clicked' callback is called.
07-16 02:32:13.062+0600 E/uicomponents(17268): Can't get screen reader app context - error code: -17891327
07-16 02:32:13.072+0600 E/uicomponents(17268): Can't get screen reader app context - error code: -17891327
07-16 02:32:13.223+0600 I/Tizen::System( 1367): (259) > Active app [com.samsun], current [org.exampl] 
07-16 02:32:13.223+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-16 02:32:13.223+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-16 02:32:13.743+0600 I/Tizen::App( 1367): (243) > App[org.example.uicomponents] pid[17268] terminate event is forwarded
07-16 02:32:13.743+0600 I/Tizen::System( 1367): (256) > osp.accessorymanager.service provider is found.
07-16 02:32:13.743+0600 I/Tizen::System( 1367): (196) > Accessory Owner is removed [org.example.uicomponents, 17268, ]
07-16 02:32:13.743+0600 I/Tizen::System( 1367): (256) > osp.system.service provider is found.
07-16 02:32:13.743+0600 I/Tizen::App( 1367): (506) > TerminatedApp(org.example.uicomponents)
07-16 02:32:13.743+0600 I/Tizen::App( 1367): (512) > Not registered pid(17268)
07-16 02:32:13.743+0600 I/Tizen::System( 1367): (246) > Terminated app [org.example.uicomponents]
07-16 02:32:13.743+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-16 02:32:13.763+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-16 02:32:13.763+0600 I/Tizen::App( 1367): (782) > Finished invoking application event listener for org.example.uicomponents, 17268.
07-16 02:32:14.834+0600 I/Tizen::System( 1367): (259) > Active app [org.exampl], current [com.samsun] 
07-16 02:32:14.834+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-16 02:32:14.844+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-16 02:32:15.455+0600 I/Tizen::App( 1367): (499) > LaunchedApp(org.example.uicomponents)
07-16 02:32:15.455+0600 I/Tizen::App( 1367): (733) > Finished invoking application event listener for org.example.uicomponents, 17985.
07-16 02:38:54.694+0600 E/uicomponents(17985): Can't get screen reader app context - error code: -17891327
07-16 02:38:54.704+0600 E/uicomponents(17985): Can't get screen reader app context - error code: -17891327
07-16 02:38:54.864+0600 I/Tizen::System( 1367): (259) > Active app [com.samsun], current [org.exampl] 
07-16 02:38:54.864+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-16 02:38:54.874+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-16 02:38:55.345+0600 I/Tizen::App( 1367): (243) > App[org.example.uicomponents] pid[17985] terminate event is forwarded
07-16 02:38:55.345+0600 I/Tizen::System( 1367): (256) > osp.accessorymanager.service provider is found.
07-16 02:38:55.345+0600 I/Tizen::System( 1367): (196) > Accessory Owner is removed [org.example.uicomponents, 17985, ]
07-16 02:38:55.345+0600 I/Tizen::System( 1367): (256) > osp.system.service provider is found.
07-16 02:38:55.345+0600 I/Tizen::App( 1367): (506) > TerminatedApp(org.example.uicomponents)
07-16 02:38:55.345+0600 I/Tizen::App( 1367): (512) > Not registered pid(17985)
07-16 02:38:55.345+0600 I/Tizen::System( 1367): (246) > Terminated app [org.example.uicomponents]
07-16 02:38:55.345+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-16 02:38:55.365+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-16 02:38:55.365+0600 I/Tizen::App( 1367): (782) > Finished invoking application event listener for org.example.uicomponents, 17985.
07-16 02:39:00.880+0600 I/Tizen::System( 1367): (259) > Active app [com.samsun], current [com.samsun] 
07-16 02:39:00.880+0600 I/Tizen::System( 1367): (273) > Current App[com.samsun] is already actived.
07-16 02:39:00.980+0600 I/Tizen::App( 1367): (499) > LaunchedApp(com.samsung.weather-m-agent)
07-16 02:39:00.980+0600 I/Tizen::App( 1367): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 20999.
07-16 02:50:31.211+0600 I/Tizen::App( 1367): (243) > App[com.samsung.weather-m-agent] pid[20999] terminate event is forwarded
07-16 02:50:31.211+0600 I/Tizen::System( 1367): (256) > osp.accessorymanager.service provider is found.
07-16 02:50:31.211+0600 I/Tizen::System( 1367): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 20999, ]
07-16 02:50:31.211+0600 I/Tizen::System( 1367): (256) > osp.system.service provider is found.
07-16 02:50:31.211+0600 I/Tizen::App( 1367): (506) > TerminatedApp(com.samsung.weather-m-agent)
07-16 02:50:31.211+0600 I/Tizen::App( 1367): (512) > Not registered pid(20999)
07-16 02:50:31.211+0600 I/Tizen::System( 1367): (246) > Terminated app [com.samsung.weather-m-agent]
07-16 02:50:31.211+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-16 02:50:31.221+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-16 02:50:31.221+0600 I/Tizen::App( 1367): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 20999.
07-16 14:07:24.673+0600 I/Tizen::System( 1367): (150) > Battery Warn Level is changed
07-16 14:07:24.673+0600 I/Tizen::System( 1367): (182) > Battery Level event is forwarded
07-18 21:29:09.018+0600 I/Tizen::System( 1367): (280) > The screen has been turned on.
07-18 21:29:09.018+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 21:29:09.168+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 21:29:09.178+0600 I/Tizen::App( 1367): (499) > LaunchedApp(com.samsung.weather-m-agent)
07-18 21:29:09.178+0600 I/Tizen::App( 1367): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 6454.
07-18 21:29:10.960+0600 I/Tizen::App( 1367): (243) > App[com.samsung.weather-m-agent] pid[6454] terminate event is forwarded
07-18 21:29:10.960+0600 I/Tizen::System( 1367): (256) > osp.accessorymanager.service provider is found.
07-18 21:29:10.960+0600 I/Tizen::System( 1367): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 6454, ]
07-18 21:29:10.960+0600 I/Tizen::System( 1367): (256) > osp.system.service provider is found.
07-18 21:29:10.960+0600 I/Tizen::App( 1367): (506) > TerminatedApp(com.samsung.weather-m-agent)
07-18 21:29:10.960+0600 I/Tizen::App( 1367): (512) > Not registered pid(6454)
07-18 21:29:10.960+0600 I/Tizen::System( 1367): (246) > Terminated app [com.samsung.weather-m-agent]
07-18 21:29:10.960+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 21:29:10.980+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 21:29:10.980+0600 I/Tizen::App( 1367): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 6454.
07-18 21:29:13.152+0600 I/Tizen::System( 1367): (259) > Active app [com.samsun], current [com.samsun] 
07-18 21:29:13.152+0600 I/Tizen::System( 1367): (273) > Current App[com.samsun] is already actived.
07-18 21:29:13.252+0600 I/Tizen::System( 1367): (340) > Setting event[http://tizen.org/setting/screen.wallpaper.lock] is occured.
07-18 21:29:13.252+0600 I/Tizen::System( 1367): (351) > The key is http://tizen.org/setting/screen.wallpaper.lock.
07-18 21:29:13.252+0600 I/Tizen::System( 1367): (355) > Try to awake client processes.
07-18 21:29:13.252+0600 I/Tizen::System( 1367): (362) > Event is delivered to b8203c50.
07-18 21:29:17.756+0600 I/Tizen::System( 1367): (340) > Setting event[http://tizen.org/setting/network.wifi] is occured.
07-18 21:29:17.756+0600 I/Tizen::System( 1367): (362) > Event is delivered to b8203c50.
07-18 21:29:17.826+0600 I/Tizen::Net::Wifi( 1367): (941) > The background scan result updated.
07-18 21:29:19.148+0600 I/Tizen::App( 1367): (499) > LaunchedApp(net.wifi-qs)
07-18 21:29:19.148+0600 I/Tizen::App( 1367): (733) > Finished invoking application event listener for net.wifi-qs, 13451.
07-18 21:29:19.768+0600 I/Tizen::System( 1367): (259) > Active app [org.tizen.], current [com.samsun] 
07-18 21:29:19.768+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 21:29:19.778+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 21:29:20.008+0600 I/Tizen::Net::Wifi( 1367): (941) > The background scan result updated.
07-18 21:29:20.279+0600 I/Tizen::App( 1367): (499) > LaunchedApp(org.tizen.gps-syspopup)
07-18 21:29:20.279+0600 I/Tizen::App( 1367): (733) > Finished invoking application event listener for org.tizen.gps-syspopup, 19495.
07-18 21:29:20.539+0600 E/Tizen::Base( 1367): (1083) > [E_OUT_OF_RANGE] The startIndex(11) MUST be greater than or equal to 0, and less than the length of this string(11).
07-18 21:29:20.539+0600 I/Tizen::System( 1367): (259) > Active app [net.wifi-q], current [org.tizen.] 
07-18 21:29:20.539+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 21:29:20.559+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 21:29:21.840+0600 I/Tizen::System( 1367): (259) > Active app [org.tizen.], current [net.wifi-q] 
07-18 21:29:21.840+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 21:29:21.840+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 21:29:22.211+0600 I/Tizen::App( 1367): (243) > App[net.wifi-qs] pid[13451] terminate event is forwarded
07-18 21:29:22.211+0600 I/Tizen::System( 1367): (256) > osp.accessorymanager.service provider is found.
07-18 21:29:22.211+0600 I/Tizen::System( 1367): (196) > Accessory Owner is removed [net.wifi-qs, 13451, ]
07-18 21:29:22.211+0600 I/Tizen::System( 1367): (256) > osp.system.service provider is found.
07-18 21:29:22.211+0600 I/Tizen::App( 1367): (506) > TerminatedApp(net.wifi-qs)
07-18 21:29:22.211+0600 I/Tizen::App( 1367): (512) > Not registered pid(13451)
07-18 21:29:22.211+0600 I/Tizen::System( 1367): (246) > Terminated app [net.wifi-qs]
07-18 21:29:22.211+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 21:29:22.221+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 21:29:22.221+0600 I/Tizen::App( 1367): (782) > Finished invoking application event listener for net.wifi-qs, 13451.
07-18 21:29:22.551+0600 I/Tizen::System( 1367): (340) > Setting event[http://tizen.org/setting/location.gps] is occured.
07-18 21:29:22.551+0600 I/Tizen::System( 1367): (362) > Event is delivered to b8203c50.
07-18 21:29:28.116+0600 I/Tizen::Net::Wifi( 1367): (941) > The background scan result updated.
07-18 21:29:29.448+0600 I/Tizen::System( 1367): (340) > Setting event[http://tizen.org/setting/location.wps] is occured.
07-18 21:29:29.448+0600 I/Tizen::System( 1367): (362) > Event is delivered to b8203c50.
07-18 21:29:29.568+0600 I/Tizen::System( 1367): (259) > Active app [com.samsun], current [org.tizen.] 
07-18 21:29:29.568+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 21:29:29.588+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 21:29:29.908+0600 I/Tizen::App( 1367): (243) > App[org.tizen.gps-syspopup] pid[19495] terminate event is forwarded
07-18 21:29:29.908+0600 I/Tizen::System( 1367): (256) > osp.accessorymanager.service provider is found.
07-18 21:29:29.908+0600 I/Tizen::System( 1367): (196) > Accessory Owner is removed [org.tizen.gps-syspopup, 19495, ]
07-18 21:29:29.908+0600 I/Tizen::System( 1367): (256) > osp.system.service provider is found.
07-18 21:29:29.908+0600 I/Tizen::App( 1367): (506) > TerminatedApp(org.tizen.gps-syspopup)
07-18 21:29:29.908+0600 I/Tizen::App( 1367): (512) > Not registered pid(19495)
07-18 21:29:29.908+0600 I/Tizen::System( 1367): (246) > Terminated app [org.tizen.gps-syspopup]
07-18 21:29:29.908+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 21:29:29.928+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 21:29:29.928+0600 I/Tizen::App( 1367): (782) > Finished invoking application event listener for org.tizen.gps-syspopup, 19495.
07-18 21:29:33.161+0600 I/Tizen::System( 1367): (259) > Active app [com.samsun], current [com.samsun] 
07-18 21:29:33.161+0600 I/Tizen::System( 1367): (273) > Current App[com.samsun] is already actived.
07-18 21:29:33.331+0600 I/Tizen::App( 1367): (499) > LaunchedApp(com.samsung.weather-m-agent)
07-18 21:29:33.331+0600 I/Tizen::App( 1367): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 6591.
07-18 21:29:34.723+0600 I/Tizen::App( 1367): (243) > App[com.samsung.weather-m-agent] pid[6591] terminate event is forwarded
07-18 21:29:34.723+0600 I/Tizen::System( 1367): (256) > osp.accessorymanager.service provider is found.
07-18 21:29:34.723+0600 I/Tizen::System( 1367): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 6591, ]
07-18 21:29:34.723+0600 I/Tizen::System( 1367): (256) > osp.system.service provider is found.
07-18 21:29:34.723+0600 I/Tizen::App( 1367): (506) > TerminatedApp(com.samsung.weather-m-agent)
07-18 21:29:34.723+0600 I/Tizen::App( 1367): (512) > Not registered pid(6591)
07-18 21:29:34.723+0600 I/Tizen::System( 1367): (246) > Terminated app [com.samsung.weather-m-agent]
07-18 21:29:34.723+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 21:29:34.733+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 21:29:34.733+0600 I/Tizen::App( 1367): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 6591.
07-18 21:29:44.342+0600 E/Tizen::App( 1367): (703) > Cannot acquire app for 6532.
07-18 21:29:44.372+0600 I/Tizen::App( 1367): (753) > [E_OBJ_NOT_FOUND] Cannot acquire app from pid 6532.
07-18 21:29:49.647+0600 I/Tizen::System( 1367): (280) > The screen has been turned on.
07-18 21:29:49.647+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 21:29:49.677+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 21:29:49.687+0600 I/Tizen::App( 1367): (499) > LaunchedApp(com.samsung.weather-m-agent)
07-18 21:29:49.687+0600 I/Tizen::App( 1367): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 6679.
07-18 21:29:50.808+0600 I/Tizen::System( 1367): (259) > Active app [com.samsun], current [com.samsun] 
07-18 21:29:50.808+0600 I/Tizen::System( 1367): (273) > Current App[com.samsun] is already actived.
07-18 21:29:50.889+0600 I/Tizen::System( 1367): (340) > Setting event[http://tizen.org/setting/screen.wallpaper.lock] is occured.
07-18 21:29:50.889+0600 I/Tizen::System( 1367): (351) > The key is http://tizen.org/setting/screen.wallpaper.lock.
07-18 21:29:50.889+0600 I/Tizen::System( 1367): (355) > Try to awake client processes.
07-18 21:29:50.889+0600 I/Tizen::System( 1367): (362) > Event is delivered to b8203c50.
07-18 21:29:51.149+0600 I/Tizen::App( 1367): (243) > App[com.samsung.weather-m-agent] pid[6679] terminate event is forwarded
07-18 21:29:51.149+0600 I/Tizen::System( 1367): (256) > osp.accessorymanager.service provider is found.
07-18 21:29:51.159+0600 I/Tizen::System( 1367): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 6679, ]
07-18 21:29:51.159+0600 I/Tizen::System( 1367): (256) > osp.system.service provider is found.
07-18 21:29:51.159+0600 I/Tizen::App( 1367): (506) > TerminatedApp(com.samsung.weather-m-agent)
07-18 21:29:51.159+0600 I/Tizen::App( 1367): (512) > Not registered pid(6679)
07-18 21:29:51.159+0600 I/Tizen::System( 1367): (246) > Terminated app [com.samsung.weather-m-agent]
07-18 21:29:51.159+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 21:29:51.159+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 21:29:51.159+0600 I/Tizen::App( 1367): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 6679.
07-18 21:29:51.469+0600 I/Tizen::Net::Wifi( 1367): (941) > The background scan result updated.
07-18 21:30:01.139+0600 I/Tizen::Net::Wifi( 1367): (941) > The background scan result updated.
07-18 21:30:03.951+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.healthcare, key: start, val: install
07-18 21:30:03.951+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.healthcare], Key = [start], Value = [install], install = [1]
07-18 21:30:03.971+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.healthcare, key: install_percent, val: 30
07-18 21:30:03.971+0600 I/Tizen::App( 1367): (119) > InstallationInProgress [30]
07-18 21:30:03.971+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.healthcare], Key = [install_percent], Value = [30], install = [1]
07-18 21:30:04.502+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.healthcare, key: install_percent, val: 60
07-18 21:30:04.502+0600 I/Tizen::App( 1367): (119) > InstallationInProgress [60]
07-18 21:30:04.502+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.healthcare], Key = [install_percent], Value = [60], install = [1]
07-18 21:30:04.582+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.healthcare, key: install_percent, val: 100
07-18 21:30:04.582+0600 I/Tizen::App( 1367): (119) > InstallationInProgress [100]
07-18 21:30:04.582+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.healthcare], Key = [install_percent], Value = [100], install = [1]
07-18 21:30:05.283+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.healthcare, key: end, val: ok
07-18 21:30:05.283+0600 I/Tizen::App( 1367): (78) > Installation is Completed. [Package = org.example.healthcare]
07-18 21:30:05.283+0600 I/Tizen::App( 1367): (671) > Enter. package(org.example.healthcare), installationResult(0)
07-18 21:30:05.303+0600 I/Tizen::App( 1367): (1360) > package(org.example.healthcare), version(1.0.0), type(tpk), displayName(healthcare), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.healthcare), storeClient(), appRootPath(/opt/usr/apps/org.example.healthcare)
07-18 21:30:05.363+0600 I/Tizen::App( 1367): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.healthcare]
07-18 21:30:05.383+0600 I/Tizen::App( 1367): (416) > appName = [healthcare]
07-18 21:30:05.383+0600 I/Tizen::App( 1367): (509) > exe = [/opt/usr/apps/org.example.healthcare/bin/healthcare], displayName = [healthcare], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
07-18 21:30:05.383+0600 I/Tizen::App( 1367): (683) > Application count(1) in this package
07-18 21:30:05.383+0600 I/Tizen::App( 1367): (840) > Enter.
07-18 21:30:05.383+0600 I/Tizen::App( 1367): (703) > Exit.
07-18 21:30:05.383+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.healthcare], Key = [end], Value = [ok], install = [1]
07-18 21:30:05.403+0600 I/Tizen::App( 1367): (416) > appName = [healthcare]
07-18 21:30:05.403+0600 I/Tizen::App( 1367): (509) > exe = [/opt/usr/apps/org.example.healthcare/bin/healthcare], displayName = [healthcare], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
07-18 21:30:05.403+0600 I/Tizen::App( 1367): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.healthcare.info]
07-18 21:30:05.403+0600 I/Tizen::App( 1367): (131) > Enter
07-18 21:30:05.403+0600 I/Tizen::App( 1367): (137) > org.example.healthcare does not have launch condition
07-18 21:30:05.403+0600 I/Tizen::App( 1367): (883) > Exit.
07-18 21:30:10.928+0600 D/healthcares( 6647): created
07-18 21:30:11.118+0600 D/healthcares( 6647): button create start
07-18 21:30:11.138+0600 D/healthcares( 6647): button create end
07-18 21:30:11.258+0600 D/before  ( 6647): created
07-18 21:30:11.369+0600 I/Tizen::System( 1367): (259) > Active app [org.exampl], current [com.samsun] 
07-18 21:30:11.369+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 21:30:11.379+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 21:30:12.069+0600 I/Tizen::App( 1367): (499) > LaunchedApp(org.example.healthcare)
07-18 21:30:12.069+0600 I/Tizen::App( 1367): (733) > Finished invoking application event listener for org.example.healthcare, 6647.
07-18 21:30:19.086+0600 I/Tizen::Net::Wifi( 1367): (941) > The background scan result updated.
07-18 21:30:29.236+0600 D/healthcares( 6647): buttonclicked
07-18 21:30:29.236+0600 D/healthcare( 6647): user height entry: 65
07-18 21:30:29.236+0600 D/healthcare( 6647): user weight entry: 78
07-18 21:30:29.236+0600 D/SavedData( 6647): dataSaved
07-18 21:30:53.109+0600 I/Tizen::Net::Wifi( 1367): (941) > The background scan result updated.
07-18 21:31:02.078+0600 D/healthcares( 6647): created
07-18 21:31:02.108+0600 D/healthcares( 6647): button create start
07-18 21:31:02.118+0600 D/healthcares( 6647): button create end
07-18 21:31:02.198+0600 I/healthcare( 6647): Settings item clicked 
07-18 21:31:04.430+0600 I/healthcare( 6647): HOme item clicked 
07-18 21:31:04.430+0600 D/HOmeView( 6647): homeviewcreated
07-18 21:31:05.862+0600 I/healthcare( 6647): Graph item clicked 
07-18 21:31:13.819+0600 I/healthcare( 6647): HOme item clicked 
07-18 21:31:13.819+0600 D/HOmeView( 6647): homeviewcreated
07-18 21:31:16.562+0600 I/healthcare( 6647): HOme item clicked 
07-18 21:31:16.562+0600 D/HOmeView( 6647): homeviewcreated
07-18 21:31:17.523+0600 I/healthcare( 6647): Graph item clicked 
07-18 21:31:19.025+0600 I/healthcare( 6647): HOme item clicked 
07-18 21:31:19.025+0600 D/HOmeView( 6647): homeviewcreated
07-18 21:31:21.547+0600 D/healthcares( 6647): created
07-18 21:31:21.587+0600 D/healthcares( 6647): button create start
07-18 21:31:21.587+0600 D/healthcares( 6647): button create end
07-18 21:31:21.667+0600 I/healthcare( 6647): Settings item clicked 
07-18 21:31:22.858+0600 I/healthcare( 6647): HOme item clicked 
07-18 21:31:22.858+0600 D/HOmeView( 6647): homeviewcreated
07-18 21:31:25.381+0600 I/healthcare( 6647): Graph item clicked 
07-18 21:31:26.452+0600 D/healthcares( 6647): created
07-18 21:31:26.482+0600 D/healthcares( 6647): button create start
07-18 21:31:26.492+0600 D/healthcares( 6647): button create end
07-18 21:31:26.572+0600 I/healthcare( 6647): Settings item clicked 
07-18 21:31:59.114+0600 I/Tizen::Net::Wifi( 1367): (941) > The background scan result updated.
07-18 21:34:09.150+0600 I/Tizen::Net::Wifi( 1367): (941) > The background scan result updated.
07-18 21:36:19.137+0600 I/Tizen::Net::Wifi( 1367): (941) > The background scan result updated.
07-18 21:36:36.554+0600 I/healthcare( 6647): Graph item clicked 
07-18 21:36:37.725+0600 I/healthcare( 6647): HOme item clicked 
07-18 21:36:37.725+0600 D/HOmeView( 6647): homeviewcreated
07-18 21:36:41.009+0600 I/Tizen::System( 1367): (259) > Active app [com.samsun], current [org.exampl] 
07-18 21:36:41.009+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 21:36:41.019+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 21:36:42.921+0600 I/Tizen::System( 1367): (259) > Active app [com.samsun], current [com.samsun] 
07-18 21:36:42.921+0600 I/Tizen::System( 1367): (273) > Current App[com.samsun] is already actived.
07-18 21:36:43.871+0600 I/Tizen::App( 1367): (499) > LaunchedApp(com.samsung.task-mgr)
07-18 21:36:43.871+0600 I/Tizen::App( 1367): (733) > Finished invoking application event listener for com.samsung.task-mgr, 6526.
07-18 21:36:45.563+0600 I/Tizen::App( 1367): (243) > App[org.example.avoidrickshaw] pid[16902] terminate event is forwarded
07-18 21:36:45.563+0600 I/Tizen::System( 1367): (256) > osp.accessorymanager.service provider is found.
07-18 21:36:45.563+0600 I/Tizen::System( 1367): (196) > Accessory Owner is removed [org.example.avoidrickshaw, 16902, ]
07-18 21:36:45.563+0600 I/Tizen::System( 1367): (256) > osp.system.service provider is found.
07-18 21:36:45.563+0600 I/Tizen::App( 1367): (506) > TerminatedApp(org.example.avoidrickshaw)
07-18 21:36:45.563+0600 I/Tizen::App( 1367): (512) > Not registered pid(16902)
07-18 21:36:45.563+0600 I/Tizen::System( 1367): (246) > Terminated app [org.example.avoidrickshaw]
07-18 21:36:45.573+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 21:36:45.593+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 21:36:45.593+0600 I/Tizen::App( 1367): (782) > Finished invoking application event listener for org.example.avoidrickshaw, 16902.
07-18 21:36:45.873+0600 I/Tizen::System( 1367): (259) > Active app [com.samsun], current [com.samsun] 
07-18 21:36:45.873+0600 I/Tizen::System( 1367): (273) > Current App[com.samsun] is already actived.
07-18 21:36:46.104+0600 I/Tizen::App( 1367): (243) > App[com.samsung.task-mgr] pid[6526] terminate event is forwarded
07-18 21:36:46.104+0600 I/Tizen::System( 1367): (256) > osp.accessorymanager.service provider is found.
07-18 21:36:46.104+0600 I/Tizen::System( 1367): (196) > Accessory Owner is removed [com.samsung.task-mgr, 6526, ]
07-18 21:36:46.104+0600 I/Tizen::System( 1367): (256) > osp.system.service provider is found.
07-18 21:36:46.104+0600 I/Tizen::App( 1367): (506) > TerminatedApp(com.samsung.task-mgr)
07-18 21:36:46.104+0600 I/Tizen::App( 1367): (512) > Not registered pid(6526)
07-18 21:36:46.104+0600 I/Tizen::System( 1367): (246) > Terminated app [com.samsung.task-mgr]
07-18 21:36:46.104+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 21:36:46.124+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 21:36:46.124+0600 I/Tizen::App( 1367): (782) > Finished invoking application event listener for com.samsung.task-mgr, 6526.
07-18 21:36:46.204+0600 I/Tizen::App( 1367): (243) > App[org.example.healthcare] pid[6647] terminate event is forwarded
07-18 21:36:46.204+0600 I/Tizen::System( 1367): (256) > osp.accessorymanager.service provider is found.
07-18 21:36:46.204+0600 I/Tizen::System( 1367): (196) > Accessory Owner is removed [org.example.healthcare, 6647, ]
07-18 21:36:46.204+0600 I/Tizen::System( 1367): (256) > osp.system.service provider is found.
07-18 21:36:46.204+0600 I/Tizen::App( 1367): (506) > TerminatedApp(org.example.healthcare)
07-18 21:36:46.204+0600 I/Tizen::App( 1367): (512) > Not registered pid(6647)
07-18 21:36:46.204+0600 I/Tizen::System( 1367): (246) > Terminated app [org.example.healthcare]
07-18 21:36:46.204+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 21:36:46.224+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 21:36:46.224+0600 I/Tizen::App( 1367): (782) > Finished invoking application event listener for org.example.healthcare, 6647.
07-18 21:36:48.226+0600 D/avoidrickshaw( 6918): ok text
07-18 21:36:48.326+0600 I/Tizen::System( 1367): (259) > Active app [org.exampl], current [com.samsun] 
07-18 21:36:48.326+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 21:36:48.336+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 21:36:49.066+0600 I/Tizen::App( 1367): (499) > LaunchedApp(org.example.avoidrickshaw)
07-18 21:36:49.066+0600 I/Tizen::App( 1367): (733) > Finished invoking application event listener for org.example.avoidrickshaw, 6918.
07-18 21:36:53.531+0600 I/Tizen::System( 1367): (259) > Active app [com.samsun], current [org.exampl] 
07-18 21:36:53.531+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 21:36:53.541+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 21:36:55.483+0600 D/healthcares( 7953): created
07-18 21:36:55.663+0600 D/healthcares( 7953): button create start
07-18 21:36:55.683+0600 D/healthcares( 7953): button create end
07-18 21:36:55.783+0600 D/before  ( 7953): created
07-18 21:36:55.903+0600 I/Tizen::System( 1367): (259) > Active app [org.exampl], current [com.samsun] 
07-18 21:36:55.903+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 21:36:55.903+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 21:36:56.614+0600 I/Tizen::App( 1367): (499) > LaunchedApp(org.example.healthcare)
07-18 21:36:56.614+0600 I/Tizen::App( 1367): (733) > Finished invoking application event listener for org.example.healthcare, 7953.
07-18 21:36:59.347+0600 D/menuoption( 7953): secondview
07-18 21:36:59.647+0600 D/menuoption( 7953): secondview
07-18 21:36:59.857+0600 D/menuoption( 7953): secondview
07-18 21:37:01.338+0600 I/healthcare( 7953): HOme item clicked 
07-18 21:37:01.338+0600 D/HOmeView( 7953): homeviewcreated
07-18 21:37:02.490+0600 D/healthcares( 7953): created
07-18 21:37:02.520+0600 D/healthcares( 7953): button create start
07-18 21:37:02.530+0600 D/healthcares( 7953): button create end
07-18 21:37:02.610+0600 I/healthcare( 7953): Settings item clicked 
07-18 21:37:03.421+0600 I/healthcare( 7953): Graph item clicked 
07-18 21:37:04.351+0600 I/healthcare( 7953): HOme item clicked 
07-18 21:37:04.351+0600 D/HOmeView( 7953): homeviewcreated
07-18 21:37:07.394+0600 I/Tizen::System( 1367): (259) > Active app [com.samsun], current [org.exampl] 
07-18 21:37:07.394+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 21:37:07.394+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 21:37:08.465+0600 I/Tizen::System( 1367): (259) > Active app [com.samsun], current [com.samsun] 
07-18 21:37:08.465+0600 I/Tizen::System( 1367): (273) > Current App[com.samsun] is already actived.
07-18 21:37:09.386+0600 I/Tizen::App( 1367): (499) > LaunchedApp(com.samsung.task-mgr)
07-18 21:37:09.386+0600 I/Tizen::App( 1367): (733) > Finished invoking application event listener for com.samsung.task-mgr, 7922.
07-18 21:37:09.987+0600 I/Tizen::System( 1367): (259) > Active app [com.samsun], current [com.samsun] 
07-18 21:37:09.987+0600 I/Tizen::System( 1367): (273) > Current App[com.samsun] is already actived.
07-18 21:37:09.987+0600 I/Tizen::App( 1367): (243) > App[org.example.avoidrickshaw] pid[6918] terminate event is forwarded
07-18 21:37:09.987+0600 I/Tizen::System( 1367): (256) > osp.accessorymanager.service provider is found.
07-18 21:37:09.987+0600 I/Tizen::System( 1367): (196) > Accessory Owner is removed [org.example.avoidrickshaw, 6918, ]
07-18 21:37:09.987+0600 I/Tizen::System( 1367): (256) > osp.system.service provider is found.
07-18 21:37:09.987+0600 I/Tizen::App( 1367): (506) > TerminatedApp(org.example.avoidrickshaw)
07-18 21:37:09.987+0600 I/Tizen::App( 1367): (512) > Not registered pid(6918)
07-18 21:37:09.987+0600 I/Tizen::System( 1367): (246) > Terminated app [org.example.avoidrickshaw]
07-18 21:37:09.987+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 21:37:10.087+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 21:37:10.087+0600 I/Tizen::App( 1367): (782) > Finished invoking application event listener for org.example.avoidrickshaw, 6918.
07-18 21:37:10.087+0600 I/Tizen::App( 1367): (243) > App[org.example.healthcare] pid[7953] terminate event is forwarded
07-18 21:37:10.087+0600 I/Tizen::System( 1367): (256) > osp.accessorymanager.service provider is found.
07-18 21:37:10.087+0600 I/Tizen::System( 1367): (196) > Accessory Owner is removed [org.example.healthcare, 7953, ]
07-18 21:37:10.087+0600 I/Tizen::System( 1367): (256) > osp.system.service provider is found.
07-18 21:37:10.087+0600 I/Tizen::App( 1367): (506) > TerminatedApp(org.example.healthcare)
07-18 21:37:10.087+0600 I/Tizen::App( 1367): (512) > Not registered pid(7953)
07-18 21:37:10.087+0600 I/Tizen::System( 1367): (246) > Terminated app [org.example.healthcare]
07-18 21:37:10.087+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 21:37:10.117+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 21:37:10.117+0600 I/Tizen::App( 1367): (782) > Finished invoking application event listener for org.example.healthcare, 7953.
07-18 21:37:10.437+0600 I/Tizen::App( 1367): (243) > App[com.samsung.task-mgr] pid[7922] terminate event is forwarded
07-18 21:37:10.437+0600 I/Tizen::System( 1367): (256) > osp.accessorymanager.service provider is found.
07-18 21:37:10.437+0600 I/Tizen::System( 1367): (196) > Accessory Owner is removed [com.samsung.task-mgr, 7922, ]
07-18 21:37:10.437+0600 I/Tizen::System( 1367): (256) > osp.system.service provider is found.
07-18 21:37:10.437+0600 I/Tizen::App( 1367): (506) > TerminatedApp(com.samsung.task-mgr)
07-18 21:37:10.437+0600 I/Tizen::App( 1367): (512) > Not registered pid(7922)
07-18 21:37:10.437+0600 I/Tizen::System( 1367): (246) > Terminated app [com.samsung.task-mgr]
07-18 21:37:10.437+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 21:37:10.477+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 21:37:10.477+0600 I/Tizen::App( 1367): (782) > Finished invoking application event listener for com.samsung.task-mgr, 7922.
07-18 21:37:11.749+0600 I/Tizen::System( 1367): (259) > Active app [com.samsun], current [com.samsun] 
07-18 21:37:11.749+0600 I/Tizen::System( 1367): (273) > Current App[com.samsun] is already actived.
07-18 21:37:11.859+0600 I/Tizen::App( 1367): (499) > LaunchedApp(com.samsung.weather-m-agent)
07-18 21:37:11.859+0600 I/Tizen::App( 1367): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 8034.
07-18 21:37:13.310+0600 I/Tizen::App( 1367): (243) > App[com.samsung.weather-m-agent] pid[8034] terminate event is forwarded
07-18 21:37:13.310+0600 I/Tizen::System( 1367): (256) > osp.accessorymanager.service provider is found.
07-18 21:37:13.310+0600 I/Tizen::System( 1367): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 8034, ]
07-18 21:37:13.310+0600 I/Tizen::System( 1367): (256) > osp.system.service provider is found.
07-18 21:37:13.310+0600 I/Tizen::App( 1367): (506) > TerminatedApp(com.samsung.weather-m-agent)
07-18 21:37:13.310+0600 I/Tizen::App( 1367): (512) > Not registered pid(8034)
07-18 21:37:13.310+0600 I/Tizen::System( 1367): (246) > Terminated app [com.samsung.weather-m-agent]
07-18 21:37:13.310+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 21:37:13.320+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 21:37:13.320+0600 I/Tizen::App( 1367): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 8034.
07-18 21:46:15.739+0600 I/Tizen::System( 1367): (280) > The screen has been turned on.
07-18 21:46:15.739+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 21:46:15.779+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 21:46:15.789+0600 I/Tizen::App( 1367): (499) > LaunchedApp(com.samsung.weather-m-agent)
07-18 21:46:15.789+0600 I/Tizen::App( 1367): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 10262.
07-18 21:46:17.271+0600 I/Tizen::App( 1367): (243) > App[com.samsung.weather-m-agent] pid[10262] terminate event is forwarded
07-18 21:46:17.271+0600 I/Tizen::System( 1367): (256) > osp.accessorymanager.service provider is found.
07-18 21:46:17.271+0600 I/Tizen::System( 1367): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 10262, ]
07-18 21:46:17.271+0600 I/Tizen::System( 1367): (256) > osp.system.service provider is found.
07-18 21:46:17.271+0600 I/Tizen::App( 1367): (506) > TerminatedApp(com.samsung.weather-m-agent)
07-18 21:46:17.271+0600 I/Tizen::App( 1367): (512) > Not registered pid(10262)
07-18 21:46:17.271+0600 I/Tizen::System( 1367): (246) > Terminated app [com.samsung.weather-m-agent]
07-18 21:46:17.271+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 21:46:17.291+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 21:46:17.291+0600 I/Tizen::App( 1367): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 10262.
07-18 21:46:17.591+0600 I/Tizen::System( 1367): (259) > Active app [com.samsun], current [com.samsun] 
07-18 21:46:17.591+0600 I/Tizen::System( 1367): (273) > Current App[com.samsun] is already actived.
07-18 21:46:17.681+0600 I/Tizen::System( 1367): (340) > Setting event[http://tizen.org/setting/screen.wallpaper.lock] is occured.
07-18 21:46:17.681+0600 I/Tizen::System( 1367): (351) > The key is http://tizen.org/setting/screen.wallpaper.lock.
07-18 21:46:17.681+0600 I/Tizen::System( 1367): (355) > Try to awake client processes.
07-18 21:46:17.691+0600 I/Tizen::System( 1367): (362) > Event is delivered to b8203c50.
07-18 21:46:17.731+0600 I/Tizen::Net::Wifi( 1367): (941) > The background scan result updated.
07-18 21:46:19.903+0600 D/healthcares( 7984): created
07-18 21:46:20.084+0600 D/healthcares( 7984): button create start
07-18 21:46:20.104+0600 D/healthcares( 7984): button create end
07-18 21:46:20.204+0600 D/before  ( 7984): created
07-18 21:46:20.314+0600 I/Tizen::System( 1367): (259) > Active app [org.exampl], current [com.samsun] 
07-18 21:46:20.314+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 21:46:20.314+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 21:46:21.035+0600 I/Tizen::App( 1367): (499) > LaunchedApp(org.example.healthcare)
07-18 21:46:21.035+0600 I/Tizen::App( 1367): (733) > Finished invoking application event listener for org.example.healthcare, 7984.
07-18 21:46:28.181+0600 I/Tizen::Net::Wifi( 1367): (941) > The background scan result updated.
07-18 21:46:38.061+0600 I/healthcare( 7984): HOme item clicked 
07-18 21:46:38.061+0600 D/HOmeView( 7984): homeviewcreated
07-18 21:46:39.372+0600 D/healthcares( 7984): created
07-18 21:46:39.412+0600 D/healthcares( 7984): button create start
07-18 21:46:39.412+0600 D/healthcares( 7984): button create end
07-18 21:46:39.493+0600 I/healthcare( 7984): Settings item clicked 
07-18 21:46:41.775+0600 I/healthcare( 7984): Graph item clicked 
07-18 21:46:46.099+0600 I/Tizen::Net::Wifi( 1367): (941) > The background scan result updated.
07-18 21:47:20.132+0600 I/Tizen::Net::Wifi( 1367): (941) > The background scan result updated.
07-18 21:48:26.137+0600 I/Tizen::Net::Wifi( 1367): (941) > The background scan result updated.
07-18 21:50:36.183+0600 I/Tizen::Net::Wifi( 1367): (941) > The background scan result updated.
07-18 21:52:27.332+0600 I/Tizen::System( 1367): (259) > Active app [com.samsun], current [org.exampl] 
07-18 21:52:27.332+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 21:52:27.352+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 21:52:27.672+0600 I/Tizen::App( 1367): (243) > App[org.example.healthcare] pid[7984] terminate event is forwarded
07-18 21:52:27.672+0600 I/Tizen::System( 1367): (256) > osp.accessorymanager.service provider is found.
07-18 21:52:27.672+0600 I/Tizen::System( 1367): (196) > Accessory Owner is removed [org.example.healthcare, 7984, ]
07-18 21:52:27.672+0600 I/Tizen::System( 1367): (256) > osp.system.service provider is found.
07-18 21:52:27.672+0600 I/Tizen::App( 1367): (506) > TerminatedApp(org.example.healthcare)
07-18 21:52:27.672+0600 I/Tizen::App( 1367): (512) > Not registered pid(7984)
07-18 21:52:27.672+0600 I/Tizen::System( 1367): (246) > Terminated app [org.example.healthcare]
07-18 21:52:27.672+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 21:52:27.692+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 21:52:27.692+0600 I/Tizen::App( 1367): (782) > Finished invoking application event listener for org.example.healthcare, 7984.
07-18 21:52:34.399+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.healthcare, key: start, val: update
07-18 21:52:34.399+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.healthcare], Key = [start], Value = [update], install = [1]
07-18 21:52:34.419+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.healthcare, key: install_percent, val: 30
07-18 21:52:34.419+0600 I/Tizen::App( 1367): (119) > InstallationInProgress [30]
07-18 21:52:34.419+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.healthcare], Key = [install_percent], Value = [30], install = [1]
07-18 21:52:34.809+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.healthcare, key: end, val: fail
07-18 21:52:34.809+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.healthcare], Key = [end], Value = [fail], install = [1]
07-18 21:52:39.574+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.healthcare, key: start, val: install
07-18 21:52:39.574+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.healthcare], Key = [start], Value = [install], install = [1]
07-18 21:52:39.594+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.healthcare, key: install_percent, val: 30
07-18 21:52:39.594+0600 I/Tizen::App( 1367): (119) > InstallationInProgress [30]
07-18 21:52:39.594+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.healthcare], Key = [install_percent], Value = [30], install = [1]
07-18 21:52:40.084+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.healthcare, key: install_percent, val: 60
07-18 21:52:40.084+0600 I/Tizen::App( 1367): (119) > InstallationInProgress [60]
07-18 21:52:40.084+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.healthcare], Key = [install_percent], Value = [60], install = [1]
07-18 21:52:40.154+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.healthcare, key: install_percent, val: 100
07-18 21:52:40.154+0600 I/Tizen::App( 1367): (119) > InstallationInProgress [100]
07-18 21:52:40.154+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.healthcare], Key = [install_percent], Value = [100], install = [1]
07-18 21:52:40.875+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.healthcare, key: end, val: ok
07-18 21:52:40.875+0600 I/Tizen::App( 1367): (78) > Installation is Completed. [Package = org.example.healthcare]
07-18 21:52:40.875+0600 I/Tizen::App( 1367): (671) > Enter. package(org.example.healthcare), installationResult(0)
07-18 21:52:40.885+0600 I/Tizen::App( 1367): (1360) > package(org.example.healthcare), version(1.0.0), type(tpk), displayName(healthcare), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.healthcare), storeClient(), appRootPath(/opt/usr/apps/org.example.healthcare)
07-18 21:52:40.945+0600 I/Tizen::App( 1367): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.healthcare]
07-18 21:52:40.955+0600 I/Tizen::App( 1367): (416) > appName = [healthcare]
07-18 21:52:40.955+0600 I/Tizen::App( 1367): (509) > exe = [/opt/usr/apps/org.example.healthcare/bin/healthcare], displayName = [healthcare], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
07-18 21:52:40.955+0600 I/Tizen::App( 1367): (683) > Application count(1) in this package
07-18 21:52:40.955+0600 I/Tizen::App( 1367): (840) > Enter.
07-18 21:52:40.955+0600 I/Tizen::App( 1367): (703) > Exit.
07-18 21:52:40.955+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.healthcare], Key = [end], Value = [ok], install = [1]
07-18 21:52:40.965+0600 I/Tizen::App( 1367): (416) > appName = [healthcare]
07-18 21:52:40.965+0600 I/Tizen::App( 1367): (509) > exe = [/opt/usr/apps/org.example.healthcare/bin/healthcare], displayName = [healthcare], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
07-18 21:52:40.965+0600 I/Tizen::App( 1367): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.healthcare.info]
07-18 21:52:40.965+0600 I/Tizen::App( 1367): (131) > Enter
07-18 21:52:40.995+0600 I/Tizen::App( 1367): (137) > org.example.healthcare does not have launch condition
07-18 21:52:40.995+0600 I/Tizen::App( 1367): (883) > Exit.
07-18 21:52:46.150+0600 I/Tizen::Net::Wifi( 1367): (941) > The background scan result updated.
07-18 21:52:46.911+0600 D/healthcares(10287): created
07-18 21:52:47.091+0600 D/healthcares(10287): button create start
07-18 21:52:47.111+0600 D/healthcares(10287): button create end
07-18 21:52:47.231+0600 D/before  (10287): created
07-18 21:52:47.361+0600 I/Tizen::System( 1367): (259) > Active app [org.exampl], current [com.samsun] 
07-18 21:52:47.361+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 21:52:47.361+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 21:52:48.032+0600 I/Tizen::App( 1367): (499) > LaunchedApp(org.example.healthcare)
07-18 21:52:48.032+0600 I/Tizen::App( 1367): (733) > Finished invoking application event listener for org.example.healthcare, 10287.
07-18 21:52:56.030+0600 D/menuoption(10287): secondview
07-18 21:52:56.460+0600 D/menuoption(10287): secondview
07-18 21:52:56.671+0600 D/menuoption(10287): secondview
07-18 21:53:01.525+0600 I/Tizen::System( 1367): (259) > Active app [com.samsun], current [org.exampl] 
07-18 21:53:01.525+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 21:53:01.535+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 21:53:04.818+0600 I/Tizen::System( 1367): (259) > Active app [com.samsun], current [com.samsun] 
07-18 21:53:04.828+0600 I/Tizen::System( 1367): (273) > Current App[com.samsun] is already actived.
07-18 21:53:04.979+0600 I/Tizen::App( 1367): (499) > LaunchedApp(com.samsung.weather-m-agent)
07-18 21:53:04.979+0600 I/Tizen::App( 1367): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 11792.
07-18 21:53:06.350+0600 I/Tizen::App( 1367): (243) > App[com.samsung.weather-m-agent] pid[11792] terminate event is forwarded
07-18 21:53:06.350+0600 I/Tizen::System( 1367): (256) > osp.accessorymanager.service provider is found.
07-18 21:53:06.350+0600 I/Tizen::System( 1367): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 11792, ]
07-18 21:53:06.350+0600 I/Tizen::System( 1367): (256) > osp.system.service provider is found.
07-18 21:53:06.350+0600 I/Tizen::App( 1367): (506) > TerminatedApp(com.samsung.we
