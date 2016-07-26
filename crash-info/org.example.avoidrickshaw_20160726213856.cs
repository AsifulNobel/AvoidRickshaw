S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPD6
Build-Date: 2016.04.28 20:23:28

Crash Information
Process Name: avoidrickshaw
PID: 29926
Date: 2016-07-26 21:38:56+0600
Executable File Path: /opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 29926, uid 5000)

Register Information
r0   = 0x8002e372, r1   = 0x00000000
r2   = 0xb42ea000, r3   = 0xb42ea010
r4   = 0xb29d51cb, r5   = 0xb76eb4e0
r6   = 0xb76f7368, r7   = 0xbeb06208
r8   = 0x800168b5, r9   = 0xb5ebb708
r10  = 0xb76f6358, fp   = 0x00000000
ip   = 0xb5fab120, sp   = 0xbeb061b0
lr   = 0xb5f6fbd9, pc   = 0xb29d435c
cpsr = 0x800e0030

Memory Information
MemTotal:   730440 KB
MemFree:     43140 KB
Buffers:     46520 KB
Cached:     276812 KB
VmPeak:     116952 KB
VmSize:     116948 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24108 KB
VmRSS:       24108 KB
VmData:      42780 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36276 KB
VmPTE:          84 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 29926 TID = 29926
29926 29929 31749 31756 31921 

