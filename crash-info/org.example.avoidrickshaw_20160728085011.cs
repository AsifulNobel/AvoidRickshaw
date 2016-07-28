S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPD6
Build-Date: 2016.04.28 20:23:28

Crash Information
Process Name: avoidrickshaw
PID: 13625
Date: 2016-07-28 08:50:11+0600
Executable File Path: /opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 13625, uid 5000)

Register Information
r0   = 0x80054ea9, r1   = 0x00000000
r2   = 0xb42dd000, r3   = 0xb42dd010
r4   = 0xb29c80a0, r5   = 0xb7e79d98
r6   = 0xb7e88420, r7   = 0xbe865208
r8   = 0x800168b5, r9   = 0xb5eae708
r10  = 0xb7e87410, fp   = 0x00000000
ip   = 0xb5f9e120, sp   = 0xbe8651b0
lr   = 0xb5f62bd9, pc   = 0xb29c7070
cpsr = 0x800e0030

Memory Information
MemTotal:   730440 KB
MemFree:     47188 KB
Buffers:     45232 KB
Cached:     275976 KB
VmPeak:     107636 KB
VmSize:     107632 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24684 KB
VmRSS:       24684 KB
VmData:      33672 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36252 KB
VmPTE:          82 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 13625 TID = 13625
13625 13629 15530 15817 

Maps Information
b0b42000 b1341000 rw-p [stack:15817]
b1a8e000 b1a9f000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b1aaf000 b1ab4000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b1c8c000 b248b000 rw-p [stack:15530]
b2507000 b250f000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2520000 b2521000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b2531000 b2545000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2559000 b255a000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b256a000 b256d000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b257e000 b257f000 r-xp /usr/lib/libxshmfence.so.1.0.0
b258f000 b2591000 r-xp /usr/lib/libxcb-present.so.0.0.0
b25a1000 b25a3000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b25b3000 b25c3000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b25d3000 b25df000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b282f000 b2831000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b2841000 b2847000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b2857000 b286b000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b287b000 b2895000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b28a5000 b28ab000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
b28bb000 b28c2000 r-xp /usr/lib/libeventsystem.so.0.0.1
b28d2000 b28f5000 r-xp /usr/lib/libSLP-location-product.so.0.9.0
b2906000 b291d000 r-xp /usr/lib/libSLP-location.so.0.11.5_5
b292d000 b2934000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2945000 b294d000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b295d000 b2961000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
b2972000 b2981000 r-xp /usr/lib/libcapi-location-manager.so.0.6.1_3
b2991000 b2998000 r-xp /usr/lib/libcapi-appfw-preference.so.0.3.1.0
b29aa000 b29b0000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b29c0000 b29c9000 r-xp /opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw
b2aea000 b2bcd000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2c04000 b2c2c000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2c3e000 b343d000 rw-p [stack:13629]
b343d000 b343f000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b344f000 b3459000 r-xp /lib/libnss_files-2.20-2014.11.so
b346a000 b3473000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3484000 b3495000 r-xp /lib/libnsl-2.20-2014.11.so
b34a8000 b34ae000 r-xp /lib/libnss_compat-2.20-2014.11.so
b34bf000 b34c0000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b34e8000 b34ef000 r-xp /usr/lib/libminizip.so.1.0.0
b34ff000 b3504000 r-xp /usr/lib/libstorage.so.0.1
b3514000 b3569000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b357f000 b3593000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b35a3000 b35e7000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b35f7000 b35ff000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b360f000 b363f000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3652000 b370b000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b371f000 b3773000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3784000 b379f000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b37af000 b3870000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3883000 b3895000 r-xp /usr/lib/libefl-assist.so.0.1.0
b38a5000 b38a9000 r-xp /usr/lib/libogg.so.0.7.1
b38b9000 b38db000 r-xp /usr/lib/libvorbis.so.0.4.3
b38eb000 b39cf000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b39eb000 b39f8000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3a09000 b3a4c000 r-xp /usr/lib/libsndfile.so.1.0.25
b3a61000 b3aa8000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3ab9000 b3abf000 r-xp /usr/lib/libjson-c.so.2.0.1
b3ad0000 b3ad7000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3ae7000 b3b27000 r-xp /usr/lib/libmdm.so.1.2.10
b3b37000 b3b3f000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3b4e000 b3b5e000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3b7f000 b3bdf000 r-xp /usr/lib/libasound.so.2.0.0
b3bf1000 b3c27000 r-xp /usr/lib/libpulse.so.0.16.2
b3c38000 b3c3b000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3c4b000 b3c4e000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3c5e000 b3c63000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3c73000 b3c74000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3c84000 b3c8f000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3ca3000 b3caa000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3cba000 b3cc0000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3cd0000 b3cd5000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3ce5000 b3d00000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3d10000 b3d17000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3d27000 b3d2a000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3d3b000 b3d69000 r-xp /usr/lib/libidn.so.11.5.44
b3d79000 b3d8f000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3da0000 b3daa000 r-xp /usr/lib/libcares.so.2.1.0
b3dba000 b3dc4000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3dd4000 b3dd6000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3de6000 b3de7000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3df7000 b3dfb000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3e0c000 b3e34000 r-xp /usr/lib/libui-extension.so.0.1.0
b3e45000 b3e6e000 r-xp /usr/lib/libturbojpeg.so
b3e8e000 b3e94000 r-xp /usr/lib/libgif.so.4.1.6
b3ea4000 b3eea000 r-xp /usr/lib/libcurl.so.4.3.0
b3efb000 b3f1c000 r-xp /usr/lib/libexif.so.12.3.3
b3f37000 b3f4c000 r-xp /usr/lib/libtts.so
b3f5d000 b3f65000 r-xp /usr/lib/libfeedback.so.0.1.4
b3f75000 b4035000 r-xp /usr/lib/libdali-core.so.0.0.0
b4040000 b4133000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b4153000 b422d000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b4244000 b4246000 r-xp /usr/lib/libboost_system.so.1.51.0
b4256000 b425c000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b426c000 b428f000 r-xp /usr/lib/libboost_thread.so.1.51.0
b42a0000 b42a2000 r-xp /usr/lib/libappsvc.so.0.1.0
b42b2000 b42b4000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b42c5000 b42ca000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b42e1000 b42e3000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b42f3000 b42fa000 r-xp /usr/lib/libsensord-share.so
b430a000 b4322000 r-xp /usr/lib/libsensor.so.1.1.0
b4333000 b4336000 r-xp /usr/lib/libXv.so.1.0.0
b4346000 b434b000 r-xp /usr/lib/libutilX.so.1.1.0
b435b000 b4360000 r-xp /usr/lib/libappcore-common.so.1.1
b4370000 b4377000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b438a000 b438e000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b439f000 b4469000 r-xp /usr/lib/libCOREGL.so.4.0
b4480000 b4483000 r-xp /usr/lib/libuuid.so.1.3.0
b4494000 b44ab000 r-xp /usr/lib/libblkid.so.1.1.0
b44bc000 b44be000 r-xp /usr/lib/libXau.so.6.0.0
b44ce000 b44d1000 r-xp /usr/lib/libEGL.so.1.4
b44d9000 b44df000 r-xp /usr/lib/libxcb-render.so.0.0.0
b44ef000 b44f1000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4502000 b4510000 r-xp /usr/lib/libGLESv2.so.2.0
b4519000 b457b000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4590000 b45a8000 r-xp /usr/lib/libmount.so.1.1.0
b45b9000 b45cd000 r-xp /usr/lib/libxcb.so.1.1.0
b45de000 b45e5000 r-xp /lib/libcrypt-2.20-2014.11.so
b461d000 b462e000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b463f000 b4641000 r-xp /usr/lib/libiri.so
b4651000 b465c000 r-xp /usr/lib/libgpg-error.so.0.15.0
b466d000 b4682000 r-xp /lib/libexpat.so.1.5.2
b4694000 b4752000 r-xp /usr/lib/libcairo.so.2.11200.14
b4765000 b476d000 r-xp /usr/lib/libdrm.so.2.4.0
b477d000 b4780000 r-xp /usr/lib/libdri2.so.0.0.0
b4791000 b47df000 r-xp /usr/lib/libssl.so.1.0.0
b47f4000 b4800000 r-xp /usr/lib/libeeze.so.1.13.0
b4810000 b4819000 r-xp /usr/lib/libethumb.so.1.13.0
b4829000 b482c000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b483c000 b49f3000 r-xp /usr/lib/libcrypto.so.1.0.0
b564a000 b5653000 r-xp /usr/lib/libXi.so.6.1.0
b5663000 b5665000 r-xp /usr/lib/libXgesture.so.7.0.0
b5675000 b5679000 r-xp /usr/lib/libXtst.so.6.1.0
b5689000 b568f000 r-xp /usr/lib/libXrender.so.1.3.0
b569f000 b56a5000 r-xp /usr/lib/libXrandr.so.2.2.0
b56b6000 b56b8000 r-xp /usr/lib/libXinerama.so.1.0.0
b56c8000 b56cb000 r-xp /usr/lib/libXfixes.so.3.1.0
b56db000 b56e6000 r-xp /usr/lib/libXext.so.6.4.0
b56f6000 b56f8000 r-xp /usr/lib/libXdamage.so.1.1.0
b5708000 b570a000 r-xp /usr/lib/libXcomposite.so.1.0.0
b571b000 b57fd000 r-xp /usr/lib/libX11.so.6.3.0
b5810000 b5817000 r-xp /usr/lib/libXcursor.so.1.0.2
b5827000 b583f000 r-xp /usr/lib/libudev.so.1.6.0
b5841000 b5844000 r-xp /lib/libattr.so.1.1.0
b5854000 b5874000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5876000 b587b000 r-xp /usr/lib/libffi.so.6.0.2
b588b000 b58a3000 r-xp /lib/libz.so.1.2.8
b58b3000 b58b5000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58c5000 b599a000 r-xp /usr/lib/libxml2.so.2.9.2
b59af000 b5a4a000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a66000 b5a69000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a79000 b5a92000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5aa3000 b5ab4000 r-xp /lib/libresolv-2.20-2014.11.so
b5ac8000 b5b42000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b57000 b5b59000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b69000 b5b70000 r-xp /usr/lib/libembryo.so.1.13.0
b5b80000 b5b98000 r-xp /usr/lib/libpng12.so.0.50.0
b5ba9000 b5bcc000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bed000 b5c01000 r-xp /usr/lib/libector.so.1.13.0
b5c12000 b5c2a000 r-xp /usr/lib/liblua-5.1.so
b5c3b000 b5c92000 r-xp /usr/lib/libfreetype.so.6.11.3
b5ca6000 b5cce000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5cdf000 b5cf2000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d03000 b5d3a000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d4b000 b5d59000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d69000 b5d71000 r-xp /usr/lib/libtbm.so.1.0.0
b5d81000 b5d8e000 r-xp /usr/lib/libeio.so.1.13.0
b5d9e000 b5da0000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5db0000 b5db5000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5dc5000 b5ddc000 r-xp /usr/lib/libefreet.so.1.13.0
b5dee000 b5e0e000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e1e000 b5e3e000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e40000 b5e46000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e56000 b5e67000 r-xp /usr/lib/libemotion.so.1.13.0
b5e78000 b5e7f000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e8f000 b5e9e000 r-xp /usr/lib/libeo.so.1.13.0
b5eaf000 b5ec1000 r-xp /usr/lib/libecore_input.so.1.13.0
b5ed2000 b5ed7000 r-xp /usr/lib/libecore_file.so.1.13.0
b5ee7000 b5f00000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f10000 b5f2d000 r-xp /usr/lib/libeet.so.1.13.0
b5f46000 b5f8e000 r-xp /usr/lib/libeina.so.1.13.0
b5f9f000 b5faf000 r-xp /usr/lib/libefl.so.1.13.0
b5fc0000 b60a5000 r-xp /usr/lib/libicuuc.so.51.1
b60c2000 b6202000 r-xp /usr/lib/libicui18n.so.51.1
b6219000 b6251000 r-xp /usr/lib/libecore_x.so.1.13.0
b6263000 b6266000 r-xp /lib/libcap.so.2.21
b6276000 b629f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62b0000 b62b7000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62c9000 b6300000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6311000 b63fc000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b640f000 b6488000 r-xp /usr/lib/libsqlite3.so.0.8.6
b649a000 b649f000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64af000 b64b9000 r-xp /usr/lib/libvconf.so.0.2.45
b64c9000 b64cb000 r-xp /usr/lib/libvasum.so.0.3.1
b64db000 b64dd000 r-xp /usr/lib/libttrace.so.1.1
b64ed000 b64f0000 r-xp /usr/lib/libiniparser.so.0
b6500000 b6526000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6536000 b653b000 r-xp /usr/lib/libxdgmime.so.1.1.0
b654c000 b6563000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6574000 b65df000 r-xp /lib/libm-2.20-2014.11.so
b65f0000 b65f6000 r-xp /lib/librt-2.20-2014.11.so
b6607000 b6614000 r-xp /usr/lib/libunwind.so.8.0.1
b664a000 b676e000 r-xp /lib/libc-2.20-2014.11.so
b6783000 b679c000 r-xp /lib/libgcc_s-4.9.so.1
b67ac000 b688e000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b689f000 b68c9000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68da000 b6916000 r-xp /usr/lib/libsystemd.so.0.4.0
b6918000 b699a000 r-xp /usr/lib/libedje.so.1.13.0
b69ad000 b69cb000 r-xp /usr/lib/libecore.so.1.13.0
b69eb000 b6b72000 r-xp /usr/lib/libevas.so.1.13.0
b6ba7000 b6bbb000 r-xp /lib/libpthread-2.20-2014.11.so
b6bcf000 b6e04000 r-xp /usr/lib/libelementary.so.1.13.0
b6e32000 b6e36000 r-xp /usr/lib/libsmack.so.1.0.0
b6e46000 b6e4d000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e5d000 b6e5f000 r-xp /usr/lib/libdlog.so.0.0.0
b6e6f000 b6e72000 r-xp /usr/lib/libbundle.so.0.1.22
b6e82000 b6e84000 r-xp /lib/libdl-2.20-2014.11.so
b6e95000 b6ead000 r-xp /usr/lib/libaul.so.0.1.0
b6ec1000 b6ec6000 r-xp /usr/lib/libappcore-efl.so.1.1
b6ed7000 b6ee4000 r-xp /usr/lib/liblptcp.so
b6ef6000 b6efa000 r-xp /usr/lib/libsys-assert.so
b6f0b000 b6f2b000 r-xp /lib/ld-2.20-2014.11.so
b6f3c000 b6f41000 r-xp /usr/bin/launchpad-loader
b7c6c000 b7f87000 rw-p [heap]
be845000 be866000 rw-p [stack]
b7c6c000 b7f87000 rw-p [heap]
be845000 be866000 rw-p [stack]
End of Maps Information

