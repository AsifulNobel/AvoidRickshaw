S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPD6
Build-Date: 2016.04.28 20:23:28

Crash Information
Process Name: avoidrickshaw
PID: 8484
Date: 2016-07-19 02:58:00+0600
Executable File Path: /opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 8484, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00002124
r2   = 0x00000006, r3   = 0xb44804c0
r4   = 0x00000002, r5   = 0xb4480000
r6   = 0xb678509c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0x00000002
r10  = 0x00000007, fp   = 0xbec74a88
ip   = 0x00000000, sp   = 0xbec7484c
lr   = 0xb667bf18, pc   = 0xb667ab84
cpsr = 0x200e0010

Memory Information
MemTotal:   730440 KB
MemFree:    118492 KB
Buffers:     43784 KB
Cached:     192936 KB
VmPeak:     117444 KB
VmSize:     116840 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       23608 KB
VmRSS:       23608 KB
VmData:      42796 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36236 KB
VmPTE:          86 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 8484 TID = 8484
8484 8487 9180 9187 9199 

Maps Information
b0501000 b0d00000 rw-p [stack:9199]
b1301000 b1b00000 rw-p [stack:9187]
b1c2e000 b1c36000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.49
b1c46000 b1c48000 r-xp /usr/lib/liblbs-agps.so.0.1.0
b1c58000 b1c66000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
b1c7d000 b1c7f000 r-xp /usr/lib/location/module/libwps.so.0.6.8_9
b1c8f000 b1c92000 r-xp /usr/lib/location/module/libgps.so.0.6.8_9
b1ca3000 b24a2000 rw-p [stack:9180]
b2527000 b252f000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2540000 b2541000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b2551000 b2565000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2579000 b257a000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b258a000 b258d000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b259e000 b259f000 r-xp /usr/lib/libxshmfence.so.1.0.0
b25af000 b25b1000 r-xp /usr/lib/libxcb-present.so.0.0.0
b25c1000 b25c3000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b25d3000 b25e3000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b25f3000 b25ff000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b284f000 b2851000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b2861000 b2867000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b2877000 b288b000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b289b000 b28b5000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b28c5000 b28cb000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
b28db000 b28e2000 r-xp /usr/lib/libeventsystem.so.0.0.1
b28f2000 b2915000 r-xp /usr/lib/libSLP-location-product.so.0.9.0
b2926000 b293d000 r-xp /usr/lib/libSLP-location.so.0.11.5_5
b294d000 b2954000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2965000 b296d000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b297d000 b2981000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
b2992000 b29a1000 r-xp /usr/lib/libcapi-location-manager.so.0.6.1_3
b29b3000 b29b9000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b29c9000 b29ce000 r-xp /opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw
b2aef000 b2bd2000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2c09000 b2c31000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2c43000 b3442000 rw-p [stack:8487]
b3442000 b3444000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3454000 b345e000 r-xp /lib/libnss_files-2.20-2014.11.so
b346f000 b3478000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3489000 b349a000 r-xp /lib/libnsl-2.20-2014.11.so
b34ad000 b34b3000 r-xp /lib/libnss_compat-2.20-2014.11.so
b34c4000 b34c5000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b34ed000 b34f4000 r-xp /usr/lib/libminizip.so.1.0.0
b3504000 b3509000 r-xp /usr/lib/libstorage.so.0.1
b3519000 b356e000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3584000 b3598000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b35a8000 b35ec000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b35fc000 b3604000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3614000 b3644000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3657000 b3710000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3724000 b3778000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3789000 b37a4000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b37b4000 b3875000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3888000 b389a000 r-xp /usr/lib/libefl-assist.so.0.1.0
b38aa000 b38ae000 r-xp /usr/lib/libogg.so.0.7.1
b38be000 b38e0000 r-xp /usr/lib/libvorbis.so.0.4.3
b38f0000 b39d4000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b39f0000 b39fd000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3a0e000 b3a51000 r-xp /usr/lib/libsndfile.so.1.0.25
b3a66000 b3aad000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3abe000 b3ac4000 r-xp /usr/lib/libjson-c.so.2.0.1
b3ad5000 b3adc000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3aec000 b3b2c000 r-xp /usr/lib/libmdm.so.1.2.10
b3b3c000 b3b44000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3b53000 b3b63000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3b84000 b3be4000 r-xp /usr/lib/libasound.so.2.0.0
b3bf6000 b3c2c000 r-xp /usr/lib/libpulse.so.0.16.2
b3c3d000 b3c40000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3c50000 b3c53000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3c63000 b3c68000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3c78000 b3c79000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3c89000 b3c94000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3ca8000 b3caf000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3cbf000 b3cc5000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3cd5000 b3cda000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3cea000 b3d05000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3d15000 b3d1c000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3d2c000 b3d2f000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3d40000 b3d6e000 r-xp /usr/lib/libidn.so.11.5.44
b3d7e000 b3d94000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3da5000 b3daf000 r-xp /usr/lib/libcares.so.2.1.0
b3dbf000 b3dc9000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3dd9000 b3ddb000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3deb000 b3dec000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3dfc000 b3e00000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3e11000 b3e39000 r-xp /usr/lib/libui-extension.so.0.1.0
b3e4a000 b3e73000 r-xp /usr/lib/libturbojpeg.so
b3e93000 b3e99000 r-xp /usr/lib/libgif.so.4.1.6
b3ea9000 b3eef000 r-xp /usr/lib/libcurl.so.4.3.0
b3f00000 b3f21000 r-xp /usr/lib/libexif.so.12.3.3
b3f3c000 b3f51000 r-xp /usr/lib/libtts.so
b3f62000 b3f6a000 r-xp /usr/lib/libfeedback.so.0.1.4
b3f7a000 b403a000 r-xp /usr/lib/libdali-core.so.0.0.0
b4045000 b4138000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b4158000 b4232000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b4249000 b424b000 r-xp /usr/lib/libboost_system.so.1.51.0
b425b000 b4261000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b4271000 b4294000 r-xp /usr/lib/libboost_thread.so.1.51.0
b42a5000 b42a7000 r-xp /usr/lib/libappsvc.so.0.1.0
b42b7000 b42b9000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b42ca000 b42cf000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b42e6000 b42e8000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b42f8000 b42ff000 r-xp /usr/lib/libsensord-share.so
b430f000 b4327000 r-xp /usr/lib/libsensor.so.1.1.0
b4338000 b433b000 r-xp /usr/lib/libXv.so.1.0.0
b434b000 b4350000 r-xp /usr/lib/libutilX.so.1.1.0
b4360000 b4365000 r-xp /usr/lib/libappcore-common.so.1.1
b4375000 b437c000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b438f000 b4393000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b43a4000 b446e000 r-xp /usr/lib/libCOREGL.so.4.0
b4485000 b4488000 r-xp /usr/lib/libuuid.so.1.3.0
b4499000 b44b0000 r-xp /usr/lib/libblkid.so.1.1.0
b44c1000 b44c3000 r-xp /usr/lib/libXau.so.6.0.0
b44d3000 b44d6000 r-xp /usr/lib/libEGL.so.1.4
b44de000 b44e4000 r-xp /usr/lib/libxcb-render.so.0.0.0
b44f4000 b44f6000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4507000 b4515000 r-xp /usr/lib/libGLESv2.so.2.0
b451e000 b4580000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4595000 b45ad000 r-xp /usr/lib/libmount.so.1.1.0
b45be000 b45d2000 r-xp /usr/lib/libxcb.so.1.1.0
b45e3000 b45ea000 r-xp /lib/libcrypt-2.20-2014.11.so
b4622000 b4633000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b4644000 b4646000 r-xp /usr/lib/libiri.so
b4656000 b4661000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4672000 b4687000 r-xp /lib/libexpat.so.1.5.2
b4699000 b4757000 r-xp /usr/lib/libcairo.so.2.11200.14
b476a000 b4772000 r-xp /usr/lib/libdrm.so.2.4.0
b4782000 b4785000 r-xp /usr/lib/libdri2.so.0.0.0
b4796000 b47e4000 r-xp /usr/lib/libssl.so.1.0.0
b47f9000 b4805000 r-xp /usr/lib/libeeze.so.1.13.0
b4815000 b481e000 r-xp /usr/lib/libethumb.so.1.13.0
b482e000 b4831000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4841000 b49f8000 r-xp /usr/lib/libcrypto.so.1.0.0
b564f000 b5658000 r-xp /usr/lib/libXi.so.6.1.0
b5668000 b566a000 r-xp /usr/lib/libXgesture.so.7.0.0
b567a000 b567e000 r-xp /usr/lib/libXtst.so.6.1.0
b568e000 b5694000 r-xp /usr/lib/libXrender.so.1.3.0
b56a4000 b56aa000 r-xp /usr/lib/libXrandr.so.2.2.0
b56bb000 b56bd000 r-xp /usr/lib/libXinerama.so.1.0.0
b56cd000 b56d0000 r-xp /usr/lib/libXfixes.so.3.1.0
b56e0000 b56eb000 r-xp /usr/lib/libXext.so.6.4.0
b56fb000 b56fd000 r-xp /usr/lib/libXdamage.so.1.1.0
b570d000 b570f000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5720000 b5802000 r-xp /usr/lib/libX11.so.6.3.0
b5815000 b581c000 r-xp /usr/lib/libXcursor.so.1.0.2
b582c000 b5844000 r-xp /usr/lib/libudev.so.1.6.0
b5846000 b5849000 r-xp /lib/libattr.so.1.1.0
b5859000 b5879000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b587b000 b5880000 r-xp /usr/lib/libffi.so.6.0.2
b5890000 b58a8000 r-xp /lib/libz.so.1.2.8
b58b8000 b58ba000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58ca000 b599f000 r-xp /usr/lib/libxml2.so.2.9.2
b59b4000 b5a4f000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a6b000 b5a6e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a7e000 b5a97000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5aa8000 b5ab9000 r-xp /lib/libresolv-2.20-2014.11.so
b5acd000 b5b47000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b5c000 b5b5e000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b6e000 b5b75000 r-xp /usr/lib/libembryo.so.1.13.0
b5b85000 b5b9d000 r-xp /usr/lib/libpng12.so.0.50.0
b5bae000 b5bd1000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bf2000 b5c06000 r-xp /usr/lib/libector.so.1.13.0
b5c17000 b5c2f000 r-xp /usr/lib/liblua-5.1.so
b5c40000 b5c97000 r-xp /usr/lib/libfreetype.so.6.11.3
b5cab000 b5cd3000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5ce4000 b5cf7000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d08000 b5d3f000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d50000 b5d5e000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d6e000 b5d76000 r-xp /usr/lib/libtbm.so.1.0.0
b5d86000 b5d93000 r-xp /usr/lib/libeio.so.1.13.0
b5da3000 b5da5000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5db5000 b5dba000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5dca000 b5de1000 r-xp /usr/lib/libefreet.so.1.13.0
b5df3000 b5e13000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e23000 b5e43000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e45000 b5e4b000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e5b000 b5e6c000 r-xp /usr/lib/libemotion.so.1.13.0
b5e7d000 b5e84000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e94000 b5ea3000 r-xp /usr/lib/libeo.so.1.13.0
b5eb4000 b5ec6000 r-xp /usr/lib/libecore_input.so.1.13.0
b5ed7000 b5edc000 r-xp /usr/lib/libecore_file.so.1.13.0
b5eec000 b5f05000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f15000 b5f32000 r-xp /usr/lib/libeet.so.1.13.0
b5f4b000 b5f93000 r-xp /usr/lib/libeina.so.1.13.0
b5fa4000 b5fb4000 r-xp /usr/lib/libefl.so.1.13.0
b5fc5000 b60aa000 r-xp /usr/lib/libicuuc.so.51.1
b60c7000 b6207000 r-xp /usr/lib/libicui18n.so.51.1
b621e000 b6256000 r-xp /usr/lib/libecore_x.so.1.13.0
b6268000 b626b000 r-xp /lib/libcap.so.2.21
b627b000 b62a4000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62b5000 b62bc000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62ce000 b6305000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6316000 b6401000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6414000 b648d000 r-xp /usr/lib/libsqlite3.so.0.8.6
b649f000 b64a4000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64b4000 b64be000 r-xp /usr/lib/libvconf.so.0.2.45
b64ce000 b64d0000 r-xp /usr/lib/libvasum.so.0.3.1
b64e0000 b64e2000 r-xp /usr/lib/libttrace.so.1.1
b64f2000 b64f5000 r-xp /usr/lib/libiniparser.so.0
b6505000 b652b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b653b000 b6540000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6551000 b6568000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6579000 b65e4000 r-xp /lib/libm-2.20-2014.11.so
b65f5000 b65fb000 r-xp /lib/librt-2.20-2014.11.so
b660c000 b6619000 r-xp /usr/lib/libunwind.so.8.0.1
b664f000 b6773000 r-xp /lib/libc-2.20-2014.11.so
b6788000 b67a1000 r-xp /lib/libgcc_s-4.9.so.1
b67b1000 b6893000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68a4000 b68ce000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68df000 b691b000 r-xp /usr/lib/libsystemd.so.0.4.0
b691d000 b699f000 r-xp /usr/lib/libedje.so.1.13.0
b69b2000 b69d0000 r-xp /usr/lib/libecore.so.1.13.0
b69f0000 b6b77000 r-xp /usr/lib/libevas.so.1.13.0
b6bac000 b6bc0000 r-xp /lib/libpthread-2.20-2014.11.so
b6bd4000 b6e09000 r-xp /usr/lib/libelementary.so.1.13.0
b6e37000 b6e3b000 r-xp /usr/lib/libsmack.so.1.0.0
b6e4b000 b6e52000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e62000 b6e64000 r-xp /usr/lib/libdlog.so.0.0.0
b6e74000 b6e77000 r-xp /usr/lib/libbundle.so.0.1.22
b6e87000 b6e89000 r-xp /lib/libdl-2.20-2014.11.so
b6e9a000 b6eb2000 r-xp /usr/lib/libaul.so.0.1.0
b6ec6000 b6ecb000 r-xp /usr/lib/libappcore-efl.so.1.1
b6edc000 b6ee9000 r-xp /usr/lib/liblptcp.so
b6efb000 b6eff000 r-xp /usr/lib/libsys-assert.so
b6f10000 b6f30000 r-xp /lib/ld-2.20-2014.11.so
b6f41000 b6f46000 r-xp /usr/bin/launchpad-loader
b733f000 b76a8000 rw-p [heap]
bec55000 bec76000 rw-p [stack]
b733f000 b76a8000 rw-p [heap]
bec55000 bec76000 rw-p [stack]
End of Maps Information