Maps Information
b0351000 b0b50000 rw-p [stack:31921]
b1301000 b1b00000 rw-p [stack:31756]
b1c25000 b1c2d000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.49
b1c3d000 b1c3f000 r-xp /usr/lib/liblbs-agps.so.0.1.0
b1c4f000 b1c5d000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
b1c74000 b1c76000 r-xp /usr/lib/location/module/libwps.so.0.6.8_9
b1c86000 b1c89000 r-xp /usr/lib/location/module/libgps.so.0.6.8_9
b1c9a000 b2499000 rw-p [stack:31749]
b2515000 b251d000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b252e000 b252f000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b253f000 b2553000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2567000 b2568000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2578000 b257b000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b258c000 b258d000 r-xp /usr/lib/libxshmfence.so.1.0.0
b259d000 b259f000 r-xp /usr/lib/libxcb-present.so.0.0.0
b25af000 b25b1000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b25c1000 b25d1000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b25e1000 b25ed000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b283d000 b283f000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b284f000 b2855000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b2865000 b2879000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b2889000 b28a3000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b28b3000 b28b9000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
b28c9000 b28d0000 r-xp /usr/lib/libeventsystem.so.0.0.1
b28e0000 b2903000 r-xp /usr/lib/libSLP-location-product.so.0.9.0
b2914000 b292b000 r-xp /usr/lib/libSLP-location.so.0.11.5_5
b293b000 b2942000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2953000 b295b000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b296b000 b296f000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
b2980000 b298f000 r-xp /usr/lib/libcapi-location-manager.so.0.6.1_3
b299f000 b29a6000 r-xp /usr/lib/libcapi-appfw-preference.so.0.3.1.0
b29b8000 b29be000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b29ce000 b29d6000 r-xp /opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw
b2af7000 b2bda000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2c11000 b2c39000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2c4b000 b344a000 rw-p [stack:29929]
b344a000 b344c000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b345c000 b3466000 r-xp /lib/libnss_files-2.20-2014.11.so
b3477000 b3480000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3491000 b34a2000 r-xp /lib/libnsl-2.20-2014.11.so
b34b5000 b34bb000 r-xp /lib/libnss_compat-2.20-2014.11.so
b34cc000 b34cd000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b34f5000 b34fc000 r-xp /usr/lib/libminizip.so.1.0.0
b350c000 b3511000 r-xp /usr/lib/libstorage.so.0.1
b3521000 b3576000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b358c000 b35a0000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b35b0000 b35f4000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3604000 b360c000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b361c000 b364c000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b365f000 b3718000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b372c000 b3780000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3791000 b37ac000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b37bc000 b387d000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3890000 b38a2000 r-xp /usr/lib/libefl-assist.so.0.1.0
b38b2000 b38b6000 r-xp /usr/lib/libogg.so.0.7.1
b38c6000 b38e8000 r-xp /usr/lib/libvorbis.so.0.4.3
b38f8000 b39dc000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b39f8000 b3a05000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3a16000 b3a59000 r-xp /usr/lib/libsndfile.so.1.0.25
b3a6e000 b3ab5000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3ac6000 b3acc000 r-xp /usr/lib/libjson-c.so.2.0.1
b3add000 b3ae4000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3af4000 b3b34000 r-xp /usr/lib/libmdm.so.1.2.10
b3b44000 b3b4c000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3b5b000 b3b6b000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3b8c000 b3bec000 r-xp /usr/lib/libasound.so.2.0.0
b3bfe000 b3c34000 r-xp /usr/lib/libpulse.so.0.16.2
b3c45000 b3c48000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3c58000 b3c5b000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3c6b000 b3c70000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3c80000 b3c81000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3c91000 b3c9c000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3cb0000 b3cb7000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3cc7000 b3ccd000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3cdd000 b3ce2000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3cf2000 b3d0d000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3d1d000 b3d24000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3d34000 b3d37000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3d48000 b3d76000 r-xp /usr/lib/libidn.so.11.5.44
b3d86000 b3d9c000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3dad000 b3db7000 r-xp /usr/lib/libcares.so.2.1.0
b3dc7000 b3dd1000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3de1000 b3de3000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3df3000 b3df4000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3e04000 b3e08000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3e19000 b3e41000 r-xp /usr/lib/libui-extension.so.0.1.0
b3e52000 b3e7b000 r-xp /usr/lib/libturbojpeg.so
b3e9b000 b3ea1000 r-xp /usr/lib/libgif.so.4.1.6
b3eb1000 b3ef7000 r-xp /usr/lib/libcurl.so.4.3.0
b3f08000 b3f29000 r-xp /usr/lib/libexif.so.12.3.3
b3f44000 b3f59000 r-xp /usr/lib/libtts.so
b3f6a000 b3f72000 r-xp /usr/lib/libfeedback.so.0.1.4
b3f82000 b4042000 r-xp /usr/lib/libdali-core.so.0.0.0
b404d000 b4140000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b4160000 b423a000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b4251000 b4253000 r-xp /usr/lib/libboost_system.so.1.51.0
b4263000 b4269000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b4279000 b429c000 r-xp /usr/lib/libboost_thread.so.1.51.0
b42ad000 b42af000 r-xp /usr/lib/libappsvc.so.0.1.0
b42bf000 b42c1000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b42d2000 b42d7000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b42ee000 b42f0000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b4300000 b4307000 r-xp /usr/lib/libsensord-share.so
b4317000 b432f000 r-xp /usr/lib/libsensor.so.1.1.0
b4340000 b4343000 r-xp /usr/lib/libXv.so.1.0.0
b4353000 b4358000 r-xp /usr/lib/libutilX.so.1.1.0
b4368000 b436d000 r-xp /usr/lib/libappcore-common.so.1.1
b437d000 b4384000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b4397000 b439b000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b43ac000 b4476000 r-xp /usr/lib/libCOREGL.so.4.0
b448d000 b4490000 r-xp /usr/lib/libuuid.so.1.3.0
b44a1000 b44b8000 r-xp /usr/lib/libblkid.so.1.1.0
b44c9000 b44cb000 r-xp /usr/lib/libXau.so.6.0.0
b44db000 b44de000 r-xp /usr/lib/libEGL.so.1.4
b44e6000 b44ec000 r-xp /usr/lib/libxcb-render.so.0.0.0
b44fc000 b44fe000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b450f000 b451d000 r-xp /usr/lib/libGLESv2.so.2.0
b4526000 b4588000 r-xp /usr/lib/libpixman-1.so.0.28.2
b459d000 b45b5000 r-xp /usr/lib/libmount.so.1.1.0
b45c6000 b45da000 r-xp /usr/lib/libxcb.so.1.1.0
b45eb000 b45f2000 r-xp /lib/libcrypt-2.20-2014.11.so
b462a000 b463b000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b464c000 b464e000 r-xp /usr/lib/libiri.so
b465e000 b4669000 r-xp /usr/lib/libgpg-error.so.0.15.0
b467a000 b468f000 r-xp /lib/libexpat.so.1.5.2
b46a1000 b475f000 r-xp /usr/lib/libcairo.so.2.11200.14
b4772000 b477a000 r-xp /usr/lib/libdrm.so.2.4.0
b478a000 b478d000 r-xp /usr/lib/libdri2.so.0.0.0
b479e000 b47ec000 r-xp /usr/lib/libssl.so.1.0.0
b4801000 b480d000 r-xp /usr/lib/libeeze.so.1.13.0
b481d000 b4826000 r-xp /usr/lib/libethumb.so.1.13.0
b4836000 b4839000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4849000 b4a00000 r-xp /usr/lib/libcrypto.so.1.0.0
b5657000 b5660000 r-xp /usr/lib/libXi.so.6.1.0
b5670000 b5672000 r-xp /usr/lib/libXgesture.so.7.0.0
b5682000 b5686000 r-xp /usr/lib/libXtst.so.6.1.0
b5696000 b569c000 r-xp /usr/lib/libXrender.so.1.3.0
b56ac000 b56b2000 r-xp /usr/lib/libXrandr.so.2.2.0
b56c3000 b56c5000 r-xp /usr/lib/libXinerama.so.1.0.0
b56d5000 b56d8000 r-xp /usr/lib/libXfixes.so.3.1.0
b56e8000 b56f3000 r-xp /usr/lib/libXext.so.6.4.0
b5703000 b5705000 r-xp /usr/lib/libXdamage.so.1.1.0
b5715000 b5717000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5728000 b580a000 r-xp /usr/lib/libX11.so.6.3.0
b581d000 b5824000 r-xp /usr/lib/libXcursor.so.1.0.2
b5834000 b584c000 r-xp /usr/lib/libudev.so.1.6.0
b584e000 b5851000 r-xp /lib/libattr.so.1.1.0
b5861000 b5881000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5883000 b5888000 r-xp /usr/lib/libffi.so.6.0.2
b5898000 b58b0000 r-xp /lib/libz.so.1.2.8
b58c0000 b58c2000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58d2000 b59a7000 r-xp /usr/lib/libxml2.so.2.9.2
b59bc000 b5a57000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a73000 b5a76000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a86000 b5a9f000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5ab0000 b5ac1000 r-xp /lib/libresolv-2.20-2014.11.so
b5ad5000 b5b4f000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b64000 b5b66000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b76000 b5b7d000 r-xp /usr/lib/libembryo.so.1.13.0
b5b8d000 b5ba5000 r-xp /usr/lib/libpng12.so.0.50.0
b5bb6000 b5bd9000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bfa000 b5c0e000 r-xp /usr/lib/libector.so.1.13.0
b5c1f000 b5c37000 r-xp /usr/lib/liblua-5.1.so
b5c48000 b5c9f000 r-xp /usr/lib/libfreetype.so.6.11.3
b5cb3000 b5cdb000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5cec000 b5cff000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d10000 b5d47000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d58000 b5d66000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d76000 b5d7e000 r-xp /usr/lib/libtbm.so.1.0.0
b5d8e000 b5d9b000 r-xp /usr/lib/libeio.so.1.13.0
b5dab000 b5dad000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5dbd000 b5dc2000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5dd2000 b5de9000 r-xp /usr/lib/libefreet.so.1.13.0
b5dfb000 b5e1b000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e2b000 b5e4b000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e4d000 b5e53000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e63000 b5e74000 r-xp /usr/lib/libemotion.so.1.13.0
b5e85000 b5e8c000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e9c000 b5eab000 r-xp /usr/lib/libeo.so.1.13.0
b5ebc000 b5ece000 r-xp /usr/lib/libecore_input.so.1.13.0
b5edf000 b5ee4000 r-xp /usr/lib/libecore_file.so.1.13.0
b5ef4000 b5f0d000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f1d000 b5f3a000 r-xp /usr/lib/libeet.so.1.13.0
b5f53000 b5f9b000 r-xp /usr/lib/libeina.so.1.13.0
b5fac000 b5fbc000 r-xp /usr/lib/libefl.so.1.13.0
b5fcd000 b60b2000 r-xp /usr/lib/libicuuc.so.51.1
b60cf000 b620f000 r-xp /usr/lib/libicui18n.so.51.1
b6226000 b625e000 r-xp /usr/lib/libecore_x.so.1.13.0
b6270000 b6273000 r-xp /lib/libcap.so.2.21
b6283000 b62ac000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62bd000 b62c4000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62d6000 b630d000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b631e000 b6409000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b641c000 b6495000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64a7000 b64ac000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64bc000 b64c6000 r-xp /usr/lib/libvconf.so.0.2.45
b64d6000 b64d8000 r-xp /usr/lib/libvasum.so.0.3.1
b64e8000 b64ea000 r-xp /usr/lib/libttrace.so.1.1
b64fa000 b64fd000 r-xp /usr/lib/libiniparser.so.0
b650d000 b6533000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6543000 b6548000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6559000 b6570000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6581000 b65ec000 r-xp /lib/libm-2.20-2014.11.so
b65fd000 b6603000 r-xp /lib/librt-2.20-2014.11.so
b6614000 b6621000 r-xp /usr/lib/libunwind.so.8.0.1
b6657000 b677b000 r-xp /lib/libc-2.20-2014.11.so
b6790000 b67a9000 r-xp /lib/libgcc_s-4.9.so.1
b67b9000 b689b000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68ac000 b68d6000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68e7000 b6923000 r-xp /usr/lib/libsystemd.so.0.4.0
b6925000 b69a7000 r-xp /usr/lib/libedje.so.1.13.0
b69ba000 b69d8000 r-xp /usr/lib/libecore.so.1.13.0
b69f8000 b6b7f000 r-xp /usr/lib/libevas.so.1.13.0
b6bb4000 b6bc8000 r-xp /lib/libpthread-2.20-2014.11.so
b6bdc000 b6e11000 r-xp /usr/lib/libelementary.so.1.13.0
b6e3f000 b6e43000 r-xp /usr/lib/libsmack.so.1.0.0
b6e53000 b6e5a000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e6a000 b6e6c000 r-xp /usr/lib/libdlog.so.0.0.0
b6e7c000 b6e7f000 r-xp /usr/lib/libbundle.so.0.1.22
b6e8f000 b6e91000 r-xp /lib/libdl-2.20-2014.11.so
b6ea2000 b6eba000 r-xp /usr/lib/libaul.so.0.1.0
b6ece000 b6ed3000 r-xp /usr/lib/libappcore-efl.so.1.1
b6ee4000 b6ef1000 r-xp /usr/lib/liblptcp.so
b6f03000 b6f07000 r-xp /usr/lib/libsys-assert.so
b6f18000 b6f38000 r-xp /lib/ld-2.20-2014.11.so
b6f49000 b6f4e000 r-xp /usr/bin/launchpad-loader
b74db000 b77d4000 rw-p [heap]
beae6000 beb07000 rw-p [stack]
b74db000 b77d4000 rw-p [heap]
beae6000 beb07000 rw-p [stack]
End of Maps Information