Callstack Information (PID:13625)
Call Stack Count: 21
 0: view_history_create + 0x43 (0xb29c7070) [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw] + 0x7070
 1: _show_history_cb + 0x7a (0xb29c6cbb) [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw] + 0x6cbb
 2: (0xb6a517ed) [/usr/lib/libevas.so.1] + 0x667ed
 3: (0xb5e9a219) [/usr/lib/libeo.so.1] + 0xb219
 4: eo_event_callback_call + 0x68 (0xb5e98fb9) [/usr/lib/libeo.so.1] + 0x9fb9
 5: evas_object_smart_callback_call + 0x38 (0xb6a52edd) [/usr/lib/libevas.so.1] + 0x67edd
 6: (0xb696edd7) [/usr/lib/libedje.so.1] + 0x56dd7
 7: (0xb697311f) [/usr/lib/libedje.so.1] + 0x5b11f
 8: (0xb696f791) [/usr/lib/libedje.so.1] + 0x57791
 9: (0xb696fb61) [/usr/lib/libedje.so.1] + 0x57b61
10: (0xb696fcb5) [/usr/lib/libedje.so.1] + 0x57cb5
11: (0xb69bcd11) [/usr/lib/libecore.so.1] + 0xfd11
12: (0xb69b8c4b) [/usr/lib/libecore.so.1] + 0xbc4b
13: (0xb69bea5d) [/usr/lib/libecore.so.1] + 0x11a5d
14: ecore_main_loop_begin + 0x3e (0xb69bec83) [/usr/lib/libecore.so.1] + 0x11c83
15: appcore_efl_main + 0x20c (0xb6ec42bd) [/usr/lib/libappcore-efl.so.1] + 0x32bd
16: ui_app_main + 0xc0 (0xb438c909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
17: main + 0x9a (0xb29c632b) [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw] + 0x632b
18: (0xb6f3dbaf) [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw] + 0x1baf
19: __libc_start_main + 0x114 (0xb66604bc) [/lib/libc.so.6] + 0x164bc
20: (0xb6f3de94) [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw] + 0x1e94
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
07-25 22:05:49.299+0600 D/avoidrickshaw(32394): event-values: 0.202193, -0.063410, 10.188040, 0.000000
07-25 22:05:49.359+0600 D/avoidrickshaw(32394): event-values: 0.185444, -0.078963, 10.178469, 0.000000
07-25 22:05:49.419+0600 D/avoidrickshaw(32394): event-values: 0.201595, -0.089133, 10.154541, 0.000000
07-25 22:05:49.479+0600 D/avoidrickshaw(32394): event-values: 0.211167, -0.080160, 10.190434, 0.000000
07-25 22:05:49.539+0600 D/avoidrickshaw(32394): event-values: 0.183649, -0.084945, 10.183852, 0.000000
07-25 22:05:49.599+0600 D/avoidrickshaw(32394): event-values: 0.187238, -0.079561, 10.145569, 0.000000
07-25 22:05:49.659+0600 D/avoidrickshaw(32394): event-values: 0.203390, -0.075972, 10.172487, 0.000000
07-25 22:05:49.719+0600 D/avoidrickshaw(32394): event-values: 0.205783, -0.070588, 10.176675, 0.000000
07-25 22:05:49.779+0600 D/avoidrickshaw(32394): event-values: 0.198604, -0.090927, 10.179067, 0.000000
07-25 22:05:49.839+0600 D/avoidrickshaw(32394): event-values: 0.211167, -0.072383, 10.176675, 0.000000
07-25 22:05:49.909+0600 D/avoidrickshaw(32394): horizontal_acc: 12.000000, vertical_acc: -1.000000
07-25 22:05:49.909+0600 D/avoidrickshaw(32394): previous lat: 23.742136, previous long: 90.411688
07-25 22:05:49.909+0600 D/avoidrickshaw(32394): current lat: 23.742149, current long: 90.411686
07-25 22:05:49.919+0600 D/avoidrickshaw(32394): because step count did not update, saving position only.
07-25 22:05:49.919+0600 D/avoidrickshaw(32394): event-values: 0.186042, -0.082552, 10.143773, 0.000000
07-25 22:05:49.959+0600 D/avoidrickshaw(32394): event-values: 0.189033, -0.088534, 10.174281, 0.000000
07-25 22:05:50.019+0600 D/avoidrickshaw(32394): event-values: 0.189033, -0.071785, 10.155738, 0.000000
07-25 22:05:50.079+0600 D/avoidrickshaw(32394): event-values: 0.193819, -0.083151, 10.164113, 0.000000
07-25 22:05:50.140+0600 D/avoidrickshaw(32394): event-values: 0.204586, -0.079561, 10.165908, 0.000000
07-25 22:05:50.200+0600 D/avoidrickshaw(32394): event-values: 0.182453, -0.073579, 10.158729, 0.000000
07-25 22:05:50.260+0600 D/avoidrickshaw(32394): event-values: 0.192024, -0.084945, 10.157533, 0.000000
07-25 22:05:50.320+0600 D/avoidrickshaw(32394): event-values: 0.204586, -0.065803, 10.168301, 0.000000
07-25 22:05:50.380+0600 D/avoidrickshaw(32394): event-values: 0.214158, -0.067597, 10.174281, 0.000000
07-25 22:05:50.440+0600 D/avoidrickshaw(32394): event-values: 0.198604, -0.080758, 10.160523, 0.000000
07-25 22:05:50.500+0600 D/avoidrickshaw(32394): event-values: 0.195015, -0.074776, 10.164113, 0.000000
07-25 22:05:50.560+0600 D/avoidrickshaw(32394): event-values: 0.177069, -0.056231, 10.176076, 0.000000
07-25 22:05:50.620+0600 D/avoidrickshaw(32394): event-values: 0.214158, -0.077767, 10.175477, 0.000000
07-25 22:05:50.680+0600 D/avoidrickshaw(32394): event-values: 0.211167, -0.077169, 10.165309, 0.000000
07-25 22:05:50.740+0600 D/avoidrickshaw(32394): event-values: 0.157328, -0.078365, 10.176675, 0.000000
07-25 22:05:50.800+0600 D/avoidrickshaw(32394): event-values: 0.200997, -0.086740, 10.172487, 0.000000
07-25 22:05:50.860+0600 D/avoidrickshaw(32394): event-values: 0.209970, -0.061017, 10.186246, 0.000000
07-25 22:05:50.920+0600 D/avoidrickshaw(32394): event-values: 0.206979, -0.077767, 10.151550, 0.000000
07-25 22:05:50.980+0600 D/avoidrickshaw(32394): event-values: 0.189631, -0.066401, 10.180862, 0.000000
07-25 22:05:51.040+0600 D/avoidrickshaw(32394): event-values: 0.199202, -0.080758, 10.170692, 0.000000
07-25 22:05:51.100+0600 D/avoidrickshaw(32394): event-values: 0.226720, -0.073579, 10.196415, 0.000000
07-25 22:05:51.160+0600 D/avoidrickshaw(32394): event-values: 0.206979, -0.081356, 10.174281, 0.000000
07-25 22:05:51.221+0600 D/avoidrickshaw(32394): event-values: 0.177667, -0.075972, 10.171888, 0.000000
07-25 22:05:51.281+0600 D/avoidrickshaw(32394): event-values: 0.213559, -0.076570, 10.189835, 0.000000
07-25 22:05:51.341+0600 D/avoidrickshaw(32394): event-values: 0.208176, -0.075374, 10.170692, 0.000000
07-25 22:05:51.401+0600 D/avoidrickshaw(32394): event-values: 0.195015, -0.080758, 10.153345, 0.000000
07-25 22:05:51.461+0600 D/avoidrickshaw(32394): event-values: 0.178863, -0.078963, 10.156934, 0.000000
07-25 22:05:51.521+0600 D/avoidrickshaw(32394): event-values: 0.180658, -0.077169, 10.171888, 0.000000
07-25 22:05:51.581+0600 D/avoidrickshaw(32394): event-values: 0.199801, -0.068794, 10.171888, 0.000000
07-25 22:05:51.641+0600 D/avoidrickshaw(32394): event-values: 0.190828, -0.083151, 10.167104, 0.000000
07-25 22:05:51.701+0600 D/avoidrickshaw(32394): event-values: 0.176471, -0.081356, 10.187442, 0.000000
07-25 22:05:51.761+0600 D/avoidrickshaw(32394): event-values: 0.223131, -0.058026, 10.174281, 0.000000
07-25 22:05:51.821+0600 D/avoidrickshaw(32394): event-values: 0.194417, -0.084347, 10.178469, 0.000000
07-25 22:05:51.881+0600 D/avoidrickshaw(32394): event-values: 0.184846, -0.068794, 10.176675, 0.000000
07-25 22:05:51.941+0600 D/avoidrickshaw(32394): event-values: 0.196810, -0.056830, 10.174880, 0.000000
07-25 22:05:52.001+0600 D/avoidrickshaw(32394): event-values: 0.189033, -0.069392, 10.173084, 0.000000
07-25 22:05:52.061+0600 D/avoidrickshaw(32394): event-values: 0.208176, -0.075374, 10.155738, 0.000000
07-25 22:05:52.121+0600 D/avoidrickshaw(32394): event-values: 0.190229, -0.071785, 10.180862, 0.000000
07-25 22:05:52.181+0600 D/avoidrickshaw(32394): event-values: 0.168694, -0.069990, 10.185647, 0.000000
07-25 22:05:52.242+0600 D/avoidrickshaw(32394): event-values: 0.203988, -0.069392, 10.181459, 0.000000
07-25 22:05:52.302+0600 D/avoidrickshaw(32394): event-values: 0.183051, -0.075972, 10.150353, 0.000000
07-25 22:05:52.362+0600 D/avoidrickshaw(32394): event-values: 0.190828, -0.090927, 10.168897, 0.000000
07-25 22:05:52.422+0600 D/avoidrickshaw(32394): event-values: 0.202193, -0.075972, 10.165309, 0.000000
07-25 22:05:52.482+0600 D/avoidrickshaw(32394): event-values: 0.198006, -0.077169, 10.162916, 0.000000
07-25 22:05:52.542+0600 D/avoidrickshaw(32394): event-values: 0.196211, -0.083151, 10.154541, 0.000000
07-25 22:05:52.602+0600 D/avoidrickshaw(32394): event-values: 0.191426, -0.077169, 10.199407, 0.000000
07-25 22:05:52.662+0600 D/avoidrickshaw(32394): event-values: 0.205185, -0.075972, 10.149158, 0.000000
07-25 22:05:52.722+0600 D/avoidrickshaw(32394): event-values: 0.214158, -0.087338, 10.161720, 0.000000
07-25 22:05:52.782+0600 D/avoidrickshaw(32394): event-values: 0.166899, -0.094516, 10.161121, 0.000000
07-25 22:05:52.842+0600 D/avoidrickshaw(32394): event-values: 0.220738, -0.061615, 10.188639, 0.000000
07-25 22:05:52.902+0600 D/avoidrickshaw(32394): event-values: 0.200997, -0.061017, 10.222138, 0.000000
07-25 22:05:52.962+0600 D/avoidrickshaw(32394): event-values: 0.181855, -0.075972, 10.201799, 0.000000
07-25 22:05:53.022+0600 D/avoidrickshaw(32394): event-values: 0.195015, -0.072383, 10.147961, 0.000000
07-25 22:05:53.082+0600 D/avoidrickshaw(32394): event-values: 0.226720, -0.074178, 10.204191, 0.000000
07-25 22:05:53.142+0600 D/avoidrickshaw(32394): event-values: 0.199801, -0.107079, 10.128220, 0.000000
07-25 22:05:53.202+0600 D/avoidrickshaw(32394): event-values: 0.183649, -0.078963, 10.184451, 0.000000
07-25 22:05:53.263+0600 D/avoidrickshaw(32394): event-values: 0.198604, -0.083151, 10.164711, 0.000000
07-25 22:05:53.323+0600 D/avoidrickshaw(32394): event-values: 0.226122, -0.074178, 10.180862, 0.000000
07-25 22:05:53.383+0600 D/avoidrickshaw(32394): event-values: 0.177667, -0.078963, 10.179067, 0.000000
07-25 22:05:53.443+0600 D/avoidrickshaw(32394): event-values: 0.186640, -0.085543, 10.177272, 0.000000
07-25 22:05:53.503+0600 D/avoidrickshaw(32394): event-values: 0.209970, -0.102891, 10.200004, 0.000000
07-25 22:05:53.563+0600 D/avoidrickshaw(32394): event-values: 0.186042, -0.062213, 10.147961, 0.000000
07-25 22:05:53.623+0600 D/avoidrickshaw(32394): event-values: 0.208774, -0.072383, 10.183852, 0.000000
07-25 22:05:53.683+0600 D/avoidrickshaw(32394): event-values: 0.201595, -0.074178, 10.147363, 0.000000
07-25 22:05:53.743+0600 D/avoidrickshaw(32394): event-values: 0.204586, -0.083749, 10.190434, 0.000000
07-25 22:05:53.803+0600 D/avoidrickshaw(32394): event-values: 0.238684, -0.075972, 10.221540, 0.000000
07-25 22:05:53.873+0600 D/avoidrickshaw(32394): event-values: 0.221934, -0.082552, 10.164711, 0.000000
07-25 22:05:53.903+0600 D/avoidrickshaw(32394): horizontal_acc: 24.000000, vertical_acc: -1.000000
07-25 22:05:53.903+0600 D/avoidrickshaw(32394): previous lat: 23.742149, previous long: 90.411686
07-25 22:05:53.903+0600 D/avoidrickshaw(32394): current lat: 23.742149, current long: 90.411686
07-25 22:05:53.913+0600 D/avoidrickshaw(32394): because step count did not update, distance not updated.
07-25 22:05:53.933+0600 D/avoidrickshaw(32394): event-values: 0.166301, -0.094516, 10.159328, 0.000000
07-25 22:05:53.993+0600 D/avoidrickshaw(32394): event-values: 0.188435, -0.076570, 10.085149, 0.000000
07-25 22:05:54.053+0600 D/avoidrickshaw(32394): event-values: 0.198604, -0.076570, 10.175477, 0.000000
07-25 22:05:54.113+0600 D/avoidrickshaw(32394): event-values: 0.201595, -0.066999, 10.238290, 0.000000
07-25 22:05:54.173+0600 D/avoidrickshaw(32394): event-values: 0.191426, -0.077767, 10.135997, 0.000000
07-25 22:05:54.233+0600 D/avoidrickshaw(32394): event-values: 0.222532, -0.055633, 10.208978, 0.000000
07-25 22:05:54.294+0600 D/avoidrickshaw(32394): event-values: 0.209970, -0.089731, 10.184451, 0.000000
07-25 22:05:54.354+0600 D/avoidrickshaw(32394): event-values: 0.179462, -0.080758, 10.193424, 0.000000
07-25 22:05:54.414+0600 D/avoidrickshaw(32394): event-values: 0.212961, -0.059821, 10.142577, 0.000000
07-25 22:05:54.474+0600 D/avoidrickshaw(32394): event-values: 0.196810, -0.079561, 10.187442, 0.000000
07-25 22:05:54.534+0600 D/avoidrickshaw(32394): event-values: 0.195613, -0.074776, 10.165309, 0.000000
07-25 22:05:54.594+0600 D/avoidrickshaw(32394): event-values: 0.177667, -0.068195, 10.174281, 0.000000
07-25 22:05:54.654+0600 D/avoidrickshaw(32394): event-values: 0.189033, -0.058026, 10.185647, 0.000000
07-25 22:05:54.714+0600 D/avoidrickshaw(32394): event-values: 0.213559, -0.063410, 10.172487, 0.000000
07-25 22:05:54.774+0600 D/avoidrickshaw(32394): event-values: 0.178265, -0.077767, 10.159328, 0.000000
07-25 22:05:54.834+0600 D/avoidrickshaw(32394): event-values: 0.211167, -0.059222, 10.162319, 0.000000
07-25 22:05:54.894+0600 D/avoidrickshaw(32394): event-values: 0.194417, -0.058624, 10.184451, 0.000000
07-25 22:05:54.954+0600 D/avoidrickshaw(32394): event-values: 0.162114, -0.081356, 10.194620, 0.000000
07-25 22:05:55.014+0600 D/avoidrickshaw(32394): event-values: 0.181855, -0.100499, 10.098309, 0.000000
07-25 22:05:55.074+0600 D/avoidrickshaw(32394): event-values: 0.196211, -0.060419, 10.247264, 0.000000
07-25 22:05:55.134+0600 D/avoidrickshaw(32394): event-values: 0.166899, -0.092722, 10.185647, 0.000000
07-25 22:05:55.194+0600 D/avoidrickshaw(32394): event-values: 0.203390, -0.082552, 10.145569, 0.000000
07-25 22:05:55.254+0600 D/avoidrickshaw(32394): event-values: 0.203988, -0.091525, 10.186844, 0.000000
07-25 22:05:55.315+0600 D/avoidrickshaw(32394): event-values: 0.203390, -0.061615, 10.163515, 0.000000
07-25 22:05:55.375+0600 D/avoidrickshaw(32394): event-values: 0.181256, -0.072383, 10.170692, 0.000000
07-25 22:05:55.435+0600 D/avoidrickshaw(32394): event-values: 0.171087, -0.091525, 10.130014, 0.000000
07-25 22:05:55.495+0600 D/avoidrickshaw(32394): event-values: 0.229711, -0.087936, 10.197014, 0.000000
07-25 22:05:55.555+0600 D/avoidrickshaw(32394): event-values: 0.196211, -0.064008, 10.186246, 0.000000
07-25 22:05:55.615+0600 D/avoidrickshaw(32394): event-values: 0.194417, -0.071785, 10.159925, 0.000000
07-25 22:05:55.675+0600 D/avoidrickshaw(32394): event-values: 0.201595, -0.087936, 10.183254, 0.000000
07-25 22:05:55.735+0600 D/avoidrickshaw(32394): event-values: 0.204586, -0.078963, 10.159925, 0.000000
07-25 22:05:55.795+0600 D/avoidrickshaw(32394): event-values: 0.224327, -0.062812, 10.156336, 0.000000
07-25 22:05:55.855+0600 D/avoidrickshaw(32394): event-values: 0.192622, -0.070588, 10.185050, 0.000000
07-25 22:05:55.915+0600 D/avoidrickshaw(32394): event-values: 0.181256, -0.069990, 10.152148, 0.000000
07-25 22:05:55.975+0600 D/avoidrickshaw(32394): event-values: 0.209970, -0.059821, 10.162319, 0.000000
07-25 22:05:56.035+0600 D/avoidrickshaw(32394): event-values: 0.164507, -0.074776, 10.109076, 0.000000
07-25 22:05:56.095+0600 D/avoidrickshaw(32394): event-values: 0.202792, -0.084945, 10.192227, 0.000000
07-25 22:05:56.155+0600 D/avoidrickshaw(32394): event-values: 0.189033, -0.073579, 10.206585, 0.000000
07-25 22:05:56.215+0600 D/avoidrickshaw(32394): event-values: 0.187837, -0.095115, 10.129416, 0.000000
07-25 22:05:56.275+0600 D/avoidrickshaw(32394): event-values: 0.205185, -0.065204, 10.195816, 0.000000
07-25 22:05:56.336+0600 D/avoidrickshaw(32394): event-values: 0.168694, -0.067597, 10.183254, 0.000000
07-25 22:05:56.396+0600 D/avoidrickshaw(32394): event-values: 0.215952, -0.083749, 10.153944, 0.000000
07-25 22:05:56.456+0600 D/avoidrickshaw(32394): event-values: 0.228515, -0.073579, 10.160523, 0.000000
07-25 22:05:56.516+0600 D/avoidrickshaw(32394): event-values: 0.164507, -0.092124, 10.188040, 0.000000
07-25 22:05:56.576+0600 D/avoidrickshaw(32394): event-values: 0.184846, -0.066999, 10.162916, 0.000000
07-25 22:05:56.636+0600 D/avoidrickshaw(32394): event-values: 0.247657, -0.080758, 10.166506, 0.000000
07-25 22:05:56.696+0600 D/avoidrickshaw(32394): event-values: 0.215952, -0.068794, 10.182058, 0.000000
07-25 22:05:56.756+0600 D/avoidrickshaw(32394): event-values: 0.179462, -0.081356, 10.169496, 0.000000
07-25 22:05:56.816+0600 D/avoidrickshaw(32394): event-values: 0.189033, -0.083749, 10.186844, 0.000000
07-25 22:05:56.876+0600 D/avoidrickshaw(32394): event-values: 0.240479, -0.062812, 10.146765, 0.000000
07-25 22:05:56.936+0600 D/avoidrickshaw(32394): event-values: 0.195613, -0.078365, 10.165309, 0.000000
07-25 22:05:56.996+0600 D/avoidrickshaw(32394): event-values: 0.169292, -0.074178, 10.156336, 0.000000
07-25 22:05:57.056+0600 D/avoidrickshaw(32394): event-values: 0.223729, -0.072981, 10.172487, 0.000000
07-25 22:05:57.116+0600 D/avoidrickshaw(32394): event-values: 0.224925, -0.071186, 10.167104, 0.000000
07-25 22:05:57.176+0600 D/avoidrickshaw(32394): event-values: 0.189033, -0.078963, 10.155140, 0.000000
07-25 22:05:57.236+0600 D/avoidrickshaw(32394): event-values: 0.173480, -0.065204, 10.171290, 0.000000
07-25 22:05:57.296+0600 D/avoidrickshaw(32394): event-values: 0.220738, -0.069990, 10.160523, 0.000000
07-25 22:05:57.357+0600 D/avoidrickshaw(32394): event-values: 0.211765, -0.074776, 10.170094, 0.000000
07-25 22:05:57.417+0600 D/avoidrickshaw(32394): event-values: 0.190828, -0.064008, 10.176076, 0.000000
07-25 22:05:57.477+0600 D/avoidrickshaw(32394): event-values: 0.172881, -0.066401, 10.163515, 0.000000
07-25 22:05:57.537+0600 D/avoidrickshaw(32394): event-values: 0.183649, -0.058624, 10.189237, 0.000000
07-25 22:05:57.597+0600 D/avoidrickshaw(32394): event-values: 0.195015, -0.061017, 10.157533, 0.000000
07-25 22:05:57.657+0600 D/avoidrickshaw(32394): event-values: 0.186640, -0.064008, 10.163515, 0.000000
07-25 22:05:57.717+0600 D/avoidrickshaw(32394): event-values: 0.172881, -0.092722, 10.164113, 0.000000
07-25 22:05:57.777+0600 D/avoidrickshaw(32394): event-values: 0.206381, -0.070588, 10.165908, 0.000000
07-25 22:05:57.837+0600 D/avoidrickshaw(32394): event-values: 0.211765, -0.058624, 10.162319, 0.000000
07-25 22:05:57.907+0600 D/avoidrickshaw(32394): horizontal_acc: 24.000000, vertical_acc: -1.000000
07-25 22:05:57.907+0600 D/avoidrickshaw(32394): previous lat: 23.742149, previous long: 90.411686
07-25 22:05:57.907+0600 D/avoidrickshaw(32394): current lat: 23.742149, current long: 90.411686
07-25 22:05:57.917+0600 D/avoidrickshaw(32394): because step count did not update, distance not updated.
07-25 22:05:57.917+0600 D/avoidrickshaw(32394): event-values: 0.192622, -0.086740, 10.187442, 0.000000
07-25 22:05:57.957+0600 D/avoidrickshaw(32394): event-values: 0.189033, -0.069392, 10.176675, 0.000000
07-25 22:05:58.017+0600 D/avoidrickshaw(32394): event-values: 0.190229, -0.089133, 10.166506, 0.000000
07-25 22:05:58.077+0600 D/avoidrickshaw(32394): event-values: 0.195613, -0.072981, 10.165908, 0.000000
07-25 22:05:58.137+0600 D/avoidrickshaw(32394): event-values: 0.192024, -0.065803, 10.188040, 0.000000
07-25 22:05:58.197+0600 D/avoidrickshaw(32394): event-values: 0.196211, -0.084347, 10.170094, 0.000000
07-25 22:05:58.257+0600 D/avoidrickshaw(32394): event-values: 0.207577, -0.057428, 10.158132, 0.000000
07-25 22:05:58.317+0600 D/avoidrickshaw(32394): event-values: 0.192622, -0.071785, 10.178469, 0.000000
07-25 22:05:58.378+0600 D/avoidrickshaw(32394): event-values: 0.188435, -0.075972, 10.159328, 0.000000
07-25 22:05:58.438+0600 D/avoidrickshaw(32394): event-values: 0.200997, -0.078963, 10.156934, 0.000000
07-25 22:05:58.498+0600 D/avoidrickshaw(32394): event-values: 0.188435, -0.077169, 10.188639, 0.000000
07-25 22:05:58.558+0600 D/avoidrickshaw(32394): event-values: 0.199801, -0.074178, 10.165908, 0.000000
07-25 22:05:58.618+0600 D/avoidrickshaw(32394): event-values: 0.196810, -0.077169, 10.151550, 0.000000
07-25 22:05:58.678+0600 D/avoidrickshaw(32394): event-values: 0.198604, -0.077767, 10.156934, 0.000000
07-25 22:05:58.738+0600 D/avoidrickshaw(32394): event-values: 0.219541, -0.073579, 10.153944, 0.000000
07-25 22:05:58.798+0600 D/avoidrickshaw(32394): event-values: 0.175872, -0.070588, 10.176675, 0.000000
07-25 22:05:58.858+0600 D/avoidrickshaw(32394): event-values: 0.185444, -0.086740, 10.167104, 0.000000
07-25 22:05:58.918+0600 D/avoidrickshaw(32394): event-values: 0.191426, -0.075972, 10.176076, 0.000000
07-25 22:05:58.978+0600 D/avoidrickshaw(32394): event-values: 0.194417, -0.069990, 10.180862, 0.000000
07-25 22:05:59.038+0600 D/avoidrickshaw(32394): event-values: 0.201595, -0.075972, 10.172487, 0.000000
07-25 22:05:59.098+0600 D/avoidrickshaw(32394): event-values: 0.193819, -0.096311, 10.189835, 0.000000
07-25 22:05:59.158+0600 D/avoidrickshaw(32394): event-values: 0.197408, -0.080758, 10.166506, 0.000000
07-25 22:05:59.218+0600 D/avoidrickshaw(32394): event-values: 0.207577, -0.069392, 10.173683, 0.000000
07-25 22:05:59.278+0600 D/avoidrickshaw(32394): event-values: 0.188435, -0.077767, 10.171888, 0.000000
07-25 22:05:59.338+0600 D/avoidrickshaw(32394): event-values: 0.192622, -0.075972, 10.175477, 0.000000
07-25 22:05:59.399+0600 D/avoidrickshaw(32394): event-values: 0.203390, -0.095115, 10.176076, 0.000000
07-25 22:05:59.459+0600 D/avoidrickshaw(32394): event-values: 0.192024, -0.076570, 10.191629, 0.000000
07-25 22:05:59.519+0600 D/avoidrickshaw(32394): event-values: 0.195613, -0.067597, 10.182058, 0.000000
07-25 22:05:59.579+0600 D/avoidrickshaw(32394): event-values: 0.197408, -0.078963, 10.183852, 0.000000
07-25 22:05:59.639+0600 D/avoidrickshaw(32394): event-values: 0.193819, -0.068794, 10.181459, 0.000000
07-25 22:05:59.699+0600 D/avoidrickshaw(32394): event-values: 0.199202, -0.074178, 10.173084, 0.000000
07-25 22:05:59.759+0600 D/avoidrickshaw(32394): event-values: 0.201595, -0.086142, 10.177272, 0.000000
07-25 22:05:59.819+0600 D/avoidrickshaw(32394): event-values: 0.209372, -0.077169, 10.170094, 0.000000
07-25 22:05:59.879+0600 D/avoidrickshaw(32394): event-values: 0.214158, -0.077169, 10.163515, 0.000000
07-25 22:05:59.939+0600 D/avoidrickshaw(32394): event-values: 0.199801, -0.061017, 10.164113, 0.000000
07-25 22:05:59.999+0600 D/avoidrickshaw(32394): event-values: 0.199801, -0.093320, 10.176675, 0.000000
07-25 22:06:00.059+0600 D/avoidrickshaw(32394): event-values: 0.205783, -0.083151, 10.168301, 0.000000
07-25 22:06:00.119+0600 D/avoidrickshaw(32394): event-values: 0.195613, -0.095115, 10.173683, 0.000000
07-25 22:06:00.179+0600 D/avoidrickshaw(32394): event-values: 0.203988, -0.064008, 10.194620, 0.000000
07-25 22:06:00.239+0600 D/avoidrickshaw(32394): event-values: 0.187238, -0.076570, 10.177272, 0.000000
07-25 22:06:00.299+0600 D/avoidrickshaw(32394): event-values: 0.215952, -0.074178, 10.182058, 0.000000
07-25 22:06:00.359+0600 D/avoidrickshaw(32394): event-values: 0.199801, -0.083749, 10.162916, 0.000000
07-25 22:06:00.420+0600 D/avoidrickshaw(32394): event-values: 0.189631, -0.077169, 10.161121, 0.000000
07-25 22:06:00.480+0600 D/avoidrickshaw(32394): event-values: 0.202193, -0.071186, 10.177272, 0.000000
07-25 22:06:00.540+0600 D/avoidrickshaw(32394): event-values: 0.202193, -0.077767, 10.182058, 0.000000
07-25 22:06:00.600+0600 D/avoidrickshaw(32394): event-values: 0.185444, -0.074776, 10.140782, 0.000000
07-25 22:06:00.660+0600 D/avoidrickshaw(32394): event-values: 0.190828, -0.068794, 10.166506, 0.000000
07-25 22:06:00.720+0600 D/avoidrickshaw(32394): event-values: 0.197408, -0.098106, 10.159328, 0.000000
07-25 22:06:00.780+0600 D/avoidrickshaw(32394): event-values: 0.205185, -0.079561, 10.173084, 0.000000
07-25 22:06:00.840+0600 D/avoidrickshaw(32394): event-values: 0.199202, -0.081356, 10.173683, 0.000000
07-25 22:06:00.900+0600 D/avoidrickshaw(32394): event-values: 0.188435, -0.078365, 10.155738, 0.000000
07-25 22:06:00.960+0600 D/avoidrickshaw(32394): event-values: 0.193220, -0.053839, 10.172487, 0.000000
07-25 22:06:01.020+0600 D/avoidrickshaw(32394): event-values: 0.206381, -0.080160, 10.173683, 0.000000
07-25 22:06:01.080+0600 D/avoidrickshaw(32394): event-values: 0.209372, -0.072981, 10.159328, 0.000000
07-25 22:06:01.140+0600 D/avoidrickshaw(32394): event-values: 0.189033, -0.061017, 10.189835, 0.000000
07-25 22:06:01.200+0600 D/avoidrickshaw(32394): event-values: 0.205185, -0.054437, 10.173683, 0.000000
07-25 22:06:01.260+0600 D/avoidrickshaw(32394): event-values: 0.202193, -0.078963, 10.182058, 0.000000
07-25 22:06:01.320+0600 D/avoidrickshaw(32394): event-values: 0.213559, -0.068195, 10.171290, 0.000000
07-25 22:06:01.380+0600 D/avoidrickshaw(32394): event-values: 0.181256, -0.071785, 10.164711, 0.000000
07-25 22:06:01.441+0600 D/avoidrickshaw(32394): event-values: 0.184846, -0.089133, 10.180264, 0.000000
07-25 22:06:01.501+0600 D/avoidrickshaw(32394): event-values: 0.185444, -0.094516, 10.172487, 0.000000
07-25 22:06:01.561+0600 D/avoidrickshaw(32394): event-values: 0.198006, -0.068794, 10.178469, 0.000000
07-25 22:06:01.621+0600 D/avoidrickshaw(32394): event-values: 0.203390, -0.071785, 10.171888, 0.000000
07-25 22:06:01.681+0600 D/avoidrickshaw(32394): event-values: 0.196810, -0.061615, 10.162319, 0.000000
07-25 22:06:01.731+0600 D/avoidrickshaw(32394): event-values: 0.183051, -0.085543, 10.167104, 0.000000
07-25 22:06:01.791+0600 D/avoidrickshaw(32394): event-values: 0.184846, -0.081954, 10.158729, 0.000000
07-25 22:06:01.851+0600 D/avoidrickshaw(32394): event-values: 0.200997, -0.058026, 10.175477, 0.000000
07-25 22:06:01.901+0600 D/avoidrickshaw(32394): horizontal_acc: 16.000000, vertical_acc: -1.000000
07-25 22:06:01.901+0600 D/avoidrickshaw(32394): previous lat: 23.742149, previous long: 90.411686
07-25 22:06:01.901+0600 D/avoidrickshaw(32394): current lat: 23.742154, current long: 90.411687
07-25 22:06:01.911+0600 D/avoidrickshaw(32394): because step count did not update, distance not updated.
07-25 22:06:01.911+0600 D/avoidrickshaw(32394): event-values: 0.177667, -0.066401, 10.173683, 0.000000
07-25 22:06:01.971+0600 D/avoidrickshaw(32394): event-values: 0.191426, -0.073579, 10.173683, 0.000000
07-25 22:06:02.031+0600 D/avoidrickshaw(32394): event-values: 0.202193, -0.075374, 10.188040, 0.000000
07-25 22:06:02.091+0600 D/avoidrickshaw(32394): event-values: 0.193220, -0.076570, 10.173683, 0.000000
07-25 22:06:02.151+0600 D/avoidrickshaw(32394): event-values: 0.192622, -0.068794, 10.171290, 0.000000
07-25 22:06:02.211+0600 D/avoidrickshaw(32394): event-values: 0.234497, -0.087338, 10.164711, 0.000000
07-25 22:06:02.271+0600 D/avoidrickshaw(32394): event-values: 0.184247, -0.082552, 10.114462, 0.000000
07-25 22:06:02.331+0600 D/avoidrickshaw(32394): event-values: 0.212363, -0.056830, 10.190434, 0.000000
07-25 22:06:02.391+0600 D/avoidrickshaw(32394): event-values: 0.181855, -0.080758, 10.168897, 0.000000
07-25 22:06:02.452+0600 D/avoidrickshaw(32394): event-values: 0.244666, -0.059821, 10.238290, 0.000000
07-25 22:06:02.512+0600 D/avoidrickshaw(32394): event-values: 0.212363, -0.064008, 10.193424, 0.000000
07-25 22:06:02.572+0600 D/avoidrickshaw(32394): event-values: 0.177667, -0.074178, 10.141978, 0.000000
07-25 22:06:02.632+0600 D/avoidrickshaw(32394): event-values: 0.203390, -0.084347, 10.147363, 0.000000
07-25 22:06:02.692+0600 D/avoidrickshaw(32394): event-values: 0.195015, -0.064606, 10.148559, 0.000000
07-25 22:06:02.752+0600 D/avoidrickshaw(32394): event-values: 0.205783, -0.050249, 10.164711, 0.000000
07-25 22:06:02.812+0600 D/avoidrickshaw(32394): event-values: 0.193819, -0.083151, 10.188639, 0.000000
07-25 22:06:02.872+0600 D/avoidrickshaw(32394): event-values: 0.181256, -0.080160, 10.166506, 0.000000
07-25 22:06:02.882+0600 I/Tizen::Net::Wifi( 1305): (941) > The background scan result updated.
07-25 22:06:02.932+0600 D/avoidrickshaw(32394): event-values: 0.188435, -0.077767, 10.158132, 0.000000
07-25 22:06:02.992+0600 D/avoidrickshaw(32394): event-values: 0.171087, -0.092722, 10.140184, 0.000000
07-25 22:06:03.052+0600 D/avoidrickshaw(32394): event-values: 0.205185, -0.075374, 10.214361, 0.000000
07-25 22:06:03.112+0600 D/avoidrickshaw(32394): event-values: 0.192024, -0.082552, 10.156336, 0.000000
07-25 22:06:03.172+0600 D/avoidrickshaw(32394): event-values: 0.191426, -0.074776, 10.159328, 0.000000
07-25 22:06:03.232+0600 D/avoidrickshaw(32394): event-values: 0.223131, -0.053240, 10.197014, 0.000000
07-25 22:06:03.292+0600 D/avoidrickshaw(32394): event-values: 0.200997, -0.069392, 10.190434, 0.000000
07-25 22:06:03.352+0600 D/avoidrickshaw(32394): event-values: 0.150748, -0.094516, 10.128819, 0.000000
07-25 22:06:03.412+0600 D/avoidrickshaw(32394): event-values: 0.205185, -0.077767, 10.223933, 0.000000
07-25 22:06:03.473+0600 D/avoidrickshaw(32394): event-values: 0.180060, -0.059222, 10.156934, 0.000000
07-25 22:06:03.533+0600 D/avoidrickshaw(32394): event-values: 0.170489, -0.064606, 10.151550, 0.000000
07-25 22:06:03.593+0600 D/avoidrickshaw(32394): event-values: 0.213559, -0.065204, 10.191629, 0.000000
07-25 22:06:03.653+0600 D/avoidrickshaw(32394): event-values: 0.166899, -0.081954, 10.160523, 0.000000
07-25 22:06:03.713+0600 D/avoidrickshaw(32394): event-values: 0.178265, -0.058624, 10.210773, 0.000000
07-25 22:06:03.773+0600 D/avoidrickshaw(32394): event-values: 0.207577, -0.091525, 10.181459, 0.000000
07-25 22:06:03.833+0600 D/avoidrickshaw(32394): event-values: 0.198006, -0.063410, 10.189835, 0.000000
07-25 22:06:03.893+0600 D/avoidrickshaw(32394): event-values: 0.177069, -0.071785, 10.141978, 0.000000
07-25 22:06:03.953+0600 D/avoidrickshaw(32394): event-values: 0.212363, -0.096909, 10.195816, 0.000000
07-25 22:06:04.013+0600 D/avoidrickshaw(32394): event-values: 0.218345, -0.066401, 10.144372, 0.000000
07-25 22:06:04.073+0600 D/avoidrickshaw(32394): event-values: 0.222532, -0.074178, 10.183852, 0.000000
07-25 22:06:04.133+0600 D/avoidrickshaw(32394): event-values: 0.166899, -0.078365, 10.164113, 0.000000
07-25 22:06:04.193+0600 D/avoidrickshaw(32394): event-values: 0.183649, -0.073579, 10.171888, 0.000000
07-25 22:06:04.253+0600 D/avoidrickshaw(32394): event-values: 0.214158, -0.069392, 10.141978, 0.000000
07-25 22:06:04.313+0600 D/avoidrickshaw(32394): event-values: 0.221934, -0.056231, 10.132407, 0.000000
07-25 22:06:04.373+0600 D/avoidrickshaw(32394): event-values: 0.215354, -0.051446, 10.202397, 0.000000
07-25 22:06:04.433+0600 D/avoidrickshaw(32394): event-values: 0.163310, -0.064606, 10.164711, 0.000000
07-25 22:06:04.494+0600 D/avoidrickshaw(32394): event-values: 0.194417, -0.071785, 10.199407, 0.000000
07-25 22:06:04.554+0600 D/avoidrickshaw(32394): event-values: 0.192622, -0.064606, 10.174880, 0.000000
07-25 22:06:04.614+0600 D/avoidrickshaw(32394): event-values: 0.214756, -0.058026, 10.188639, 0.000000
07-25 22:06:04.674+0600 D/avoidrickshaw(32394): event-values: 0.196810, -0.101695, 10.205389, 0.000000
07-25 22:06:04.734+0600 D/avoidrickshaw(32394): event-values: 0.202193, -0.070588, 10.147961, 0.000000
07-25 22:06:04.794+0600 D/avoidrickshaw(32394): event-values: 0.225524, -0.076570, 10.216157, 0.000000
07-25 22:06:04.854+0600 D/avoidrickshaw(32394): event-values: 0.195613, -0.054437, 10.174281, 0.000000
07-25 22:06:04.914+0600 D/avoidrickshaw(32394): event-values: 0.189631, -0.078963, 10.194620, 0.000000
07-25 22:06:04.974+0600 D/avoidrickshaw(32394): event-values: 0.227318, -0.061017, 10.198808, 0.000000
07-25 22:06:05.034+0600 D/avoidrickshaw(32394): event-values: 0.181256, -0.078963, 10.150353, 0.000000
07-25 22:06:05.094+0600 D/avoidrickshaw(32394): event-values: 0.195015, -0.084945, 10.164711, 0.000000
07-25 22:06:05.154+0600 D/avoidrickshaw(32394): event-values: 0.183649, -0.062812, 10.166506, 0.000000
07-25 22:06:05.214+0600 D/avoidrickshaw(32394): event-values: 0.210568, -0.072981, 10.167104, 0.000000
07-25 22:06:05.274+0600 D/avoidrickshaw(32394): event-values: 0.192622, -0.082552, 10.168301, 0.000000
07-25 22:06:05.334+0600 D/avoidrickshaw(32394): event-values: 0.189033, -0.066999, 10.156336, 0.000000
07-25 22:06:05.394+0600 D/avoidrickshaw(32394): event-values: 0.210568, -0.068195, 10.175477, 0.000000
07-25 22:06:05.454+0600 D/avoidrickshaw(32394): event-values: 0.221336, -0.078963, 10.180264, 0.000000
07-25 22:06:05.515+0600 D/avoidrickshaw(32394): event-values: 0.201595, -0.073579, 10.172487, 0.000000
07-25 22:06:05.575+0600 D/avoidrickshaw(32394): event-values: 0.185444, -0.090927, 10.178469, 0.000000
07-25 22:06:05.635+0600 D/avoidrickshaw(32394): event-values: 0.210568, -0.077767, 10.134801, 0.000000
07-25 22:06:05.695+0600 D/avoidrickshaw(32394): event-values: 0.212363, -0.080758, 10.176076, 0.000000
07-25 22:06:05.755+0600 D/avoidrickshaw(32394): event-values: 0.190828, -0.059821, 10.206585, 0.000000
07-25 22:06:05.815+0600 D/avoidrickshaw(32394): event-values: 0.204586, -0.062213, 10.196415, 0.000000
07-25 22:06:05.875+0600 D/avoidrickshaw(32394): event-values: 0.220738, -0.080160, 10.184451, 0.000000
07-25 22:06:05.905+0600 D/avoidrickshaw(32394): horizontal_acc: 8.000000, vertical_acc: -1.000000
07-25 22:06:05.905+0600 D/avoidrickshaw(32394): previous lat: 23.742149, previous long: 90.411686
07-25 22:06:05.905+0600 D/avoidrickshaw(32394): current lat: 23.742158, current long: 90.411684
07-25 22:06:05.915+0600 D/avoidrickshaw(32394): because step count did not update, distance not updated.
07-25 22:06:05.935+0600 D/avoidrickshaw(32394): event-values: 0.217149, -0.086142, 10.174880, 0.000000
07-25 22:06:05.995+0600 D/avoidrickshaw(32394): event-values: 0.177069, -0.069392, 10.164113, 0.000000
07-25 22:06:06.055+0600 D/avoidrickshaw(32394): event-values: 0.179462, -0.062812, 10.189237, 0.000000
07-25 22:06:06.115+0600 D/avoidrickshaw(32394): event-values: 0.219541, -0.086740, 10.178469, 0.000000
07-25 22:06:06.175+0600 D/avoidrickshaw(32394): event-values: 0.209372, -0.083749, 10.168897, 0.000000
07-25 22:06:06.235+0600 D/avoidrickshaw(32394): event-values: 0.192622, -0.087936, 10.182656, 0.000000
07-25 22:06:06.295+0600 D/avoidrickshaw(32394): event-values: 0.190229, -0.072383, 10.168301, 0.000000
07-25 22:06:06.355+0600 D/avoidrickshaw(32394): event-values: 0.218345, -0.070588, 10.177871, 0.000000
07-25 22:06:06.415+0600 D/avoidrickshaw(32394): event-values: 0.190828, -0.081356, 10.164711, 0.000000
07-25 22:06:06.475+0600 D/avoidrickshaw(32394): event-values: 0.177069, -0.064008, 10.170692, 0.000000
07-25 22:06:06.535+0600 D/avoidrickshaw(32394): event-values: 0.196211, -0.079561, 10.164711, 0.000000
07-25 22:06:06.596+0600 D/avoidrickshaw(32394): event-values: 0.197408, -0.077169, 10.165309, 0.000000
07-25 22:06:06.656+0600 D/avoidrickshaw(32394): event-values: 0.176471, -0.076570, 10.163515, 0.000000
07-25 22:06:06.716+0600 D/avoidrickshaw(32394): event-values: 0.178265, -0.070588, 10.172487, 0.000000
07-25 22:06:06.776+0600 D/avoidrickshaw(32394): event-values: 0.194417, -0.077169, 10.185050, 0.000000
07-25 22:06:06.836+0600 D/avoidrickshaw(32394): event-values: 0.211167, -0.075374, 10.180264, 0.000000
07-25 22:06:06.896+0600 D/avoidrickshaw(32394): event-values: 0.194417, -0.089731, 10.172487, 0.000000
07-25 22:06:06.956+0600 D/avoidrickshaw(32394): event-values: 0.178265, -0.084945, 10.154541, 0.000000
07-25 22:06:07.016+0600 D/avoidrickshaw(32394): event-values: 0.196810, -0.084347, 10.177871, 0.000000
07-25 22:06:07.076+0600 D/avoidrickshaw(32394): event-values: 0.210568, -0.080160, 10.176675, 0.000000
07-25 22:06:07.136+0600 D/avoidrickshaw(32394): event-values: 0.182453, -0.072383, 10.158132, 0.000000
07-25 22:06:07.196+0600 D/avoidrickshaw(32394): event-values: 0.188435, -0.072981, 10.180862, 0.000000
07-25 22:06:07.256+0600 D/avoidrickshaw(32394): event-values: 0.212363, -0.066999, 10.174880, 0.000000
07-25 22:06:07.316+0600 D/avoidrickshaw(32394): event-values: 0.198006, -0.077169, 10.160523, 0.000000
07-25 22:06:07.376+0600 D/avoidrickshaw(32394): event-values: 0.196810, -0.078365, 10.171290, 0.000000
07-25 22:06:07.436+0600 D/avoidrickshaw(32394): event-values: 0.186640, -0.061017, 10.183852, 0.000000
07-25 22:06:07.496+0600 D/avoidrickshaw(32394): event-values: 0.198604, -0.074776, 10.173084, 0.000000
07-25 22:06:07.556+0600 D/avoidrickshaw(32394): event-values: 0.196211, -0.070588, 10.155738, 0.000000
07-25 22:06:07.617+0600 D/avoidrickshaw(32394): event-values: 0.199202, -0.101097, 10.183254, 0.000000
07-25 22:06:07.677+0600 D/avoidrickshaw(32394): event-values: 0.211765, -0.058026, 10.161720, 0.000000
07-25 22:06:07.737+0600 D/avoidrickshaw(32394): event-values: 0.215354, -0.080160, 10.146765, 0.000000
07-25 22:06:07.797+0600 D/avoidrickshaw(32394): event-values: 0.219541, -0.066401, 10.185647, 0.000000
07-25 22:06:07.857+0600 D/avoidrickshaw(32394): event-values: 0.189033, -0.081954, 10.183852, 0.000000
07-25 22:06:07.917+0600 D/avoidrickshaw(32394): event-values: 0.192622, -0.069392, 10.161720, 0.000000
07-25 22:06:07.977+0600 D/avoidrickshaw(32394): event-values: 0.183649, -0.069392, 10.156336, 0.000000
07-25 22:06:08.037+0600 D/avoidrickshaw(32394): event-values: 0.192024, -0.068794, 10.173084, 0.000000
07-25 22:06:08.097+0600 D/avoidrickshaw(32394): event-values: 0.181855, -0.074178, 10.169496, 0.000000
07-25 22:06:08.157+0600 D/avoidrickshaw(32394): event-values: 0.179462, -0.081954, 10.173683, 0.000000
07-25 22:06:08.217+0600 D/avoidrickshaw(32394): event-values: 0.208176, -0.064008, 10.162319, 0.000000
07-25 22:06:08.277+0600 D/avoidrickshaw(32394): event-values: 0.189033, -0.080160, 10.164113, 0.000000
07-25 22:06:08.337+0600 D/avoidrickshaw(32394): event-values: 0.195015, -0.071785, 10.170094, 0.000000
07-25 22:06:08.397+0600 D/avoidrickshaw(32394): event-values: 0.151346, -0.092722, 10.194620, 0.000000
07-25 22:06:08.457+0600 D/avoidrickshaw(32394): event-values: 0.220738, -0.075972, 10.168897, 0.000000
07-25 22:06:08.517+0600 D/avoidrickshaw(32394): event-values: 0.190229, -0.059222, 10.180862, 0.000000
07-25 22:06:08.577+0600 D/avoidrickshaw(32394): event-values: 0.190229, -0.078963, 10.171888, 0.000000
07-25 22:06:08.638+0600 D/avoidrickshaw(32394): event-values: 0.218943, -0.074776, 10.173084, 0.000000
07-25 22:06:08.698+0600 D/avoidrickshaw(32394): event-values: 0.206381, -0.069990, 10.173084, 0.000000
07-25 22:06:08.758+0600 D/avoidrickshaw(32394): event-values: 0.195613, -0.087936, 10.183852, 0.000000
07-25 22:06:08.818+0600 D/avoidrickshaw(32394): event-values: 0.176471, -0.072383, 10.168897, 0.000000
07-25 22:06:08.878+0600 D/avoidrickshaw(32394): event-values: 0.202792, -0.071186, 10.165908, 0.000000
07-25 22:06:08.938+0600 D/avoidrickshaw(32394): event-values: 0.202792, -0.073579, 10.152746, 0.000000
07-25 22:06:08.998+0600 D/avoidrickshaw(32394): event-values: 0.185444, -0.071186, 10.178469, 0.000000
07-25 22:06:09.058+0600 D/avoidrickshaw(32394): event-values: 0.199801, -0.072981, 10.173084, 0.000000
07-25 22:06:09.118+0600 D/avoidrickshaw(32394): event-values: 0.208176, -0.081356, 10.161121, 0.000000
07-25 22:06:09.178+0600 D/avoidrickshaw(32394): event-values: 0.192622, -0.082552, 10.174880, 0.000000
07-25 22:06:09.238+0600 D/avoidrickshaw(32394): event-values: 0.198604, -0.074178, 10.166506, 0.000000
07-25 22:06:09.298+0600 D/avoidrickshaw(32394): event-values: 0.181256, -0.064008, 10.185050, 0.000000
07-25 22:06:09.358+0600 D/avoidrickshaw(32394): event-values: 0.201595, -0.087338, 10.156934, 0.000000
07-25 22:06:09.418+0600 D/avoidrickshaw(32394): event-values: 0.212363, -0.072981, 10.177871, 0.000000
07-25 22:06:09.478+0600 D/avoidrickshaw(32394): event-values: 0.189033, -0.079561, 10.185647, 0.000000
07-25 22:06:09.538+0600 D/avoidrickshaw(32394): event-values: 0.195015, -0.067597, 10.183254, 0.000000
07-25 22:06:09.598+0600 D/avoidrickshaw(32394): event-values: 0.201595, -0.062213, 10.181459, 0.000000
07-25 22:06:09.659+0600 D/avoidrickshaw(32394): event-values: 0.193819, -0.090329, 10.179665, 0.000000
07-25 22:06:09.719+0600 D/avoidrickshaw(32394): event-values: 0.193220, -0.077169, 10.161720, 0.000000
07-25 22:06:09.779+0600 D/avoidrickshaw(32394): event-values: 0.190828, -0.081356, 10.199407, 0.000000
07-25 22:06:09.839+0600 D/avoidrickshaw(32394): event-values: 0.175872, -0.076570, 10.171888, 0.000000
07-25 22:06:09.919+0600 D/avoidrickshaw(32394): horizontal_acc: 24.000000, vertical_acc: -1.000000
07-25 22:06:09.919+0600 D/avoidrickshaw(32394): previous lat: 23.742149, previous long: 90.411686
07-25 22:06:09.919+0600 D/avoidrickshaw(32394): current lat: 23.742160, current long: 90.411682
07-25 22:06:09.929+0600 D/avoidrickshaw(32394): because step count did not update, saving position only.
07-25 22:06:09.929+0600 D/avoidrickshaw(32394): event-values: 0.202193, -0.076570, 10.182656, 0.000000
07-25 22:06:09.959+0600 D/avoidrickshaw(32394): event-values: 0.185444, -0.073579, 10.183852, 0.000000
07-25 22:06:10.019+0600 D/avoidrickshaw(32394): event-values: 0.202193, -0.078963, 10.173084, 0.000000
07-25 22:06:10.079+0600 D/avoidrickshaw(32394): event-values: 0.194417, -0.080758, 10.180264, 0.000000
07-25 22:06:10.139+0600 D/avoidrickshaw(32394): event-values: 0.181855, -0.074178, 10.175477, 0.000000
07-25 22:06:10.199+0600 D/avoidrickshaw(32394): event-values: 0.197408, -0.073579, 10.161720, 0.000000
07-25 22:06:10.259+0600 D/avoidrickshaw(32394): event-values: 0.202193, -0.064606, 10.155140, 0.000000
07-25 22:06:10.319+0600 D/avoidrickshaw(32394): event-values: 0.202193, -0.086740, 10.163515, 0.000000
07-25 22:06:10.379+0600 D/avoidrickshaw(32394): event-values: 0.192622, -0.062213, 10.196415, 0.000000
07-25 22:06:10.439+0600 D/avoidrickshaw(32394): event-values: 0.190229, -0.075374, 10.186246, 0.000000
07-25 22:06:10.499+0600 D/avoidrickshaw(32394): event-values: 0.220738, -0.062213, 10.179067, 0.000000
07-25 22:06:10.559+0600 D/avoidrickshaw(32394): event-values: 0.203988, -0.076570, 10.180862, 0.000000
07-25 22:06:10.619+0600 D/avoidrickshaw(32394): event-values: 0.200399, -0.074178, 10.160523, 0.000000
07-25 22:06:10.680+0600 D/avoidrickshaw(32394): event-values: 0.209372, -0.076570, 10.176076, 0.000000
07-25 22:06:10.740+0600 D/avoidrickshaw(32394): event-values: 0.209970, -0.085543, 10.188639, 0.000000
07-25 22:06:10.800+0600 D/avoidrickshaw(32394): event-values: 0.205185, -0.061017, 10.165908, 0.000000
07-25 22:06:10.860+0600 D/avoidrickshaw(32394): event-values: 0.192622, -0.068794, 10.179665, 0.000000
07-25 22:06:10.920+0600 D/avoidrickshaw(32394): event-values: 0.190828, -0.063410, 10.171290, 0.000000
07-25 22:06:10.980+0600 D/avoidrickshaw(32394): event-values: 0.213559, -0.065204, 10.173084, 0.000000
07-25 22:06:11.040+0600 D/avoidrickshaw(32394): event-values: 0.216550, -0.074178, 10.178469, 0.000000
07-25 22:06:11.100+0600 D/avoidrickshaw(32394): event-values: 0.208176, -0.072981, 10.180264, 0.000000
07-25 22:06:11.160+0600 D/avoidrickshaw(32394): event-values: 0.195015, -0.070588, 10.177871, 0.000000
07-25 22:06:11.220+0600 D/avoidrickshaw(32394): event-values: 0.192024, -0.075972, 10.165309, 0.000000
07-25 22:06:11.280+0600 D/avoidrickshaw(32394): event-values: 0.190229, -0.072383, 10.170692, 0.000000
07-25 22:06:11.340+0600 D/avoidrickshaw(32394): event-values: 0.186640, -0.072981, 10.188639, 0.000000
07-25 22:06:11.400+0600 D/avoidrickshaw(32394): event-values: 0.187238, -0.075374, 10.175477, 0.000000
07-25 22:06:11.460+0600 D/avoidrickshaw(32394): event-values: 0.211167, -0.069990, 10.174880, 0.000000
07-25 22:06:11.520+0600 D/avoidrickshaw(32394): event-values: 0.188435, -0.072383, 10.171290, 0.000000
07-25 22:06:11.580+0600 D/avoidrickshaw(32394): event-values: 0.182453, -0.080160, 10.173084, 0.000000
07-25 22:06:11.640+0600 D/avoidrickshaw(32394): event-values: 0.171685, -0.065204, 10.146765, 0.000000
07-25 22:06:11.701+0600 D/avoidrickshaw(32394): event-values: 0.220140, -0.075972, 10.153345, 0.000000
07-25 22:06:11.761+0600 D/avoidrickshaw(32394): event-values: 0.221336, -0.074178, 10.182058, 0.000000
07-25 22:06:11.821+0600 D/avoidrickshaw(32394): event-values: 0.165703, -0.098106, 10.170692, 0.000000
07-25 22:06:11.881+0600 D/avoidrickshaw(32394): event-values: 0.183649, -0.053240, 10.174281, 0.000000
07-25 22:06:11.941+0600 D/avoidrickshaw(32394): event-values: 0.199202, -0.083151, 10.174281, 0.000000
07-25 22:06:11.991+0600 D/avoidrickshaw(32394): event-values: 0.205783, -0.061615, 10.174880, 0.000000
07-25 22:06:12.051+0600 D/avoidrickshaw(32394): event-values: 0.175274, -0.090927, 10.157533, 0.000000
07-25 22:06:12.111+0600 D/avoidrickshaw(32394): event-values: 0.176471, -0.100499, 10.182058, 0.000000
07-25 22:06:12.171+0600 D/avoidrickshaw(32394): event-values: 0.217149, -0.083749, 10.176076, 0.000000
07-25 22:06:12.231+0600 D/avoidrickshaw(32394): event-values: 0.189631, -0.076570, 10.184451, 0.000000
07-25 22:06:12.291+0600 D/avoidrickshaw(32394): event-values: 0.196810, -0.083749, 10.186844, 0.000000
07-25 22:06:12.351+0600 D/avoidrickshaw(32394): event-values: 0.195613, -0.068794, 10.180862, 0.000000
07-25 22:06:12.411+0600 D/avoidrickshaw(32394): event-values: 0.209970, -0.084347, 10.178469, 0.000000
07-25 22:06:12.471+0600 D/avoidrickshaw(32394): event-values: 0.207577, -0.090329, 10.165309, 0.000000
07-25 22:06:12.531+0600 D/avoidrickshaw(32394): event-values: 0.183649, -0.071186, 10.162319, 0.000000
07-25 22:06:12.591+0600 D/avoidrickshaw(32394): event-values: 0.178265, -0.074178, 10.170094, 0.000000
07-25 22:06:12.651+0600 D/avoidrickshaw(32394): event-values: 0.209372, -0.072383, 10.169496, 0.000000
07-25 22:06:12.712+0600 D/avoidrickshaw(32394): event-values: 0.209372, -0.087936, 10.171888, 0.000000
07-25 22:06:12.772+0600 D/avoidrickshaw(32394): event-values: 0.161516, -0.074178, 10.182058, 0.000000
07-25 22:06:12.832+0600 D/avoidrickshaw(32394): event-values: 0.198006, -0.071785, 10.174281, 0.000000
07-25 22:06:12.892+0600 D/avoidrickshaw(32394): event-values: 0.205185, -0.078963, 10.185647, 0.000000
07-25 22:06:12.952+0600 D/avoidrickshaw(32394): event-values: 0.205783, -0.071785, 10.182058, 0.000000
07-25 22:06:13.012+0600 D/avoidrickshaw(32394): event-values: 0.181855, -0.085543, 10.165908, 0.000000
07-25 22:06:13.072+0600 D/avoidrickshaw(32394): event-values: 0.197408, -0.061017, 10.183254, 0.000000
07-25 22:06:13.132+0600 D/avoidrickshaw(32394): event-values: 0.211167, -0.058026, 10.173084, 0.000000
07-25 22:06:13.192+0600 D/avoidrickshaw(32394): event-values: 0.209970, -0.063410, 10.172487, 0.000000
07-25 22:06:13.252+0600 D/avoidrickshaw(32394): event-values: 0.175274, -0.064606, 10.174281, 0.000000
07-25 22:06:13.312+0600 D/avoidrickshaw(32394): event-values: 0.206979, -0.076570, 10.162319, 0.000000
07-25 22:06:13.372+0600 D/avoidrickshaw(32394): event-values: 0.213559, -0.080758, 10.178469, 0.000000
07-25 22:06:13.432+0600 D/avoidrickshaw(32394): event-values: 0.203390, -0.067597, 10.153944, 0.000000
07-25 22:06:13.492+0600 D/avoidrickshaw(32394): event-values: 0.189631, -0.065803, 10.179665, 0.000000
07-25 22:06:13.552+0600 D/avoidrickshaw(32394): event-values: 0.189631, -0.071785, 10.176076, 0.000000
07-25 22:06:13.612+0600 D/avoidrickshaw(32394): event-values: 0.212363, -0.069990, 10.179067, 0.000000
07-25 22:06:13.672+0600 D/avoidrickshaw(32394): event-values: 0.207577, -0.081356, 10.161121, 0.000000
07-25 22:06:13.733+0600 D/avoidrickshaw(32394): event-values: 0.196211, -0.081356, 10.178469, 0.000000
07-25 22:06:13.793+0600 D/avoidrickshaw(32394): event-values: 0.192622, -0.064606, 10.182058, 0.000000
07-25 22:06:13.853+0600 D/avoidrickshaw(32394): event-values: 0.199202, -0.084945, 10.171888, 0.000000
07-25 22:06:13.913+0600 D/avoidrickshaw(32394): horizontal_acc: 8.000000, vertical_acc: -1.000000
07-25 22:06:13.913+0600 D/avoidrickshaw(32394): previous lat: 23.742160, previous long: 90.411682
07-25 22:06:13.913+0600 D/avoidrickshaw(32394): current lat: 23.742160, current long: 90.411682
07-25 22:06:13.913+0600 D/avoidrickshaw(32394): because step count did not update, distance not updated.
07-25 22:06:13.913+0600 D/avoidrickshaw(32394): event-values: 0.208176, -0.075374, 10.167104, 0.000000
07-25 22:06:13.973+0600 D/avoidrickshaw(32394): event-values: 0.185444, -0.069990, 10.195219, 0.000000
07-25 22:06:14.033+0600 D/avoidrickshaw(32394): event-values: 0.187837, -0.076570, 10.179665, 0.000000
07-25 22:06:14.093+0600 D/avoidrickshaw(32394): event-values: 0.226720, -0.089133, 10.182656, 0.000000
07-25 22:06:14.153+0600 D/avoidrickshaw(32394): event-values: 0.190828, -0.077767, 10.171290, 0.000000
07-25 22:06:14.213+0600 D/avoidrickshaw(32394): event-values: 0.196211, -0.066401, 10.183852, 0.000000
07-25 22:06:14.273+0600 D/avoidrickshaw(32394): event-values: 0.206979, -0.078963, 10.176675, 0.000000
07-25 22:06:14.333+0600 D/avoidrickshaw(32394): event-values: 0.199801, -0.078365, 10.170094, 0.000000
07-25 22:06:14.393+0600 D/avoidrickshaw(32394): event-values: 0.206381, -0.077767, 10.192227, 0.000000
07-25 22:06:14.453+0600 D/avoidrickshaw(32394): event-values: 0.204586, -0.075972, 10.164113, 0.000000
07-25 22:06:14.513+0600 D/avoidrickshaw(32394): event-values: 0.208774, -0.077169, 10.176076, 0.000000
07-25 22:06:14.573+0600 D/avoidrickshaw(32394): event-values: 0.192622, -0.075972, 10.192227, 0.000000
07-25 22:06:14.633+0600 D/avoidrickshaw(32394): event-values: 0.180658, -0.071186, 10.177272, 0.000000
07-25 22:06:14.693+0600 D/avoidrickshaw(32394): event-values: 0.192024, -0.072383, 10.176675, 0.000000
07-25 22:06:14.754+0600 D/avoidrickshaw(32394): event-values: 0.205783, -0.085543, 10.173683, 0.000000
07-25 22:06:14.814+0600 D/avoidrickshaw(32394): event-values: 0.190828, -0.060419, 10.158132, 0.000000
07-25 22:06:14.874+0600 D/avoidrickshaw(32394): event-values: 0.190229, -0.065803, 10.168897, 0.000000
07-25 22:06:14.934+0600 D/avoidrickshaw(32394): event-values: 0.221336, -0.073579, 10.188639, 0.000000
07-25 22:06:14.994+0600 D/avoidrickshaw(32394): event-values: 0.209372, -0.064606, 10.171888, 0.000000
07-25 22:06:15.054+0600 D/avoidrickshaw(32394): event-values: 0.205185, -0.082552, 10.163515, 0.000000
07-25 22:06:15.114+0600 D/avoidrickshaw(32394): event-values: 0.186640, -0.064606, 10.179067, 0.000000
07-25 22:06:15.174+0600 D/avoidrickshaw(32394): event-values: 0.199202, -0.056231, 10.164113, 0.000000
07-25 22:06:15.234+0600 D/avoidrickshaw(32394): event-values: 0.211765, -0.092124, 10.171290, 0.000000
07-25 22:06:15.294+0600 D/avoidrickshaw(32394): event-values: 0.199202, -0.075374, 10.170094, 0.000000
07-25 22:06:15.354+0600 D/avoidrickshaw(32394): event-values: 0.163908, -0.066999, 10.177272, 0.000000
07-25 22:06:15.414+0600 D/avoidrickshaw(32394): event-values: 0.202792, -0.075972, 10.170692, 0.000000
07-25 22:06:15.474+0600 D/avoidrickshaw(32394): event-values: 0.215354, -0.074776, 10.178469, 0.000000
07-25 22:06:15.534+0600 D/avoidrickshaw(32394): event-values: 0.186042, -0.074178, 10.174880, 0.000000
07-25 22:06:15.594+0600 D/avoidrickshaw(32394): event-values: 0.172283, -0.073579, 10.186844, 0.000000
07-25 22:06:15.654+0600 D/avoidrickshaw(32394): event-values: 0.211167, -0.074776, 10.182656, 0.000000
07-25 22:06:15.714+0600 D/avoidrickshaw(32394): event-values: 0.229711, -0.071186, 10.174281, 0.000000
07-25 22:06:15.775+0600 D/avoidrickshaw(32394): event-values: 0.180060, -0.073579, 10.177871, 0.000000
07-25 22:06:15.835+0600 D/avoidrickshaw(32394): event-values: 0.166899, -0.077767, 10.169496, 0.000000
07-25 22:06:15.895+0600 D/avoidrickshaw(32394): event-values: 0.208176, -0.072383, 10.177871, 0.000000
07-25 22:06:15.955+0600 D/avoidrickshaw(32394): event-values: 0.214756, -0.076570, 10.192227, 0.000000
07-25 22:06:16.015+0600 D/avoidrickshaw(32394): event-values: 0.173480, -0.070588, 10.166506, 0.000000
07-25 22:06:16.075+0600 D/avoidrickshaw(32394): event-values: 0.209372, -0.072981, 10.189237, 0.000000
07-25 22:06:16.135+0600 D/avoidrickshaw(32394): event-values: 0.223131, -0.068195, 10.164113, 0.000000
07-25 22:06:16.195+0600 D/avoidrickshaw(32394): event-values: 0.194417, -0.082552, 10.165309, 0.000000
07-25 22:06:16.255+0600 D
