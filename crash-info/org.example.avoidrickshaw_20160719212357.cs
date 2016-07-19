S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPD6
Build-Date: 2016.04.28 20:23:28

Crash Information
Process Name: avoidrickshaw
PID: 2837
Date: 2016-07-19 21:23:57+0600
Executable File Path: /opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 2837, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000b15
r2   = 0x00000006, r3   = 0xb44d54c0
r4   = 0x00000002, r5   = 0xb44d5000
r6   = 0xb67da09c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0x00000060
r10  = 0xb81b64ec, fp   = 0xb7f5e948
ip   = 0x00000000, sp   = 0xbeae6f14
lr   = 0xb66d0f18, pc   = 0xb66cfb84
cpsr = 0x200f0010

Memory Information
MemTotal:   730440 KB
MemFree:    130612 KB
Buffers:     29616 KB
Cached:     256256 KB
VmPeak:     123816 KB
VmSize:     120020 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22764 KB
VmRSS:       22764 KB
VmData:      49224 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36324 KB
VmPTE:          82 KB
VmSwap:          0 KB

Threads Information
Threads: 6
PID = 2837 TID = 2837
2837 2841 3150 3151 3158 3172 

Maps Information
afc01000 b0400000 rw-p [stack:3172]
b0b74000 b0b85000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b0b95000 b0b9a000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b0bb8000 b13b7000 rw-p [stack:3158]
b13b7000 b13bf000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.49
b13cf000 b13d1000 r-xp /usr/lib/liblbs-agps.so.0.1.0
b13e1000 b13ef000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
b1514000 b1516000 r-xp /usr/lib/location/module/libwps.so.0.6.8_9
b1526000 b1529000 r-xp /usr/lib/location/module/libgps.so.0.6.8_9
b153a000 b1d39000 rw-p [stack:3151]
b1d3a000 b2539000 rw-p [stack:3150]
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
b2a08000 b2a0e000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2a1e000 b2a23000 r-xp /opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw
b2b44000 b2c27000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2c5e000 b2c86000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2c98000 b3497000 rw-p [stack:2841]
b3497000 b3499000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b34a9000 b34b3000 r-xp /lib/libnss_files-2.20-2014.11.so
b34c4000 b34cd000 r-xp /lib/libnss_nis-2.20-2014.11.so
b34de000 b34ef000 r-xp /lib/libnsl-2.20-2014.11.so
b3502000 b3508000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3519000 b351a000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3542000 b3549000 r-xp /usr/lib/libminizip.so.1.0.0
b3559000 b355e000 r-xp /usr/lib/libstorage.so.0.1
b356e000 b35c3000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b35d9000 b35ed000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b35fd000 b3641000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3651000 b3659000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3669000 b3699000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b36ac000 b3765000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3779000 b37cd000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b37de000 b37f9000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3809000 b38ca000 r-xp /usr/lib/libprotobuf.so.9.0.1
b38dd000 b38ef000 r-xp /usr/lib/libefl-assist.so.0.1.0
b38ff000 b3903000 r-xp /usr/lib/libogg.so.0.7.1
b3913000 b3935000 r-xp /usr/lib/libvorbis.so.0.4.3
b3945000 b3a29000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b3a45000 b3a52000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3a63000 b3aa6000 r-xp /usr/lib/libsndfile.so.1.0.25
b3abb000 b3b02000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3b13000 b3b19000 r-xp /usr/lib/libjson-c.so.2.0.1
b3b2a000 b3b31000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3b41000 b3b81000 r-xp /usr/lib/libmdm.so.1.2.10
b3b91000 b3b99000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3ba8000 b3bb8000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3bd9000 b3c39000 r-xp /usr/lib/libasound.so.2.0.0
b3c4b000 b3c81000 r-xp /usr/lib/libpulse.so.0.16.2
b3c92000 b3c95000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3ca5000 b3ca8000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3cb8000 b3cbd000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3ccd000 b3cce000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3cde000 b3ce9000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3cfd000 b3d04000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3d14000 b3d1a000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3d2a000 b3d2f000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3d3f000 b3d5a000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3d6a000 b3d71000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3d81000 b3d84000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3d95000 b3dc3000 r-xp /usr/lib/libidn.so.11.5.44
b3dd3000 b3de9000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3dfa000 b3e04000 r-xp /usr/lib/libcares.so.2.1.0
b3e14000 b3e1e000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3e2e000 b3e30000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3e40000 b3e41000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3e51000 b3e55000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3e66000 b3e8e000 r-xp /usr/lib/libui-extension.so.0.1.0
b3e9f000 b3ec8000 r-xp /usr/lib/libturbojpeg.so
b3ee8000 b3eee000 r-xp /usr/lib/libgif.so.4.1.6
b3efe000 b3f44000 r-xp /usr/lib/libcurl.so.4.3.0
b3f55000 b3f76000 r-xp /usr/lib/libexif.so.12.3.3
b3f91000 b3fa6000 r-xp /usr/lib/libtts.so
b3fb7000 b3fbf000 r-xp /usr/lib/libfeedback.so.0.1.4
b3fcf000 b408f000 r-xp /usr/lib/libdali-core.so.0.0.0
b409a000 b418d000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b41ad000 b4287000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b429e000 b42a0000 r-xp /usr/lib/libboost_system.so.1.51.0
b42b0000 b42b6000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b42c6000 b42e9000 r-xp /usr/lib/libboost_thread.so.1.51.0
b42fa000 b42fc000 r-xp /usr/lib/libappsvc.so.0.1.0
b430c000 b430e000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b431f000 b4324000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b433b000 b433d000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b434d000 b4354000 r-xp /usr/lib/libsensord-share.so
b4364000 b437c000 r-xp /usr/lib/libsensor.so.1.1.0
b438d000 b4390000 r-xp /usr/lib/libXv.so.1.0.0
b43a0000 b43a5000 r-xp /usr/lib/libutilX.so.1.1.0
b43b5000 b43ba000 r-xp /usr/lib/libappcore-common.so.1.1
b43ca000 b43d1000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b43e4000 b43e8000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b43f9000 b44c3000 r-xp /usr/lib/libCOREGL.so.4.0
b44da000 b44dd000 r-xp /usr/lib/libuuid.so.1.3.0
b44ee000 b4505000 r-xp /usr/lib/libblkid.so.1.1.0
b4516000 b4518000 r-xp /usr/lib/libXau.so.6.0.0
b4528000 b452b000 r-xp /usr/lib/libEGL.so.1.4
b4533000 b4539000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4549000 b454b000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b455c000 b456a000 r-xp /usr/lib/libGLESv2.so.2.0
b4573000 b45d5000 r-xp /usr/lib/libpixman-1.so.0.28.2
b45ea000 b4602000 r-xp /usr/lib/libmount.so.1.1.0
b4613000 b4627000 r-xp /usr/lib/libxcb.so.1.1.0
b4638000 b463f000 r-xp /lib/libcrypt-2.20-2014.11.so
b4677000 b4688000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b4699000 b469b000 r-xp /usr/lib/libiri.so
b46ab000 b46b6000 r-xp /usr/lib/libgpg-error.so.0.15.0
b46c7000 b46dc000 r-xp /lib/libexpat.so.1.5.2
b46ee000 b47ac000 r-xp /usr/lib/libcairo.so.2.11200.14
b47bf000 b47c7000 r-xp /usr/lib/libdrm.so.2.4.0
b47d7000 b47da000 r-xp /usr/lib/libdri2.so.0.0.0
b47eb000 b4839000 r-xp /usr/lib/libssl.so.1.0.0
b484e000 b485a000 r-xp /usr/lib/libeeze.so.1.13.0
b486a000 b4873000 r-xp /usr/lib/libethumb.so.1.13.0
b4883000 b4886000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4896000 b4a4d000 r-xp /usr/lib/libcrypto.so.1.0.0
b56a4000 b56ad000 r-xp /usr/lib/libXi.so.6.1.0
b56bd000 b56bf000 r-xp /usr/lib/libXgesture.so.7.0.0
b56cf000 b56d3000 r-xp /usr/lib/libXtst.so.6.1.0
b56e3000 b56e9000 r-xp /usr/lib/libXrender.so.1.3.0
b56f9000 b56ff000 r-xp /usr/lib/libXrandr.so.2.2.0
b5710000 b5712000 r-xp /usr/lib/libXinerama.so.1.0.0
b5722000 b5725000 r-xp /usr/lib/libXfixes.so.3.1.0
b5735000 b5740000 r-xp /usr/lib/libXext.so.6.4.0
b5750000 b5752000 r-xp /usr/lib/libXdamage.so.1.1.0
b5762000 b5764000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5775000 b5857000 r-xp /usr/lib/libX11.so.6.3.0
b586a000 b5871000 r-xp /usr/lib/libXcursor.so.1.0.2
b5881000 b5899000 r-xp /usr/lib/libudev.so.1.6.0
b589b000 b589e000 r-xp /lib/libattr.so.1.1.0
b58ae000 b58ce000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58d0000 b58d5000 r-xp /usr/lib/libffi.so.6.0.2
b58e5000 b58fd000 r-xp /lib/libz.so.1.2.8
b590d000 b590f000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b591f000 b59f4000 r-xp /usr/lib/libxml2.so.2.9.2
b5a09000 b5aa4000 r-xp /usr/lib/libstdc++.so.6.0.20
b5ac0000 b5ac3000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5ad3000 b5aec000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5afd000 b5b0e000 r-xp /lib/libresolv-2.20-2014.11.so
b5b22000 b5b9c000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5bb1000 b5bb3000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bc3000 b5bca000 r-xp /usr/lib/libembryo.so.1.13.0
b5bda000 b5bf2000 r-xp /usr/lib/libpng12.so.0.50.0
b5c03000 b5c26000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c47000 b5c5b000 r-xp /usr/lib/libector.so.1.13.0
b5c6c000 b5c84000 r-xp /usr/lib/liblua-5.1.so
b5c95000 b5cec000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d00000 b5d28000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d39000 b5d4c000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d5d000 b5d94000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5da5000 b5db3000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5dc3000 b5dcb000 r-xp /usr/lib/libtbm.so.1.0.0
b5ddb000 b5de8000 r-xp /usr/lib/libeio.so.1.13.0
b5df8000 b5dfa000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e0a000 b5e0f000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e1f000 b5e36000 r-xp /usr/lib/libefreet.so.1.13.0
b5e48000 b5e68000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e78000 b5e98000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e9a000 b5ea0000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5eb0000 b5ec1000 r-xp /usr/lib/libemotion.so.1.13.0
b5ed2000 b5ed9000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5ee9000 b5ef8000 r-xp /usr/lib/libeo.so.1.13.0
b5f09000 b5f1b000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f2c000 b5f31000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f41000 b5f5a000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f6a000 b5f87000 r-xp /usr/lib/libeet.so.1.13.0
b5fa0000 b5fe8000 r-xp /usr/lib/libeina.so.1.13.0
b5ff9000 b6009000 r-xp /usr/lib/libefl.so.1.13.0
b601a000 b60ff000 r-xp /usr/lib/libicuuc.so.51.1
b611c000 b625c000 r-xp /usr/lib/libicui18n.so.51.1
b6273000 b62ab000 r-xp /usr/lib/libecore_x.so.1.13.0
b62bd000 b62c0000 r-xp /lib/libcap.so.2.21
b62d0000 b62f9000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b630a000 b6311000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6323000 b635a000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b636b000 b6456000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6469000 b64e2000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64f4000 b64f9000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6509000 b6513000 r-xp /usr/lib/libvconf.so.0.2.45
b6523000 b6525000 r-xp /usr/lib/libvasum.so.0.3.1
b6535000 b6537000 r-xp /usr/lib/libttrace.so.1.1
b6547000 b654a000 r-xp /usr/lib/libiniparser.so.0
b655a000 b6580000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6590000 b6595000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65a6000 b65bd000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65ce000 b6639000 r-xp /lib/libm-2.20-2014.11.so
b664a000 b6650000 r-xp /lib/librt-2.20-2014.11.so
b6661000 b666e000 r-xp /usr/lib/libunwind.so.8.0.1
b66a4000 b67c8000 r-xp /lib/libc-2.20-2014.11.so
b67dd000 b67f6000 r-xp /lib/libgcc_s-4.9.so.1
b6806000 b68e8000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68f9000 b6923000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6934000 b6970000 r-xp /usr/lib/libsystemd.so.0.4.0
b6972000 b69f4000 r-xp /usr/lib/libedje.so.1.13.0
b6a07000 b6a25000 r-xp /usr/lib/libecore.so.1.13.0
b6a45000 b6bcc000 r-xp /usr/lib/libevas.so.1.13.0
b6c01000 b6c15000 r-xp /lib/libpthread-2.20-2014.11.so
b6c29000 b6e5e000 r-xp /usr/lib/libelementary.so.1.13.0
b6e8c000 b6e90000 r-xp /usr/lib/libsmack.so.1.0.0
b6ea0000 b6ea7000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6eb7000 b6eb9000 r-xp /usr/lib/libdlog.so.0.0.0
b6ec9000 b6ecc000 r-xp /usr/lib/libbundle.so.0.1.22
b6edc000 b6ede000 r-xp /lib/libdl-2.20-2014.11.so
b6eef000 b6f07000 r-xp /usr/lib/libaul.so.0.1.0
b6f1b000 b6f20000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f31000 b6f3e000 r-xp /usr/lib/liblptcp.so
b6f50000 b6f54000 r-xp /usr/lib/libsys-assert.so
b6f65000 b6f85000 r-xp /lib/ld-2.20-2014.11.so
b6f96000 b6f9b000 r-xp /usr/bin/launchpad-loader
b7f58000 b8203000 rw-p [heap]
beac7000 beae8000 rw-p [stack]
b7f58000 b8203000 rw-p [heap]
beac7000 beae8000 rw-p [stack]
End of Maps Information