Callstack Information (PID:29926)
Call Stack Count: 21
 0: view_history_create + 0x47 (0xb29d435c) [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw] + 0x635c
 1: _show_history_cb + 0x7a (0xb29d3fa3) [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw] + 0x5fa3
 2: (0xb6a5e7ed) [/usr/lib/libevas.so.1] + 0x667ed
 3: (0xb5ea7219) [/usr/lib/libeo.so.1] + 0xb219
 4: eo_event_callback_call + 0x68 (0xb5ea5fb9) [/usr/lib/libeo.so.1] + 0x9fb9
 5: evas_object_smart_callback_call + 0x38 (0xb6a5fedd) [/usr/lib/libevas.so.1] + 0x67edd
 6: (0xb697bdd7) [/usr/lib/libedje.so.1] + 0x56dd7
 7: (0xb698011f) [/usr/lib/libedje.so.1] + 0x5b11f
 8: (0xb697c791) [/usr/lib/libedje.so.1] + 0x57791
 9: (0xb697cb61) [/usr/lib/libedje.so.1] + 0x57b61
10: (0xb697ccb5) [/usr/lib/libedje.so.1] + 0x57cb5
11: (0xb69c9d11) [/usr/lib/libecore.so.1] + 0xfd11
12: (0xb69c5c4b) [/usr/lib/libecore.so.1] + 0xbc4b
13: (0xb69cba5d) [/usr/lib/libecore.so.1] + 0x11a5d
14: ecore_main_loop_begin + 0x3e (0xb69cbc83) [/usr/lib/libecore.so.1] + 0x11c83
15: appcore_efl_main + 0x20c (0xb6ed12bd) [/usr/lib/libappcore-efl.so.1] + 0x32bd
16: ui_app_main + 0xc0 (0xb4399909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
17: main + 0x9a (0xb29d3613) [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw] + 0x5613
18: (0xb6f4abaf) [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw] + 0x1baf
19: __libc_start_main + 0x114 (0xb666d4bc) [/lib/libc.so.6] + 0x164bc
20: (0xb6f4ae94) [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw] + 0x1e94
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
07-25 22:05:41.952+0600 D/avoidrickshaw(32394): event-values: 0.202792, -0.071186, 10.168301, 0.000000
07-25 22:05:42.012+0600 D/avoidrickshaw(32394): event-values: 0.190828, -0.072981, 10.177272, 0.000000
07-25 22:05:42.072+0600 D/avoidrickshaw(32394): event-values: 0.206979, -0.081356, 10.163515, 0.000000
07-25 22:05:42.132+0600 D/avoidrickshaw(32394): event-values: 0.196211, -0.086142, 10.166506, 0.000000
07-25 22:05:42.192+0600 D/avoidrickshaw(32394): event-values: 0.205783, -0.075972, 10.174880, 0.000000
07-25 22:05:42.262+0600 D/avoidrickshaw(32394): event-values: 0.192024, -0.077169, 10.163515, 0.000000
07-25 22:05:42.322+0600 D/avoidrickshaw(32394): event-values: 0.200399, -0.064606, 10.166506, 0.000000
07-25 22:05:42.382+0600 D/avoidrickshaw(32394): event-values: 0.195613, -0.093320, 10.180862, 0.000000
07-25 22:05:42.442+0600 D/avoidrickshaw(32394): event-values: 0.193819, -0.078365, 10.162319, 0.000000
07-25 22:05:42.502+0600 D/avoidrickshaw(32394): event-values: 0.192024, -0.089133, 10.185050, 0.000000
07-25 22:05:42.562+0600 D/avoidrickshaw(32394): event-values: 0.196810, -0.070588, 10.182058, 0.000000
07-25 22:05:42.622+0600 D/avoidrickshaw(32394): event-values: 0.192024, -0.077169, 10.159925, 0.000000
07-25 22:05:42.682+0600 D/avoidrickshaw(32394): event-values: 0.185444, -0.088534, 10.158132, 0.000000
07-25 22:05:42.742+0600 D/avoidrickshaw(32394): event-values: 0.179462, -0.072383, 10.161121, 0.000000
07-25 22:05:42.802+0600 D/avoidrickshaw(32394): event-values: 0.206979, -0.077767, 10.167104, 0.000000
07-25 22:05:42.872+0600 D/avoidrickshaw(32394): event-values: 0.183051, -0.068195, 10.168897, 0.000000
07-25 22:05:42.922+0600 D/avoidrickshaw(32394): event-values: 0.198604, -0.085543, 10.168301, 0.000000
07-25 22:05:42.983+0600 D/avoidrickshaw(32394): event-values: 0.203390, -0.086142, 10.159328, 0.000000
07-25 22:05:43.043+0600 D/avoidrickshaw(32394): event-values: 0.199801, -0.075374, 10.161121, 0.000000
07-25 22:05:43.103+0600 D/avoidrickshaw(32394): event-values: 0.195015, -0.077169, 10.180862, 0.000000
07-25 22:05:43.163+0600 D/avoidrickshaw(32394): event-values: 0.174676, -0.081954, 10.175477, 0.000000
07-25 22:05:43.223+0600 D/avoidrickshaw(32394): event-values: 0.212363, -0.064008, 10.165309, 0.000000
07-25 22:05:43.283+0600 D/avoidrickshaw(32394): event-values: 0.189033, -0.079561, 10.184451, 0.000000
07-25 22:05:43.343+0600 D/avoidrickshaw(32394): event-values: 0.202792, -0.075972, 10.174281, 0.000000
07-25 22:05:43.403+0600 D/avoidrickshaw(32394): event-values: 0.196211, -0.073579, 10.189835, 0.000000
07-25 22:05:43.463+0600 D/avoidrickshaw(32394): event-values: 0.199801, -0.080758, 10.164113, 0.000000
07-25 22:05:43.523+0600 D/avoidrickshaw(32394): event-values: 0.217747, -0.075374, 10.181459, 0.000000
07-25 22:05:43.583+0600 D/avoidrickshaw(32394): event-values: 0.193220, -0.075374, 10.176675, 0.000000
07-25 22:05:43.643+0600 D/avoidrickshaw(32394): event-values: 0.190229, -0.065803, 10.167702, 0.000000
07-25 22:05:43.703+0600 D/avoidrickshaw(32394): event-values: 0.210568, -0.083151, 10.162319, 0.000000
07-25 22:05:43.763+0600 D/avoidrickshaw(32394): event-values: 0.196211, -0.076570, 10.164113, 0.000000
07-25 22:05:43.823+0600 D/avoidrickshaw(32394): event-values: 0.190828, -0.065204, 10.171888, 0.000000
07-25 22:05:43.883+0600 D/avoidrickshaw(32394): event-values: 0.186640, -0.066999, 10.182058, 0.000000
07-25 22:05:43.943+0600 D/avoidrickshaw(32394): event-values: 0.187837, -0.080160, 10.189237, 0.000000
07-25 22:05:44.004+0600 D/avoidrickshaw(32394): event-values: 0.190229, -0.072981, 10.187442, 0.000000
07-25 22:05:44.064+0600 D/avoidrickshaw(32394): event-values: 0.199202, -0.073579, 10.173683, 0.000000
07-25 22:05:44.124+0600 D/avoidrickshaw(32394): event-values: 0.188435, -0.068794, 10.183852, 0.000000
07-25 22:05:44.184+0600 D/avoidrickshaw(32394): event-values: 0.200997, -0.080758, 10.165309, 0.000000
07-25 22:05:44.244+0600 D/avoidrickshaw(32394): event-values: 0.203988, -0.057428, 10.183852, 0.000000
07-25 22:05:44.304+0600 D/avoidrickshaw(32394): event-values: 0.196211, -0.062213, 10.163515, 0.000000
07-25 22:05:44.364+0600 D/avoidrickshaw(32394): event-values: 0.202792, -0.095115, 10.173683, 0.000000
07-25 22:05:44.424+0600 D/avoidrickshaw(32394): event-values: 0.196810, -0.071785, 10.159925, 0.000000
07-25 22:05:44.484+0600 D/avoidrickshaw(32394): event-values: 0.208176, -0.071186, 10.149756, 0.000000
07-25 22:05:44.544+0600 D/avoidrickshaw(32394): event-values: 0.202193, -0.088534, 10.180862, 0.000000
07-25 22:05:44.604+0600 D/avoidrickshaw(32394): event-values: 0.199801, -0.053839, 10.174880, 0.000000
07-25 22:05:44.664+0600 D/avoidrickshaw(32394): event-values: 0.197408, -0.067597, 10.177272, 0.000000
07-25 22:05:44.724+0600 D/avoidrickshaw(32394): event-values: 0.214158, -0.082552, 10.161121, 0.000000
07-25 22:05:44.784+0600 D/avoidrickshaw(32394): event-values: 0.201595, -0.067597, 10.169496, 0.000000
07-25 22:05:44.844+0600 D/avoidrickshaw(32394): event-values: 0.200399, -0.074776, 10.156336, 0.000000
07-25 22:05:44.904+0600 D/avoidrickshaw(32394): event-values: 0.209970, -0.079561, 10.162319, 0.000000
07-25 22:05:44.964+0600 D/avoidrickshaw(32394): event-values: 0.199202, -0.093320, 10.188639, 0.000000
07-25 22:05:45.025+0600 D/avoidrickshaw(32394): event-values: 0.199202, -0.074178, 10.188639, 0.000000
07-25 22:05:45.085+0600 D/avoidrickshaw(32394): event-values: 0.188435, -0.072383, 10.171290, 0.000000
07-25 22:05:45.145+0600 D/avoidrickshaw(32394): event-values: 0.189033, -0.074776, 10.156934, 0.000000
07-25 22:05:45.205+0600 D/avoidrickshaw(32394): event-values: 0.196211, -0.086740, 10.156336, 0.000000
07-25 22:05:45.265+0600 D/avoidrickshaw(32394): event-values: 0.208774, -0.079561, 10.179665, 0.000000
07-25 22:05:45.325+0600 D/avoidrickshaw(32394): event-values: 0.192622, -0.078365, 10.173084, 0.000000
07-25 22:05:45.385+0600 D/avoidrickshaw(32394): event-values: 0.194417, -0.093918, 10.181459, 0.000000
07-25 22:05:45.445+0600 D/avoidrickshaw(32394): event-values: 0.183051, -0.071186, 10.174281, 0.000000
07-25 22:05:45.505+0600 D/avoidrickshaw(32394): event-values: 0.208176, -0.076570, 10.162319, 0.000000
07-25 22:05:45.565+0600 D/avoidrickshaw(32394): event-values: 0.178863, -0.078963, 10.180862, 0.000000
07-25 22:05:45.625+0600 D/avoidrickshaw(32394): event-values: 0.186042, -0.076570, 10.172487, 0.000000
07-25 22:05:45.685+0600 D/avoidrickshaw(32394): event-values: 0.193220, -0.065204, 10.168897, 0.000000
07-25 22:05:45.745+0600 D/avoidrickshaw(32394): event-values: 0.196810, -0.070588, 10.164113, 0.000000
07-25 22:05:45.805+0600 D/avoidrickshaw(32394): event-values: 0.181256, -0.069392, 10.180264, 0.000000
07-25 22:05:45.875+0600 D/avoidrickshaw(32394): event-values: 0.203390, -0.069990, 10.168897, 0.000000
07-25 22:05:45.905+0600 D/avoidrickshaw(32394): horizontal_acc: 24.000000, vertical_acc: -1.000000
07-25 22:05:45.905+0600 D/avoidrickshaw(32394): previous lat: 23.742113, previous long: 90.411685
07-25 22:05:45.905+0600 D/avoidrickshaw(32394): current lat: 23.742136, current long: 90.411688
07-25 22:05:45.915+0600 D/avoidri
