S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPD6
Build-Date: 2016.04.28 20:23:28

Crash Information
Process Name: avoidrickshaw
PID: 22947
Date: 2016-07-26 21:02:12+0600
Executable File Path: /opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 22947, uid 5000)

Register Information
r0   = 0x000001e0, r1   = 0xb9027dc0
r2   = 0x00000001, r3   = 0x00000005
r4   = 0xb6a6b52d, r5   = 0xb5fe66ec
r6   = 0xb5fd3e30, r7   = 0x00000001
r8   = 0x00000005, r9   = 0x00000000
r10  = 0xb9071110, fp   = 0x00000000
ip   = 0x00000001, sp   = 0xbee3f168
lr   = 0xb5fcca17, pc   = 0xb6a6b546
cpsr = 0x600d0030

Memory Information
MemTotal:   730440 KB
MemFree:     42020 KB
Buffers:     46468 KB
Cached:     276404 KB
VmPeak:     115416 KB
VmSize:     115412 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24028 KB
VmRSS:       24028 KB
VmData:      42780 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36276 KB
VmPTE:          84 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 22947 TID = 22947
22947 22950 23633 23640 23652 

Maps Information
b04d1000 b0cd0000 rw-p [stack:23652]
b1301000 b1b00000 rw-p [stack:23640]
b1c40000 b1c48000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.49
b1c58000 b1c5a000 r-xp /usr/lib/liblbs-agps.so.0.1.0
b1c6a000 b1c78000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
b1c8f000 b1c91000 r-xp /usr/lib/location/module/libwps.so.0.6.8_9
b1ca1000 b1ca4000 r-xp /usr/lib/location/module/libgps.so.0.6.8_9
b1cb5000 b24b4000 rw-p [stack:23633]
b2530000 b2538000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2549000 b254a000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b255a000 b256e000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2582000 b2583000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2593000 b2596000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b25a7000 b25a8000 r-xp /usr/lib/libxshmfence.so.1.0.0
b25b8000 b25ba000 r-xp /usr/lib/libxcb-present.so.0.0.0
b25ca000 b25cc000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b25dc000 b25ec000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b25fc000 b2608000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b2858000 b285a000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b286a000 b2870000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b2880000 b2894000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b28a4000 b28be000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b28ce000 b28d4000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
b28e4000 b28eb000 r-xp /usr/lib/libeventsystem.so.0.0.1
b28fb000 b291e000 r-xp /usr/lib/libSLP-location-product.so.0.9.0
b292f000 b2946000 r-xp /usr/lib/libSLP-location.so.0.11.5_5
b2956000 b295d000 r-xp /usr/lib/libefl-extension.so.0.1.0
b296e000 b2976000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b2986000 b298a000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
b299b000 b29aa000 r-xp /usr/lib/libcapi-location-manager.so.0.6.1_3
b29ba000 b29c1000 r-xp /usr/lib/libcapi-appfw-preference.so.0.3.1.0
b29d3000 b29d9000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b29e9000 b29f1000 r-xp /opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw
b2b12000 b2bf5000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2c2c000 b2c54000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2c66000 b3465000 rw-p [stack:22950]
b3465000 b3467000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3477000 b3481000 r-xp /lib/libnss_files-2.20-2014.11.so
b3492000 b349b000 r-xp /lib/libnss_nis-2.20-2014.11.so
b34ac000 b34bd000 r-xp /lib/libnsl-2.20-2014.11.so
b34d0000 b34d6000 r-xp /lib/libnss_compat-2.20-2014.11.so
b34e7000 b34e8000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3510000 b3517000 r-xp /usr/lib/libminizip.so.1.0.0
b3527000 b352c000 r-xp /usr/lib/libstorage.so.0.1
b353c000 b3591000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b35a7000 b35bb000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b35cb000 b360f000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b361f000 b3627000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3637000 b3667000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b367a000 b3733000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3747000 b379b000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b37ac000 b37c7000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b37d7000 b3898000 r-xp /usr/lib/libprotobuf.so.9.0.1
b38ab000 b38bd000 r-xp /usr/lib/libefl-assist.so.0.1.0
b38cd000 b38d1000 r-xp /usr/lib/libogg.so.0.7.1
b38e1000 b3903000 r-xp /usr/lib/libvorbis.so.0.4.3
b3913000 b39f7000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b3a13000 b3a20000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3a31000 b3a74000 r-xp /usr/lib/libsndfile.so.1.0.25
b3a89000 b3ad0000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3ae1000 b3ae7000 r-xp /usr/lib/libjson-c.so.2.0.1
b3af8000 b3aff000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3b0f000 b3b4f000 r-xp /usr/lib/libmdm.so.1.2.10
b3b5f000 b3b67000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3b76000 b3b86000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3ba7000 b3c07000 r-xp /usr/lib/libasound.so.2.0.0
b3c19000 b3c4f000 r-xp /usr/lib/libpulse.so.0.16.2
b3c60000 b3c63000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3c73000 b3c76000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3c86000 b3c8b000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3c9b000 b3c9c000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3cac000 b3cb7000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3ccb000 b3cd2000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3ce2000 b3ce8000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3cf8000 b3cfd000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3d0d000 b3d28000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3d38000 b3d3f000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3d4f000 b3d52000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3d63000 b3d91000 r-xp /usr/lib/libidn.so.11.5.44
b3da1000 b3db7000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3dc8000 b3dd2000 r-xp /usr/lib/libcares.so.2.1.0
b3de2000 b3dec000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3dfc000 b3dfe000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3e0e000 b3e0f000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3e1f000 b3e23000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3e34000 b3e5c000 r-xp /usr/lib/libui-extension.so.0.1.0
b3e6d000 b3e96000 r-xp /usr/lib/libturbojpeg.so
b3eb6000 b3ebc000 r-xp /usr/lib/libgif.so.4.1.6
b3ecc000 b3f12000 r-xp /usr/lib/libcurl.so.4.3.0
b3f23000 b3f44000 r-xp /usr/lib/libexif.so.12.3.3
b3f5f000 b3f74000 r-xp /usr/lib/libtts.so
b3f85000 b3f8d000 r-xp /usr/lib/libfeedback.so.0.1.4
b3f9d000 b405d000 r-xp /usr/lib/libdali-core.so.0.0.0
b4068000 b415b000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b417b000 b4255000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b426c000 b426e000 r-xp /usr/lib/libboost_system.so.1.51.0
b427e000 b4284000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b4294000 b42b7000 r-xp /usr/lib/libboost_thread.so.1.51.0
b42c8000 b42ca000 r-xp /usr/lib/libappsvc.so.0.1.0
b42da000 b42dc000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b42ed000 b42f2000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4309000 b430b000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b431b000 b4322000 r-xp /usr/lib/libsensord-share.so
b4332000 b434a000 r-xp /usr/lib/libsensor.so.1.1.0
b435b000 b435e000 r-xp /usr/lib/libXv.so.1.0.0
b436e000 b4373000 r-xp /usr/lib/libutilX.so.1.1.0
b4383000 b4388000 r-xp /usr/lib/libappcore-common.so.1.1
b4398000 b439f000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b43b2000 b43b6000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b43c7000 b4491000 r-xp /usr/lib/libCOREGL.so.4.0
b44a8000 b44ab000 r-xp /usr/lib/libuuid.so.1.3.0
b44bc000 b44d3000 r-xp /usr/lib/libblkid.so.1.1.0
b44e4000 b44e6000 r-xp /usr/lib/libXau.so.6.0.0
b44f6000 b44f9000 r-xp /usr/lib/libEGL.so.1.4
b4501000 b4507000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4517000 b4519000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b452a000 b4538000 r-xp /usr/lib/libGLESv2.so.2.0
b4541000 b45a3000 r-xp /usr/lib/libpixman-1.so.0.28.2
b45b8000 b45d0000 r-xp /usr/lib/libmount.so.1.1.0
b45e1000 b45f5000 r-xp /usr/lib/libxcb.so.1.1.0
b4606000 b460d000 r-xp /lib/libcrypt-2.20-2014.11.so
b4645000 b4656000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b4667000 b4669000 r-xp /usr/lib/libiri.so
b4679000 b4684000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4695000 b46aa000 r-xp /lib/libexpat.so.1.5.2
b46bc000 b477a000 r-xp /usr/lib/libcairo.so.2.11200.14
b478d000 b4795000 r-xp /usr/lib/libdrm.so.2.4.0
b47a5000 b47a8000 r-xp /usr/lib/libdri2.so.0.0.0
b47b9000 b4807000 r-xp /usr/lib/libssl.so.1.0.0
b481c000 b4828000 r-xp /usr/lib/libeeze.so.1.13.0
b4838000 b4841000 r-xp /usr/lib/libethumb.so.1.13.0
b4851000 b4854000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4864000 b4a1b000 r-xp /usr/lib/libcrypto.so.1.0.0
b5672000 b567b000 r-xp /usr/lib/libXi.so.6.1.0
b568b000 b568d000 r-xp /usr/lib/libXgesture.so.7.0.0
b569d000 b56a1000 r-xp /usr/lib/libXtst.so.6.1.0
b56b1000 b56b7000 r-xp /usr/lib/libXrender.so.1.3.0
b56c7000 b56cd000 r-xp /usr/lib/libXrandr.so.2.2.0
b56de000 b56e0000 r-xp /usr/lib/libXinerama.so.1.0.0
b56f0000 b56f3000 r-xp /usr/lib/libXfixes.so.3.1.0
b5703000 b570e000 r-xp /usr/lib/libXext.so.6.4.0
b571e000 b5720000 r-xp /usr/lib/libXdamage.so.1.1.0
b5730000 b5732000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5743000 b5825000 r-xp /usr/lib/libX11.so.6.3.0
b5838000 b583f000 r-xp /usr/lib/libXcursor.so.1.0.2
b584f000 b5867000 r-xp /usr/lib/libudev.so.1.6.0
b5869000 b586c000 r-xp /lib/libattr.so.1.1.0
b587c000 b589c000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b589e000 b58a3000 r-xp /usr/lib/libffi.so.6.0.2
b58b3000 b58cb000 r-xp /lib/libz.so.1.2.8
b58db000 b58dd000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58ed000 b59c2000 r-xp /usr/lib/libxml2.so.2.9.2
b59d7000 b5a72000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a8e000 b5a91000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5aa1000 b5aba000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5acb000 b5adc000 r-xp /lib/libresolv-2.20-2014.11.so
b5af0000 b5b6a000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b7f000 b5b81000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b91000 b5b98000 r-xp /usr/lib/libembryo.so.1.13.0
b5ba8000 b5bc0000 r-xp /usr/lib/libpng12.so.0.50.0
b5bd1000 b5bf4000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c15000 b5c29000 r-xp /usr/lib/libector.so.1.13.0
b5c3a000 b5c52000 r-xp /usr/lib/liblua-5.1.so
b5c63000 b5cba000 r-xp /usr/lib/libfreetype.so.6.11.3
b5cce000 b5cf6000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d07000 b5d1a000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d2b000 b5d62000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d73000 b5d81000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d91000 b5d99000 r-xp /usr/lib/libtbm.so.1.0.0
b5da9000 b5db6000 r-xp /usr/lib/libeio.so.1.13.0
b5dc6000 b5dc8000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5dd8000 b5ddd000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5ded000 b5e04000 r-xp /usr/lib/libefreet.so.1.13.0
b5e16000 b5e36000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e46000 b5e66000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e68000 b5e6e000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e7e000 b5e8f000 r-xp /usr/lib/libemotion.so.1.13.0
b5ea0000 b5ea7000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5eb7000 b5ec6000 r-xp /usr/lib/libeo.so.1.13.0
b5ed7000 b5ee9000 r-xp /usr/lib/libecore_input.so.1.13.0
b5efa000 b5eff000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f0f000 b5f28000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f38000 b5f55000 r-xp /usr/lib/libeet.so.1.13.0
b5f6e000 b5fb6000 r-xp /usr/lib/libeina.so.1.13.0
b5fc7000 b5fd7000 r-xp /usr/lib/libefl.so.1.13.0
b5fe8000 b60cd000 r-xp /usr/lib/libicuuc.so.51.1
b60ea000 b622a000 r-xp /usr/lib/libicui18n.so.51.1
b6241000 b6279000 r-xp /usr/lib/libecore_x.so.1.13.0
b628b000 b628e000 r-xp /lib/libcap.so.2.21
b629e000 b62c7000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62d8000 b62df000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62f1000 b6328000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6339000 b6424000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6437000 b64b0000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64c2000 b64c7000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64d7000 b64e1000 r-xp /usr/lib/libvconf.so.0.2.45
b64f1000 b64f3000 r-xp /usr/lib/libvasum.so.0.3.1
b6503000 b6505000 r-xp /usr/lib/libttrace.so.1.1
b6515000 b6518000 r-xp /usr/lib/libiniparser.so.0
b6528000 b654e000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b655e000 b6563000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6574000 b658b000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b659c000 b6607000 r-xp /lib/libm-2.20-2014.11.so
b6618000 b661e000 r-xp /lib/librt-2.20-2014.11.so
b662f000 b663c000 r-xp /usr/lib/libunwind.so.8.0.1
b6672000 b6796000 r-xp /lib/libc-2.20-2014.11.so
b67ab000 b67c4000 r-xp /lib/libgcc_s-4.9.so.1
b67d4000 b68b6000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68c7000 b68f1000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6902000 b693e000 r-xp /usr/lib/libsystemd.so.0.4.0
b6940000 b69c2000 r-xp /usr/lib/libedje.so.1.13.0
b69d5000 b69f3000 r-xp /usr/lib/libecore.so.1.13.0
b6a13000 b6b9a000 r-xp /usr/lib/libevas.so.1.13.0
b6bcf000 b6be3000 r-xp /lib/libpthread-2.20-2014.11.so
b6bf7000 b6e2c000 r-xp /usr/lib/libelementary.so.1.13.0
b6e5a000 b6e5e000 r-xp /usr/lib/libsmack.so.1.0.0
b6e6e000 b6e75000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e85000 b6e87000 r-xp /usr/lib/libdlog.so.0.0.0
b6e97000 b6e9a000 r-xp /usr/lib/libbundle.so.0.1.22
b6eaa000 b6eac000 r-xp /lib/libdl-2.20-2014.11.so
b6ebd000 b6ed5000 r-xp /usr/lib/libaul.so.0.1.0
b6ee9000 b6eee000 r-xp /usr/lib/libappcore-efl.so.1.1
b6eff000 b6f0c000 r-xp /usr/lib/liblptcp.so
b6f1e000 b6f22000 r-xp /usr/lib/libsys-assert.so
b6f33000 b6f53000 r-xp /lib/ld-2.20-2014.11.so
b6f64000 b6f69000 r-xp /usr/bin/launchpad-loader
b8e56000 b914f000 rw-p [heap]
bee1f000 bee40000 rw-p [stack]
b8e56000 b914f000 rw-p [heap]
bee1f000 bee40000 rw-p [stack]
End of Maps Information

Callstack Information (PID:22947)
Call Stack Count: 1
 0: (0xb6a6b546) [/usr/lib/libevas.so.1] + 0x58546
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
07-25 22:05:24.114+0600 D/avoid