Callstack Information (PID:2837)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb66cfb84) [/lib/libc.so.6] + 0x2bb84
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
07-19 21:18:07.275+0600 D/BROWSER_WIDGET( 1054): Width and Height = 474 ,474
07-19 21:18:10.328+0600 E/OSP_SLP ( 1305): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_BASE failed.
07-19 21:18:10.328+0600 E/OSP_SLP ( 1305): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_BASE_COL failed.
07-19 21:18:10.328+0600 E/OSP_SLP ( 1305): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_BASE_UTIL failed.
07-19 21:18:10.328+0600 E/OSP_SLP ( 1305): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_CNT failed.
07-19 21:18:10.328+0600 E/OSP_SLP ( 1305): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_CTXT failed.
07-19 21:18:10.328+0600 E/OSP_SLP ( 1305): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_GRP failed.
07-19 21:18:10.328+0600 E/OSP_SLP ( 1305): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_LCL failed.
07-19 21:18:10.328+0600 E/OSP_SLP ( 1305): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_LOC failed.
07-19 21:18:10.328+0600 E/OSP_SLP ( 1305): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_LOC_CTRL failed.
07-19 21:18:10.328+0600 E/OSP_SLP ( 1305): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_LOC_SVC failed.
07-19 21:18:10.328+0600 E/OSP_SLP ( 1305): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_MEDIA failed.
07-19 21:18:10.328+0600 E/OSP_SLP ( 1305): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_NET_BT failed.
07-19 21:18:10.328+0600 E/OSP_SLP ( 1305): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_NET_NFC failed.
07-19 21:18:10.328+0600 E/OSP_SLP ( 1305): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_SEC failed.
07-19 21:18:10.328+0600 E/OSP_SLP ( 1305): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_SEC_CERT failed.
07-19 21:18:10.328+0600 E/OSP_SLP ( 1305): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_SEC_CRYPTO failed.
07-19 21:18:10.328+0600 E/OSP_SLP ( 1305): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_SCL failed.
07-19 21:18:10.328+0600 E/OSP_SLP ( 1305): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_TEL failed.
07-19 21:18:10.328+0600 E/OSP_SLP ( 1305): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_TEXT failed.
07-19 21:18:10.328+0600 E/OSP_SLP ( 1305): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_UI failed.
07-19 21:18:10.328+0600 E/OSP_SLP ( 1305): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_UI_ANIM failed.
07-19 21:18:10.328+0600 E/OSP_SLP ( 1305): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_UI_CTRL failed.
07-19 21:18:10.328+0600 E/OSP_SLP ( 1305): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_UI_EFFECT failed.
07-19 21:18:10.328+0600 E/OSP_SLP ( 1305): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_UI_IME failed.
07-19 21:18:10.328+0600 E/OSP_SLP ( 1305): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_UI_SCENES failed.
07-19 21:18:10.328+0600 E/OSP_SLP ( 1305): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_UIX failed.
07-19 21:18:10.328+0600 E/OSP_SLP ( 1305): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_UIX_SPEECH failed.
07-19 21:18:10.328+0600 E/OSP_SLP ( 1305): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_WEB failed.
07-19 21:18:10.328+0600 E/OSP_SLP ( 1305): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_WEB_CTRL failed.
07-19 21:18:10.328+0600 E/OSP_SLP ( 1305): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_WEB_JSON failed.
07-19 21:18:10.328+0600 E/Tizen::Base::Runtime( 1305): (292) > [E_OBJ_NOT_FOUND] This is not OSP thread.
07-19 21:18:10.328+0600 E/Tizen::Base::Runtime( 1305): (207) > [E_INVALID_OPERATION] Event manager does not exist.
07-19 21:18:10.338+0600 I/Tizen::App( 1305): (85) > Create new instance
07-19 21:18:10.338+0600 I/Tizen::Io( 1305): (350) > [E_SUCCESS] exception occurred.
07-19 21:18:10.338+0600 I/Tizen::App( 1305): (116) > Loading 15 sections from /usr/etc/app-control-info.ini
07-19 21:18:10.338+0600 I/Tizen::App( 1305): (147) > Finished loading 15 tizen AppControl entries
07-19 21:18:10.348+0600 I/Tizen::Io( 1305): (350) > [E_SUCCESS] exception occurred.
07-19 21:18:10.348+0600 I/Tizen::App( 1305): (169) > Loading 34 sections from /usr/etc/app-control-alias.ini
07-19 21:18:10.348+0600 I/Tizen::App( 1305): (223) > (osp.appcontrol.CONTACT, tizen.contacts)
07-19 21:18:10.348+0600 I/Tizen::App( 1305): (223) > (osp.appcontrol.CONTACT, tizen.contacts)
07-19 21:18:10.348+0600 I/Tizen::App( 1305): (223) > (osp.appcontrol.CONTACT, tizen.contacts)
07-19 21:18:10.348+0600 I/Tizen::App( 1305): (223) > (osp.appcontrol.CONTACT, tizen.contacts)
07-19 21:18:10.348+0600 I/Tizen::App( 1305): (223) > (osp.appcontrol.CALENDAR, tizen.calendar)
07-19 21:18:10.348+0600 I/Tizen::App( 1305): (223) > (osp.appcontrol.CALENDAR, tizen.calendar)
07-19 21:18:10.348+0600 I/Tizen::App( 1305): (223) > (osp.appcontrol.TODO, tizen.todo)
07-19 21:18:10.348+0600 I/Tizen::App( 1305): (223) > (osp.appcontrol.BT, tizen.bluetooth)
07-19 21:18:10.348+0600 I/Tizen::App( 1305): (223) > (osp.appcontrol.DIAL, tizen.phone)
07-19 21:18:10.348+0600 I/Tizen::App( 1305): (223) > (osp.appcontrol.CALL, tizen.phone)
07-19 21:18:10.348+0600 I/Tizen::App( 1305): (223) > (osp.appcontrol.BROWSER, tizen.internet)
07-19 21:18:10.348+0600 I/Tizen::App( 1305): (223) > (osp.appcontrol.MEDIA, tizen.filemanager)
07-19 21:18:10.348+0600 I/Tizen::App( 1305): (223) > (osp.appcontrol.MESSAGE, tizen.messages)
07-19 21:18:10.348+0600 I/Tizen::App( 1305): (223) > (osp.appcontrol.EMAIL, tizen.email)
07-19 21:18:10.348+0600 I/Tizen::App( 1305): (223) > (osp.appcontrol.IMAGE, tizen.imageviewer)
07-19 21:18:10.348+0600 I/Tizen::App( 1305): (223) > (osp.appcontrol.VIDEO, tizen.videoplayer)
07-19 21:18:10.348+0600 I/Tizen::App( 1305): (223) > (osp.appcontrol.AUDIO, tizen.musicplayer)
07-19 21:18:10.348+0600 I/Tizen::App( 1305): (223) > (osp.appcontrol.CAMERA, tizen.camera)
07-19 21:18:10.348+0600 I/Tizen::App( 1305): (223) > (osp.appcontrol.SETTINGS, tizen.settings)
07-19 21:18:10.348+0600 I/Tizen::App( 1305): (223) > (osp.appcontrol.provider.contact, tizen.contacts)
07-19 21:18:10.348+0600 I/Tizen::App( 1305): (223) > (osp.appcontrol.provider.contact, tizen.contacts)
07-19 21:18:10.348+0600 I/Tizen::App( 1305): (223) > (osp.appcontrol.provider.contact, tizen.contacts)
07-19 21:18:10.348+0600 I/Tizen::App( 1305): (223) > (osp.appcontrol.provider.contact, tizen.contacts)
07-19 21:18:10.348+0600 I/Tizen::App( 1305): (223) > (osp.appcontrol.provider.calendar, tizen.calendar)
07-19 21:18:10.348+0600 I/Tizen::App( 1305): (223) > (osp.appcontrol.provider.calendar, tizen.calendar)
07-19 21:18:10.348+0600 I/Tizen::App( 1305): (223) > (osp.appcontrol.provider.todo, tizen.todo)
07-19 21:18:10.348+0600 I/Tizen::App( 1305): (223) > (osp.appcontrol.provider.bluetooth, tizen.bluetooth)
07-19 21:18:10.348+0600 I/Tizen::App( 1305): (223) > (osp.appcontrol.provider.call, tizen.phone)
07-19 21:18:10.348+0600 I/Tizen::App( 1305): (223) > (osp.appcontrol.provider.call, tizen.phone)
07-19 21:18:10.348+0600 I/Tizen::App( 1305): (223) > (osp.appcontrol.provider.browser, tizen.internet)
07-19 21:18:10.348+0600 I/Tizen::App( 1305): (223) > (osp.appcontrol.provider.media, tizen.filemanager)
07-19 21:18:10.348+0600 I/Tizen::App( 1305): (223) > (osp.appcontrol.provider.message, tizen.messages)
07-19 21:18:10.348+0600 I/Tizen::App( 1305): (223) > (osp.appcontrol.provider.email, tizen.email)
07-19 21:18:10.348+0600 I/Tizen::App( 1305): (223) > (osp.appcontrol.provider.image, tizen.imageviewer)
07-19 21:18:10.348+0600 I/Tizen::App( 1305): (223) > (osp.appcontrol.provider.imageeditor, tizen.imageeditor)
07-19 21:18:10.348+0600 I/Tizen::App( 1305): (223) > (osp.appcontrol.provider.video, tizen.videoplayer)
07-19 21:18:10.348+0600 I/Tizen::App( 1305): (223) > (osp.appcontrol.provider.audio, tizen.musicplayer)
07-19 21:18:10.348+0600 I/Tizen::App( 1305): (223) > (osp.appcontrol.provider.camera, tizen.camera)
07-19 21:18:10.348+0600 I/Tizen::App( 1305): (223) > (osp.appcontrol.provider.camera, tizen.camera)
07-19 21:18:10.348+0600 I/Tizen::App( 1305): (223) > (osp.appcontrol.provider.settings, tizen.settings)
07-19 21:18:10.348+0600 I/Tizen::App( 1305): (223) > (osp.appcontrol.provider.certificatemanager, tizen.certificatemanager)
07-19 21:18:10.348+0600 I/Tizen::App( 1305): (223) > (tizen.camera, tizen.camera)
07-19 21:18:10.348+0600 I/Tizen::App( 1305): (223) > (tizen.camera, tizen.camera)
07-19 21:18:10.348+0600 I/Tizen::App( 1305): (223) > (tizen.camera, tizen.camera)
07-19 21:18:10.348+0600 I/Tizen::App( 1305): (223) > (tizen.phone, tizen.call)
07-19 21:18:10.348+0600 I/Tizen::App( 1305): (223) > (tizen.certificatemanager, tizen.certificatemanager)
07-19 21:18:10.348+0600 I/Tizen::App( 1305): (232) > Finished loading 46 entries.
07-19 21:18:10.368+0600 I/Tizen::App( 1305): (181) > App root directory (/opt/usr/apps/aospd00043/:9) open.
07-19 21:18:10.368+0600 I/Tizen::App( 1305): (195) > sd root directory (/opt/storage/sdcard/app2sd/aospd00043:-1) open.
07-19 21:18:10.368+0600 I/Tizen::App( 1305): (237) > AppInfo [aospd00043.osp-app-service][aospd00043.osp-app-service][220].
07-19 21:18:10.368+0600 I/osp-app-service( 1305): int OspMain(int, char**)(36) > Application started.
07-19 21:18:10.368+0600 I/Tizen::App( 1305): (145) > Enter.
07-19 21:18:10.368+0600 I/Tizen::App( 1305): (301) > Enter::app-service::InitializeIpc
07-19 21:18:10.368+0600 I/Tizen::App( 1305): (49) > Enter
07-19 21:18:10.368+0600 I/Tizen::App( 1305): (51) > Exit
07-19 21:18:10.368+0600 I/Tizen::App( 1305): (74) > Enter
07-19 21:18:10.368+0600 I/Tizen::App( 1305): (63) > 
07-19 21:18:10.368+0600 I/Tizen::App( 1305): (76) > Enter
07-19 21:18:10.398+0600 I/Tizen::App( 1305): (84) > There is no launchOnBoot App.
07-19 21:18:10.398+0600 I/Tizen::App( 1305): (86) > Exit
07-19 21:18:10.398+0600 I/Tizen::Io( 1305): (202) > Unlink a socket has failed.. but it is not a problem.
07-19 21:18:10.398+0600 I/Tizen::App( 1305): (88) > Exit
07-19 21:18:10.398+0600 I/Tizen::Io( 1305): (202) > Unlink a socket has failed.. but it is not a problem.
07-19 21:18:10.398+0600 I/Tizen::App( 1305): (121) > 
07-19 21:18:10.458+0600 I/Tizen::App( 1305): (665) > Registered app event listener.
07-19 21:18:10.458+0600 I/Tizen::App( 1305): (325) > Exit.
07-19 21:18:10.458+0600 I/Tizen::App( 1305): (152) > Exit.
07-19 21:18:10.458+0600 I/Tizen::App | LAUNCH( 1305): (165) > [osp-app-service:<Initialize Application>:start]
07-19 21:18:10.458+0600 I/Tizen::App( 1305): (205) > Maintain message box compatiblity between 2.3 and 2.4
07-19 21:18:11.259+0600 I/Tizen::App( 1305): (228) > Platform creation event.
07-19 21:18:11.269+0600 I/Tizen::App | LAUNCH( 1305): (257) > [osp-app-service:<OnAppInitializing>:start]
07-19 21:18:11.279+0600 I/Tizen::App( 1305): (416) > appName = [osp-app-service]
07-19 21:18:11.279+0600 I/Tizen::App( 1305): (509) > exe = [/opt/apps/aospd00043/bin/osp-app-service], displayName = [Native Application Service], mainApp = [1], menuIconVisible = [1], serviceApp = [1]
07-19 21:18:11.689+0600 I/Tizen::App( 1305): (54) > [E_SUCCESS] 1 entry registered.
07-19 21:18:11.689+0600 I/Tizen::App( 1305): (190) > Enter::app-service::OnAppInitializing
07-19 21:18:11.689+0600 I/Tizen::App( 1305): (198) > Exit.
07-19 21:18:11.689+0600 I/Tizen::App | LAUNCH( 1305): (268) > [osp-app-service:<OnAppInitializing>:done]
07-19 21:18:11.689+0600 I/Tizen::App | LAUNCH( 1305): (270) > [osp-app-service:<RegisterApplication>:start]
07-19 21:18:11.689+0600 I/Tizen::App( 1305): (162) > Service itself is registered.
07-19 21:18:11.699+0600 I/Tizen::App( 1305): (149) > app = [aospd00043.osp-app-service], package = [aospd00043]
07-19 21:18:11.699+0600 I/Tizen::App( 1305): (241) > Set OOM : result is E_SUCCESS
07-19 21:18:11.699+0600 I/Tizen::App( 1305): (243) > The application (app(aospd00043.osp-app-service), pid:1305) Registered.
07-19 21:18:11.699+0600 I/Tizen::App( 1305): (453) > registered app count : 1
07-19 21:18:11.699+0600 I/Tizen::App( 1305): (460) > aospd00043.osp-app-service(pid:1305)
07-19 21:18:11.699+0600 I/Tizen::App | LAUNCH( 1305): (277) > [osp-app-service:<RegisterApplication>:done]
07-19 21:18:12.049+0600 I/Tizen::App( 1305): (90) > 
07-19 21:18:12.049+0600 I/Tizen::App( 1305): (107) > Current request ID : 0.
07-19 21:18:12.049+0600 I/Tizen::App( 1305): (542) > Request 0x1 received for 0x0.
07-19 21:18:12.049+0600 I/Tizen::App | LAUNCH( 1305): (370) > [osp-app-service:<RequestHandler and OnAppInitialized>:start]
07-19 21:18:12.049+0600 I/Tizen::App( 1305): (572) > Handling AppControl request
07-19 21:18:12.049+0600 I/Tizen::App( 1305): (720) > No AppControl provider event listener set for request 0.
07-19 21:18:12.049+0600 I/Tizen::App( 1305): (205) > Enter::app-service::OnAppInitialized
07-19 21:18:12.049+0600 I/Tizen::App( 1305): (344) > Enter::app-service::ReadySystemServices
07-19 21:18:12.099+0600 I/Tizen::System( 1305): (186) > Send function[b6c1c755] is registered for Accessory.
07-19 21:18:12.099+0600 I/Tizen::App( 1305): (512) > Initializing common-service...
07-19 21:18:12.099+0600 I/Tizen::Io( 1305): (42) > Enter.
07-19 21:18:12.099+0600 I/Tizen::Io( 1305): (202) > Unlink a socket has failed.. but it is not a problem.
07-19 21:18:12.099+0600 I/Tizen::Net( 1305): (82) > Initializing ConnectivityService...
07-19 21:18:12.099+0600 I/Tizen::Net( 1305): (55) > Enter.
07-19 21:18:12.099+0600 I/Tizen::Net( 1305): (68) > Initializing ConnectivityService...
07-19 21:18:12.109+0600 I/Tizen::Io( 1305): (202) > Unlink a socket has failed.. but it is not a problem.
07-19 21:18:12.109+0600 I/Tizen::Net( 1305): (111) > _NetConnectivityIpcStub started.
07-19 21:18:12.109+0600 I/Tizen::Net( 1305): (606) > GetDbPath() has been succeeded with the path:/opt/usr/apps/aospd00043/data/.tizen_netaccount.db
07-19 21:18:12.109+0600 I/Tizen::Net( 1305): (606) > GetDbPath() has been succeeded with the path:/opt/usr/apps/aospd00043/data/.tizen_netaccount.db
07-19 21:18:12.119+0600 I/Tizen::Net( 1305): (606) > GetDbPath() has been succeeded with the path:/opt/usr/apps/aospd00043/data/.tizen_netaccount.db
07-19 21:18:12.260+0600 I/Tizen::Net( 1305): (802) > GetAllProfileNamesN() has been succeeded with profiles count:0
07-19 21:18:12.260+0600 I/Tizen::Net( 1305): (1038) > Network account database is updated.
07-19 21:18:12.280+0600 I/Tizen::Net( 1305): (96) > The return value of connection_create() is 0x0
07-19 21:18:12.280+0600 I/Tizen::Net( 1305): (105) > The return value of connection_create() is 0x0
07-19 21:18:12.280+0600 I/Tizen::System( 1305): (607) > Request Key is http://tizen.org/feature/network.wifi.
07-19 21:18:12.300+0600 I/Tizen::Io( 1305): (350) > [E_SUCCESS] exception occurred.
07-19 21:18:12.330+0600 I/Tizen::Net::Wifi( 1305): (508) > SSID : Liuntu security type : 2 encryption type : 3
07-19 21:18:12.340+0600 I/Tizen::Net::Wifi( 1305): (508) > SSID : As3  security type : 2 encryption type : 3
07-19 21:18:12.340+0600 I/Tizen::Net::Wifi( 1305): (81) > _WifiService is created
07-19 21:18:12.340+0600 I/Tizen::Net::Wifi( 1305): (87) > _WifiProximityService is created
07-19 21:18:12.340+0600 I/Tizen::System( 1305): (607) > Request Key is http://tizen.org/feature/network.wifi.direct.
07-19 21:18:12.350+0600 I/Tizen::Io( 1305): (350) > [E_SUCCESS] exception occurred.
07-19 21:18:12.350+0600 I/Tizen::Net::Wifi( 1305): (106) > _WifiDirectService is created.
07-19 21:18:12.350+0600 I/Tizen::Io( 1305): (202) > Unlink a socket has failed.. but it is not a problem.
07-19 21:18:12.350+0600 I/Tizen::Net::Wifi( 1305): (224) > _WifiConnectivityIpcStub started.
07-19 21:18:12.350+0600 I/Tizen::Net::Wifi( 1305): (117) > _IpcServer is created
07-19 21:18:12.350+0600 I/Tizen::System( 1305): (607) > Request Key is http://tizen.org/feature/network.wifi.
07-19 21:18:12.350+0600 I/Tizen::Net::Wifi( 1305): (181) > pWifiServie is -1218867384
07-19 21:18:12.350+0600 I/Tizen::Net::Wifi( 1305): (59) > _WifiExtensionService is created
07-19 21:18:12.350+0600 I/Tizen::Io( 1305): (202) > Unlink a socket has failed.. but it is not a problem.
07-19 21:18:12.350+0600 I/Tizen::Net::Wifi( 1305): (95) > _WifiExtensionConnectivityIpcStub started.
07-19 21:18:12.350+0600 I/Tizen::System( 1305): (607) > Request Key is BluetoothSupported.
07-19 21:18:12.360+0600 I/Tizen::Io( 1305): (350) > [E_SUCCESS] exception occurred.
07-19 21:18:12.390+0600 I/Tizen::Io( 1305): (202) > Unlink a socket has failed.. but it is not a problem.
07-19 21:18:12.390+0600 I/Tizen::Io( 1305): (202) > Unlink a socket has failed.. but it is not a problem.
07-19 21:18:12.390+0600 I/Tizen::Net( 1305): (115) > Initializing ConnectivityService is successful.
07-19 21:18:12.390+0600 I/Tizen::Net( 1305): (90) > Initializing ConnectivityService is successful.
07-19 21:18:12.390+0600 I/Tizen::Net( 1305): (36) > Enter.
07-19 21:18:12.390+0600 I/Tizen::Net( 1305): (49) > Initializing MessagingService...
07-19 21:18:12.390+0600 I/Tizen::Io( 1305): (202) > Unlink a socket has failed.. but it is not a problem.
07-19 21:18:12.390+0600 I/Tizen::Messaging( 1305): (127) > _MessagingIpcStub started.
07-19 21:18:12.390+0600 I/Tizen::Messaging( 1305): (103) > _MessagingIpcStub Construct.
07-19 21:18:12.390+0600 I/Tizen::Io( 1305): (202) > Unlink a socket has failed.. but it is not a problem.
07-19 21:18:12.390+0600 I/Tizen::Messaging( 1305): (96) > _MessagingIpcStubEx started.
07-19 21:18:12.390+0600 I/Tizen::Messaging( 1305): (78) > _MessagingIpcStubEx Construct.
07-19 21:18:12.390+0600 I/Tizen::Net( 1305): (68) > Initializing MessagingService is successful.
07-19 21:18:12.390+0600 I/Tizen::Io( 1305): (202) > Unlink a socket has failed.. but it is not a problem.
07-19 21:18:12.400+0600 I/Tizen::System( 1305): (226) > wifi init is started
07-19 21:18:12.400+0600 I/Tizen::System( 1305): (228) > wifi init result is -38
07-19 21:18:12.410+0600 E/Tizen::System( 1305): (70) > It is failed to register VCONFKEY_SETAPPL_DEFAULT_MEM_WAP_INT event listener
07-19 21:18:12.410+0600 E/Tizen::System( 1305): (94) > It is failed to register VCONFKEY_SETAPPL_DEFAULT_MEM_FM_RADIO_INT event listener
07-19 21:18:12.420+0600 E/Tizen::System( 1305): (100) > It is failed to register VCONFKEY_SETAPPL_DEFAULT_MEM_DVB_H_INT event listener
07-19 21:18:12.420+0600 I/Tizen::System( 1305): (158) > Volume change callback is already registered
07-19 21:18:12.420+0600 E/Tizen::System( 1305): (101) > Setting done
07-19 21:18:12.420+0600 I/Tizen::Io( 1305): (202) > Unlink a socket has failed.. but it is not a problem.
07-19 21:18:12.420+0600 E/Tizen::System( 1305): (103) > Runtime done
07-19 21:18:12.420+0600 I/Tizen::Io( 1305): (202) > Unlink a socket has failed.. but it is not a problem.
07-19 21:18:12.420+0600 I/Tizen::System( 1305): (166) > InitSingleton
07-19 21:18:12.420+0600 I/Tizen::Io( 1305): (178) > The buffer is empty.
07-19 21:18:12.420+0600 I/Tizen::System( 1305): (109) > It is success InitSingleton.
07-19 21:18:12.420+0600 E/Tizen::System( 1305): (105) > Device done
07-19 21:18:12.420+0600 I/Tizen::Io( 1305): (202) > Unlink a socket has failed.. but it is not a problem.
07-19 21:18:12.450+0600 I/Tizen::System( 1305): (734) > It successed to register power_set_changed_cb
07-19 21:18:12.450+0600 I/Tizen::Io( 1305): (178) > The buffer is empty.
07-19 21:18:12.450+0600 E/Tizen::System( 1305): (107) > Power done
07-19 21:18:12.450+0600 I/Tizen::Io( 1305): (202) > Unlink a socket has failed.. but it is not a problem.
07-19 21:18:12.450+0600 E/Tizen::System( 1305): (116) > UI done
07-19 21:18:12.450+0600 I/Tizen::Io( 1305): (202) > Unlink a socket has failed.. but it is not a problem.
07-19 21:18:12.450+0600 E/Tizen::System( 1305): (119) > System done
07-19 21:18:12.450+0600 I/Tizen::Io( 1305): (202) > Unlink a socket has failed.. but it is not a problem.
07-19 21:18:12.460+0600 E/Tizen::System( 1305): (122) > AlarmEx done
07-19 21:18:12.460+0600 I/Tizen::System( 1305): (1213) > Updating the cache file
07-19 21:18:12.470+0600 I/Tizen::Io( 1305): (350) > [E_SUCCESS] exception occurred.
07-19 21:18:12.470+0600 I/Tizen::System( 1305): (2762) > Request Key is http://tizen.org/feature/screen.dpi.
07-19 21:18:12.480+0600 I/Tizen::System( 1305): (2762) > Request Key is http://tizen.org/feature/screen.height.
07-19 21:18:12.490+0600 I/Tizen::System( 1305): (2762) > Request Key is http://tizen.org/feature/screen.width.
07-19 21:18:12.500+0600 I/Tizen::System( 1305): (2785) > Request Key is http://tizen.org/feature/screen.size.large.
07-19 21:18:12.510+0600 I/Tizen::System( 1305): (2785) > Request Key is http://tizen.org/feature/screen.size.normal.
07-19 21:18:12.520+0600 I/Tizen::System( 1305): (2785) > Request Key is http://tizen.org/feature/screen.size.normal.240.400.
07-19 21:18:12.530+0600 I/Tizen::System( 1305): (2785) > Request Key is http://tizen.org/feature/screen.size.normal.320.480.
07-19 21:18:12.540+0600 I/Tizen::System( 1305): (2785) > Request Key is http://tizen.org/feature/screen.size.normal.480.800.
07-19 21:18:12.550+0600 I/Tizen::System( 1305): (2785) > Request Key is http://tizen.org/feature/screen.size.normal.540.960.
07-19 21:18:12.560+0600 I/Tizen::System( 1305): (2785) > Request Key is http://tizen.org/feature/screen.size.normal.600.1024.
07-19 21:18:12.570+0600 I/Tizen::System( 1305): (2785) > Request Key is http://tizen.org/feature/screen.size.normal.720.1280.
07-19 21:18:12.570+0600 I/Tizen::System( 1305): (2785) > Request Key is http://tizen.org/feature/screen.size.normal.1080.1920.
07-19 21:18:12.590+0600 E/Tizen::Security( 1305): (128) > Intergration mode
07-19 21:18:12.590+0600 I/osp-security-service( 1305): result PrivilegeService::Construct()(61) > Entered.
07-19 21:18:12.590+0600 I/Tizen::Io( 1305): (202) > Unlink a socket has failed.. but it is not a problem.
07-19 21:18:12.590+0600 I/osp-security-service( 1305): result PrivilegeService::Construct()(69) > Leaved.
07-19 21:18:12.590+0600 I/Tizen::Io( 1305): (202) > Unlink a socket has failed.. but it is not a problem.
07-19 21:18:12.590+0600 I/Tizen::Io( 1305): (114) > inotify fd: 61, channel: 0xb758d9f0
07-19 21:18:12.590+0600 I/Tizen::Io( 1305): (105) > _FileEventManagerImpl: 0xb7614b38, _Event: 0xb7613740
07-19 21:18:12.590+0600 I/Tizen::Io( 1305): (286) > Add event info, wd: 1, _FileEventInfo: 0xb76166b0, _FileEventManagerImpl: 0xb7614b38
07-19 21:18:12.590+0600 I/Tizen::Io( 1305): (178) > Add to watch list
07-19 21:18:12.590+0600 I/Tizen::Io( 1305): (105) > _FileEventManagerImpl: 0xb7615d10, _Event: 0xb7616900
07-19 21:18:12.590+0600 I/Tizen::Io( 1305): (286) > Add event info, wd: 2, _FileEventInfo: 0xb7599810, _FileEventManagerImpl: 0xb7615d10
07-19 21:18:12.590+0600 I/Tizen::Io( 1305): (178) > Add to watch list
07-19 21:18:12.590+0600 I/Tizen::Io( 1305): (105) > _FileEventManagerImpl: 0xb76166e8, _Event: 0xb7616a58
07-19 21:18:12.590+0600 I/Tizen::Io( 1305): (286) > Add event info, wd: 3, _FileEventInfo: 0xb75998c8, _FileEventManagerImpl: 0xb76166e8
07-19 21:18:12.590+0600 I/Tizen::Io( 1305): (178) > Add to watch list
07-19 21:18:12.590+0600 I/Tizen::Io( 1305): (105) > _FileEventManagerImpl: 0xb7616980, _Event: 0xb7599a08
07-19 21:18:12.600+0600 I/Tizen::Io( 1305): (286) > Add event info, wd: 4, _FileEventInfo: 0xb7540468, _FileEventManagerImpl: 0xb7616980
07-19 21:18:12.600+0600 I/Tizen::Io( 1305): (178) > Add to watch list
07-19 21:18:12.600+0600 I/Tizen::Io( 1305): (105) > _FileEventManagerImpl: 0xb75401b8, _Event: 0xb7540200
07-19 21:18:12.600+0600 I/Tizen::Io( 1305): (286) > Add event info, wd: 5, _FileEventInfo: 0xb75402b0, _FileEventManagerImpl: 0xb75401b8
07-19 21:18:12.600+0600 I/Tizen::Io( 1305): (178) > Add to watch list
07-19 21:18:12.600+0600 I/Tizen::Io( 1305): (105) > _FileEventManagerImpl: 0xb75405a8, _Event: 0xb75403f0
07-19 21:18:12.600+0600 E/Tizen::Io( 1305): (116) > [E_FILE_NOT_FOUND] The path (/usr/share/cert-svc/ca-certs/) dose not exist.
07-19 21:18:12.600+0600 E/Tizen::Io( 1305): (71) > [E_FILE_NOT_FOUND] An entry for the specified path[/usr/share/cert-svc/ca-certs/] could not be found.
07-19 21:18:12.600+0600 I/osp-app-service( 1305): result _DrmService::Construct()(119) > _DrmService::Construct is called.
07-19 21:18:12.680+0600 I/Tizen::App( 1305): (282) > Wrong process id value -1.
07-19 21:18:12.690+0600 I/osp-app-service( 1305): result _DrmService::Construct()(124) > _DrmService::RequestLocalMessagePort successfully called.
07-19 21:18:12.690+0600 I/osp-app-service( 1305): result _DrmService::Construct()(129) > _DrmService : LocalMessagePort is ready.
07-19 21:18:12.690+0600 I/osp-app-service( 1305): static _DrmService* _DrmService::GetInstance()(96) > _DrmService : m_pInstance is created.
07-19 21:18:12.690+0600 I/Tizen::App( 1305): (520) > Initializing common-service is successful.
07-19 21:18:12.690+0600 I/Tizen::App( 1305): (528) > Enter :: LaunchUserServices
07-19 21:18:12.700+0600 I/Tizen::App( 1305): (533) > No launch-on-boot entry.
07-19 21:18:12.700+0600 I/Tizen::System( 1305): (1012) > It successed to register boot event listener.
07-19 21:18:12.700+0600 I/Tizen::App( 1305): (244) > Exit.
07-19 21:18:12.700+0600 I/Tizen::App | LAUNCH( 1305): (380) > [osp-app-service:<RequestHandler and OnAppInitialized>:done]
07-19 21:18:12.700+0600 I/Tizen::App | LAUNCH( 1305): (384) > [osp-app-service:<Initialize Application>:done]
07-19 21:18:12.700+0600 I/Tizen::App( 1305): (103) > Service requested.
07-19 21:18:12.700+0600 I/Tizen::App( 1305): (620) > Dummy handler
07-19 21:18:12.720+0600 I/Tizen::App( 1305): (499) > LaunchedApp(com.samsung.saf-servie)
07-19 21:18:12.720+0600 I/Tizen::App( 1305): (733) > Finished invoking application event listener for com.samsung.saf-servie, 1379.
07-19 21:18:12.850+0600 I/Tizen::App( 1305): (243) > App[com.samsung.saf-servie] pid[1379] terminate event is forwarded
07-19 21:18:12.850+0600 I/Tizen::System( 1305): (256) > osp.accessorymanager.service provider is found.
07-19 21:18:12.850+0600 I/Tizen::System( 1305): (196) > Accessory Owner is removed [com.samsung.saf-servie, 1379, ]
07-19 21:18:12.850+0600 I/Tizen::System( 1305): (256) > osp.system.service provider is found.
07-19 21:18:12.850+0600 I/Tizen::App( 1305): (506) > TerminatedApp(com.samsung.saf-servie)
07-19 21:18:12.850+0600 I/Tizen::App( 1305): (512) > Not registered pid(1379)
07-19 21:18:12.850+0600 I/Tizen::System( 1305): (246) > Terminated app [com.samsung.saf-servie]
07-19 21:18:12.850+0600 E/Tizen::Io( 1305): (278) > [E_INVALID_ARG] entryName.GetLength() <= 0
07-19 21:18:12.900+0600 I/Tizen::System( 1305): (157) > change brightness system value.
07-19 21:18:12.900+0600 I/Tizen::App( 1305): (782) > Finished invoking application event listener for com.samsung.saf-servie, 1379.
07-19 21:18:13.401+0600 I/Tizen::App( 1305): (753) > [E_OBJ_NOT_FOUND] Cannot acquire app from pid 1326.
07-19 21:18:13.951+0600 I/Tizen::App( 1305): (499) > LaunchedApp(com.samsung.cloud-content-sync)
07-19 21:18:13.951+0600 I/Tizen::App( 1305): (733) > Finished invoking application event listener for com.samsung.cloud-content-sync, 1453.
07-19 21:18:16.974+0600 I/Tizen::App( 1305): (499) > LaunchedApp(org.tizen.tizenstore.tizenstoreservice)
07-19 21:18:16.974+0600 I/Tizen::App( 1305): (733) > Finished invoking application event listener for org.tizen.tizenstore.tizenstoreservice, 1513.
07-19 21:18:17.054+0600 I/Tizen::App( 1305): (499) > LaunchedApp(com.samsung.samsung-log-relay-mobile-service)
07-19 21:18:17.054+0600 I/Tizen::App( 1305): (733) > Finished invoking application event listener for com.samsung.samsung-log-relay-mobile-service, 1372.
07-19 21:18:17.625+0600 I/Tizen::App( 1305): (753) > [E_OBJ_NOT_FOUND] Cannot acquire app from pid 915.
07-19 21:18:19.927+0600 I/Tizen::App( 1305): (499) > LaunchedApp(EmbkcJFK7q.MMSBootService)
07-19 21:18:19.927+0600 I/Tizen::App( 1305): (733) > Finished invoking application event listener for EmbkcJFK7q.MMSBootService, 1550.
07-19 21:18:20.337+0600 E/OSP_SLP ( 1550): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_BASE failed.
07-19 21:18:20.337+0600 E/OSP_SLP ( 1550): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_BASE_COL failed.
07-19 21:18:20.337+0600 E/OSP_SLP ( 1550): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_BASE_UTIL failed.
07-19 21:18:20.337+0600 E/OSP_SLP ( 1550): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_CNT failed.
07-19 21:18:20.337+0600 E/OSP_SLP ( 1550): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_CTXT failed.
07-19 21:18:20.337+0600 E/OSP_SLP ( 1550): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_GRP failed.
07-19 21:18:20.337+0600 E/OSP_SLP ( 1550): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_LCL failed.
07-19 21:18:20.337+0600 E/OSP_SLP ( 1550): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_LOC failed.
07-19 21:18:20.337+0600 E/OSP_SLP ( 1550): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_LOC_CTRL failed.
07-19 21:18:20.337+0600 E/OSP_SLP ( 1550): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_LOC_SVC failed.
07-19 21:18:20.337+0600 E/OSP_SLP ( 1550): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_MEDIA failed.
07-19 21:18:20.337+0600 E/OSP_SLP ( 1550): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_NET_BT failed.
07-19 21:18:20.337+0600 E/OSP_SLP ( 1550): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_NET_NFC failed.
07-19 21:18:20.337+0600 E/OSP_SLP ( 1550): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_SEC failed.
07-19 21:18:20.337+0600 E/OSP_SLP ( 1550): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_SEC_CERT failed.
07-19 21:18:20.337+0600 E/OSP_SLP ( 1550): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_SEC_CRYPTO failed.
07-19 21:18:20.337+0600 E/OSP_SLP ( 1550): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_SCL failed.
07-19 21:18:20.337+0600 E/OSP_SLP ( 1550): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_TEL failed.
07-19 21:18:20.337+0600 E/OSP_SLP ( 1550): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_TEXT failed.
07-19 21:18:20.337+0600 E/OSP_SLP ( 1550): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_UI failed.
07-19 21:18:20.337+0600 E/OSP_SLP ( 1550): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_UI_ANIM failed.
07-19 21:18:20.337+0600 E/OSP_SLP ( 1550): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_UI_CTRL failed.
07-19 21:18:20.337+0600 E/OSP_SLP ( 1550): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_UI_EFFECT failed.
07-19 21:18:20.337+0600 E/OSP_SLP ( 1550): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_UI_IME failed.
07-19 21:18:20.337+0600 E/OSP_SLP ( 1550): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_UI_SCENES failed.
07-19 21:18:20.337+0600 E/OSP_SLP ( 1550): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_UIX failed.
07-19 21:18:20.337+0600 E/OSP_SLP ( 1550): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_UIX_SPEECH failed.
07-19 21:18:20.337+0600 E/OSP_SLP ( 1550): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_WEB failed.
07-19 21:18:20.337+0600 E/OSP_SLP ( 1550): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_WEB_CTRL failed.
07-19 21:18:20.337+0600 E/OSP_SLP ( 1550): FBaseSys.cpp: __IsIniEntryEnabled(901) > [EXCEPTION]  finding PlatformInfologModules:NID_WEB_JSON failed.
07-19 21:18:20.337+0600 E/Tizen::Base::Runtime( 1550): (292) > [E_OBJ_NOT_FOUND] This is not OSP thread.
07-19 21:18:20.337+0600 E/Tizen::Base::Runtime( 1550): (207) > [E_INVALID_OPERATION] Event manager does not exist.
07-19 21:18:20.337+0600 I/Tizen::App( 1550): (85) > Create new instance
07-19 21:18:20.337+0600 I/Tizen::Io( 1550): (350) > [E_SUCCESS] exception occurred.
07-19 21:18:20.337+0600 I/Tizen::App( 1550): (116) > Loading 15 sections from /usr/etc/app-control-info.ini
07-19 21:18:20.337+0600 I/Tizen::App( 1550): (147) > Finished loading 15 tizen AppControl entries
07-19 21:18:20.347+0600 I/Tizen::Io( 1550): (350) > [E_SUCCESS] exception occurred.
07-19 21:18:20.347+0600 I/Tizen::App( 1550): (169) > Loading 34 sections from /usr/etc/app-control-alias.ini
07-19 21:18:20.347+0600 I/Tizen::App( 1550): (223) > (osp.appcontrol.CONTACT, tizen.contacts)
07-19 21:18:20.347+0600 I/Tizen::App( 1550): (223) > (osp.appcontrol.CONTACT, tizen.contacts)
07-19 21:18:20.347+0600 I/Tizen::App( 1550): (223) > (osp.appcontrol.CONTACT, tizen.contacts)
07-19 21:18:20.347+0600 I/Tizen::App( 1550): (223) > (osp.appcontrol.CONTACT, tizen.contacts)
07-19 21:18:20.347+0600 I/Tizen::App( 1550): (223) > (osp.appcontrol.CALENDAR, tizen.calendar)
07-19 21:18:20.347+0600 I/Tizen::App( 1550): (223) > (osp.appcontrol.CALENDAR, tizen.calendar)
07-19 21:18:20.347+0600 I/Tizen::App( 1550): (223) > (osp.appcontrol.TODO, tizen.todo)
07-19 21:18:20.347+0600 I/Tizen::App( 1550): (223) > (osp.appcontrol.BT, tizen.bluetooth)
07-19 21:18:20.347+0600 I/Tizen::App( 1550): (223) > (osp.appcontrol.DIAL, tizen.phone)
07-19 21:18:20.347+0600 I/Tizen::App( 1550): (223) > (osp.appcontrol.CALL, tizen.phone)
07-19 21:18:20.347+0600 I/Tizen::App( 1550): (223) > (osp.appcontrol.BROWSER, tizen.internet)
07-19 21:18:20.347+0600 I/Tizen::App( 1550): (223) > (osp.appcontrol.MEDIA, tizen.filemanager)
07-19 21:18:20.347+0600 I/Tizen::App( 1550): (223) > (osp.appcontrol.MESSAGE, tizen.messages)
07-19 21:18:20.347+0600 I/Tizen::App( 1550): (223) > (osp.appcontrol.EMAIL, tizen.email)
07-19 21:18:20.347+0600 I/Tizen::App( 1550): (223) > (osp.appcontrol.IMAGE, tizen.imageviewer)
07-19 21:18:20.347+0600 I/Tizen::App( 1550): (223) > (osp.appcontrol.VIDEO, tizen.videoplayer)
07-19 21:18:20.347+0600 I/Tizen::App( 1550): (223) > (osp.appcontrol.AUDIO, tizen.musicplayer)
07-19 21:18:20.347+0600 I/Tizen::App( 1550): (223) > (osp.appcontrol.CAMERA, tizen.camera)
07-19 21:18:20.347+0600 I/Tizen::App( 1550): (223) > (osp.appcontrol.SETTINGS, tizen.settings)
07-19 21:18:20.347+0600 I/Tizen::App( 1550): (223) > (osp.appcontrol.provider.contact, tizen.contacts)
07-19 21:18:20.347+0600 I/Tizen::App( 1550): (223) > (osp.appcontrol.provider.contact, tizen.contacts)
07-19 21:18:20.347+0600 I/Tizen::App( 1550): (223) > (osp.appcontrol.provider.contact, tizen.contacts)
07-19 21:18:20.347+0600 I/Tizen::App( 1550): (223) > (osp.appcontrol.provider.contact, tizen.contacts)
07-19 21:18:20.347+0600 I/Tizen::App( 1550): (223) > (osp.appcontrol.provider.calendar, tizen.calendar)
07-19 21:18:20.347+0600 I/Tizen::App( 1550): (223) > (osp.appcontrol.provider.calendar, tizen.calendar)
07-19 21:18:20.347+0600 I/Tizen::App( 1550): (223) > (osp.appcontrol.provider.todo, tizen.todo)
07-19 21:18:20.347+0600 I/Tizen::App( 1550): (223) > (osp.appcontrol.provider.bluetooth, tizen.bluetooth)
07-19 21:18:20.347+0600 I/Tizen::App( 1550): (223) > (osp.appcontrol.provider.call, tizen.phone)
07-19 21:18:20.347+0600 I/Tizen::App( 1550): (223) > (osp.appcontrol.provider.call, tizen.phone)
07-19 21:18:20.347+0600 I/Tizen::App( 1550): (223) > (osp.appcontrol.provider.browser, tizen.internet)
07-19 21:18:20.347+0600 I/Tizen::App( 1550): (223) > (osp.appcontrol.provider.media, tizen.filemanager)
07-19 21:18:20.347+0600 I/Tizen::App( 1550): (223) > (osp.appcontrol.provider.message, tizen.messages)
07-19 21:18:20.347+0600 I/Tizen::App( 1550): (223) > (osp.appcontrol.provider.email, tizen.email)
07-19 21:18:20.347+0600 I/Tizen::App( 1550): (223) > (osp.appcontrol.provider.image, tizen.imageviewer)
07-19 21:18:20.347+0600 I/Tizen::App( 1550): (223) > (osp.appcontrol.provider.imageeditor, tizen.imageeditor)
07-19 21:18:20.347+0600 I/Tizen::App( 1550): (223) > (osp.appcontrol.provider.video, tizen.videoplayer)
07-19 21:18:20.347+0600 I/Tizen::App( 1550): (223) > (osp.appcontrol.provider.audio, tizen.musicplayer)
07-19 21:18:20.347+0600 I/Tizen::App( 1550): (223) > (osp.appcontrol.provider.camera, tizen.camera)
07-19 21:18:20.347+0600 I/Tizen::App( 1550): (223) > (osp.appcontrol.provider.camera, tizen.camera)
07-19 21:18:20.347+0600 I/Tizen::App( 1550): (223) > (osp.appcontrol.provider.settings, tizen.settings)
07-19 21:18:20.347+0600 I/Tizen::App( 1550): (223) > (osp.appcontrol.provider.certificatemanager, tizen.certificatemanager)
07-19 21:18:20.347+0600 I/Tizen::App( 1550): (223) > (tizen.camera, tizen.camera)
07-19 21:18:20.347+0600 I/Tizen::App( 1550): (223) > (tizen.camera, tizen.camera)
07-19 21:18:20.357+0600 I/Tizen::App( 1550): (223) > (tizen.camera, tizen.camera)
07-19 21:18:20.357+0600 I/Tizen::App( 1550): (223) > (tizen.phone, tizen.call)
07-19 21:18:20.357+0600 I/Tizen::App( 1550): (223) > (tizen.certificatemanager, tizen.certificatemanager)
07-19 21:18:20.357+0600 I/Tizen::App( 1550): (232) > Finished loading 46 entries.
07-19 21:18:20.478+0600 I/Tizen::System( 1550): (524) > Request Key is http://tizen.org/feature/screen.dpi.
07-19 21:18:20.488+0600 I/Tizen::Io( 1550): (350) > [E_SUCCESS] exception occurred.
07-19 21:18:20.488+0600 I/Tizen::System( 1550): (524) > Request Key is http://tizen.org/feature/screen.width.
07-19 21:18:20.498+0600 I/Tizen::Io( 1550): (350) > [E_SUCCESS] exception occurred.
07-19 21:18:20.508+0600 I/Tizen::System( 1550): (524) > Request Key is http://tizen.org/feature/screen.height.
07-19 21:18:20.518+0600 I/Tizen::Io( 1550): (350) > [E_SUCCESS] exception occurred.
07-19 21:18:20.578+0600 I/Tizen::App( 1550): (181) > App root directory (/opt/usr/apps/EmbkcJFK7q/:12) open.
07-19 21:18:20.578+0600 I/Tizen::App( 1550): (195) > sd root directory (/opt/storage/sdcard/app2sd/EmbkcJFK7q:-1) open.
07-19 21:18:20.578+0600 I/Tizen::App( 1550): (237) > AppInfo [EmbkcJFK7q.MMSBootService][EmbkcJFK7q.MMSBootService][220].
07-19 21:18:20.578+0600 I/Tizen::App | LAUNCH( 1550): (165) > [MMSBootService:<Initialize Application>:start]
07-19 21:18:20.578+0600 E/Tizen::System( 1550): (215) > [E_SYSTEM] It failed to set power off
07-19 21:18:20.578+0600 I/Tizen::App( 1550): (205) > Maintain message box compatiblity between 2.3 and 2.4
07-19 21:18:21.048+0600 I/Tizen::App( 1550): (228) > Platform creation event.
07-19 21:18:21.048+0600 I/Tizen::App( 1550): (83) > Create new instance
07-19 21:18:21.048+0600 I/Tizen::App( 1550): (55) > 
07-19 21:18:21.068+0600 I/Tizen::App | LAUNCH( 1550): (257) > [MMSBootService:<OnAppInitializing>:start]
07-19 21:18:21.078+0600 I/Tizen::App( 1550): (416) > appName = [MMSBootService]
07-19 21:18:21.078+0600 I/Tizen::App( 1550): (509) > exe = [/opt/apps/EmbkcJFK7q/bin/MMSBootService], displayName = [MMSBootService], mainApp = [0], menuIconVisible = [1], serviceApp = [1]
07-19 21:18:21.078+0600 I/Tizen::App( 1550): (2343) > info file is not existed. [/opt/usr/apps/EmbkcJFK7q/info/EmbkcJFK7q.MMSBootService.info]
07-19 21:18:21.078+0600 I/Tizen::App( 1550): (2343) > info file is not existed. [/opt/usr/apps/EmbkcJFK7q/info/EmbkcJFK7q.MMSBootService.info]
07-19 21:18:21.078+0600 I/Tizen::App( 1550): (54) > [E_SUCCESS] 1 entry registered.
07-19 21:18:21.078+0600 I/Tizen::App | LAUNCH( 1550): (268) > [MMSBootService:<OnAppInitializing>:done]
07-19 21:18:21.078+0600 I/Tizen::App | LAUNCH( 1550): (270) > [MMSBootService:<RegisterApplication>:start]
07-19 21:18:21.078+0600 I/Tizen::App( 1550): (138) > 
07-19 21:18:21.078+0600 I/Tizen::App | LAUNCH( 1550): (277) > [MMSBootService:<RegisterApplication>:done]
07-19 21:18:21.088+0600 I/Tizen::App( 1305): (209) > app(EmbkcJFK7q.MMSBootService), clientId(1550)
07-19 21:18:21.088+0600 I/Tizen::App( 1305): (186) > _AppManagerStub::RegisterApplication app(EmbkcJFK7q.MMSBootService), pid(1550)
07-19 21:18:21.088+0600 I/Tizen::App( 1305): (166) > Sending event for EmbkcJFK7q.MMSBootService(1550).
07-19 21:18:21.088+0600 I/Tizen::App( 1550): (2343) > info file is not existed. [/opt/usr/apps/EmbkcJFK7q/info/EmbkcJFK7q.MMSBootService.info]
07-19 21:18:21.088+0600 I/Tizen::App( 1550): (90) > 
07-19 21:18:21.088+0600 I/Tizen::App( 1550): (107) > Current request ID : 0.
07-19 21:18:21.088+0600 I/Tizen::App( 1550): (542) > Request 0x1 received for 0x0.
07-19 21:18:21.088+0600 I/Tizen::App | LAUNCH( 1550): (370) > [MMSBootService:<RequestHandler and OnAppInitialized>:start]
07-19 21:18:21.088+0600 I/Tizen::App( 1550): (572) > Handling AppControl request
07-19 21:18:21.088+0600 I/Tizen::App( 1550): (720) > No AppControl provider event listener set for request 0.
07-19 21:18:21.088+0600 I/Tizen::App( 1550): (376) > [E_INIT_FAILED] The Initialization of your application failed.
07-19 21:18:21.088+0600 I/Tizen::App( 1550): (405) > Termination event 0x2 state
07-19 21:18:21.088+0600 I/Tizen::App( 1550): (114) > Termination event 0x2 state
07-19 21:18:21.098+0600 I/Tizen::App( 1305): (149) > app = [EmbkcJFK7q.MMSBootService], package = [EmbkcJFK7q]
07-19 21:18:21.098+0600 I/Tizen::App( 1305): (241) > Set OOM : result is E_SUCCESS
07-19 21:18:21.098+0600 I/Tizen::App( 1305): (243) > The application (app(EmbkcJFK7q.MMSBootService), pid:1550) Registered.
07-19 21:18:21.098+0600 I/Tizen::App( 1305): (453) > registered app count : 3
07-19 21:18:21.098+0600 I/Tizen::App( 1305): (460) > aospd00043.osp-app-service(pid:1305)
07-19 21:18:21.098+0600 I/Tizen::App( 1305): (460) > EmbkcJFK7q.MMSBootService(pid:1550)
07-19 21:18:21.098+0600 I/Tizen::App( 1305): (740) > Enter. AppId(EmbkcJFK7q.MMSBootService)
07-19 21:18:21.098+0600 I/Tizen::App( 1305): (357) > Enter::app-service::InitializeServices
07-19 21:18:21.098+0600 I/Tizen::App( 1305): (51) > Enter
07-19 21:18:21.098+0600 I/Tizen::App( 1305): (52) > Exit
07-19 21:18:21.098+0600 I/Tizen::App( 1305): (73) > Enter.
07-19 21:18:21.098+0600 I/Tizen::App( 1305): (75) > Enter
07-19 21:18:21.098+0600 I/Tizen::App( 1305): (76) > Exit
07-19 21:18:21.098+0600 I/Tizen::App( 1305): (92) > Enter.
07-19 21:18:21.098+0600 I/Tizen::App( 1305): (114) > Enter.
07-19 21:18:21.108+0600 I/Tizen::Io( 1305): (350) > [E_SUCCESS] exception occurred.
07-19 21:18:21.108+0600 I/Tizen::App( 1305): (164) > Exit.
07-19 21:18:21.108+0600 I/Tizen::App( 1305): (222) > Enter.
07-19 21:18:21.108+0600 I/Tizen::App( 1305): (244) > Database available and trying to open to read conditions.
07-19 21:18:21.108+0600 E/Tizen::App( 1305): (648) > [E_SUCCESS] No record exists in database.
07-19 21:18:21.108+0600 I/Tizen::App( 1305): (270) > Exit.
07-19 21:18:21.108+0600 I/Tizen::App( 1305): (107) > Exit.
07-19 21:18:21.108+0600 I/Tizen::Io( 1305): (202) > Unlink a socket has failed.. but it is not a problem.
07-19 21:18:21.108+0600 I/Tizen::App( 1305): (327) > 
07-19 21:18:21.108+0600 I/Tizen::App( 1305): (84) > Exit.
07-19 21:18:21.108+0600 I/Tizen::App( 1305): (53) > _PackageManagerStub - Enter
07-19 21:18:21.108+0600 I/Tizen::App( 1305): (70) > _PackageManagerStub - Construct.
07-19 21:18:21.108+0600 I/Tizen::App( 1305): (84) > _PackageManagerStub - StartIpcServer
07-19 21:18:21.108+0600 I/Tizen::Io( 1305): (202) > Unlink a socket has failed.. but it is not a problem.
07-19 21:18:21.108+0600 I/Tizen::App( 1305): (165) > _PackageManagerStub::OnIpcServerStarted 
07-19 21:18:21.108+0600 I/Tizen::Io( 1305): (52) > _MmcStorageManagerStub - Enter
07-19 21:18:21.108+0600 I/Tizen::Io( 1305): (158) > MMC callback is successfully registered.
07-19 21:18:21.108+0600 I/Tizen::Io( 1305): (202) > Unlink a socket has failed.. but it is not a problem.
07-19 21:18:21.108+0600 I/Tizen::Io( 1305): (216) > _MmcStorageManagerStub::OnIpcServerStarted 
07-19 21:18:21.108+0600 I/Tizen::App( 1305): (50) > _LockManagerStub - Enter
07-19 21:18:21.108+0600 I/Tizen::Io( 1305): (202) > Unlink a socket has failed.. but it is not a problem.
07-19 21:18:21.108+0600 I/Tizen::App( 1305): (135) > _LockManagerStub::OnIpcServerStarted 
07-19 21:18:21.108+0600 I/Tizen::App( 1305): (393) > Exit.
07-19 21:18:21.108+0600 I/Tizen::App( 1305): (423) > Enter::app-service::LaunchSystemServices
07-19 21:18:21.118+0600 I/Tizen::Io( 1305): (350) > [E_SUCCESS] exception occurred.
07-19 21:18:21.118+0600 I/Tizen::App( 1305): (484) > Exit.
07-19 21:18:21.118+0600 I/Tizen::App( 1305): (230) > Add PackageInstallationEventListener = [0xb74fc954]
07-19 21:18:21.118+0600 I/Tizen::App( 1305): (568) > Enter::RegisterPreloadedAppCondition
07-19 21:18:21.118+0600 I/Tizen::App( 1305): (1060) > Key[http://tizen.org/package/app/launchcondition], Value[1]
07-19 21:18:21.128+0600 I/Tizen::App( 1305): (1192) > pList's count is 0.
07-19 21:18:21.128+0600 I/Tizen::App( 1305): (1211) > GetPackageAppInfoListN(packageAppFilterMap) is null.
07-19 21:18:21.128+0600 I/Tizen::App( 1305): (615) > Exit.
07-19 21:18:21.128+0600 I/Tizen::App( 1305): (781) > Exit. AppId(EmbkcJFK7q.MMSBootService)
07-19 21:18:21.128+0600 E/osp-app-service( 1305): result Tizen::Base::Collection::__LinkedListEnumeratorT<Type>::MoveNext() [with Type = Tizen::Base::Runtime::_Event::_ListenerInfo; result = long unsigned int](1441) > [E_INVALID_OPERATION] The source collection is modified after the creation of this enumerator.
07-19 21:18:21.128+0600 I/Tizen::App( 1550): (152) > 
07-19 21:18:21.128+0600 I/Tizen::App( 1305): (209) > app(EmbkcJFK7q.MMSBootService), clientId(1550)
07-19 21:18:21.128+0600 I/Tizen::App( 1305): (198) > _AppManagerStub::UnregisterApplication(pid:1550)
07-19 21:18:21.128+0600 I/Tizen::App( 1305): (255) > (app(EmbkcJFK7q.MMSBootService), pid:1550) Unregistered.
07-19 21:18:21.128+0600 I/Tizen::App( 1305): (288) > Enter
07-19 21:18:21.138+0600 I/Tizen::App( 1305): (416) > appName = [MMSBootService]
07-19 21:18:21.148+0600 I/Tizen::App( 1305): (509) > exe = [/opt/apps/EmbkcJFK7q/bin/MMSBootService], displayName = [MMSBootService], mainApp = [0], menuIconVisible = [1], serviceApp = [1]
07-19 21:18:21.148+0600 I/Tizen::App( 1305): (2343) > info file is not existed. [/opt/usr/apps/EmbkcJFK7q/info/EmbkcJFK7q.MMSBootService.info]
07-19 21:18:21.148+0600 I/Tizen::App( 1305): (325) > Exit
07-19 21:18:21.148+0600 I/Tizen::App( 1305): (266) > app info is removed (EmbkcJFK7q.MMSBootService, 1550)
07-19 21:18:21.148+0600 I/Tizen::App( 1305): (453) > registered app count : 2
07-19 21:18:21.148+0600 I/Tizen::App( 1305): (460) > aospd00043.osp-app-service(pid:1305)
07-19 21:18:21.148+0600 I/Tizen::App( 1550): (101) > 
07-19 21:18:21.158+0600 I/Tizen::Io( 1305): (490) > G_IO_STATUS_EOF, the connection is closed.
07-19 21:18:21.158+0600 I/Tizen::Io( 1305): (516) > All connections of client(1550) are closed normally by the client.
07-19 21:18:21.168+0600 I/Tizen::App( 1305): (243) > App[EmbkcJFK7q.MMSBootService] pid[1550] terminate event is forwarded
07-19 21:18:21.168+0600 I/Tizen::System( 1305): (256) > osp.accessorymanager.service provider is found.
07-19 21:18:21.168+0600 I/Tizen::System( 1305): (196) > Accessory Owner is removed [EmbkcJFK7q.MMSBootService, 1550, ]
07-19 21:18:21.168+0600 I/Tizen::System( 1305): (256) > osp.system.service provider is found.
07-19 21:18:21.168+0600 I/Tizen::App( 1305): (506) > TerminatedApp(EmbkcJFK7q.MMSBootService)
07-19 21:18:21.168+0600 I/Tizen::App( 1305): (512) > Not registered pid(1550)
07-19 21:18:21.168+0600 I/Tizen::System( 1305): (246) > Terminated app [EmbkcJFK7q.MMSBootService]
07-19 21:18:21.168+0600 E/Tizen::Io( 1305): (278) > [E_INVALID_ARG] entryName.GetLength() <= 0
07-19 21:18:21.178+0600 I/Tizen::System( 1305): (157) > change brightness system value.
07-19 21:18:21.178+0600 I/Tizen::App( 1305): (782) > Finished invoking application event listener for EmbkcJFK7q.MMSBootService, 1550.
07-19 21:18:22.930+0600