Callstack Information (PID:8484)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb667ab84) [/lib/libc.so.6] + 0x2bb84
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
07-18 23:31:14.685+0600 I/Tizen::System( 1367): (259) > Active app [org.exampl], current [com.samsun] 
07-18 23:31:14.685+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 23:31:14.695+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 23:31:15.345+0600 I/Tizen::App( 1367): (499) > LaunchedApp(org.example.uicomponents)
07-18 23:31:15.345+0600 I/Tizen::App( 1367): (733) > Finished invoking application event listener for org.example.uicomponents, 4035.
07-18 23:31:49.979+0600 I/uicomponents( 4035): Hover button is clicked and 'clicked' callback is called.
07-18 23:31:51.431+0600 E/uicomponents( 4035): Can't get screen reader app context - error code: -17891327
07-18 23:31:51.441+0600 E/uicomponents( 4035): Can't get screen reader app context - error code: -17891327
07-18 23:31:51.611+0600 I/Tizen::System( 1367): (259) > Active app [com.samsun], current [org.exampl] 
07-18 23:31:51.611+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 23:31:51.611+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 23:31:52.041+0600 I/Tizen::App( 1367): (243) > App[org.example.uicomponents] pid[4035] terminate event is forwarded
07-18 23:31:52.041+0600 I/Tizen::System( 1367): (256) > osp.accessorymanager.service provider is found.
07-18 23:31:52.041+0600 I/Tizen::System( 1367): (196) > Accessory Owner is removed [org.example.uicomponents, 4035, ]
07-18 23:31:52.041+0600 I/Tizen::System( 1367): (256) > osp.system.service provider is found.
07-18 23:31:52.041+0600 I/Tizen::App( 1367): (506) > TerminatedApp(org.example.uicomponents)
07-18 23:31:52.041+0600 I/Tizen::App( 1367): (512) > Not registered pid(4035)
07-18 23:31:52.041+0600 I/Tizen::System( 1367): (246) > Terminated app [org.example.uicomponents]
07-18 23:31:52.041+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 23:31:52.051+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 23:31:52.051+0600 I/Tizen::App( 1367): (782) > Finished invoking application event listener for org.example.uicomponents, 4035.
07-18 23:31:53.442+0600 I/Tizen::System( 1367): (259) > Active app [org.exampl], current [com.samsun] 
07-18 23:31:53.442+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 23:31:53.452+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 23:31:54.053+0600 I/Tizen::App( 1367): (499) > LaunchedApp(org.example.uicomponents)
07-18 23:31:54.053+0600 I/Tizen::App( 1367): (733) > Finished invoking application event listener for org.example.uicomponents, 5538.
07-18 23:34:47.612+0600 E/uicomponents( 5538): Can't get screen reader app context - error code: -17891327
07-18 23:34:47.622+0600 E/uicomponents( 5538): Can't get screen reader app context - error code: -17891327
07-18 23:34:47.803+0600 I/Tizen::System( 1367): (259) > Active app [com.samsun], current [org.exampl] 
07-18 23:34:47.803+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 23:34:47.813+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 23:34:48.273+0600 I/Tizen::App( 1367): (243) > App[org.example.uicomponents] pid[5538] terminate event is forwarded
07-18 23:34:48.273+0600 I/Tizen::System( 1367): (256) > osp.accessorymanager.service provider is found.
07-18 23:34:48.273+0600 I/Tizen::System( 1367): (196) > Accessory Owner is removed [org.example.uicomponents, 5538, ]
07-18 23:34:48.273+0600 I/Tizen::System( 1367): (256) > osp.system.service provider is found.
07-18 23:34:48.273+0600 I/Tizen::App( 1367): (506) > TerminatedApp(org.example.uicomponents)
07-18 23:34:48.273+0600 I/Tizen::App( 1367): (512) > Not registered pid(5538)
07-18 23:34:48.273+0600 I/Tizen::System( 1367): (246) > Terminated app [org.example.uicomponents]
07-18 23:34:48.283+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 23:34:48.293+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 23:34:48.293+0600 I/Tizen::App( 1367): (782) > Finished invoking application event listener for org.example.uicomponents, 5538.
07-18 23:34:49.795+0600 I/Tizen::System( 1367): (259) > Active app [com.samsun], current [com.samsun] 
07-18 23:34:49.795+0600 I/Tizen::System( 1367): (273) > Current App[com.samsun] is already actived.
07-18 23:34:49.985+0600 I/Tizen::App( 1367): (499) > LaunchedApp(com.samsung.weather-m-agent)
07-18 23:34:49.985+0600 I/Tizen::App( 1367): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 6524.
07-18 23:34:51.406+0600 I/Tizen::App( 1367): (243) > App[com.samsung.weather-m-agent] pid[6524] terminate event is forwarded
07-18 23:34:51.406+0600 I/Tizen::System( 1367): (256) > osp.accessorymanager.service provider is found.
07-18 23:34:51.406+0600 I/Tizen::System( 1367): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 6524, ]
07-18 23:34:51.406+0600 I/Tizen::System( 1367): (256) > osp.system.service provider is found.
07-18 23:34:51.406+0600 I/Tizen::App( 1367): (506) > TerminatedApp(com.samsung.weather-m-agent)
07-18 23:34:51.406+0600 I/Tizen::App( 1367): (512) > Not registered pid(6524)
07-18 23:34:51.406+0600 I/Tizen::System( 1367): (246) > Terminated app [com.samsung.weather-m-agent]
07-18 23:34:51.406+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 23:34:51.416+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 23:34:51.416+0600 I/Tizen::App( 1367): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 6524.
07-18 23:36:58.900+0600 I/Tizen::System( 1367): (280) > The screen has been turned on.
07-18 23:36:58.900+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 23:36:58.961+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 23:36:58.971+0600 I/Tizen::App( 1367): (499) > LaunchedApp(com.samsung.weather-m-agent)
07-18 23:36:58.971+0600 I/Tizen::App( 1367): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 7197.
07-18 23:36:59.641+0600 I/Tizen::System( 1367): (259) > Active app [com.samsun], current [com.samsun] 
07-18 23:36:59.641+0600 I/Tizen::System( 1367): (273) > Current App[com.samsun] is already actived.
07-18 23:36:59.731+0600 I/Tizen::System( 1367): (340) > Setting event[http://tizen.org/setting/screen.wallpaper.lock] is occured.
07-18 23:36:59.731+0600 I/Tizen::System( 1367): (351) > The key is http://tizen.org/setting/screen.wallpaper.lock.
07-18 23:36:59.731+0600 I/Tizen::System( 1367): (355) > Try to awake client processes.
07-18 23:36:59.731+0600 I/Tizen::System( 1367): (362) > Event is delivered to b8203c50.
07-18 23:37:00.452+0600 I/Tizen::App( 1367): (243) > App[com.samsung.weather-m-agent] pid[7197] terminate event is forwarded
07-18 23:37:00.452+0600 I/Tizen::System( 1367): (256) > osp.accessorymanager.service provider is found.
07-18 23:37:00.452+0600 I/Tizen::System( 1367): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 7197, ]
07-18 23:37:00.452+0600 I/Tizen::System( 1367): (256) > osp.system.service provider is found.
07-18 23:37:00.452+0600 I/Tizen::App( 1367): (506) > TerminatedApp(com.samsung.weather-m-agent)
07-18 23:37:00.452+0600 I/Tizen::App( 1367): (512) > Not registered pid(7197)
07-18 23:37:00.452+0600 I/Tizen::System( 1367): (246) > Terminated app [com.samsung.weather-m-agent]
07-18 23:37:00.452+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 23:37:00.462+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 23:37:00.462+0600 I/Tizen::App( 1367): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 7197.
07-18 23:46:39.957+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.avoidrickshaw, key: start, val: update
07-18 23:46:39.957+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.avoidrickshaw], Key = [start], Value = [update], install = [96]
07-18 23:46:39.967+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.avoidrickshaw, key: install_percent, val: 30
07-18 23:46:39.967+0600 I/Tizen::App( 1367): (119) > InstallationInProgress [30]
07-18 23:46:39.967+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.avoidrickshaw], Key = [install_percent], Value = [30], install = [1]
07-18 23:46:42.220+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.avoidrickshaw, key: end, val: fail
07-18 23:46:42.220+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.avoidrickshaw], Key = [end], Value = [fail], install = [1]
07-18 23:46:46.964+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.avoidrickshaw, key: start, val: install
07-18 23:46:46.964+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.avoidrickshaw], Key = [start], Value = [install], install = [1]
07-18 23:46:46.984+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.avoidrickshaw, key: install_percent, val: 30
07-18 23:46:46.984+0600 I/Tizen::App( 1367): (119) > InstallationInProgress [30]
07-18 23:46:46.984+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.avoidrickshaw], Key = [install_percent], Value = [30], install = [1]
07-18 23:46:47.515+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.avoidrickshaw, key: install_percent, val: 60
07-18 23:46:47.515+0600 I/Tizen::App( 1367): (119) > InstallationInProgress [60]
07-18 23:46:47.515+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.avoidrickshaw], Key = [install_percent], Value = [60], install = [1]
07-18 23:46:47.575+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.avoidrickshaw, key: install_percent, val: 100
07-18 23:46:47.585+0600 I/Tizen::App( 1367): (119) > InstallationInProgress [100]
07-18 23:46:47.585+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.avoidrickshaw], Key = [install_percent], Value = [100], install = [1]
07-18 23:46:48.296+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.avoidrickshaw, key: end, val: ok
07-18 23:46:48.296+0600 I/Tizen::App( 1367): (78) > Installation is Completed. [Package = org.example.avoidrickshaw]
07-18 23:46:48.296+0600 I/Tizen::App( 1367): (671) > Enter. package(org.example.avoidrickshaw), installationResult(0)
07-18 23:46:48.346+0600 I/Tizen::App( 1367): (1360) > package(org.example.avoidrickshaw), version(1.0.0), type(tpk), displayName(avoidrickshaw), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.avoidrickshaw), storeClient(), appRootPath(/opt/usr/apps/org.example.avoidrickshaw)
07-18 23:46:48.356+0600 I/Tizen::App( 1367): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.avoidrickshaw]
07-18 23:46:48.386+0600 I/Tizen::App( 1367): (416) > appName = [avoidrickshaw]
07-18 23:46:48.386+0600 I/Tizen::App( 1367): (509) > exe = [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw], displayName = [avoidrickshaw], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
07-18 23:46:48.386+0600 I/Tizen::App( 1367): (683) > Application count(1) in this package
07-18 23:46:48.386+0600 I/Tizen::App( 1367): (840) > Enter.
07-18 23:46:48.386+0600 I/Tizen::App( 1367): (703) > Exit.
07-18 23:46:48.386+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.avoidrickshaw], Key = [end], Value = [ok], install = [1]
07-18 23:46:48.396+0600 I/Tizen::App( 1367): (416) > appName = [avoidrickshaw]
07-18 23:46:48.396+0600 I/Tizen::App( 1367): (509) > exe = [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw], displayName = [avoidrickshaw], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
07-18 23:46:48.396+0600 I/Tizen::App( 1367): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.avoidrickshaw.info]
07-18 23:46:48.396+0600 I/Tizen::App( 1367): (131) > Enter
07-18 23:46:48.406+0600 I/Tizen::App( 1367): (137) > org.example.avoidrickshaw does not have launch condition
07-18 23:46:48.406+0600 I/Tizen::App( 1367): (883) > Exit.
07-18 23:46:53.120+0600 I/Tizen::System( 1367): (458) > org.tizen.system.deviced.display - CurrentBrightness (0)
07-18 23:46:54.482+0600 I/Tizen::System( 1367): (259) > Active app [org.exampl], current [com.samsun] 
07-18 23:46:54.482+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 23:46:54.502+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 23:46:54.502+0600 I/Tizen::System( 1367): (458) > org.tizen.system.deviced.display - CurrentBrightness (46)
07-18 23:46:55.142+0600 I/Tizen::App( 1367): (499) > LaunchedApp(org.example.avoidrickshaw)
07-18 23:46:55.142+0600 I/Tizen::App( 1367): (733) > Finished invoking application event listener for org.example.avoidrickshaw, 5725.
07-18 23:47:00.838+0600 I/Tizen::System( 1367): (259) > Active app [com.samsun], current [org.exampl] 
07-18 23:47:00.838+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 23:47:00.848+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 23:47:00.978+0600 I/Tizen::App( 1367): (499) > LaunchedApp(com.samsung.weather-m-agent)
07-18 23:47:00.978+0600 I/Tizen::App( 1367): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 9818.
07-18 23:47:02.399+0600 I/Tizen::App( 1367): (243) > App[com.samsung.weather-m-agent] pid[9818] terminate event is forwarded
07-18 23:47:02.399+0600 I/Tizen::System( 1367): (256) > osp.accessorymanager.service provider is found.
07-18 23:47:02.399+0600 I/Tizen::System( 1367): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 9818, ]
07-18 23:47:02.399+0600 I/Tizen::System( 1367): (256) > osp.system.service provider is found.
07-18 23:47:02.399+0600 I/Tizen::App( 1367): (506) > TerminatedApp(com.samsung.weather-m-agent)
07-18 23:47:02.399+0600 I/Tizen::App( 1367): (512) > Not registered pid(9818)
07-18 23:47:02.399+0600 I/Tizen::System( 1367): (246) > Terminated app [com.samsung.weather-m-agent]
07-18 23:47:02.399+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 23:47:02.870+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 23:47:02.870+0600 I/Tizen::App( 1367): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 9818.
07-18 23:47:02.870+0600 I/Tizen::System( 1367): (280) > The screen has been turned on.
07-18 23:47:02.870+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 23:47:02.880+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 23:47:02.890+0600 I/Tizen::App( 1367): (499) > LaunchedApp(com.samsung.weather-m-agent)
07-18 23:47:02.890+0600 I/Tizen::App( 1367): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 9838.
07-18 23:47:03.610+0600 I/Tizen::System( 1367): (259) > Active app [org.exampl], current [com.samsun] 
07-18 23:47:03.610+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 23:47:03.620+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 23:47:03.711+0600 I/Tizen::System( 1367): (340) > Setting event[http://tizen.org/setting/screen.wallpaper.lock] is occured.
07-18 23:47:03.711+0600 I/Tizen::System( 1367): (351) > The key is http://tizen.org/setting/screen.wallpaper.lock.
07-18 23:47:03.711+0600 I/Tizen::System( 1367): (355) > Try to awake client processes.
07-18 23:47:03.711+0600 I/Tizen::System( 1367): (362) > Event is delivered to b8203c50.
07-18 23:47:04.321+0600 I/Tizen::App( 1367): (243) > App[com.samsung.weather-m-agent] pid[9838] terminate event is forwarded
07-18 23:47:04.321+0600 I/Tizen::System( 1367): (256) > osp.accessorymanager.service provider is found.
07-18 23:47:04.321+0600 I/Tizen::System( 1367): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 9838, ]
07-18 23:47:04.321+0600 I/Tizen::System( 1367): (256) > osp.system.service provider is found.
07-18 23:47:04.321+0600 I/Tizen::App( 1367): (506) > TerminatedApp(com.samsung.weather-m-agent)
07-18 23:47:04.321+0600 I/Tizen::App( 1367): (512) > Not registered pid(9838)
07-18 23:47:04.321+0600 I/Tizen::System( 1367): (246) > Terminated app [com.samsung.weather-m-agent]
07-18 23:47:04.321+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 23:47:04.331+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 23:47:04.331+0600 I/Tizen::App( 1367): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 9838.
07-18 23:54:38.724+0600 I/Tizen::System( 1367): (259) > Active app [com.samsun], current [org.exampl] 
07-18 23:54:38.724+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 23:54:38.754+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 23:54:38.965+0600 I/Tizen::App( 1367): (243) > App[org.example.avoidrickshaw] pid[5725] terminate event is forwarded
07-18 23:54:38.965+0600 I/Tizen::System( 1367): (256) > osp.accessorymanager.service provider is found.
07-18 23:54:38.965+0600 I/Tizen::System( 1367): (196) > Accessory Owner is removed [org.example.avoidrickshaw, 5725, ]
07-18 23:54:38.965+0600 I/Tizen::System( 1367): (256) > osp.system.service provider is found.
07-18 23:54:38.965+0600 I/Tizen::App( 1367): (506) > TerminatedApp(org.example.avoidrickshaw)
07-18 23:54:38.965+0600 I/Tizen::App( 1367): (512) > Not registered pid(5725)
07-18 23:54:38.965+0600 I/Tizen::System( 1367): (246) > Terminated app [org.example.avoidrickshaw]
07-18 23:54:38.965+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 23:54:38.985+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 23:54:38.985+0600 I/Tizen::App( 1367): (782) > Finished invoking application event listener for org.example.avoidrickshaw, 5725.
07-18 23:54:45.241+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.avoidrickshaw, key: start, val: update
07-18 23:54:45.241+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.avoidrickshaw], Key = [start], Value = [update], install = [1]
07-18 23:54:45.261+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.avoidrickshaw, key: install_percent, val: 30
07-18 23:54:45.261+0600 I/Tizen::App( 1367): (119) > InstallationInProgress [30]
07-18 23:54:45.261+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.avoidrickshaw], Key = [install_percent], Value = [30], install = [1]
07-18 23:54:45.671+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.avoidrickshaw, key: end, val: fail
07-18 23:54:45.671+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.avoidrickshaw], Key = [end], Value = [fail], install = [96]
07-18 23:54:50.186+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.avoidrickshaw, key: start, val: install
07-18 23:54:50.186+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.avoidrickshaw], Key = [start], Value = [install], install = [96]
07-18 23:54:50.196+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.avoidrickshaw, key: install_percent, val: 30
07-18 23:54:50.196+0600 I/Tizen::App( 1367): (119) > InstallationInProgress [30]
07-18 23:54:50.196+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.avoidrickshaw], Key = [install_percent], Value = [30], install = [96]
07-18 23:54:50.726+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.avoidrickshaw, key: install_percent, val: 60
07-18 23:54:50.726+0600 I/Tizen::App( 1367): (119) > InstallationInProgress [60]
07-18 23:54:50.726+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.avoidrickshaw], Key = [install_percent], Value = [60], install = [96]
07-18 23:54:50.806+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.avoidrickshaw, key: install_percent, val: 100
07-18 23:54:50.806+0600 I/Tizen::App( 1367): (119) > InstallationInProgress [100]
07-18 23:54:50.806+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.avoidrickshaw], Key = [install_percent], Value = [100], install = [96]
07-18 23:54:51.537+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.avoidrickshaw, key: end, val: ok
07-18 23:54:51.537+0600 I/Tizen::App( 1367): (78) > Installation is Completed. [Package = org.example.avoidrickshaw]
07-18 23:54:51.537+0600 I/Tizen::App( 1367): (671) > Enter. package(org.example.avoidrickshaw), installationResult(0)
07-18 23:54:51.567+0600 I/Tizen::App( 1367): (1360) > package(org.example.avoidrickshaw), version(1.0.0), type(tpk), displayName(avoidrickshaw), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.avoidrickshaw), storeClient(), appRootPath(/opt/usr/apps/org.example.avoidrickshaw)
07-18 23:54:51.607+0600 I/Tizen::App( 1367): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.avoidrickshaw]
07-18 23:54:51.627+0600 I/Tizen::App( 1367): (416) > appName = [avoidrickshaw]
07-18 23:54:51.627+0600 I/Tizen::App( 1367): (509) > exe = [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw], displayName = [avoidrickshaw], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
07-18 23:54:51.647+0600 I/Tizen::App( 1367): (683) > Application count(1) in this package
07-18 23:54:51.647+0600 I/Tizen::App( 1367): (840) > Enter.
07-18 23:54:51.657+0600 I/Tizen::App( 1367): (703) > Exit.
07-18 23:54:51.657+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.avoidrickshaw], Key = [end], Value = [ok], install = [1]
07-18 23:54:51.667+0600 I/Tizen::App( 1367): (416) > appName = [avoidrickshaw]
07-18 23:54:51.667+0600 I/Tizen::App( 1367): (509) > exe = [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw], displayName = [avoidrickshaw], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
07-18 23:54:51.667+0600 I/Tizen::App( 1367): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.avoidrickshaw.info]
07-18 23:54:51.667+0600 I/Tizen::App( 1367): (131) > Enter
07-18 23:54:51.667+0600 I/Tizen::App( 1367): (137) > org.example.avoidrickshaw does not have launch condition
07-18 23:54:51.667+0600 I/Tizen::App( 1367): (883) > Exit.
07-18 23:57:03.015+0600 I/Tizen::System( 1367): (458) > org.tizen.system.deviced.display - CurrentBrightness (0)
07-18 23:57:05.828+0600 I/Tizen::System( 1367): (280) > The screen has been turned on.
07-18 23:57:05.828+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 23:57:05.828+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 23:57:05.838+0600 I/Tizen::System( 1367): (458) > org.tizen.system.deviced.display - CurrentBrightness (46)
07-18 23:57:12.184+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.avoidrickshaw, key: start, val: update
07-18 23:57:12.184+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.avoidrickshaw], Key = [start], Value = [update], install = [1]
07-18 23:57:12.194+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.avoidrickshaw, key: install_percent, val: 30
07-18 23:57:12.194+0600 I/Tizen::App( 1367): (119) > InstallationInProgress [30]
07-18 23:57:12.194+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.avoidrickshaw], Key = [install_percent], Value = [30], install = [1]
07-18 23:57:12.565+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.avoidrickshaw, key: end, val: fail
07-18 23:57:12.565+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.avoidrickshaw], Key = [end], Value = [fail], install = [1]
07-18 23:57:17.039+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.avoidrickshaw, key: start, val: install
07-18 23:57:17.039+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.avoidrickshaw], Key = [start], Value = [install], install = [1]
07-18 23:57:17.059+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.avoidrickshaw, key: install_percent, val: 30
07-18 23:57:17.059+0600 I/Tizen::App( 1367): (119) > InstallationInProgress [30]
07-18 23:57:17.059+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.avoidrickshaw], Key = [install_percent], Value = [30], install = [1]
07-18 23:57:17.579+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.avoidrickshaw, key: install_percent, val: 60
07-18 23:57:17.589+0600 I/Tizen::App( 1367): (119) > InstallationInProgress [60]
07-18 23:57:17.589+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.avoidrickshaw], Key = [install_percent], Value = [60], install = [1]
07-18 23:57:17.650+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.avoidrickshaw, key: install_percent, val: 100
07-18 23:57:17.650+0600 I/Tizen::App( 1367): (119) > InstallationInProgress [100]
07-18 23:57:17.650+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.avoidrickshaw], Key = [install_percent], Value = [100], install = [1]
07-18 23:57:18.380+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.avoidrickshaw, key: end, val: ok
07-18 23:57:18.380+0600 I/Tizen::App( 1367): (78) > Installation is Completed. [Package = org.example.avoidrickshaw]
07-18 23:57:18.380+0600 I/Tizen::App( 1367): (671) > Enter. package(org.example.avoidrickshaw), installationResult(0)
07-18 23:57:18.430+0600 I/Tizen::App( 1367): (1360) > package(org.example.avoidrickshaw), version(1.0.0), type(tpk), displayName(avoidrickshaw), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.avoidrickshaw), storeClient(), appRootPath(/opt/usr/apps/org.example.avoidrickshaw)
07-18 23:57:18.450+0600 I/Tizen::App( 1367): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.avoidrickshaw]
07-18 23:57:18.470+0600 I/Tizen::App( 1367): (416) > appName = [avoidrickshaw]
07-18 23:57:18.470+0600 I/Tizen::App( 1367): (509) > exe = [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw], displayName = [avoidrickshaw], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
07-18 23:57:18.480+0600 I/Tizen::App( 1367): (683) > Application count(1) in this package
07-18 23:57:18.480+0600 I/Tizen::App( 1367): (840) > Enter.
07-18 23:57:18.490+0600 I/Tizen::App( 1367): (703) > Exit.
07-18 23:57:18.490+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.avoidrickshaw], Key = [end], Value = [ok], install = [1]
07-18 23:57:18.490+0600 I/Tizen::App( 1367): (416) > appName = [avoidrickshaw]
07-18 23:57:18.490+0600 I/Tizen::App( 1367): (509) > exe = [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw], displayName = [avoidrickshaw], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
07-18 23:57:18.490+0600 I/Tizen::App( 1367): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.avoidrickshaw.info]
07-18 23:57:18.490+0600 I/Tizen::App( 1367): (131) > Enter
07-18 23:57:18.530+0600 I/Tizen::App( 1367): (137) > org.example.avoidrickshaw does not have launch condition
07-18 23:57:18.530+0600 I/Tizen::App( 1367): (883) > Exit.
07-18 23:57:24.496+0600 I/Tizen::System( 1367): (259) > Active app [org.exampl], current [com.samsun] 
07-18 23:57:24.506+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 23:57:24.506+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 23:57:25.177+0600 I/Tizen::App( 1367): (499) > LaunchedApp(org.example.avoidrickshaw)
07-18 23:57:25.177+0600 I/Tizen::App( 1367): (733) > Finished invoking application event listener for org.example.avoidrickshaw, 9792.
07-18 23:58:03.074+0600 I/Tizen::System( 1367): (259) > Active app [com.samsun], current [org.exampl] 
07-18 23:58:03.074+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 23:58:03.084+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 23:58:03.304+0600 I/Tizen::App( 1367): (243) > App[org.example.avoidrickshaw] pid[9792] terminate event is forwarded
07-18 23:58:03.304+0600 I/Tizen::System( 1367): (256) > osp.accessorymanager.service provider is found.
07-18 23:58:03.304+0600 I/Tizen::System( 1367): (196) > Accessory Owner is removed [org.example.avoidrickshaw, 9792, ]
07-18 23:58:03.304+0600 I/Tizen::System( 1367): (256) > osp.system.service provider is found.
07-18 23:58:03.304+0600 I/Tizen::App( 1367): (506) > TerminatedApp(org.example.avoidrickshaw)
07-18 23:58:03.304+0600 I/Tizen::App( 1367): (512) > Not registered pid(9792)
07-18 23:58:03.304+0600 I/Tizen::System( 1367): (246) > Terminated app [org.example.avoidrickshaw]
07-18 23:58:03.304+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 23:58:03.324+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 23:58:03.324+0600 I/Tizen::App( 1367): (782) > Finished invoking application event listener for org.example.avoidrickshaw, 9792.
07-18 23:58:09.110+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.avoidrickshaw, key: start, val: update
07-18 23:58:09.110+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.avoidrickshaw], Key = [start], Value = [update], install = [1]
07-18 23:58:09.120+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.avoidrickshaw, key: install_percent, val: 30
07-18 23:58:09.120+0600 I/Tizen::App( 1367): (119) > InstallationInProgress [30]
07-18 23:58:09.120+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.avoidrickshaw], Key = [install_percent], Value = [30], install = [1]
07-18 23:58:09.470+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.avoidrickshaw, key: end, val: fail
07-18 23:58:09.470+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.avoidrickshaw], Key = [end], Value = [fail], install = [1]
07-18 23:58:14.525+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.avoidrickshaw, key: start, val: install
07-18 23:58:14.525+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.avoidrickshaw], Key = [start], Value = [install], install = [1]
07-18 23:58:14.545+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.avoidrickshaw, key: install_percent, val: 30
07-18 23:58:14.545+0600 I/Tizen::App( 1367): (119) > InstallationInProgress [30]
07-18 23:58:14.545+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.avoidrickshaw], Key = [install_percent], Value = [30], install = [1]
07-18 23:58:15.056+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.avoidrickshaw, key: install_percent, val: 60
07-18 23:58:15.056+0600 I/Tizen::App( 1367): (119) > InstallationInProgress [60]
07-18 23:58:15.056+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.avoidrickshaw], Key = [install_percent], Value = [60], install = [1]
07-18 23:58:15.126+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.avoidrickshaw, key: install_percent, val: 100
07-18 23:58:15.126+0600 I/Tizen::App( 1367): (119) > InstallationInProgress [100]
07-18 23:58:15.126+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.avoidrickshaw], Key = [install_percent], Value = [100], install = [1]
07-18 23:58:15.846+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.avoidrickshaw, key: end, val: ok
07-18 23:58:15.846+0600 I/Tizen::App( 1367): (78) > Installation is Completed. [Package = org.example.avoidrickshaw]
07-18 23:58:15.846+0600 I/Tizen::App( 1367): (671) > Enter. package(org.example.avoidrickshaw), installationResult(0)
07-18 23:58:15.886+0600 I/Tizen::App( 1367): (1360) > package(org.example.avoidrickshaw), version(1.0.0), type(tpk), displayName(avoidrickshaw), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.avoidrickshaw), storeClient(), appRootPath(/opt/usr/apps/org.example.avoidrickshaw)
07-18 23:58:15.916+0600 I/Tizen::App( 1367): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.avoidrickshaw]
07-18 23:58:15.956+0600 I/Tizen::App( 1367): (416) > appName = [avoidrickshaw]
07-18 23:58:15.956+0600 I/Tizen::App( 1367): (509) > exe = [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw], displayName = [avoidrickshaw], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
07-18 23:58:15.956+0600 I/Tizen::App( 1367): (683) > Application count(1) in this package
07-18 23:58:15.956+0600 I/Tizen::App( 1367): (703) > Exit.
07-18 23:58:15.956+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.avoidrickshaw], Key = [end], Value = [ok], install = [96]
07-18 23:58:15.966+0600 I/Tizen::App( 1367): (840) > Enter.
07-18 23:58:16.006+0600 I/Tizen::App( 1367): (416) > appName = [avoidrickshaw]
07-18 23:58:16.006+0600 I/Tizen::App( 1367): (509) > exe = [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw], displayName = [avoidrickshaw], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
07-18 23:58:16.006+0600 I/Tizen::App( 1367): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.avoidrickshaw.info]
07-18 23:58:16.006+0600 I/Tizen::App( 1367): (131) > Enter
07-18 23:58:16.006+0600 I/Tizen::App( 1367): (137) > org.example.avoidrickshaw does not have launch condition
07-18 23:58:16.006+0600 I/Tizen::App( 1367): (883) > Exit.
07-18 23:58:22.042+0600 I/Tizen::System( 1367): (259) > Active app [org.exampl], current [com.samsun] 
07-18 23:58:22.052+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-18 23:58:22.062+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-18 23:58:22.693+0600 I/Tizen::App( 1367): (499) > LaunchedApp(org.example.avoidrickshaw)
07-18 23:58:22.693+0600 I/Tizen::App( 1367): (733) > Finished invoking application event listener for org.example.avoidrickshaw, 12863.
07-19 00:06:58.837+0600 I/Tizen::System( 1367): (458) > org.tizen.system.deviced.display - CurrentBrightness (0)
07-19 00:07:06.534+0600 I/Tizen::System( 1367): (259) > Active app [com.samsun], current [org.exampl] 
07-19 00:07:06.534+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-19 00:07:06.594+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-19 00:07:06.594+0600 I/Tizen::System( 1367): (458) > org.tizen.system.deviced.display - CurrentBrightness (46)
07-19 00:07:06.674+0600 I/Tizen::App( 1367): (499) > LaunchedApp(com.samsung.weather-m-agent)
07-19 00:07:06.674+0600 I/Tizen::App( 1367): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 15529.
07-19 00:07:08.096+0600 I/Tizen::App( 1367): (243) > App[com.samsung.weather-m-agent] pid[15529] terminate event is forwarded
07-19 00:07:08.096+0600 I/Tizen::System( 1367): (256) > osp.accessorymanager.service provider is found.
07-19 00:07:08.096+0600 I/Tizen::System( 1367): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 15529, ]
07-19 00:07:08.096+0600 I/Tizen::System( 1367): (256) > osp.system.service provider is found.
07-19 00:07:08.096+0600 I/Tizen::App( 1367): (506) > TerminatedApp(com.samsung.weather-m-agent)
07-19 00:07:08.096+0600 I/Tizen::App( 1367): (512) > Not registered pid(15529)
07-19 00:07:08.096+0600 I/Tizen::System( 1367): (246) > Terminated app [com.samsung.weather-m-agent]
07-19 00:07:08.096+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-19 00:07:08.106+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-19 00:07:08.106+0600 I/Tizen::App( 1367): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 15529.
07-19 00:10:11.835+0600 I/Tizen::System( 1367): (280) > The screen has been turned on.
07-19 00:10:11.835+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-19 00:10:11.865+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-19 00:10:11.875+0600 I/Tizen::App( 1367): (499) > LaunchedApp(com.samsung.weather-m-agent)
07-19 00:10:11.875+0600 I/Tizen::App( 1367): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 16481.
07-19 00:10:12.706+0600 I/Tizen::System( 1367): (259) > Active app [org.exampl], current [com.samsun] 
07-19 00:10:12.706+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-19 00:10:12.706+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-19 00:10:12.786+0600 I/Tizen::System( 1367): (340) > Setting event[http://tizen.org/setting/screen.wallpaper.lock] is occured.
07-19 00:10:12.786+0600 I/Tizen::System( 1367): (351) > The key is http://tizen.org/setting/screen.wallpaper.lock.
07-19 00:10:12.786+0600 I/Tizen::System( 1367): (355) > Try to awake client processes.
07-19 00:10:12.786+0600 I/Tizen::System( 1367): (362) > Event is delivered to b8203c50.
07-19 00:10:13.316+0600 I/Tizen::App( 1367): (243) > App[com.samsung.weather-m-agent] pid[16481] terminate event is forwarded
07-19 00:10:13.316+0600 I/Tizen::System( 1367): (256) > osp.accessorymanager.service provider is found.
07-19 00:10:13.316+0600 I/Tizen::System( 1367): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 16481, ]
07-19 00:10:13.316+0600 I/Tizen::System( 1367): (256) > osp.system.service provider is found.
07-19 00:10:13.316+0600 I/Tizen::App( 1367): (506) > TerminatedApp(com.samsung.weather-m-agent)
07-19 00:10:13.316+0600 I/Tizen::App( 1367): (512) > Not registered pid(16481)
07-19 00:10:13.316+0600 I/Tizen::System( 1367): (246) > Terminated app [com.samsung.weather-m-agent]
07-19 00:10:13.316+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-19 00:10:13.316+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-19 00:10:13.316+0600 I/Tizen::App( 1367): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 16481.
07-19 00:10:14.157+0600 I/Tizen::System( 1367): (259) > Active app [com.samsun], current [org.exampl] 
07-19 00:10:14.157+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-19 00:10:14.157+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-19 00:10:16.259+0600 I/Tizen::System( 1367): (259) > Active app [org.exampl], current [com.samsun] 
07-19 00:10:16.259+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-19 00:10:16.259+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-19 00:10:16.910+0600 I/Tizen::App( 1367): (499) > LaunchedApp(org.example.uicomponents)
07-19 00:10:16.910+0600 I/Tizen::App( 1367): (733) > Finished invoking application event listener for org.example.uicomponents, 13353.
07-19 00:15:14.200+0600 I/Tizen::Net::Wifi( 1367): (742) > _WifiService is not registered.
07-19 00:15:14.210+0600 I/Tizen::Net::Wifi( 1367): (742) > _WifiService is not registered.
07-19 00:15:14.210+0600 I/Tizen::Net::Wifi( 1367): (742) > _WifiService is not registered.
07-19 00:15:14.300+0600 I/Tizen::System( 1367): (340) > Setting event[http://tizen.org/setting/network.wifi] is occured.
07-19 00:15:14.300+0600 I/Tizen::System( 1367): (362) > Event is delivered to b8203c50.
07-19 00:15:14.390+0600 I/Tizen::Net::Wifi( 1367): (742) > _WifiService is not registered.
07-19 00:15:15.051+0600 I/Tizen::Net::Wifi( 1367): (742) > _WifiService is not registered.
07-19 00:15:15.051+0600 I/Tizen::Net::Wifi( 1367): (742) > _WifiService is not registered.
07-19 00:15:15.111+0600 I/Tizen::Net::Wifi( 1367): (1085) > _WifiService is not registered.
07-19 00:15:16.322+0600 E/Tizen::App( 1367): (703) > Cannot acquire app for 16524.
07-19 00:15:16.362+0600 I/Tizen::App( 1367): (753) > [E_OBJ_NOT_FOUND] Cannot acquire app from pid 16524.
07-19 00:15:16.672+0600 I/Tizen::Net::Wifi( 1367): (742) > _WifiService is not registered.
07-19 00:19:50.940+0600 E/uicomponents(13353): Can't get screen reader app context - error code: -17891327
07-19 00:19:50.950+0600 E/uicomponents(13353): Can't get screen reader app context - error code: -17891327
07-19 00:19:51.080+0600 I/Tizen::System( 1367): (259) > Active app [com.samsun], current [org.exampl] 
07-19 00:19:51.080+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-19 00:19:51.090+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-19 00:19:51.560+0600 I/Tizen::App( 1367): (243) > App[org.example.uicomponents] pid[13353] terminate event is forwarded
07-19 00:19:51.560+0600 I/Tizen::System( 1367): (256) > osp.accessorymanager.service provider is found.
07-19 00:19:51.560+0600 I/Tizen::System( 1367): (196) > Accessory Owner is removed [org.example.uicomponents, 13353, ]
07-19 00:19:51.560+0600 I/Tizen::System( 1367): (256) > osp.system.service provider is found.
07-19 00:19:51.560+0600 I/Tizen::App( 1367): (506) > TerminatedApp(org.example.uicomponents)
07-19 00:19:51.560+0600 I/Tizen::App( 1367): (512) > Not registered pid(13353)
07-19 00:19:51.560+0600 I/Tizen::System( 1367): (246) > Terminated app [org.example.uicomponents]
07-19 00:19:51.560+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-19 00:19:51.580+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-19 00:19:51.580+0600 I/Tizen::App( 1367): (782) > Finished invoking application event listener for org.example.uicomponents, 13353.
07-19 00:19:54.844+0600 I/Tizen::App( 1367): (243) > App[org.example.avoidrickshaw] pid[12863] terminate event is forwarded
07-19 00:19:54.844+0600 I/Tizen::System( 1367): (256) > osp.accessorymanager.service provider is found.
07-19 00:19:54.844+0600 I/Tizen::System( 1367): (196) > Accessory Owner is removed [org.example.avoidrickshaw, 12863, ]
07-19 00:19:54.844+0600 I/Tizen::System( 1367): (256) > osp.system.service provider is found.
07-19 00:19:54.844+0600 I/Tizen::App( 1367): (506) > TerminatedApp(org.example.avoidrickshaw)
07-19 00:19:54.844+0600 I/Tizen::App( 1367): (512) > Not registered pid(12863)
07-19 00:19:54.844+0600 I/Tizen::System( 1367): (246) > Terminated app [org.example.avoidrickshaw]
07-19 00:19:54.844+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-19 00:19:54.854+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-19 00:19:54.854+0600 I/Tizen::App( 1367): (782) > Finished invoking application event listener for org.example.avoidrickshaw, 12863.
07-19 00:20:01.200+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.avoidrickshaw, key: start, val: update
07-19 00:20:01.200+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.avoidrickshaw], Key = [start], Value = [update], install = [1]
07-19 00:20:01.220+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.avoidrickshaw, key: install_percent, val: 30
07-19 00:20:01.220+0600 I/Tizen::App( 1367): (119) > InstallationInProgress [30]
07-19 00:20:01.220+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.avoidrickshaw], Key = [install_percent], Value = [30], install = [96]
07-19 00:20:01.610+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.avoidrickshaw, key: end, val: fail
07-19 00:20:01.610+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.avoidrickshaw], Key = [end], Value = [fail], install = [96]
07-19 00:20:06.175+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.avoidrickshaw, key: start, val: install
07-19 00:20:06.175+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.avoidrickshaw], Key = [start], Value = [install], install = [1]
07-19 00:20:06.195+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.avoidrickshaw, key: install_percent, val: 30
07-19 00:20:06.195+0600 I/Tizen::App( 1367): (119) > InstallationInProgress [30]
07-19 00:20:06.195+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.avoidrickshaw], Key = [install_percent], Value = [30], install = [1]
07-19 00:20:06.725+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.avoidrickshaw, key: install_percent, val: 60
07-19 00:20:06.725+0600 I/Tizen::App( 1367): (119) > InstallationInProgress [60]
07-19 00:20:06.725+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.avoidrickshaw], Key = [install_percent], Value = [60], install = [1]
07-19 00:20:06.805+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.avoidrickshaw, key: install_percent, val: 100
07-19 00:20:06.805+0600 I/Tizen::App( 1367): (119) > InstallationInProgress [100]
07-19 00:20:06.805+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.avoidrickshaw], Key = [install_percent], Value = [100], install = [1]
07-19 00:20:07.516+0600 I/Tizen::App( 1367): (1894) > PackageEventHandler - req: 13670002, pkg_type: tpk, pkg_name: org.example.avoidrickshaw, key: end, val: ok
07-19 00:20:07.516+0600 I/Tizen::App( 1367): (78) > Installation is Completed. [Package = org.example.avoidrickshaw]
07-19 00:20:07.516+0600 I/Tizen::App( 1367): (671) > Enter. package(org.example.avoidrickshaw), installationResult(0)
07-19 00:20:07.556+0600 I/Tizen::App( 1367): (1360) > package(org.example.avoidrickshaw), version(1.0.0), type(tpk), displayName(avoidrickshaw), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.avoidrickshaw), storeClient(), appRootPath(/opt/usr/apps/org.example.avoidrickshaw)
07-19 00:20:07.596+0600 I/Tizen::App( 1367): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.avoidrickshaw]
07-19 00:20:07.606+0600 I/Tizen::App( 1367): (416) > appName = [avoidrickshaw]
07-19 00:20:07.606+0600 I/Tizen::App( 1367): (509) > exe = [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw], displayName = [avoidrickshaw], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
07-19 00:20:07.606+0600 I/Tizen::App( 1367): (683) > Application count(1) in this package
07-19 00:20:07.606+0600 I/Tizen::App( 1367): (840) > Enter.
07-19 00:20:07.616+0600 I/Tizen::App( 1367): (416) > appName = [avoidrickshaw]
07-19 00:20:07.616+0600 I/Tizen::App( 1367): (509) > exe = [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw], displayName = [avoidrickshaw], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
07-19 00:20:07.616+0600 I/Tizen::App( 1367): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.avoidrickshaw.info]
07-19 00:20:07.616+0600 I/Tizen::App( 1367): (131) > Enter
07-19 00:20:07.626+0600 I/Tizen::App( 1367): (703) > Exit.
07-19 00:20:07.626+0600 I/Tizen::App( 1367): (1584) > Package = [org.example.avoidrickshaw], Key = [end], Value = [ok], install = [96]
07-19 00:20:07.626+0600 I/Tizen::App( 1367): (137) > org.example.avoidrickshaw does not have launch condition
07-19 00:20:07.626+0600 I/Tizen::App( 1367): (883) > Exit.
07-19 00:20:14.122+0600 I/Tizen::System( 1367): (259) > Active app [org.exampl], current [com.samsun] 
07-19 00:20:14.122+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-19 00:20:14.162+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-19 00:20:14.192+0600 I/Tizen::System( 1367): (340) > Setting event[http://tizen.org/setting/network.wifi] is occured.
07-19 00:20:14.192+0600 I/Tizen::System( 1367): (362) > Event is delivered to b8203c50.
07-19 00:20:14.573+0600 I/Tizen::App( 1367): (499) > LaunchedApp(org.example.avoidrickshaw)
07-19 00:20:14.573+0600 I/Tizen::App( 1367): (733) > Finished invoking application event listener for org.example.avoidrickshaw, 18090.
07-19 00:20:14.583+0600 I/Tizen::System( 1367): (340) > Setting event[http://tizen.org/setting/network.wifi] is occured.
07-19 00:20:14.583+0600 I/Tizen::System( 1367): (362) > Event is delivered to b8203c50.
07-19 00:20:16.625+0600 I/Tizen::System( 1367): (259) > Active app [com.samsun], current [org.exampl] 
07-19 00:20:16.625+0600 I/Tizen::Io( 1367): (729) > Entry not found
07-19 00:20:16.635+0600 I/Tizen::System( 1367): (157) > change brightness system value.
07-19 00:20:19.287+0600 I/Tizen::System( 1367): (340) > Setting event[http://tizen.org/setting/screen.rotation.auto] is occured.
07-19 00:20:19.287+0600 I/Tizen::System( 1367): (351) > The key is http://tizen.org/setting/screen.rotation.auto.
07-19 00:20:19.287+0600 I/Tizen::System( 1367): (355) > Try to awake client processes.
07-19 00:20:19.287+0600 I/Tizen::System( 1367): (362) > Event is delivered to b8203c50.
07-19 00:20:19.978+0600 I/Tizen::System( 1367): (340) > Setting event[http://tizen.org/setting/screen.rotation.auto]
