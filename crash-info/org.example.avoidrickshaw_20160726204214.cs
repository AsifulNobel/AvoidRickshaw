S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPD6
Build-Date: 2016.04.28 20:23:28

Crash Information
Process Name: avoidrickshaw
PID: 17726
Date: 2016-07-26 20:42:14+0600
Executable File Path: /opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 17726, uid 5000)

Register Information
r0   = 0x000001e0, r1   = 0xb76e0f60
r2   = 0x00000001, r3   = 0x00000005
r4   = 0xb6ad852d, r5   = 0xb60536ec
r6   = 0xb6040e30, r7   = 0x00000001
r8   = 0x00000005, r9   = 0x00000000
r10  = 0xb772a2e8, fp   = 0x00000000
ip   = 0x00000001, sp   = 0xbec22168
lr   = 0xb6039a17, pc   = 0xb6ad8546
cpsr = 0x600d0030

Memory Information
MemTotal:   730440 KB
MemFree:     43660 KB
Buffers:     46392 KB
Cached:     276168 KB
VmPeak:     116952 KB
VmSize:     116948 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24112 KB
VmRSS:       24112 KB
VmData:      42780 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36276 KB
VmPTE:          84 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 17726 TID = 17726
17726 17730 18612 18619 18779 

Maps Information
b03e3000 b0be2000 rw-p [stack:18779]
b13a0000 b1b9f000 rw-p [stack:18619]
b1b9f000 b1ba7000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.49
b1bb7000 b1bb9000 r-xp /usr/lib/liblbs-agps.so.0.1.0
b1bc9000 b1bd7000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
b1bee000 b1bf0000 r-xp /usr/lib/location/module/libwps.so.0.6.8_9
b1d0e000 b1d11000 r-xp /usr/lib/location/module/libgps.so.0.6.8_9
b1d22000 b2521000 rw-p [stack:18612]
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
b2a27000 b2a2e000 r-xp /usr/lib/libcapi-appfw-preference.so.0.3.1.0
b2a40000 b2a46000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2a56000 b2a5e000 r-xp /opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw
b2b7f000 b2c62000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2c99000 b2cc1000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2cd3000 b34d2000 rw-p [stack:17730]
b34d2000 b34d4000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b34e4000 b34ee000 r-xp /lib/libnss_files-2.20-2014.11.so
b34ff000 b3508000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3519000 b352a000 r-xp /lib/libnsl-2.20-2014.11.so
b353d000 b3543000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3554000 b3555000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b357d000 b3584000 r-xp /usr/lib/libminizip.so.1.0.0
b3594000 b3599000 r-xp /usr/lib/libstorage.so.0.1
b35a9000 b35fe000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3614000 b3628000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b3638000 b367c000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b368c000 b3694000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b36a4000 b36d4000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b36e7000 b37a0000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b37b4000 b3808000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3819000 b3834000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3844000 b3905000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3918000 b392a000 r-xp /usr/lib/libefl-assist.so.0.1.0
b393a000 b393e000 r-xp /usr/lib/libogg.so.0.7.1
b394e000 b3970000 r-xp /usr/lib/libvorbis.so.0.4.3
b3980000 b3a64000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b3a80000 b3a8d000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3a9e000 b3ae1000 r-xp /usr/lib/libsndfile.so.1.0.25
b3af6000 b3b3d000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3b4e000 b3b54000 r-xp /usr/lib/libjson-c.so.2.0.1
b3b65000 b3b6c000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3b7c000 b3bbc000 r-xp /usr/lib/libmdm.so.1.2.10
b3bcc000 b3bd4000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3be3000 b3bf3000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3c14000 b3c74000 r-xp /usr/lib/libasound.so.2.0.0
b3c86000 b3cbc000 r-xp /usr/lib/libpulse.so.0.16.2
b3ccd000 b3cd0000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3ce0000 b3ce3000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3cf3000 b3cf8000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3d08000 b3d09000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3d19000 b3d24000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3d38000 b3d3f000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3d4f000 b3d55000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3d65000 b3d6a000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3d7a000 b3d95000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3da5000 b3dac000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3dbc000 b3dbf000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3dd0000 b3dfe000 r-xp /usr/lib/libidn.so.11.5.44
b3e0e000 b3e24000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3e35000 b3e3f000 r-xp /usr/lib/libcares.so.2.1.0
b3e4f000 b3e59000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3e69000 b3e6b000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3e7b000 b3e7c000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3e8c000 b3e90000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3ea1000 b3ec9000 r-xp /usr/lib/libui-extension.so.0.1.0
b3eda000 b3f03000 r-xp /usr/lib/libturbojpeg.so
b3f23000 b3f29000 r-xp /usr/lib/libgif.so.4.1.6
b3f39000 b3f7f000 r-xp /usr/lib/libcurl.so.4.3.0
b3f90000 b3fb1000 r-xp /usr/lib/libexif.so.12.3.3
b3fcc000 b3fe1000 r-xp /usr/lib/libtts.so
b3ff2000 b3ffa000 r-xp /usr/lib/libfeedback.so.0.1.4
b400a000 b40ca000 r-xp /usr/lib/libdali-core.so.0.0.0
b40d5000 b41c8000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b41e8000 b42c2000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b42d9000 b42db000 r-xp /usr/lib/libboost_system.so.1.51.0
b42eb000 b42f1000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b4301000 b4324000 r-xp /usr/lib/libboost_thread.so.1.51.0
b4335000 b4337000 r-xp /usr/lib/libappsvc.so.0.1.0
b4347000 b4349000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b435a000 b435f000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4376000 b4378000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b4388000 b438f000 r-xp /usr/lib/libsensord-share.so
b439f000 b43b7000 r-xp /usr/lib/libsensor.so.1.1.0
b43c8000 b43cb000 r-xp /usr/lib/libXv.so.1.0.0
b43db000 b43e0000 r-xp /usr/lib/libutilX.so.1.1.0
b43f0000 b43f5000 r-xp /usr/lib/libappcore-common.so.1.1
b4405000 b440c000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b441f000 b4423000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b4434000 b44fe000 r-xp /usr/lib/libCOREGL.so.4.0
b4515000 b4518000 r-xp /usr/lib/libuuid.so.1.3.0
b4529000 b4540000 r-xp /usr/lib/libblkid.so.1.1.0
b4551000 b4553000 r-xp /usr/lib/libXau.so.6.0.0
b4563000 b4566000 r-xp /usr/lib/libEGL.so.1.4
b456e000 b4574000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4584000 b4586000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4597000 b45a5000 r-xp /usr/lib/libGLESv2.so.2.0
b45ae000 b4610000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4625000 b463d000 r-xp /usr/lib/libmount.so.1.1.0
b464e000 b4662000 r-xp /usr/lib/libxcb.so.1.1.0
b4673000 b467a000 r-xp /lib/libcrypt-2.20-2014.11.so
b46b2000 b46c3000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b46d4000 b46d6000 r-xp /usr/lib/libiri.so
b46e6000 b46f1000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4702000 b4717000 r-xp /lib/libexpat.so.1.5.2
b4729000 b47e7000 r-xp /usr/lib/libcairo.so.2.11200.14
b47fa000 b4802000 r-xp /usr/lib/libdrm.so.2.4.0
b4812000 b4815000 r-xp /usr/lib/libdri2.so.0.0.0
b4826000 b4874000 r-xp /usr/lib/libssl.so.1.0.0
b4889000 b4895000 r-xp /usr/lib/libeeze.so.1.13.0
b48a5000 b48ae000 r-xp /usr/lib/libethumb.so.1.13.0
b48be000 b48c1000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b48d1000 b4a88000 r-xp /usr/lib/libcrypto.so.1.0.0
b56df000 b56e8000 r-xp /usr/lib/libXi.so.6.1.0
b56f8000 b56fa000 r-xp /usr/lib/libXgesture.so.7.0.0
b570a000 b570e000 r-xp /usr/lib/libXtst.so.6.1.0
b571e000 b5724000 r-xp /usr/lib/libXrender.so.1.3.0
b5734000 b573a000 r-xp /usr/lib/libXrandr.so.2.2.0
b574b000 b574d000 r-xp /usr/lib/libXinerama.so.1.0.0
b575d000 b5760000 r-xp /usr/lib/libXfixes.so.3.1.0
b5770000 b577b000 r-xp /usr/lib/libXext.so.6.4.0
b578b000 b578d000 r-xp /usr/lib/libXdamage.so.1.1.0
b579d000 b579f000 r-xp /usr/lib/libXcomposite.so.1.0.0
b57b0000 b5892000 r-xp /usr/lib/libX11.so.6.3.0
b58a5000 b58ac000 r-xp /usr/lib/libXcursor.so.1.0.2
b58bc000 b58d4000 r-xp /usr/lib/libudev.so.1.6.0
b58d6000 b58d9000 r-xp /lib/libattr.so.1.1.0
b58e9000 b5909000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b590b000 b5910000 r-xp /usr/lib/libffi.so.6.0.2
b5920000 b5938000 r-xp /lib/libz.so.1.2.8
b5948000 b594a000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b595a000 b5a2f000 r-xp /usr/lib/libxml2.so.2.9.2
b5a44000 b5adf000 r-xp /usr/lib/libstdc++.so.6.0.20
b5afb000 b5afe000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5b0e000 b5b27000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b38000 b5b49000 r-xp /lib/libresolv-2.20-2014.11.so
b5b5d000 b5bd7000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5bec000 b5bee000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bfe000 b5c05000 r-xp /usr/lib/libembryo.so.1.13.0
b5c15000 b5c2d000 r-xp /usr/lib/libpng12.so.0.50.0
b5c3e000 b5c61000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c82000 b5c96000 r-xp /usr/lib/libector.so.1.13.0
b5ca7000 b5cbf000 r-xp /usr/lib/liblua-5.1.so
b5cd0000 b5d27000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d3b000 b5d63000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d74000 b5d87000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d98000 b5dcf000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5de0000 b5dee000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5dfe000 b5e06000 r-xp /usr/lib/libtbm.so.1.0.0
b5e16000 b5e23000 r-xp /usr/lib/libeio.so.1.13.0
b5e33000 b5e35000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e45000 b5e4a000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e5a000 b5e71000 r-xp /usr/lib/libefreet.so.1.13.0
b5e83000 b5ea3000 r-xp /usr/lib/libeldbus.so.1.13.0
b5eb3000 b5ed3000 r-xp /usr/lib/libecore_con.so.1.13.0
b5ed5000 b5edb000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5eeb000 b5efc000 r-xp /usr/lib/libemotion.so.1.13.0
b5f0d000 b5f14000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f24000 b5f33000 r-xp /usr/lib/libeo.so.1.13.0
b5f44000 b5f56000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f67000 b5f6c000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f7c000 b5f95000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5fa5000 b5fc2000 r-xp /usr/lib/libeet.so.1.13.0
b5fdb000 b6023000 r-xp /usr/lib/libeina.so.1.13.0
b6034000 b6044000 r-xp /usr/lib/libefl.so.1.13.0
b6055000 b613a000 r-xp /usr/lib/libicuuc.so.51.1
b6157000 b6297000 r-xp /usr/lib/libicui18n.so.51.1
b62ae000 b62e6000 r-xp /usr/lib/libecore_x.so.1.13.0
b62f8000 b62fb000 r-xp /lib/libcap.so.2.21
b630b000 b6334000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6345000 b634c000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b635e000 b6395000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b63a6000 b6491000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b64a4000 b651d000 r-xp /usr/lib/libsqlite3.so.0.8.6
b652f000 b6534000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6544000 b654e000 r-xp /usr/lib/libvconf.so.0.2.45
b655e000 b6560000 r-xp /usr/lib/libvasum.so.0.3.1
b6570000 b6572000 r-xp /usr/lib/libttrace.so.1.1
b6582000 b6585000 r-xp /usr/lib/libiniparser.so.0
b6595000 b65bb000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65cb000 b65d0000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65e1000 b65f8000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6609000 b6674000 r-xp /lib/libm-2.20-2014.11.so
b6685000 b668b000 r-xp /lib/librt-2.20-2014.11.so
b669c000 b66a9000 r-xp /usr/lib/libunwind.so.8.0.1
b66df000 b6803000 r-xp /lib/libc-2.20-2014.11.so
b6818000 b6831000 r-xp /lib/libgcc_s-4.9.so.1
b6841000 b6923000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6934000 b695e000 r-xp /usr/lib/libdbus-1.so.3.8.12
b696f000 b69ab000 r-xp /usr/lib/libsystemd.so.0.4.0
b69ad000 b6a2f000 r-xp /usr/lib/libedje.so.1.13.0
b6a42000 b6a60000 r-xp /usr/lib/libecore.so.1.13.0
b6a80000 b6c07000 r-xp /usr/lib/libevas.so.1.13.0
b6c3c000 b6c50000 r-xp /lib/libpthread-2.20-2014.11.so
b6c64000 b6e99000 r-xp /usr/lib/libelementary.so.1.13.0
b6ec7000 b6ecb000 r-xp /usr/lib/libsmack.so.1.0.0
b6edb000 b6ee2000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6ef2000 b6ef4000 r-xp /usr/lib/libdlog.so.0.0.0
b6f04000 b6f07000 r-xp /usr/lib/libbundle.so.0.1.22
b6f17000 b6f19000 r-xp /lib/libdl-2.20-2014.11.so
b6f2a000 b6f42000 r-xp /usr/lib/libaul.so.0.1.0
b6f56000 b6f5b000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f6c000 b6f79000 r-xp /usr/lib/liblptcp.so
b6f8b000 b6f8f000 r-xp /usr/lib/libsys-assert.so
b6fa0000 b6fc0000 r-xp /lib/ld-2.20-2014.11.so
b6fd1000 b6fd6000 r-xp /usr/bin/launchpad-loader
b750f000 b7808000 rw-p [heap]
bec02000 bec23000 rw-p [stack]
b750f000 b7808000 rw-p [heap]
bec02000 bec23000 rw-p [stack]
End of Maps Information

Callstack Information (PID:17726)
Call Stack Count: 1
 0: (0xb6ad8546) [/usr/lib/libevas.so.1] + 0x58546
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
07-25 22:05:09.36
