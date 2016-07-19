S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPD6
Build-Date: 2016.04.28 20:23:28

Crash Information
Process Name: avoidrickshaw
PID: 2680
Date: 2016-07-19 21:22:38+0600
Executable File Path: /opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 2680, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000a78
r2   = 0x00000006, r3   = 0xb445a4c0
r4   = 0x00000002, r5   = 0xb445a000
r6   = 0xb675f09c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0x00000060
r10  = 0x00000000, fp   = 0xb8559118
ip   = 0x00000000, sp   = 0xbebb1df4
lr   = 0xb6655f18, pc   = 0xb6654b84
cpsr = 0x200f0010

Memory Information
MemTotal:   730440 KB
MemFree:    131632 KB
Buffers:     29348 KB
Cached:     255624 KB
VmPeak:     123264 KB
VmSize:     123260 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22984 KB
VmRSS:       22984 KB
VmData:      49356 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36324 KB
VmPTE:          84 KB
VmSwap:          0 KB

Threads Information
Threads: 6
PID = 2680 TID = 2680
2680 2682 2825 2826 2834 2866 

Maps Information
afb01000 b0300000 rw-p [stack:2866]
b0adf000 b0af0000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b0b01000 b1300000 rw-p [stack:2834]
b141b000 b1420000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b144a000 b1452000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.49
b1462000 b1464000 r-xp /usr/lib/liblbs-agps.so.0.1.0
b1474000 b1482000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
b1499000 b149b000 r-xp /usr/lib/location/module/libwps.so.0.6.8_9
b14ab000 b14ae000 r-xp /usr/lib/location/module/libgps.so.0.6.8_9
b14bf000 b1cbe000 rw-p [stack:2826]
b1cbf000 b24be000 rw-p [stack:2825]
b2501000 b2509000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b251a000 b251b000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b252b000 b253f000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2553000 b2554000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2564000 b2567000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2578000 b2579000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2589000 b258b000 r-xp /usr/lib/libxcb-present.so.0.0.0
b259b000 b259d000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b25ad000 b25bd000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b25cd000 b25d9000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b2829000 b282b000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b283b000 b2841000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b2851000 b2865000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b2875000 b288f000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b289f000 b28a5000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
b28b5000 b28bc000 r-xp /usr/lib/libeventsystem.so.0.0.1
b28cc000 b28ef000 r-xp /usr/lib/libSLP-location-product.so.0.9.0
b2900000 b2917000 r-xp /usr/lib/libSLP-location.so.0.11.5_5
b2927000 b292e000 r-xp /usr/lib/libefl-extension.so.0.1.0
b293f000 b2947000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b2957000 b295b000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
b296c000 b297b000 r-xp /usr/lib/libcapi-location-manager.so.0.6.1_3
b298d000 b2993000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b29a3000 b29a8000 r-xp /opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw
b2ac9000 b2bac000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2be3000 b2c0b000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2c1d000 b341c000 rw-p [stack:2682]
b341c000 b341e000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b342e000 b3438000 r-xp /lib/libnss_files-2.20-2014.11.so
b3449000 b3452000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3463000 b3474000 r-xp /lib/libnsl-2.20-2014.11.so
b3487000 b348d000 r-xp /lib/libnss_compat-2.20-2014.11.so
b349e000 b349f000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b34c7000 b34ce000 r-xp /usr/lib/libminizip.so.1.0.0
b34de000 b34e3000 r-xp /usr/lib/libstorage.so.0.1
b34f3000 b3548000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b355e000 b3572000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b3582000 b35c6000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b35d6000 b35de000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b35ee000 b361e000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3631000 b36ea000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b36fe000 b3752000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3763000 b377e000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b378e000 b384f000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3862000 b3874000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3884000 b3888000 r-xp /usr/lib/libogg.so.0.7.1
b3898000 b38ba000 r-xp /usr/lib/libvorbis.so.0.4.3
b38ca000 b39ae000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b39ca000 b39d7000 r-xp /usr/lib/libmdm-common.so.1.0.98
b39e8000 b3a2b000 r-xp /usr/lib/libsndfile.so.1.0.25
b3a40000 b3a87000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3a98000 b3a9e000 r-xp /usr/lib/libjson-c.so.2.0.1
b3aaf000 b3ab6000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3ac6000 b3b06000 r-xp /usr/lib/libmdm.so.1.2.10
b3b16000 b3b1e000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3b2d000 b3b3d000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3b5e000 b3bbe000 r-xp /usr/lib/libasound.so.2.0.0
b3bd0000 b3c06000 r-xp /usr/lib/libpulse.so.0.16.2
b3c17000 b3c1a000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3c2a000 b3c2d000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3c3d000 b3c42000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3c52000 b3c53000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3c63000 b3c6e000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3c82000 b3c89000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3c99000 b3c9f000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3caf000 b3cb4000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3cc4000 b3cdf000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3cef000 b3cf6000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3d06000 b3d09000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3d1a000 b3d48000 r-xp /usr/lib/libidn.so.11.5.44
b3d58000 b3d6e000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3d7f000 b3d89000 r-xp /usr/lib/libcares.so.2.1.0
b3d99000 b3da3000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3db3000 b3db5000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3dc5000 b3dc6000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3dd6000 b3dda000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3deb000 b3e13000 r-xp /usr/lib/libui-extension.so.0.1.0
b3e24000 b3e4d000 r-xp /usr/lib/libturbojpeg.so
b3e6d000 b3e73000 r-xp /usr/lib/libgif.so.4.1.6
b3e83000 b3ec9000 r-xp /usr/lib/libcurl.so.4.3.0
b3eda000 b3efb000 r-xp /usr/lib/libexif.so.12.3.3
b3f16000 b3f2b000 r-xp /usr/lib/libtts.so
b3f3c000 b3f44000 r-xp /usr/lib/libfeedback.so.0.1.4
b3f54000 b4014000 r-xp /usr/lib/libdali-core.so.0.0.0
b401f000 b4112000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b4132000 b420c000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b4223000 b4225000 r-xp /usr/lib/libboost_system.so.1.51.0
b4235000 b423b000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b424b000 b426e000 r-xp /usr/lib/libboost_thread.so.1.51.0
b427f000 b4281000 r-xp /usr/lib/libappsvc.so.0.1.0
b4291000 b4293000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b42a4000 b42a9000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b42c0000 b42c2000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b42d2000 b42d9000 r-xp /usr/lib/libsensord-share.so
b42e9000 b4301000 r-xp /usr/lib/libsensor.so.1.1.0
b4312000 b4315000 r-xp /usr/lib/libXv.so.1.0.0
b4325000 b432a000 r-xp /usr/lib/libutilX.so.1.1.0
b433a000 b433f000 r-xp /usr/lib/libappcore-common.so.1.1
b434f000 b4356000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b4369000 b436d000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b437e000 b4448000 r-xp /usr/lib/libCOREGL.so.4.0
b445f000 b4462000 r-xp /usr/lib/libuuid.so.1.3.0
b4473000 b448a000 r-xp /usr/lib/libblkid.so.1.1.0
b449b000 b449d000 r-xp /usr/lib/libXau.so.6.0.0
b44ad000 b44b0000 r-xp /usr/lib/libEGL.so.1.4
b44b8000 b44be000 r-xp /usr/lib/libxcb-render.so.0.0.0
b44ce000 b44d0000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b44e1000 b44ef000 r-xp /usr/lib/libGLESv2.so.2.0
b44f8000 b455a000 r-xp /usr/lib/libpixman-1.so.0.28.2
b456f000 b4587000 r-xp /usr/lib/libmount.so.1.1.0
b4598000 b45ac000 r-xp /usr/lib/libxcb.so.1.1.0
b45bd000 b45c4000 r-xp /lib/libcrypt-2.20-2014.11.so
b45fc000 b460d000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b461e000 b4620000 r-xp /usr/lib/libiri.so
b4630000 b463b000 r-xp /usr/lib/libgpg-error.so.0.15.0
b464c000 b4661000 r-xp /lib/libexpat.so.1.5.2
b4673000 b4731000 r-xp /usr/lib/libcairo.so.2.11200.14
b4744000 b474c000 r-xp /usr/lib/libdrm.so.2.4.0
b475c000 b475f000 r-xp /usr/lib/libdri2.so.0.0.0
b4770000 b47be000 r-xp /usr/lib/libssl.so.1.0.0
b47d3000 b47df000 r-xp /usr/lib/libeeze.so.1.13.0
b47ef000 b47f8000 r-xp /usr/lib/libethumb.so.1.13.0
b4808000 b480b000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b481b000 b49d2000 r-xp /usr/lib/libcrypto.so.1.0.0
b5629000 b5632000 r-xp /usr/lib/libXi.so.6.1.0
b5642000 b5644000 r-xp /usr/lib/libXgesture.so.7.0.0
b5654000 b5658000 r-xp /usr/lib/libXtst.so.6.1.0
b5668000 b566e000 r-xp /usr/lib/libXrender.so.1.3.0
b567e000 b5684000 r-xp /usr/lib/libXrandr.so.2.2.0
b5695000 b5697000 r-xp /usr/lib/libXinerama.so.1.0.0
b56a7000 b56aa000 r-xp /usr/lib/libXfixes.so.3.1.0
b56ba000 b56c5000 r-xp /usr/lib/libXext.so.6.4.0
b56d5000 b56d7000 r-xp /usr/lib/libXdamage.so.1.1.0
b56e7000 b56e9000 r-xp /usr/lib/libXcomposite.so.1.0.0
b56fa000 b57dc000 r-xp /usr/lib/libX11.so.6.3.0
b57ef000 b57f6000 r-xp /usr/lib/libXcursor.so.1.0.2
b5806000 b581e000 r-xp /usr/lib/libudev.so.1.6.0
b5820000 b5823000 r-xp /lib/libattr.so.1.1.0
b5833000 b5853000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5855000 b585a000 r-xp /usr/lib/libffi.so.6.0.2
b586a000 b5882000 r-xp /lib/libz.so.1.2.8
b5892000 b5894000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58a4000 b5979000 r-xp /usr/lib/libxml2.so.2.9.2
b598e000 b5a29000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a45000 b5a48000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a58000 b5a71000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a82000 b5a93000 r-xp /lib/libresolv-2.20-2014.11.so
b5aa7000 b5b21000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b36000 b5b38000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b48000 b5b4f000 r-xp /usr/lib/libembryo.so.1.13.0
b5b5f000 b5b77000 r-xp /usr/lib/libpng12.so.0.50.0
b5b88000 b5bab000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bcc000 b5be0000 r-xp /usr/lib/libector.so.1.13.0
b5bf1000 b5c09000 r-xp /usr/lib/liblua-5.1.so
b5c1a000 b5c71000 r-xp /usr/lib/libfreetype.so.6.11.3
b5c85000 b5cad000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5cbe000 b5cd1000 r-xp /usr/lib/libfribidi.so.0.3.1
b5ce2000 b5d19000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d2a000 b5d38000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d48000 b5d50000 r-xp /usr/lib/libtbm.so.1.0.0
b5d60000 b5d6d000 r-xp /usr/lib/libeio.so.1.13.0
b5d7d000 b5d7f000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5d8f000 b5d94000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5da4000 b5dbb000 r-xp /usr/lib/libefreet.so.1.13.0
b5dcd000 b5ded000 r-xp /usr/lib/libeldbus.so.1.13.0
b5dfd000 b5e1d000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e1f000 b5e25000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e35000 b5e46000 r-xp /usr/lib/libemotion.so.1.13.0
b5e57000 b5e5e000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e6e000 b5e7d000 r-xp /usr/lib/libeo.so.1.13.0
b5e8e000 b5ea0000 r-xp /usr/lib/libecore_input.so.1.13.0
b5eb1000 b5eb6000 r-xp /usr/lib/libecore_file.so.1.13.0
b5ec6000 b5edf000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5eef000 b5f0c000 r-xp /usr/lib/libeet.so.1.13.0
b5f25000 b5f6d000 r-xp /usr/lib/libeina.so.1.13.0
b5f7e000 b5f8e000 r-xp /usr/lib/libefl.so.1.13.0
b5f9f000 b6084000 r-xp /usr/lib/libicuuc.so.51.1
b60a1000 b61e1000 r-xp /usr/lib/libicui18n.so.51.1
b61f8000 b6230000 r-xp /usr/lib/libecore_x.so.1.13.0
b6242000 b6245000 r-xp /lib/libcap.so.2.21
b6255000 b627e000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b628f000 b6296000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62a8000 b62df000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b62f0000 b63db000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b63ee000 b6467000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6479000 b647e000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b648e000 b6498000 r-xp /usr/lib/libvconf.so.0.2.45
b64a8000 b64aa000 r-xp /usr/lib/libvasum.so.0.3.1
b64ba000 b64bc000 r-xp /usr/lib/libttrace.so.1.1
b64cc000 b64cf000 r-xp /usr/lib/libiniparser.so.0
b64df000 b6505000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6515000 b651a000 r-xp /usr/lib/libxdgmime.so.1.1.0
b652b000 b6542000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6553000 b65be000 r-xp /lib/libm-2.20-2014.11.so
b65cf000 b65d5000 r-xp /lib/librt-2.20-2014.11.so
b65e6000 b65f3000 r-xp /usr/lib/libunwind.so.8.0.1
b6629000 b674d000 r-xp /lib/libc-2.20-2014.11.so
b6762000 b677b000 r-xp /lib/libgcc_s-4.9.so.1
b678b000 b686d000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b687e000 b68a8000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68b9000 b68f5000 r-xp /usr/lib/libsystemd.so.0.4.0
b68f7000 b6979000 r-xp /usr/lib/libedje.so.1.13.0
b698c000 b69aa000 r-xp /usr/lib/libecore.so.1.13.0
b69ca000 b6b51000 r-xp /usr/lib/libevas.so.1.13.0
b6b86000 b6b9a000 r-xp /lib/libpthread-2.20-2014.11.so
b6bae000 b6de3000 r-xp /usr/lib/libelementary.so.1.13.0
b6e11000 b6e15000 r-xp /usr/lib/libsmack.so.1.0.0
b6e25000 b6e2c000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e3c000 b6e3e000 r-xp /usr/lib/libdlog.so.0.0.0
b6e4e000 b6e51000 r-xp /usr/lib/libbundle.so.0.1.22
b6e61000 b6e63000 r-xp /lib/libdl-2.20-2014.11.so
b6e74000 b6e8c000 r-xp /usr/lib/libaul.so.0.1.0
b6ea0000 b6ea5000 r-xp /usr/lib/libappcore-efl.so.1.1
b6eb6000 b6ec3000 r-xp /usr/lib/liblptcp.so
b6ed5000 b6ed9000 r-xp /usr/lib/libsys-assert.so
b6eea000 b6f0a000 r-xp /lib/ld-2.20-2014.11.so
b6f1b000 b6f20000 r-xp /usr/bin/launchpad-loader
b82b8000 b8584000 rw-p [heap]
beb92000 bebb3000 rw-p [stack]
b82b8000 b8584000 rw-p [heap]
beb92000 bebb3000 rw-p [stack]
End of Maps Information

Callstack Information (PID:2680)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb6654b84) [/lib/libc.so.6] + 0x2bb84
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
