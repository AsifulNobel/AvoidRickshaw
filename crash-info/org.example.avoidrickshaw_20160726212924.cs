S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPD6
Build-Date: 2016.04.28 20:23:28

Crash Information
Process Name: avoidrickshaw
PID: 29208
Date: 2016-07-26 21:29:24+0600
Executable File Path: /opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 29208, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0xb73d3fc0
r2   = 0x00000305, r3   = 0x00000004
r4   = 0xb6a9852d, r5   = 0xb60136ec
r6   = 0xb6000e30, r7   = 0x00000000
r8   = 0x00000004, r9   = 0x00000000
r10  = 0xb741d300, fp   = 0x00000000
ip   = 0x00000001, sp   = 0xbec84150
lr   = 0xb5ff9a17, pc   = 0xb6a9854e
cpsr = 0x600d0030

Memory Information
MemTotal:   730440 KB
MemFree:     41184 KB
Buffers:     46504 KB
Cached:     276724 KB
VmPeak:     115416 KB
VmSize:     115412 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24060 KB
VmRSS:       24060 KB
VmData:      42780 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36276 KB
VmPTE:          84 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 29208 TID = 29208
29208 29210 29917 29924 29940 

Maps Information
b0513000 b0d12000 rw-p [stack:29940]
b1301000 b1b00000 rw-p [stack:29924]
b1c6d000 b1c75000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.49
b1c85000 b1c87000 r-xp /usr/lib/liblbs-agps.so.0.1.0
b1c97000 b1ca5000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
b1cbc000 b1cbe000 r-xp /usr/lib/location/module/libwps.so.0.6.8_9
b1cce000 b1cd1000 r-xp /usr/lib/location/module/libgps.so.0.6.8_9
b1ce2000 b24e1000 rw-p [stack:29917]
b255d000 b2565000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2576000 b2577000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b2587000 b259b000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b25af000 b25b0000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b25c0000 b25c3000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b25d4000 b25d5000 r-xp /usr/lib/libxshmfence.so.1.0.0
b25e5000 b25e7000 r-xp /usr/lib/libxcb-present.so.0.0.0
b25f7000 b25f9000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2609000 b2619000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2629000 b2635000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b2885000 b2887000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b2897000 b289d000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b28ad000 b28c1000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b28d1000 b28eb000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b28fb000 b2901000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
b2911000 b2918000 r-xp /usr/lib/libeventsystem.so.0.0.1
b2928000 b294b000 r-xp /usr/lib/libSLP-location-product.so.0.9.0
b295c000 b2973000 r-xp /usr/lib/libSLP-location.so.0.11.5_5
b2983000 b298a000 r-xp /usr/lib/libefl-extension.so.0.1.0
b299b000 b29a3000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b29b3000 b29b7000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
b29c8000 b29d7000 r-xp /usr/lib/libcapi-location-manager.so.0.6.1_3
b29e7000 b29ee000 r-xp /usr/lib/libcapi-appfw-preference.so.0.3.1.0
b2a00000 b2a06000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2a16000 b2a1e000 r-xp /opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw
b2b3f000 b2c22000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2c59000 b2c81000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2c93000 b3492000 rw-p [stack:29210]
b3492000 b3494000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b34a4000 b34ae000 r-xp /lib/libnss_files-2.20-2014.11.so
b34bf000 b34c8000 r-xp /lib/libnss_nis-2.20-2014.11.so
b34d9000 b34ea000 r-xp /lib/libnsl-2.20-2014.11.so
b34fd000 b3503000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3514000 b3515000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b353d000 b3544000 r-xp /usr/lib/libminizip.so.1.0.0
b3554000 b3559000 r-xp /usr/lib/libstorage.so.0.1
b3569000 b35be000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b35d4000 b35e8000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b35f8000 b363c000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b364c000 b3654000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3664000 b3694000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b36a7000 b3760000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3774000 b37c8000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b37d9000 b37f4000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3804000 b38c5000 r-xp /usr/lib/libprotobuf.so.9.0.1
b38d8000 b38ea000 r-xp /usr/lib/libefl-assist.so.0.1.0
b38fa000 b38fe000 r-xp /usr/lib/libogg.so.0.7.1
b390e000 b3930000 r-xp /usr/lib/libvorbis.so.0.4.3
b3940000 b3a24000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b3a40000 b3a4d000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3a5e000 b3aa1000 r-xp /usr/lib/libsndfile.so.1.0.25
b3ab6000 b3afd000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3b0e000 b3b14000 r-xp /usr/lib/libjson-c.so.2.0.1
b3b25000 b3b2c000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3b3c000 b3b7c000 r-xp /usr/lib/libmdm.so.1.2.10
b3b8c000 b3b94000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3ba3000 b3bb3000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3bd4000 b3c34000 r-xp /usr/lib/libasound.so.2.0.0
b3c46000 b3c7c000 r-xp /usr/lib/libpulse.so.0.16.2
b3c8d000 b3c90000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3ca0000 b3ca3000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3cb3000 b3cb8000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3cc8000 b3cc9000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3cd9000 b3ce4000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3cf8000 b3cff000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3d0f000 b3d15000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3d25000 b3d2a000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3d3a000 b3d55000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3d65000 b3d6c000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3d7c000 b3d7f000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3d90000 b3dbe000 r-xp /usr/lib/libidn.so.11.5.44
b3dce000 b3de4000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3df5000 b3dff000 r-xp /usr/lib/libcares.so.2.1.0
b3e0f000 b3e19000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3e29000 b3e2b000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3e3b000 b3e3c000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3e4c000 b3e50000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3e61000 b3e89000 r-xp /usr/lib/libui-extension.so.0.1.0
b3e9a000 b3ec3000 r-xp /usr/lib/libturbojpeg.so
b3ee3000 b3ee9000 r-xp /usr/lib/libgif.so.4.1.6
b3ef9000 b3f3f000 r-xp /usr/lib/libcurl.so.4.3.0
b3f50000 b3f71000 r-xp /usr/lib/libexif.so.12.3.3
b3f8c000 b3fa1000 r-xp /usr/lib/libtts.so
b3fb2000 b3fba000 r-xp /usr/lib/libfeedback.so.0.1.4
b3fca000 b408a000 r-xp /usr/lib/libdali-core.so.0.0.0
b4095000 b4188000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b41a8000 b4282000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b4299000 b429b000 r-xp /usr/lib/libboost_system.so.1.51.0
b42ab000 b42b1000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b42c1000 b42e4000 r-xp /usr/lib/libboost_thread.so.1.51.0
b42f5000 b42f7000 r-xp /usr/lib/libappsvc.so.0.1.0
b4307000 b4309000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b431a000 b431f000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4336000 b4338000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b4348000 b434f000 r-xp /usr/lib/libsensord-share.so
b435f000 b4377000 r-xp /usr/lib/libsensor.so.1.1.0
b4388000 b438b000 r-xp /usr/lib/libXv.so.1.0.0
b439b000 b43a0000 r-xp /usr/lib/libutilX.so.1.1.0
b43b0000 b43b5000 r-xp /usr/lib/libappcore-common.so.1.1
b43c5000 b43cc000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b43df000 b43e3000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b43f4000 b44be000 r-xp /usr/lib/libCOREGL.so.4.0
b44d5000 b44d8000 r-xp /usr/lib/libuuid.so.1.3.0
b44e9000 b4500000 r-xp /usr/lib/libblkid.so.1.1.0
b4511000 b4513000 r-xp /usr/lib/libXau.so.6.0.0
b4523000 b4526000 r-xp /usr/lib/libEGL.so.1.4
b452e000 b4534000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4544000 b4546000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4557000 b4565000 r-xp /usr/lib/libGLESv2.so.2.0
b456e000 b45d0000 r-xp /usr/lib/libpixman-1.so.0.28.2
b45e5000 b45fd000 r-xp /usr/lib/libmount.so.1.1.0
b460e000 b4622000 r-xp /usr/lib/libxcb.so.1.1.0
b4633000 b463a000 r-xp /lib/libcrypt-2.20-2014.11.so
b4672000 b4683000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b4694000 b4696000 r-xp /usr/lib/libiri.so
b46a6000 b46b1000 r-xp /usr/lib/libgpg-error.so.0.15.0
b46c2000 b46d7000 r-xp /lib/libexpat.so.1.5.2
b46e9000 b47a7000 r-xp /usr/lib/libcairo.so.2.11200.14
b47ba000 b47c2000 r-xp /usr/lib/libdrm.so.2.4.0
b47d2000 b47d5000 r-xp /usr/lib/libdri2.so.0.0.0
b47e6000 b4834000 r-xp /usr/lib/libssl.so.1.0.0
b4849000 b4855000 r-xp /usr/lib/libeeze.so.1.13.0
b4865000 b486e000 r-xp /usr/lib/libethumb.so.1.13.0
b487e000 b4881000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4891000 b4a48000 r-xp /usr/lib/libcrypto.so.1.0.0
b569f000 b56a8000 r-xp /usr/lib/libXi.so.6.1.0
b56b8000 b56ba000 r-xp /usr/lib/libXgesture.so.7.0.0
b56ca000 b56ce000 r-xp /usr/lib/libXtst.so.6.1.0
b56de000 b56e4000 r-xp /usr/lib/libXrender.so.1.3.0
b56f4000 b56fa000 r-xp /usr/lib/libXrandr.so.2.2.0
b570b000 b570d000 r-xp /usr/lib/libXinerama.so.1.0.0
b571d000 b5720000 r-xp /usr/lib/libXfixes.so.3.1.0
b5730000 b573b000 r-xp /usr/lib/libXext.so.6.4.0
b574b000 b574d000 r-xp /usr/lib/libXdamage.so.1.1.0
b575d000 b575f000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5770000 b5852000 r-xp /usr/lib/libX11.so.6.3.0
b5865000 b586c000 r-xp /usr/lib/libXcursor.so.1.0.2
b587c000 b5894000 r-xp /usr/lib/libudev.so.1.6.0
b5896000 b5899000 r-xp /lib/libattr.so.1.1.0
b58a9000 b58c9000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58cb000 b58d0000 r-xp /usr/lib/libffi.so.6.0.2
b58e0000 b58f8000 r-xp /lib/libz.so.1.2.8
b5908000 b590a000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b591a000 b59ef000 r-xp /usr/lib/libxml2.so.2.9.2
b5a04000 b5a9f000 r-xp /usr/lib/libstdc++.so.6.0.20
b5abb000 b5abe000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5ace000 b5ae7000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5af8000 b5b09000 r-xp /lib/libresolv-2.20-2014.11.so
b5b1d000 b5b97000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5bac000 b5bae000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bbe000 b5bc5000 r-xp /usr/lib/libembryo.so.1.13.0
b5bd5000 b5bed000 r-xp /usr/lib/libpng12.so.0.50.0
b5bfe000 b5c21000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c42000 b5c56000 r-xp /usr/lib/libector.so.1.13.0
b5c67000 b5c7f000 r-xp /usr/lib/liblua-5.1.so
b5c90000 b5ce7000 r-xp /usr/lib/libfreetype.so.6.11.3
b5cfb000 b5d23000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d34000 b5d47000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d58000 b5d8f000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5da0000 b5dae000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5dbe000 b5dc6000 r-xp /usr/lib/libtbm.so.1.0.0
b5dd6000 b5de3000 r-xp /usr/lib/libeio.so.1.13.0
b5df3000 b5df5000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e05000 b5e0a000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e1a000 b5e31000 r-xp /usr/lib/libefreet.so.1.13.0
b5e43000 b5e63000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e73000 b5e93000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e95000 b5e9b000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5eab000 b5ebc000 r-xp /usr/lib/libemotion.so.1.13.0
b5ecd000 b5ed4000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5ee4000 b5ef3000 r-xp /usr/lib/libeo.so.1.13.0
b5f04000 b5f16000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f27000 b5f2c000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f3c000 b5f55000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f65000 b5f82000 r-xp /usr/lib/libeet.so.1.13.0
b5f9b000 b5fe3000 r-xp /usr/lib/libeina.so.1.13.0
b5ff4000 b6004000 r-xp /usr/lib/libefl.so.1.13.0
b6015000 b60fa000 r-xp /usr/lib/libicuuc.so.51.1
b6117000 b6257000 r-xp /usr/lib/libicui18n.so.51.1
b626e000 b62a6000 r-xp /usr/lib/libecore_x.so.1.13.0
b62b8000 b62bb000 r-xp /lib/libcap.so.2.21
b62cb000 b62f4000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6305000 b630c000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b631e000 b6355000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6366000 b6451000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6464000 b64dd000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64ef000 b64f4000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6504000 b650e000 r-xp /usr/lib/libvconf.so.0.2.45
b651e000 b6520000 r-xp /usr/lib/libvasum.so.0.3.1
b6530000 b6532000 r-xp /usr/lib/libttrace.so.1.1
b6542000 b6545000 r-xp /usr/lib/libiniparser.so.0
b6555000 b657b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b658b000 b6590000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65a1000 b65b8000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65c9000 b6634000 r-xp /lib/libm-2.20-2014.11.so
b6645000 b664b000 r-xp /lib/librt-2.20-2014.11.so
b665c000 b6669000 r-xp /usr/lib/libunwind.so.8.0.1
b669f000 b67c3000 r-xp /lib/libc-2.20-2014.11.so
b67d8000 b67f1000 r-xp /lib/libgcc_s-4.9.so.1
b6801000 b68e3000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68f4000 b691e000 r-xp /usr/lib/libdbus-1.so.3.8.12
b692f000 b696b000 r-xp /usr/lib/libsystemd.so.0.4.0
b696d000 b69ef000 r-xp /usr/lib/libedje.so.1.13.0
b6a02000 b6a20000 r-xp /usr/lib/libecore.so.1.13.0
b6a40000 b6bc7000 r-xp /usr/lib/libevas.so.1.13.0
b6bfc000 b6c10000 r-xp /lib/libpthread-2.20-2014.11.so
b6c24000 b6e59000 r-xp /usr/lib/libelementary.so.1.13.0
b6e87000 b6e8b000 r-xp /usr/lib/libsmack.so.1.0.0
b6e9b000 b6ea2000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6eb2000 b6eb4000 r-xp /usr/lib/libdlog.so.0.0.0
b6ec4000 b6ec7000 r-xp /usr/lib/libbundle.so.0.1.22
b6ed7000 b6ed9000 r-xp /lib/libdl-2.20-2014.11.so
b6eea000 b6f02000 r-xp /usr/lib/libaul.so.0.1.0
b6f16000 b6f1b000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f2c000 b6f39000 r-xp /usr/lib/liblptcp.so
b6f4b000 b6f4f000 r-xp /usr/lib/libsys-assert.so
b6f60000 b6f80000 r-xp /lib/ld-2.20-2014.11.so
b6f91000 b6f96000 r-xp /usr/bin/launchpad-loader
b7202000 b74fb000 rw-p [heap]
bec64000 bec85000 rw-p [stack]
b7202000 b74fb000 rw-p [heap]
bec64000 bec85000 rw-p [stack]
End of Maps Information

Callstack Information (PID:29208)
Call Stack Count: 1
 0: (0xb6a9854e) [/usr/lib/libevas.so.1] + 0x5854e
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
07-25 22:05:20.160+0600 D/avoidrickshaw(32394): event-values: 0.193819, -0.072383, 10.173683, 0.000000
07-25 22:05:20.220+0600 D/avoidrickshaw(32394): event-values: 0.205185, -0.074776, 10.174880, 0.000000
07-25 22:05:20.280+0600 D/avoidrickshaw(32394): event-values: 0.212363, -0.083749, 10.171290, 0.000000
07-25 22:05:20.340+0600 D/avoidrickshaw(32394): event-values: 0.196810, -0.088534, 10.178469, 0.000000
07-25 22:05:20.400+0600 D/avoidrickshaw(32394): event-values: 0.185444, -0.063410, 10.146166, 0.000000
07-25 22:05:20.461+0600 D/avoidrickshaw(32394): event-values: 0.236291, -0.059222, 10.209577, 0.000000
07-25 22:05:20.521+0600 D/avoidrickshaw(32394): event-values: 0.175872, -0.078963, 10.166506, 0.000000
07-25 22:05:20.581+0600 D/avoidrickshaw(32394): event-values: 0.202193, -0.074776, 10.182656, 0.000000
07-25 22:05:20.641+0600 D/avoidrickshaw(32394): event-values: 0.185444, -0.071785, 10.162319, 0.000000
07-25 22:05:20.691+0600 D/avoidrickshaw(32394): event-values: 0.215952, -0.059222, 10.162319, 0.000000
07-25 22:05:20.751+0600 D/avoidrickshaw(32394): event-values: 0.168694, -0.067597, 10.164711, 0.000000
07-25 22:05:20.811+0600 D/avoidrickshaw(32394): event-values: 0.164507, -0.101695, 10.158132, 0.000000
07-25 22:05:20.871+0600 D/avoidrickshaw(32394): event-values: 0.214158, -0.068195, 10.190434, 0.000000
07-25 22:05:20.931+0600 D/avoidrickshaw(32394): event-values: 0.162114, -0.078365, 10.168897, 0.000000
07-25 22:05:20.991+0600 D/avoidrickshaw(32394): event-values: 0.202792, -0.089731, 10.165908, 0.000000
07-25 22:05:21.051+0600 D/avoidrickshaw(32394): event-values: 0.166301, -0.067597, 10.112068, 0.000000
07-25 22:05:21.111+0600 D/avoidrickshaw(32394): event-values: 0.227318, -0.079561, 10.195816, 0.000000
07-25 22:05:21.171+0600 D/avoidrickshaw(32394): event-values: 0.192622, -0.060419, 10.149158, 0.000000
07-25 22:05:21.231+0600 D/avoidrickshaw(32394): event-values: 0.193220, -0.083749, 10.174880, 0.000000
07-25 22:05:21.291+0600 D/avoidrickshaw(32394): event-values: 0.161516, -0.087338, 10.165908, 0.000000
07-25 22:05:21.351+0600 D/avoidrickshaw(32394): event-values: 0.223729, -0.051446, 10.164113, 0.000000
07-25 22:05:21.411+0600 D/avoidrickshaw(32394): event-values: 0.233300, -0.052044, 10.183852, 0.000000
07-25 22:05:21.472+0600 D/avoidrickshaw(32394): event-values: 0.223729, -0.081356, 10.155140, 0.000000
07-25 22:05:21.532+0600 D/avoidrickshaw(32394): event-values: 0.178265, -0.100499, 10.189835, 0.000000
07-25 22:05:21.592+0600 D/avoidrickshaw(32394): event-values: 0.227916, -0.073579, 10.157533, 0.000000
07-25 22:05:21.652+0600 D/avoidrickshaw(32394): event-values: 0.186640, -0.049651, 10.227522, 0.000000
07-25 22:05:21.712+0600 D/avoidrickshaw(32394): event-values: 0.146560, -0.069392, 10.125827, 0.000000
07-25 22:05:21.772+0600 D/avoidrickshaw(32394): event-values: 0.223729, -0.057428, 10.193424, 0.000000
07-25 22:05:21.832+0600 D/avoidrickshaw(32394): event-values: 0.199202, -0.050249, 10.158132, 0.000000
07-25 22:05:21.902+0600 D/avoidrickshaw(32394): horizontal_acc: 16.000000, vertical_acc: -1.000000
07-25 22:05:21.902+0600 D/avoidrickshaw(32394): previous lat: 23.742101, previous long: 90.411688
07-25 22:05:21.902+0600 D/avoidrickshaw(32394): current lat: 23.742104, current long: 90.411684
07-25 22:05:21.912+0600 D/avoidrickshaw(32394): because step count did not update, distance not updated.
07-25 22:05:21.912+0600 D/avoidrickshaw(32394): event-values: 0.199801, -0.074776, 10.179665, 0.000000
07-25 22:05:21.952+0600 D/avoidrickshaw(32394): event-values: 0.200399, -0.093918, 10.177272, 0.000000
07-25 22:05:22.012+0600 D/avoidrickshaw(32394): event-values: 0.167498, -0.085543, 10.178469, 0.000000
07-25 22:05:22.072+0600 D/avoidrickshaw(32394): event-values: 0.228515, -0.077767, 10.173084, 0.000000
07-25 22:05:22.132+0600 D/avoidrickshaw(32394): event-values: 0.210568, -0.089133, 10.200603, 0.000000
07-25 22:05:22.192+0600 D/avoidrickshaw(32394): event-values: 0.141775, -0.088534, 10.128819, 0.000000
07-25 22:05:22.252+0600 D/avoidrickshaw(32394): event-values: 0.173480, -0.081954, 10.216754, 0.000000
07-25 22:05:22.312+0600 D/avoidrickshaw(32394): event-values: 0.229113, -0.074178, 10.166506, 0.000000
07-25 22:05:22.372+0600 D/avoidrickshaw(32394): event-values: 0.168694, -0.084347, 10.183852, 0.000000
07-25 22:05:22.432+0600 D/avoidrickshaw(32394): event-values: 0.165703, -0.055633, 10.161720, 0.000000
07-25 22:05:22.493+0600 D/avoidrickshaw(32394): event-values: 0.207577, -0.072981, 10.198210, 0.000000
07-25 22:05:22.553+0600 D/avoidrickshaw(32394): event-values: 0.199202, -0.084945, 10.185050, 0.000000
07-25 22:05:22.613+0600 D/avoidrickshaw(32394): event-values: 0.205185, -0.066401, 10.176675, 0.000000
07-25 22:05:22.673+0600 D/avoidrickshaw(32394): event-values: 0.162712, -0.079561, 10.162319, 0.000000
07-25 22:05:22.733+0600 D/avoidrickshaw(32394): event-values: 0.178863, -0.081356, 10.167104, 0.000000
07-25 22:05:22.793+0600 D/avoidrickshaw(32394): event-values: 0.210568, -0.077767, 10.180264, 0.000000
07-25 22:05:22.853+0600 D/avoidrickshaw(32394): event-values: 0.174676, -0.078365, 10.157533, 0.000000
07-25 22:05:22.913+0600 D/avoidrickshaw(32394): event-values: 0.177667, -0.096909, 10.189237, 0.000000
07-25 22:05:22.973+0600 D/avoidrickshaw(32394): event-values: 0.214158, -0.069392, 10.179067, 0.000000
07-25 22:05:23.033+0600 D/avoidrickshaw(32394): event-values: 0.204586, -0.069990, 10.177272, 0.000000
07-25 22:05:23.093+0600 D/avoidrickshaw(32394): event-values: 0.204586, -0.066401, 10.165309, 0.000000
07-25 22:05:23.153+0600 D/avoidrickshaw(32394): event-values: 0.230907, -0.070588, 10.184451, 0.000000
07-25 22:05:23.213+0600 D/avoidrickshaw(32394): event-values: 0.182453, -0.098704, 10.169496, 0.000000
07-25 22:05:23.273+0600 D/avoidrickshaw(32394): event-values: 0.196810, -0.072981, 10.164711, 0.000000
07-25 22:05:23.333+0600 D/avoidrickshaw(32394): event-values: 0.195015, -0.062213, 10.168897, 0.000000
07-25 22:05:23.393+0600 D/avoidrickshaw(32394): event-values: 0.214158, -0.086740, 10.169496, 0.000000
07-25 22:05:23.453+0600 D/avoidrickshaw(32394): event-values: 0.180658, -0.072383, 10.153345, 0.000000
07-25 22:05:23.514+0600 D/avoidrickshaw(32394): event-values: 0.170489, -0.068794, 10.174281, 0.000000
07-25 22:05:23.574+0600 D/avoidrickshaw(32394): event-values: 0.232104, -0.061615, 10.177272, 0.000000
07-25 22:05:23.634+0600 D/avoidrickshaw(32394): event-values: 0.193819, -0.068794, 10.182058, 0.000000
07-25 22:05:23.694+0600 D/avoidrickshaw(32394): event-values: 0.196211, -0.072981, 10.139585, 0.000000
07-25 22:05:23.754+0600 D/avoidrickshaw(32394): event-values: 0.189631, -0.082552, 10.156336, 0.000000
07-25 22:05:23.814+0600 D/avoidrickshaw(32394): event-values: 0.193819, -0.061017, 10.160523, 0.000000
07-25 22:05:23.874+0600 D/avoidrickshaw(32394): event-values: 0.216550, -0.081356, 10.170692, 0.000000
07-25 22:05:23.934+0600 D/avoidrickshaw(32394): event-values: 0.179462, -0.072383, 10.150952, 0.000000
07-25 22:05:23.994+0600 D/avoidrickshaw(32394): event-values: 0.169292, -0.062213, 10.170094, 0.000000
07-25 22:05:24.054+0600 D/avoidrickshaw(32394): event-values: 0.249452, -0.058026, 10.205389, 0.000000
07-25 22:05:24.114+0600 D/avoidrickshaw(32394): event-values: 0.199202, -0.078365, 10.179665, 0.000000
07-25 22:05:24.174+0600 D/avoidrickshaw(32394): event-values: 0.174078, -0.082552, 10.171888, 0.000000
07-25 22:05:24.234+0600 D/avoidrickshaw(32394): event-values: 0.160319, -0.091525, 10.140782, 0.000000
07-25 22:05:24.294+0600 D/avoidrickshaw(32394): event-values: 0.218943, -0.076570, 10.184451, 0.000000
07-25 22:05:24.354+0600 D/avoidrickshaw(32394): event-values: 0.215354, -0.072981, 10.192826, 0.000000
07-25 22:05:24.414+0600 D/avoidrickshaw(32394): event-values: 0.148355, -0.089133, 10.170692, 0.000000
07-25 22:05:24.474+0600 D/avoidrickshaw(32394): event-values: 0.212363, -0.075374, 10.180862, 0.000000
07-25 22:05:24.535+0600 D/avoidrickshaw(32394): event-values: 0.200399, -0.077767, 10.171290, 0.000000
07-25 22:05:24.595+0600 D/avoidrickshaw(32394): event-values: 0.233898, -0.081954, 10.182058, 0.000000
07-25 22:05:24.655+0600 D/avoidrickshaw(32394): event-values: 0.152542, -0.141177, 10.165908, 0.000000
07-25 22:05:24.715+0600 D/avoidrickshaw(32394): event-values: 0.209372, -0.078365, 10.179067, 0.000000
07-25 22:05:24.775+0600 D/avoidrickshaw(32394): event-values: 0.218345, -0.074776, 10.173683, 0.000000
07-25 22:05:24.835+0600 D/avoidrickshaw(32394): event-values: 0.197408, -0.071785, 10.182656, 0.000000
07-25 22:05:24.895+0600 D/avoidrickshaw(32394): event-values: 0.174676, -0.074776, 10.167702, 0.000000
07-25 22:05:24.955+0600 D/avoidrickshaw(32394): event-values: 0.220738, -0.066999, 10.164113, 0.000000
07-25 22:05:25.015+0600 D/avoidrickshaw(32394): event-values: 0.198006, -0.066999, 10.160523, 0.000000
07-25 22:05:25.075+0600 D/avoidrickshaw(32394): event-values: 0.184846, -0.062213, 10.188639, 0.000000
07-25 22:05:25.135+0600 D/avoidrickshaw(32394): event-values: 0.195015, -0.086740, 10.163515, 0.000000
07-25 22:05:25.195+0600 D/avoidrickshaw(32394): event-values: 0.202193, -0.077169, 10.159925, 0.000000
07-25 22:05:25.255+0600 D/avoidrickshaw(32394): event-values: 0.214158, -0.069990, 10.167702, 0.000000
07-25 22:05:25.315+0600 D/avoidrickshaw(32394): event-values: 0.193220, -0.071186, 10.190434, 0.000000
07-25 22:05:25.375+0600 D/avoidrickshaw(32394): event-values: 0.198604, -0.069392, 10.170094, 0.000000
07-25 22:05:25.435+0600 D/avoidrickshaw(32394): event-values: 0.197408, -0.084945, 10.165309, 0.000000
07-25 22:05:25.495+0600 D/avoidrickshaw(32394): event-values: 0.200399, -0.093320, 10.170692, 0.000000
07-25 22:05:25.556+0600 D/avoidrickshaw(32394): event-values: 0.183051, -0.078365, 10.163515, 0.000000
07-25 22:05:25.616+0600 D/avoidrickshaw(32394): event-values: 0.196810, -0.089731, 10.151550, 0.000000
07-25 22:05:25.676+0600 D/avoidrickshaw(32394): event-values: 0.217149, -0.074776, 10.176675, 0.000000
07-25 22:05:25.736+0600 D/avoidrickshaw(32394): event-values: 0.197408, -0.070588, 10.183254, 0.000000
07-25 22:05:25.796+0600 D/avoidrickshaw(32394): event-values: 0.202792, -0.068195, 10.171290, 0.000000
07-25 22:05:25.856+0600 D/avoidrickshaw(32394): event-values: 0.196211, -0.072981, 10.176076, 0.000000
07-25 22:05:25.916+0600 D/avoidrickshaw(32394): horizontal_acc: 16.000000, vertical_acc: -1.000000
07-25 22:05:25.916+0600 D/avoidrickshaw(32394): previous lat: 23.742101, previous long: 90.411688
07-25 22:05:25.916+0600 D/avoidrickshaw(32394): current lat: 23.742104, current long: 90.411684
07-25 22:05:25.916+0600 D/avoidrickshaw(32394): because step count did not update, distance not updated.
07-25 22:05:25.916+0600 D/avoidrickshaw(32394): event-values: 0.198604, -0.071785, 10.176675, 0.000000
07-25 22:05:25.976+0600 D/avoidrickshaw(32394): event-values: 0.180658, -0.072981, 10.183852, 0.000000
07-25 22:05:26.036+0600 D/avoidrickshaw(32394): event-values: 0.142373, -0.081356, 10.149756, 0.000000
07-25 22:05:26.096+0600 D/avoidrickshaw(32394): event-values: 0.211765, -0.065204, 10.173084, 0.000000
07-25 22:05:26.156+0600 D/avoidrickshaw(32394): event-values: 0.183051, -0.095115, 10.192826, 0.000000
07-25 22:05:26.216+0600 D/avoidrickshaw(32394): event-values: 0.200997, -0.075374, 10.170094, 0.000000
07-25 22:05:26.276+0600 D/avoidrickshaw(32394): event-values: 0.188435, -0.078365, 10.159925, 0.000000
07-25 22:05:26.336+0600 D/avoidrickshaw(32394): event-values: 0.193819, -0.066999, 10.176076, 0.000000
07-25 22:05:26.396+0600 D/avoidrickshaw(32394): event-values: 0.212363, -0.087936, 10.168301, 0.000000
07-25 22:05:26.456+0600 D/avoidrickshaw(32394): event-values: 0.156132, -0.078963, 10.147961, 0.000000
07-25 22:05:26.516+0600 D/avoidrickshaw(32394): event-values: 0.200997, -0.071186, 10.175477, 0.000000
07-25 22:05:26.577+0600 D/avoidrickshaw(32394): event-values: 0.175274, -0.099900, 10.122238, 0.000000
07-25 22:05:26.637+0600 D/avoidrickshaw(32394): event-values: 0.231506, -0.087338, 10.180862, 0.000000
07-25 22:05:26.697+0600 D/avoidrickshaw(32394): event-values: 0.205783, -0.081954, 10.185647, 0.000000
07-25 22:05:26.757+0600 D/avoidrickshaw(32394): event-values: 0.183051, -0.072383, 10.170094, 0.000000
07-25 22:05:26.827+0600 D/avoidrickshaw(32394): event-values: 0.199202, -0.059821, 10.150353, 0.000000
07-25 22:05:26.887+0600 D/avoidrickshaw(32394): event-values: 0.186042, -0.061017, 10.164711, 0.000000
07-25 22:05:26.947+0600 D/avoidrickshaw(32394): event-values: 0.180060, -0.070588, 10.171290, 0.000000
07-25 22:05:27.007+0600 D/avoidrickshaw(32394): event-values: 0.231506, -0.083151, 10.158132, 0.000000
07-25 22:05:27.067+0600 D/avoidrickshaw(32394): event-values: 0.193819, -0.068794, 10.173683, 0.000000
07-25 22:05:27.127+0600 D/avoidrickshaw(32394): event-values: 0.168096, -0.089133, 10.161720, 0.000000
07-25 22:05:27.187+0600 D/avoidrickshaw(32394): event-values: 0.161516, -0.084347, 10.125827, 0.000000
07-25 22:05:27.247+0600 D/avoidrickshaw(32394): event-values: 0.211765, -0.062812, 10.205987, 0.000000
07-25 22:05:27.307+0600 D/avoidrickshaw(32394): event-values: 0.198604, -0.088534, 10.180862, 0.000000
07-25 22:05:27.367+0600 D/avoidrickshaw(32394): event-values: 0.189631, -0.107677, 10.153944, 0.000000
07-25 22:05:27.427+0600 D/avoidrickshaw(32394): event-values: 0.197408, -0.061615, 10.171290, 0.000000
07-25 22:05:27.487+0600 D/avoidrickshaw(32394): event-values: 0.219541, -0.089133, 10.183852, 0.000000
07-25 22:05:27.547+0600 D/avoidrickshaw(32394): event-values: 0.211167, -0.086740, 10.165309, 0.000000
07-25 22:05:27.608+0600 D/avoidrickshaw(32394): event-values: 0.184247, -0.071186, 10.191629, 0.000000
07-25 22:05:27.668+0600 D/avoidrickshaw(32394): event-values: 0.187238, -0.067597, 10.179665, 0.000000
07-25 22:05:27.728+0600 D/avoidrickshaw(32394): event-values: 0.199801, -0.087936, 10.173084, 0.000000
07-25 22:05:27.788+0600 D/avoidrickshaw(32394): event-values: 0.223729, -0.070588, 10.189237, 0.000000
07-25 22:05:27.848+0600 D/avoidrickshaw(32394): event-values: 0.168694, -0.074776, 10.147961, 0.000000
07-25 22:05:27.908+0600 D/avoidrickshaw(32394): event-values: 0.205185, -0.078365, 10.162319, 0.000000
07-25 22:05:27.968+0600 D/avoidrickshaw(32394): event-values: 0.180060, -0.072383, 10.171290, 0.000000
07-25 22:05:28.028+0600 D/avoidrickshaw(32394): event-values: 0.183649, -0.079561, 10.171290, 0.000000
07-25 22:05:28.088+0600 D/avoidrickshaw(32394): event-values: 0.195015, -0.080160, 10.187442, 0.000000
07-25 22:05:28.148+0600 D/avoidrickshaw(32394): event-values: 0.203390, -0.099302, 10.195219, 0.000000
07-25 22:05:28.208+0600 D/avoidrickshaw(32394): event-values: 0.217747, -0.063410, 10.149756, 0.000000
07-25 22:05:28.268+0600 D/avoidrickshaw(32394): event-values: 0.186640, -0.069392, 10.165908, 0.000000
07-25 22:05:28.328+0600 D/avoidrickshaw(32394): event-values: 0.203988, -0.068794, 10.182058, 0.000000
07-25 22:05:28.388+0600 D/avoidrickshaw(32394): event-values: 0.191426, -0.087936, 10.159328, 0.000000
07-25 22:05:28.448+0600 D/avoidrickshaw(32394): event-values: 0.190229, -0.074178, 10.167702, 0.000000
07-25 22:05:28.508+0600 D/avoidrickshaw(32394): event-values: 0.205783, -0.087338, 10.209577, 0.000000
07-25 22:05:28.568+0600 D/avoidrickshaw(32394): event-values: 0.196810, -0.075972, 10.164711, 0.000000
07-25 22:05:28.629+0600 D/avoidrickshaw(32394): event-values: 0.201595, -0.078963, 10.202397, 0.000000
07-25 22:05:28.689+0600 D/avoidrickshaw(32394): event-values: 0.193220, -0.095713, 10.189237, 0.000000
07-25 22:05:28.749+0600 D/avoidrickshaw(32394): event-values: 0.218345, -0.072383, 10.195219, 0.000000
07-25 22:05:28.809+0600 D/avoidrickshaw(32394): event-values: 0.192024, -0.075374, 10.152148, 0.000000
07-25 22:05:28.879+0600 D/avoidrickshaw(32394): event-values: 0.168694, -0.084347, 10.137194, 0.000000
07-25 22:05:28.939+0600 D/avoidrickshaw(32394): event-values: 0.193220, -0.069392, 10.179067, 0.000000
07-25 22:05:28.999+0600 D/avoidrickshaw(32394): event-values: 0.194417, -0.072383, 10.174880, 0.000000
07-25 22:05:29.059+0600 D/avoidrickshaw(32394): event-values: 0.187837, -0.074776, 10.177272, 0.000000
07-25 22:05:29.119+0600 D/avoidrickshaw(32394): event-values: 0.193220, -0.058026, 10.158132, 0.000000
07-25 22:05:29.179+0600 D/avoidrickshaw(32394): event-values: 0.194417, -0.082552, 10.179067, 0.000000
07-25 22:05:29.239+0600 D/avoidrickshaw(32394): event-values: 0.214756, -0.064606, 10.177272, 0.000000
07-25 22:05:29.299+0600 D/avoidrickshaw(32394): event-values: 0.199801, -0.076570, 10.191629, 0.000000
07-25 22:05:29.359+0600 D/avoidrickshaw(32394): event-values: 0.175872, -0.082552, 10.177871, 0.000000
07-25 22:05:29.419+0600 D/avoidrickshaw(32394): event-values: 0.191426, -0.079561, 10.165908, 0.000000
07-25 22:05:29.479+0600 D/avoidrickshaw(32394): event-values: 0.204586, -0.078963, 10.188040, 0.000000
07-25 22:05:29.539+0600 D/avoidrickshaw(32394): event-values: 0.189631, -0.066999, 10.158729, 0.000000
07-25 22:05:29.599+0600 D/avoidrickshaw(32394): event-values: 0.203988, -0.061017, 10.177871, 0.000000
07-25 22:05:29.660+0600 D/avoidrickshaw(32394): event-values: 0.192622, -0.086142, 10.176076, 0.000000
07-25 22:05:29.720+0600 D/avoidrickshaw(32394): event-values: 0.197408, -0.075374, 10.163515, 0.000000
07-25 22:05:29.780+0600 D/avoidrickshaw(32394): event-values: 0.203390, -0.072383, 10.170692, 0.000000
07-25 22:05:29.840+0600 D/avoidrickshaw(32394): event-values: 0.166899, -0.095115, 10.195219, 0.000000
07-25 22:05:29.920+0600 D/avoidrickshaw(32394): horizontal_acc: 24.000000, vertical_acc: -1.000000
07-25 22:05:29.920+0600 D/avoidrickshaw(32394): previous lat: 23.742101, previous long: 90.411688
07-25 22:05:29.920+0600 D/avoidrickshaw(32394): current lat: 23.742106, current long: 90.411684
07-25 22:05:29.920+0600 D/avoidrickshaw(32394): because step count did not update, distance not updated.
07-25 22:05:29.920+0600 D/avoidrickshaw(32394): event-values: 0.193220, -0.069990, 10.177871, 0.000000
07-25 22:05:29.960+0600 D/avoidrickshaw(32394): event-values: 0.200399, -0.082552, 10.180264, 0.000000
07-25 22:05:30.020+0600 D/avoidrickshaw(32394): event-values: 0.186640, -0.075374, 10.163515, 0.000000
07-25 22:05:30.080+0600 D/avoidrickshaw(32394): event-values: 0.191426, -0.086142, 10.191031, 0.000000
07-25 22:05:30.140+0600 D/avoidrickshaw(32394): event-values: 0.200399, -0.081954, 10.167104, 0.000000
07-25 22:05:30.200+0600 D/avoidrickshaw(32394): event-values: 0.209372, -0.067597, 10.178469, 0.000000
07-25 22:05:30.260+0600 D/avoidrickshaw(32394): event-values: 0.192024, -0.076570, 10.189835, 0.000000
07-25 22:05:30.320+0600 D/avoidrickshaw(32394): event-values: 0.192024, -0.077767, 10.183852, 0.000000
07-25 22:05:30.380+0600 D/avoidrickshaw(32394): event-values: 0.190229, -0.067597, 10.187442, 0.000000
07-25 22:05:30.440+0600 D/avoidrickshaw(32394): event-values: 0.205783, -0.085543, 10.189237, 0.000000
07-25 22:05:30.500+0600 D/avoidrickshaw(32394): event-values: 0.188435, -0.073579, 10.166506, 0.000000
07-25 22:05:30.560+0600 D/avoidrickshaw(32394): event-values: 0.193220, -0.072383, 10.177871, 0.000000
07-25 22:05:30.620+0600 D/avoidrickshaw(32394): event-values: 0.207577, -0.077169, 10.168301, 0.000000
07-25 22:05:30.681+0600 D/avoidrickshaw(32394): event-values: 0.176471, -0.067597, 10.178469, 0.000000
07-25 22:05:30.741+0600 D/avoidrickshaw(32394): event-values: 0.189631, -0.076570, 10.188040, 0.000000
07-25 22:05:30.801+0600 D/avoidrickshaw(32394): event-values: 0.196810, -0.080160, 10.137791, 0.000000
07-25 22:05:30.861+0600 D/avoidrickshaw(32394): event-values: 0.191426, -0.073579, 10.172487, 0.000000
07-25 22:05:30.921+0600 D/avoidrickshaw(32394): event-values: 0.195613, -0.071785, 10.178469, 0.000000
07-25 22:05:30.971+0600 D/avoidrickshaw(32394): event-values: 0.199202, -0.064606, 10.175477, 0.000000
07-25 22:05:31.031+0600 D/avoidrickshaw(32394): event-values: 0.194417, -0.072981, 10.178469, 0.000000
07-25 22:05:31.091+0600 D/avoidrickshaw(32394): event-values: 0.198604, -0.077169, 10.137791, 0.000000
07-25 22:05:31.151+0600 D/avoidrickshaw(32394): event-values: 0.193220, -0.077169, 10.182058, 0.000000
07-25 22:05:31.211+0600 D/avoidrickshaw(32394): event-values: 0.203390, -0.072383, 10.176675, 0.000000
07-25 22:05:31.271+0600 D/avoidrickshaw(32394): event-values: 0.204586, -0.068195, 10.168301, 0.000000
07-25 22:05:31.331+0600 D/avoidrickshaw(32394): event-values: 0.210568, -0.074178, 10.167104, 0.000000
07-25 22:05:31.391+0600 D/avoidrickshaw(32394): event-values: 0.196810, -0.071785, 10.176675, 0.000000
07-25 22:05:31.451+0600 D/avoidrickshaw(32394): event-values: 0.191426, -0.080160, 10.165908, 0.000000
07-25 22:05:31.511+0600 D/avoidrickshaw(32394): event-values: 0.194417, -0.087936, 10.161720, 0.000000
07-25 22:05:31.571+0600 D/avoidrickshaw(32394): event-values: 0.200399, -0.073579, 10.151550, 0.000000
07-25 22:05:31.631+0600 D/avoidrickshaw(32394): event-values: 0.203390, -0.077169, 10.169496, 0.000000
07-25 22:05:31.692+0600 D/avoidrickshaw(32394): event-values: 0.203390, -0.086142, 10.186844, 0.000000
07-25 22:05:31.752+0600 D/avoidrickshaw(32394): event-values: 0.208176, -0.084945, 10.173683, 0.000000
07-25 22:05:31.812+0600 D/avoidrickshaw(32394): event-values: 0.206381, -0.079561, 10.196415, 0.000000
07-25 22:05:31.872+0600 D/avoidrickshaw(32394): event-values: 0.215354, -0.086142, 10.139585, 0.000000
07-25 22:05:31.932+0600 D/avoidrickshaw(32394): event-values: 0.199202, -0.062213, 10.165908, 0.000000
07-25 22:05:31.992+0600 D/avoidrickshaw(32394): event-values: 0.172881, -0.080160, 10.159925, 0.000000
07-25 22:05:32.052+0600 D/avoidrickshaw(32394): event-values: 0.215354, -0.062213, 10.163515, 0.000000
07-25 22:05:32.112+0600 D/avoidrickshaw(32394): event-values: 0.212363, -0.072383, 10.177272, 0.000000
07-25 22:05:32.172+0600 D/avoidrickshaw(32394): event-values: 0.198006, -0.085543, 10.162319, 0.000000
07-25 22:05:32.232+0600 D/avoidrickshaw(32394): event-values: 0.201595, -0.074776, 10.178469, 0.000000
07-25 22:05:32.292+0600 D/avoidrickshaw(32394): event-values: 0.182453, -0.086142, 10.181459, 0.000000
07-25 22:05:32.352+0600 D/avoidrickshaw(32394): event-values: 0.208176, -0.070588, 10.172487, 0.000000
07-25 22:05:32.412+0600 D/avoidrickshaw(32394): event-values: 0.192622, -0.093918, 10.170094, 0.000000
07-25 22:05:32.472+0600 D/avoidrickshaw(32394): event-values: 0.187837, -0.077767, 10.164711, 0.000000
07-25 22:05:32.532+0600 D/avoidrickshaw(32394): event-values: 0.184247, -0.075972, 10.191031, 0.000000
07-25 22:05:32.592+0600 D/avoidrickshaw(32394): event-values: 0.198006, -0.083151, 10.200004, 0.000000
07-25 22:05:32.652+0600 D/avoidrickshaw(32394): event-values: 0.216550, -0.090329, 10.183852, 0.000000
07-25 22:05:32.713+0600 D/avoidrickshaw(32394): event-values: 0.169292, -0.083749, 10.152746, 0.000000
07-25 22:05:32.773+0600 D/avoidrickshaw(32394): event-values: 0.181256, -0.066999, 10.170094, 0.000000
07-25 22:05:32.833+0600 D/avoidrickshaw(32394): event-values: 0.190828, -0.071186, 10.151550, 0.000000
07-25 22:05:32.893+0600 D/avoidrickshaw(32394): event-values: 0.253639, -0.092722, 10.216157, 0.000000
07-25 22:05:32.953+0600 D/avoidrickshaw(32394): event-values: 0.176471, -0.059821, 10.185647, 0.000000
07-25 22:05:33.013+0600 D/avoidrickshaw(32394): event-values: 0.183051, -0.078365, 10.167104, 0.000000
07-25 22:05:33.073+0600 D/avoidrickshaw(32394): event-values: 0.179462, -0.104088, 10.158729, 0.000000
07-25 22:05:33.133+0600 D/avoidrickshaw(32394): event-values: 0.192024, -0.074178, 10.110274, 0.000000
07-25 22:05:33.193+0600 D/avoidrickshaw(32394): event-values: 0.175872, -0.098704, 10.198210, 0.000000
07-25 22:05:33.253+0600 D/avoidrickshaw(32394): event-values: 0.204586, -0.074776, 10.216157, 0.000000
07-25 22:05:33.313+0600 D/avoidrickshaw(32394): event-values: 0.190229, -0.078963, 10.156934, 0.000000
07-25 22:05:33.373+0600 D/avoidrickshaw(32394): event-values: 0.208176, -0.061017, 10.155140, 0.000000
07-25 22:05:33.433+0600 D/avoidrickshaw(32394): event-values: 0.195613, -0.088534, 10.183254, 0.000000
07-25 22:05:33.493+0600 D/avoidrickshaw(32394): event-values: 0.211765, -0.078365, 10.181459, 0.000000
07-25 22:05:33.553+0600 D/avoidrickshaw(32394): event-values: 0.228515, -0.059222, 10.189835, 0.000000
07-25 22:05:33.613+0600 D/avoidrickshaw(32394): event-values: 0.209372, -0.065204, 10.179067, 0.000000
07-25 22:05:33.673+0600 D/avoidrickshaw(32394): event-values: 0.179462, -0.110070, 10.196415, 0.000000
07-25 22:05:33.733+0600 D/avoidrickshaw(32394): event-values: 0.216550, -0.040080, 10.158132, 0.000000
07-25 22:05:33.794+0600 D/avoidrickshaw(32394): event-values: 0.206979, -0.065803, 10.202397, 0.000000
07-25 22:05:33.854+0600 D/avoidrickshaw(32394): event-values: 0.148953, -0.083749, 10.128220, 0.000000
07-25 22:05:33.874+0600 I/Tizen::Net::Wifi( 1305): (941) > The background scan result updated.
07-25 22:05:33.934+0600 D/avoidrickshaw(32394): horizontal_acc: 24.000000, vertical_acc: -1.000000
07-25 22:05:33.934+0600 D/avoidrickshaw(32394): previous lat: 23.742101, previous long: 90.411688
07-25 22:05:33.934+0600 D/avoidrickshaw(32394): current lat: 23.742108, current long: 90.411684
07-25 22:05:33.934+0600 D/avoidrickshaw(32394): because step count did not update, distance not updated.
07-25 22:05:33.934+0600 D/avoidrickshaw(32394): event-values: 0.213559, -0.054437, 10.160523, 0.000000
07-25 22:05:33.974+0600 D/avoidrickshaw(32394): event-values: 0.204586, -0.083151, 10.183852, 0.000000
07-25 22:05:34.034+0600 D/avoidrickshaw(32394): event-values: 0.203390, -0.071186, 10.176675, 0.000000
07-25 22:05:34.094+0600 D/avoidrickshaw(32394): event-values: 0.205185, -0.083151, 10.145569, 0.000000
07-25 22:05:34.154+0600 D/avoidrickshaw(32394): event-values: 0.180658, -0.116052, 10.170692, 0.000000
07-25 22:05:34.214+0600 D/avoidrickshaw(32394): event-values: 0.174078, -0.087936, 10.186246, 0.000000
07-25 22:05:34.274+0600 D/avoidrickshaw(32394): event-values: 0.186042, -0.080758, 10.202995, 0.000000
07-25 22:05:34.334+0600 D/avoidrickshaw(32394): event-values: 0.225524, -0.075374, 10.172487, 0.000000
07-25 22:05:34.394+0600 D/avoidrickshaw(32394): event-values: 0.186042, -0.087936, 10.172487, 0.000000
07-25 22:05:34.454+0600 D/avoidrickshaw(32394): event-values: 0.145364, -0.081954, 10.169496, 0.000000
07-25 22:05:34.514+0600 D/avoidrickshaw(32394): event-values: 0.254237, -0.062812, 10.170094, 0.000000
07-25 22:05:34.574+0600 D/avoidrickshaw(32394): event-values: 0.209372, -0.067597, 10.195816, 0.000000
07-25 22:05:34.634+0600 D/avoidrickshaw(32394): event-values: 0.141177, -0.079561, 10.179665, 0.000000
07-25 22:05:34.694+0600 D/avoidrickshaw(32394): event-values: 0.164507, -0.049053, 10.176675, 0.000000
07-25 22:05:34.754+0600 D/avoidrickshaw(32394): event-values: 0.224327, -0.087338, 10.173084, 0.000000
07-25 22:05:34.815+0600 D/avoidrickshaw(32394): event-values: 0.189631, -0.079561, 10.127024, 0.000000
07-25 22:05:34.875+0600 D/avoidrickshaw(32394): event-values: 0.193819, -0.065204, 10.173084, 0.000000
07-25 22:05:34.935+0600 D/avoidrickshaw(32394): event-values: 0.129212, -0.038883, 10.167702, 0.000000
07-25 22:05:34.995+0600 D/avoidrickshaw(32394): event-values: 0.207577, -0.070588, 10.160523, 0.000000
07-25 22:05:35.055+0600 D/avoidrickshaw(32394): event-values: 0.208774, -0.084945, 10.168897, 0.000000
07-25 22:05:35.115+0600 D/avoidrickshaw(32394): event-values: 0.171087, -0.079561, 10.155738, 0.000000
07-25 22:05:35.175+0600 D/avoidrickshaw(32394): event-values: 0.171087, -0.071785, 10.187442, 0.000000
07-25 22:05:35.235+0600 D/avoidrickshaw(32394): event-values: 0.225524, -0.063410, 10.183254, 0.000000
07-25 22:05:35.295+0600 D/avoidrickshaw(32394): event-values: 0.202193, -0.077767, 10.173084, 0.000000
07-25 22:05:35.355+0600 D/avoidrickshaw(32394): event-values: 0.191426, -0.076570, 10.175477, 0.000000
07-25 22:05:35.415+0600 D/avoidrickshaw(32394): event-values: 0.188435, -0.077169, 10.158729, 0.000000
07-25 22:05:35.475+0600 D/avoidrickshaw(32394): event-values: 0.202193, -0.087338, 10.171290, 0.000000
07-25 22:05:35.535+0600 D/avoidrickshaw(32394): event-values: 0.192024, -0.074776, 10.170094, 0.000000
07-25 22:05:35.595+0600 D/avoidrickshaw(32394): event-values: 0.169890, -0.094516, 10.165309, 0.000000
07-25 22:05:35.655+0600 D/avoidrickshaw(32394): event-values: 0.181855, -0.066999, 10.182656, 0.000000
07-25 22:05:35.715+0600 D/avoidrickshaw(32394): event-values: 0.211167, -0.075972, 10.164113, 0.000000
07-25 22:05:35.775+0600 D/avoidrickshaw(32394): event-values: 0.212961, -0.091525, 10.166506, 0.000000
07-25 22:05:35.836+0600 D/avoidrickshaw(32394): event-values: 0.169890, -0.083151, 10.187442, 0.000000
07-25 22:05:35.896+0600 D/avoidrickshaw(32394): event-values: 0.199801, -0.079561, 10.162916, 0.000000
07-25 22:05:35.956+0600 D/avoidrickshaw(32394): event-values: 0.205185, -0.092124, 10.179665, 0.000000
07-25 22:05:36.016+0600 D/avoidrickshaw(32394): event-values: 0.201595, -0.075374, 10.149756, 0.000000
07-25 22:05:36.076+0600 D/avoidrickshaw(32394): event-values: 0.186042, -0.061615, 10.158729, 0.000000
07-25 22:05:36.136+0600 D/avoidrickshaw(32394): event-values: 0.192622, -0.077169, 10.158729, 0.000000
07-25 22:05:36.196+0600 D/avoidrickshaw(32394): event-values: 0.216550, -0.088534, 10.173683, 0.000000
07-25 22:05:36.256+0600 D/avoidrickshaw(32394): event-values: 0.202792, -0.081356, 10.184451, 0.000000
07-25 22:05:36.316+0600 D/avoidrickshaw(32394): event-values: 0.198604, -0.059222, 10.180264, 0.000000
07-25 22:05:36.376+0600 D/avoidrickshaw(32394): event-values: 0.193819, -0.079561, 10.175477, 0.000000
07-25 22:05:36.436+0600 D/avoidrickshaw(32394): event-values: 0.198006, -0.078963, 10.167104, 0.000000
07-25 22:05:36.496+0600 D/avoidrickshaw(32394): event-values: 0.192024, -0.071785, 10.171888, 0.000000
07-25 22:05:36.556+0600 D/avoidrickshaw(32394): event-values: 0.193819, -0.059222, 10.165309, 0.000000
07-25 22:05:36.616+0600 D/avoidrickshaw(32394): event-values: 0.183051, -0.078963, 10.162319, 0.000000
07-25 22:05:36.676+0600 D/avoidrickshaw(32394): event-values: 0.219541, -0.081356, 10.185647, 0.000000
07-25 22:05:36.736+0600 D/avoidrickshaw(32394): event-values: 0.169292, -0.078963, 10.154541, 0.000000
07-25 22:05:36.796+0600 D/avoidrickshaw(32394): event-values: 0.186640, -0.074178, 10.154541, 0.000000
07-25 22:05:36.857+0600 D/avoidrickshaw(32394): event-values: 0.195015, -0.059821, 10.186844, 0.000000
07-25 22:05:36.917+0600 D/avoidrickshaw(32394): event-values: 0.191426, -0.057428, 10.188040, 0.000000
07-25 22:05:36.977+0600 D/avoidrickshaw(32394): event-values: 0.194417, -0.072981, 10.190434, 0.000000
07-25 22:05:37.037+0600 D/avoidrickshaw(32394): event-values: 0.202792, -0.075972, 10.177272, 0.000000
07-25 22:05:37.097+0600 D/avoidrickshaw(32394): event-values: 0.192622, -0.088534, 10.156934, 0.000000
07-25 22:05:37.157+0600 D/avoidrickshaw(32394): event-values: 0.200399, -0.078365, 10.171290, 0.000000
07-25 22:05:37.217+0600 D/avoidrickshaw(32394): event-values: 0.181855, -0.092722, 10.177871, 0.000000
07-25 22:05:37.277+0600 D/avoidrickshaw(32394): event-values: 0.177069, -0.074776, 10.160523, 0.000000
07-25 22:05:37.337+0600 D/avoidrickshaw(32394): event-values: 0.190828, -0.071186, 10.164711, 0.000000
07-25 22:05:37.397+0600 D/avoidrickshaw(32394): event-values: 0.193220, -0.072981, 10.164113, 0.000000
07-25 22:05:37.457+0600 D/avoidrickshaw(32394): event-values: 0.207577, -0.082552, 10.161720, 0.000000
07-25 22:05:37.517+0600 D/avoidrickshaw(32394): event-values: 0.211167, -0.073579, 10.169496, 0.000000
07-25 22:05:37.577+0600 D/avoidrickshaw(32394): event-values: 0.196810, -0.070588, 10.162319, 0.000000
07-25 22:05:37.637+0600 D/avoidrickshaw(32394): event-values: 0.211167, -0.066401, 10.170094, 0.000000
07-25 22:05:37.697+0600 D/avoidrickshaw(32394): event-values: 0.184247, -0.072981, 10.164711, 0.000000
07-25 22:05:37.757+0600 D/avoidrickshaw(32394): event-values: 0.188435, -0.072383, 10.146166, 0.000000
07-25 22:05:37.817+0600 D/avoidrickshaw(32394): event-values: 0.202792, -0.064606, 10.186844, 0.000000
07-25 22:05:37.878+0600 D/avoidrickshaw(32394): event-values: 0.181256, -0.083749, 10.158132, 0.000000
07-25 22:05:37.908+0600 D/avoidrickshaw(32394): horizontal_acc: 16.000000, vertical_acc: -1.000000
07-25 22:05:37.908+0600 D/avoidrickshaw(32394): previous lat: 23.742101, previous long: 90.411688
07-25 22:05:37.908+0600 D/avoidrickshaw(32394): current lat: 23.742113, current long: 90.411685
07-25 22:05:37.918+0600 D/avoidrickshaw(32394): because step count did not update, saving position only.
07-25 22:05:37.938+0600 D/avoidrickshaw(32394): event-values: 0.186640, -0.081356, 10.178469, 0.000000
07-25 22:05:37.998+0600 D/avoidrickshaw(32394): event-values: 0.188435, -0.086740, 10.167702, 0.000000
07-25 22:05:38.058+0600 D/avoidrickshaw(32394): event-values: 0.203390, -0.068195, 10.174281, 0.000000
07-25 22:05:38.118+0600 D/avoidrickshaw(32394): event-values: 0.206381, -0.075972, 10.176076, 0.000000
07-25 22:05:38.178+0600 D/avoidrickshaw(32394): event-values: 0.202792, -0.092124, 10.183254, 0.000000
07-25 22:05:38.238+0600 D/avoidrickshaw(32394): event-values: 0.192622, -0.066999, 10.159328, 0.000000
07-25 22:05:38.298+0600 D/avoidrickshaw(32394): event-values: 0.200399, -0.074776, 10.178469, 0.000000
07-25 22:05:38.358+0600 D/avoidrickshaw(32394): event-values: 0.190229, -0.082552, 10.174281, 0.000000
07-25 22:05:38.418+0600 D/avoidrickshaw(32394): event-values: 0.206381, -0.061017, 10.177272, 0.000000
07-25 22:05:38.478+0600 D/avoidrickshaw(32394): event-values: 0.197408, -0.078963, 10.182656, 0.000000
07-25 22:05:38.538+0600 D/avoidrickshaw(32394): event-values: 0.208176, -0.059222, 10.189835, 0.000000
07-25 22:05:38.598+0600 D/avoidrickshaw(32394): event-values: 0.190229, -0.070588, 10.173683, 0.000000
07-25 22:05:38.658+0600 D/avoidrickshaw(32394): event-values: 0.194417, -0.094516, 10.162319, 0.000000
07-25 22:05:38.718+0600 D/avoidrickshaw(32394): event-values: 0.183649, -0.064606, 10.159328, 0.000000
07-25 22:05:38.778+0600 D/avoidrickshaw(32394): event-values: 0.192622, -0.093918, 10.171290, 0.000000
07-25 22:05:38.838+0600 D/avoidrickshaw(32394): event-values: 0.185444, -0.073579, 10.182058, 0.000000
07-25 22:05:38.899+0600 D/avoidrickshaw(32394): event-values: 0.195613, -0.067597, 10.172487, 0.000000
07-25 22:05:38.959+0600 D/avoidrickshaw(32394): event-values: 0.198006, -0.071785, 10.161121, 0.000000
07-25 22:05:39.019+0600 D/avoidrickshaw(32394): event-values: 0.203988, -0.080758, 10.152746, 0.000000
07-25 22:05:39.079+0600 D/avoidrickshaw(32394): event-values: 0.207577, -0.080160, 10.167104, 0.000000
07-25 22:05:39.139+0600 D/avoidrickshaw(32394): event-values: 0.196211, -0.068794, 10.150353, 0.000000
07-25 22:05:39.199+0600 D/avoidrickshaw(32394): event-values: 0.203390, -0.088534, 10.185647, 0.000000
07-25 22:05:39.259+0600 D/avoidrickshaw(32394): event-values: 0.196810, -0.085543, 10.173683, 0.000000
07-25 22:05:39.319+0600 D/avoidrickshaw(32394): event-values: 0.198604, -0.083151, 10.188040, 0.000000
07-25 22:05:39.379+0600 D/avoidrickshaw(32394): event-values: 0.198006, -0.078963, 10.167702, 0.000000
07-25 22:05:39.439+0600 D/avoidrickshaw(32394): event-values: 0.187837, -0.078365, 10.169496, 0.000000
07-25 22:05:39.499+0600 D/avoidrickshaw(32394): event-values: 0.190229, -0.073579, 10.185050, 0.000000
07-25 22:05:39.559+0600 D/avoidrickshaw(32394): event-values: 0.199202, -0.092124, 10.174281, 0.000000
07-25 22:05:39.619+0600 D/avoidrickshaw(32394): event-values: 0.226122, -0.074776, 10.167104, 0.000000
07-25 22:05:39.679+0600 D/avoidrickshaw(32394): event-values: 0.196211, -0.068794, 10.174880, 0.000000
07-25 22:05:39.739+0600 D/avoidrickshaw(32394): event-values: 0.192024, -0.069990, 10.159328, 0.000000
07-25 22:05:39.799+0600 D/avoidrickshaw(32394): event-values: 0.189033, -0.070588, 10.159925, 0.000000
07-25 22:05:39.859+0600 D/avoidrickshaw(32394): event-values: 0.185444, -0.067597, 10.168897, 0.000000
07-25 22:05:39.920+0600 D/avoidrickshaw(32394): event-values: 0.194417, -0.071785, 10.166506, 0.000000
07-25 22:05:39.980+0600 D/avoidrickshaw(32394): event-values: 0.194417, -0.070588, 10.175477, 0.000000
07-25 22:05:40.040+0600 D/avoidrickshaw(32394): event-values: 0.207577, -0.084347, 10.174281, 0.000000
07-25 22:05:40.100+0600 D/avoidrickshaw(32394): event-values: 0.212363, -0.063410, 10.162319, 0.000000
07-25 22:05:40.160+0600 D/avoidrickshaw(32394): event-values: 0.196211, -0.076570, 10.172487, 0.000000
07-25 22:05:40.220+0600 D/avoidrickshaw(32394): event-values: 0.196211, -0.080160, 10.173683, 0.000000
07-25 22:05:40.280+0600 D/avoidrickshaw(32394): event-values: 0.198604, -0.080758, 10.167104, 0.000000
07-25 22:05:40.340+0600 D/avoidrickshaw(32394): event-values: 0.171087, -0.071785, 10.173084, 0.000000
07-25 22:05:40.400+0600 D/avoidrickshaw(32394): event-values: 0.190229, -0.099900, 10.174880, 0.000000
07-25 22:05:40.460+0600 D/avoidrickshaw(32394): event-values: 0.209970, -0.053240, 10.183852, 0.000000
07-25 22:05:40.520+0600 D/avoidrickshaw(32394): event-values: 0.156730, -0.062213, 10.164113, 0.000000
07-25 22:05:40.580+0600 D/avoidrickshaw(32394): event-values: 0.185444, -0.079561, 10.166506, 0.000000
07-25 22:05:40.640+0600 D/avoidrickshaw(32394): event-values: 0.202193, -0.096909, 10.184451, 0.000000
07-25 22:05:40.700+0600 D/avoidrickshaw(32394): event-values: 0.208774, -0.086740, 10.161121, 0.000000
07-25 22:05:40.760+0600 D/avoidrickshaw(32394): event-values: 0.193220, -0.084945, 10.180862, 0.000000
07-25 22:05:40.820+0600 D/avoidrickshaw(32394): event-values: 0.168096, -0.084945, 10.184451, 0.000000
07-25 22:05:40.880+0600 D/avoidrickshaw(32394): event-values: 0.198006, -0.077169, 10.177871, 0.000000
07-25 22:05:40.941+0600 D/avoidrickshaw(32394): event-values: 0.223131, -0.075972, 10.195816, 0.000000
07-25 22:05:41.001+0600 D/avoidrickshaw(32394): event-values: 0.200997, -0.071785, 10.162916, 0.000000
07-25 22:05:41.061+0600 D/avoidrickshaw(32394): event-values: 0.190229, -0.068794, 10.181459, 0.000000
07-25 22:05:41.121+0600 D/avoidrickshaw(32394): event-values: 0.211167, -0.077767, 10.168897, 0.000000
07-25 22:05:41.171+0600 D/avoidrickshaw(32394): event-values: 0.208774, -0.060419, 10.179067, 0.000000
07-25 22:05:41.231+0600 D/avoidrickshaw(32394): event-values: 0.190229, -0.073579, 10.179665, 0.000000
07-25 22:05:41.291+0600 D/avoidrickshaw(32394): event-values: 0.191426, -0.082552, 10.180862, 0.000000
07-25 22:05:41.351+0600 D/avoidrickshaw(32394): event-values: 0.205185, -0.083749, 10.177871, 0.000000
07-25 22:05:41.411+0600 D/avoidrickshaw(32394): event-values: 0.184247, -0.074178, 10.182656, 0.000000
07-25 22:05:41.471+0600 D/avoidrickshaw(32394): event-values: 0.171087, -0.080160, 10.170692, 0.000000
07-25 22:05:41.531+0600 D/avoidrickshaw(32394): event-values: 0.196211, -0.072981, 10.180264, 0.000000
07-25 22:05:41.591+0600 D/avoidrickshaw(32394): event-values: 0.209372, -0.071785, 10.164113, 0.000000
07-25 22:05:41.651+0600 D/avoidrickshaw(32394): event-values: 0.192024, -0.078963, 10.180862, 0.000000
07-25 22:05:41.711+0600 D/avoidrickshaw(32394): event-values: 0.181256, -0.086740, 10.175477, 0.000000
07-25 22:05:41.771+0600 D/avoidrickshaw(32394): event-values: 0.211765, -0.058624, 10.180862, 0.000000
07-25 22:05:41.831+0600 D/avoidrickshaw(32394): event-values: 0.193819, -0.065204, 10.184451, 0.000000
07-25 22:05:41.901+0600 D/avoidrickshaw(32394): horizontal_acc: 16.000000, vertical_acc: -1.000000
07-25 22:05:41.901+0600 D/avoidrickshaw(32394): previous lat: 23.742113, previous long: 90.411685
07-25 22:05:41.901+0600 D/avoidrickshaw(32394): current lat: 23.742116, current long: 90.411687
07-25 22:05:41.911+0600 D/avoidrickshaw(32394): because step count did not update, distance not updated.
07-25 22:05:41.911+0600 D/avoidrickshaw(32394): event-values: 0.208176, -0.069990, 10.178469, 0.000000
07-25 22:05:41.952+0600 D/avoid
