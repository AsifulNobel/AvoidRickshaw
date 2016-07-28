S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPD6
Build-Date: 2016.04.28 20:23:28

Crash Information
Process Name: avoidrickshaw
PID: 18563
Date: 2016-07-28 11:16:59+0600
Executable File Path: /opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 18563, uid 5000)

Register Information
r0   = 0x8002e975, r1   = 0x00000000
r2   = 0xb42d0000, r3   = 0xb42d0010
r4   = 0xb29bb120, r5   = 0xb9114528
r6   = 0xb9120390, r7   = 0xbea99208
r8   = 0x800168b5, r9   = 0xb5ea1708
r10  = 0xb911f380, fp   = 0x00000000
ip   = 0xb5f91120, sp   = 0xbea991b0
lr   = 0xb5f55bd9, pc   = 0xb29ba0f2
cpsr = 0x800e0030

Memory Information
MemTotal:   730440 KB
MemFree:     42924 KB
Buffers:     45248 KB
Cached:     276292 KB
VmPeak:     105664 KB
VmSize:     105660 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       23808 KB
VmRSS:       23808 KB
VmData:      33464 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36164 KB
VmPTE:          80 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 18563 TID = 18563
18563 18567 32379 32393 

Maps Information
b0e35000 b1634000 rw-p [stack:32393]
b1c7f000 b247e000 rw-p [stack:32379]
b24fa000 b2502000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2513000 b2514000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b2524000 b2538000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b254c000 b254d000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b255d000 b2560000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2571000 b2572000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2582000 b2584000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2594000 b2596000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b25a6000 b25b6000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b25c6000 b25d2000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b2822000 b2824000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b2834000 b283a000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b284a000 b285e000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b286e000 b2888000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b2898000 b289e000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
b28ae000 b28b5000 r-xp /usr/lib/libeventsystem.so.0.0.1
b28c5000 b28e8000 r-xp /usr/lib/libSLP-location-product.so.0.9.0
b28f9000 b2910000 r-xp /usr/lib/libSLP-location.so.0.11.5_5
b2920000 b2927000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2938000 b2940000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b2950000 b2954000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
b2965000 b2974000 r-xp /usr/lib/libcapi-location-manager.so.0.6.1_3
b2984000 b298b000 r-xp /usr/lib/libcapi-appfw-preference.so.0.3.1.0
b299d000 b29a3000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b29b3000 b29bc000 r-xp /opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw
b2add000 b2bc0000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2bf7000 b2c1f000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2c31000 b3430000 rw-p [stack:18567]
b3430000 b3432000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3442000 b344c000 r-xp /lib/libnss_files-2.20-2014.11.so
b345d000 b3466000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3477000 b3488000 r-xp /lib/libnsl-2.20-2014.11.so
b349b000 b34a1000 r-xp /lib/libnss_compat-2.20-2014.11.so
b34b2000 b34b3000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b34db000 b34e2000 r-xp /usr/lib/libminizip.so.1.0.0
b34f2000 b34f7000 r-xp /usr/lib/libstorage.so.0.1
b3507000 b355c000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3572000 b3586000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b3596000 b35da000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b35ea000 b35f2000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3602000 b3632000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3645000 b36fe000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3712000 b3766000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3777000 b3792000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b37a2000 b3863000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3876000 b3888000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3898000 b389c000 r-xp /usr/lib/libogg.so.0.7.1
b38ac000 b38ce000 r-xp /usr/lib/libvorbis.so.0.4.3
b38de000 b39c2000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b39de000 b39eb000 r-xp /usr/lib/libmdm-common.so.1.0.98
b39fc000 b3a3f000 r-xp /usr/lib/libsndfile.so.1.0.25
b3a54000 b3a9b000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3aac000 b3ab2000 r-xp /usr/lib/libjson-c.so.2.0.1
b3ac3000 b3aca000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3ada000 b3b1a000 r-xp /usr/lib/libmdm.so.1.2.10
b3b2a000 b3b32000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3b41000 b3b51000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3b72000 b3bd2000 r-xp /usr/lib/libasound.so.2.0.0
b3be4000 b3c1a000 r-xp /usr/lib/libpulse.so.0.16.2
b3c2b000 b3c2e000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3c3e000 b3c41000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3c51000 b3c56000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3c66000 b3c67000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3c77000 b3c82000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3c96000 b3c9d000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3cad000 b3cb3000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3cc3000 b3cc8000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3cd8000 b3cf3000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3d03000 b3d0a000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3d1a000 b3d1d000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3d2e000 b3d5c000 r-xp /usr/lib/libidn.so.11.5.44
b3d6c000 b3d82000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3d93000 b3d9d000 r-xp /usr/lib/libcares.so.2.1.0
b3dad000 b3db7000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3dc7000 b3dc9000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3dd9000 b3dda000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3dea000 b3dee000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3dff000 b3e27000 r-xp /usr/lib/libui-extension.so.0.1.0
b3e38000 b3e61000 r-xp /usr/lib/libturbojpeg.so
b3e81000 b3e87000 r-xp /usr/lib/libgif.so.4.1.6
b3e97000 b3edd000 r-xp /usr/lib/libcurl.so.4.3.0
b3eee000 b3f0f000 r-xp /usr/lib/libexif.so.12.3.3
b3f2a000 b3f3f000 r-xp /usr/lib/libtts.so
b3f50000 b3f58000 r-xp /usr/lib/libfeedback.so.0.1.4
b3f68000 b4028000 r-xp /usr/lib/libdali-core.so.0.0.0
b4033000 b4126000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b4146000 b4220000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b4237000 b4239000 r-xp /usr/lib/libboost_system.so.1.51.0
b4249000 b424f000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b425f000 b4282000 r-xp /usr/lib/libboost_thread.so.1.51.0
b4293000 b4295000 r-xp /usr/lib/libappsvc.so.0.1.0
b42a5000 b42a7000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b42b8000 b42bd000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b42d4000 b42d6000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b42e6000 b42ed000 r-xp /usr/lib/libsensord-share.so
b42fd000 b4315000 r-xp /usr/lib/libsensor.so.1.1.0
b4326000 b4329000 r-xp /usr/lib/libXv.so.1.0.0
b4339000 b433e000 r-xp /usr/lib/libutilX.so.1.1.0
b434e000 b4353000 r-xp /usr/lib/libappcore-common.so.1.1
b4363000 b436a000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b437d000 b4381000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b4392000 b445c000 r-xp /usr/lib/libCOREGL.so.4.0
b4473000 b4476000 r-xp /usr/lib/libuuid.so.1.3.0
b4487000 b449e000 r-xp /usr/lib/libblkid.so.1.1.0
b44af000 b44b1000 r-xp /usr/lib/libXau.so.6.0.0
b44c1000 b44c4000 r-xp /usr/lib/libEGL.so.1.4
b44cc000 b44d2000 r-xp /usr/lib/libxcb-render.so.0.0.0
b44e2000 b44e4000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b44f5000 b4503000 r-xp /usr/lib/libGLESv2.so.2.0
b450c000 b456e000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4583000 b459b000 r-xp /usr/lib/libmount.so.1.1.0
b45ac000 b45c0000 r-xp /usr/lib/libxcb.so.1.1.0
b45d1000 b45d8000 r-xp /lib/libcrypt-2.20-2014.11.so
b4610000 b4621000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b4632000 b4634000 r-xp /usr/lib/libiri.so
b4644000 b464f000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4660000 b4675000 r-xp /lib/libexpat.so.1.5.2
b4687000 b4745000 r-xp /usr/lib/libcairo.so.2.11200.14
b4758000 b4760000 r-xp /usr/lib/libdrm.so.2.4.0
b4770000 b4773000 r-xp /usr/lib/libdri2.so.0.0.0
b4784000 b47d2000 r-xp /usr/lib/libssl.so.1.0.0
b47e7000 b47f3000 r-xp /usr/lib/libeeze.so.1.13.0
b4803000 b480c000 r-xp /usr/lib/libethumb.so.1.13.0
b481c000 b481f000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b482f000 b49e6000 r-xp /usr/lib/libcrypto.so.1.0.0
b563d000 b5646000 r-xp /usr/lib/libXi.so.6.1.0
b5656000 b5658000 r-xp /usr/lib/libXgesture.so.7.0.0
b5668000 b566c000 r-xp /usr/lib/libXtst.so.6.1.0
b567c000 b5682000 r-xp /usr/lib/libXrender.so.1.3.0
b5692000 b5698000 r-xp /usr/lib/libXrandr.so.2.2.0
b56a9000 b56ab000 r-xp /usr/lib/libXinerama.so.1.0.0
b56bb000 b56be000 r-xp /usr/lib/libXfixes.so.3.1.0
b56ce000 b56d9000 r-xp /usr/lib/libXext.so.6.4.0
b56e9000 b56eb000 r-xp /usr/lib/libXdamage.so.1.1.0
b56fb000 b56fd000 r-xp /usr/lib/libXcomposite.so.1.0.0
b570e000 b57f0000 r-xp /usr/lib/libX11.so.6.3.0
b5803000 b580a000 r-xp /usr/lib/libXcursor.so.1.0.2
b581a000 b5832000 r-xp /usr/lib/libudev.so.1.6.0
b5834000 b5837000 r-xp /lib/libattr.so.1.1.0
b5847000 b5867000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5869000 b586e000 r-xp /usr/lib/libffi.so.6.0.2
b587e000 b5896000 r-xp /lib/libz.so.1.2.8
b58a6000 b58a8000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58b8000 b598d000 r-xp /usr/lib/libxml2.so.2.9.2
b59a2000 b5a3d000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a59000 b5a5c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a6c000 b5a85000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a96000 b5aa7000 r-xp /lib/libresolv-2.20-2014.11.so
b5abb000 b5b35000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b4a000 b5b4c000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b5c000 b5b63000 r-xp /usr/lib/libembryo.so.1.13.0
b5b73000 b5b8b000 r-xp /usr/lib/libpng12.so.0.50.0
b5b9c000 b5bbf000 r-xp /usr/lib/libjpeg.so.8.0.2
b5be0000 b5bf4000 r-xp /usr/lib/libector.so.1.13.0
b5c05000 b5c1d000 r-xp /usr/lib/liblua-5.1.so
b5c2e000 b5c85000 r-xp /usr/lib/libfreetype.so.6.11.3
b5c99000 b5cc1000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5cd2000 b5ce5000 r-xp /usr/lib/libfribidi.so.0.3.1
b5cf6000 b5d2d000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d3e000 b5d4c000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d5c000 b5d64000 r-xp /usr/lib/libtbm.so.1.0.0
b5d74000 b5d81000 r-xp /usr/lib/libeio.so.1.13.0
b5d91000 b5d93000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5da3000 b5da8000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5db8000 b5dcf000 r-xp /usr/lib/libefreet.so.1.13.0
b5de1000 b5e01000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e11000 b5e31000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e33000 b5e39000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e49000 b5e5a000 r-xp /usr/lib/libemotion.so.1.13.0
b5e6b000 b5e72000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e82000 b5e91000 r-xp /usr/lib/libeo.so.1.13.0
b5ea2000 b5eb4000 r-xp /usr/lib/libecore_input.so.1.13.0
b5ec5000 b5eca000 r-xp /usr/lib/libecore_file.so.1.13.0
b5eda000 b5ef3000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f03000 b5f20000 r-xp /usr/lib/libeet.so.1.13.0
b5f39000 b5f81000 r-xp /usr/lib/libeina.so.1.13.0
b5f92000 b5fa2000 r-xp /usr/lib/libefl.so.1.13.0
b5fb3000 b6098000 r-xp /usr/lib/libicuuc.so.51.1
b60b5000 b61f5000 r-xp /usr/lib/libicui18n.so.51.1
b620c000 b6244000 r-xp /usr/lib/libecore_x.so.1.13.0
b6256000 b6259000 r-xp /lib/libcap.so.2.21
b6269000 b6292000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62a3000 b62aa000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62bc000 b62f3000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6304000 b63ef000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6402000 b647b000 r-xp /usr/lib/libsqlite3.so.0.8.6
b648d000 b6492000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64a2000 b64ac000 r-xp /usr/lib/libvconf.so.0.2.45
b64bc000 b64be000 r-xp /usr/lib/libvasum.so.0.3.1
b64ce000 b64d0000 r-xp /usr/lib/libttrace.so.1.1
b64e0000 b64e3000 r-xp /usr/lib/libiniparser.so.0
b64f3000 b6519000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6529000 b652e000 r-xp /usr/lib/libxdgmime.so.1.1.0
b653f000 b6556000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6567000 b65d2000 r-xp /lib/libm-2.20-2014.11.so
b65e3000 b65e9000 r-xp /lib/librt-2.20-2014.11.so
b65fa000 b6607000 r-xp /usr/lib/libunwind.so.8.0.1
b663d000 b6761000 r-xp /lib/libc-2.20-2014.11.so
b6776000 b678f000 r-xp /lib/libgcc_s-4.9.so.1
b679f000 b6881000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6892000 b68bc000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68cd000 b6909000 r-xp /usr/lib/libsystemd.so.0.4.0
b690b000 b698d000 r-xp /usr/lib/libedje.so.1.13.0
b69a0000 b69be000 r-xp /usr/lib/libecore.so.1.13.0
b69de000 b6b65000 r-xp /usr/lib/libevas.so.1.13.0
b6b9a000 b6bae000 r-xp /lib/libpthread-2.20-2014.11.so
b6bc2000 b6df7000 r-xp /usr/lib/libelementary.so.1.13.0
b6e25000 b6e29000 r-xp /usr/lib/libsmack.so.1.0.0
b6e39000 b6e40000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e50000 b6e52000 r-xp /usr/lib/libdlog.so.0.0.0
b6e62000 b6e65000 r-xp /usr/lib/libbundle.so.0.1.22
b6e75000 b6e77000 r-xp /lib/libdl-2.20-2014.11.so
b6e88000 b6ea0000 r-xp /usr/lib/libaul.so.0.1.0
b6eb4000 b6eb9000 r-xp /usr/lib/libappcore-efl.so.1.1
b6eca000 b6ed7000 r-xp /usr/lib/liblptcp.so
b6ee9000 b6eed000 r-xp /usr/lib/libsys-assert.so
b6efe000 b6f1e000 r-xp /lib/ld-2.20-2014.11.so
b6f2f000 b6f34000 r-xp /usr/bin/launchpad-loader
b8f04000 b91f4000 rw-p [heap]
bea79000 bea9a000 rw-p [stack]
b8f04000 b91f4000 rw-p [heap]
bea79000 bea9a000 rw-p [stack]
End of Maps Information

Callstack Information (PID:18563)
Call Stack Count: 21
 0: view_history_create + 0x4d (0xb29ba0f2) [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw] + 0x70f2
 1: _show_history_cb + 0x7a (0xb29b9d33) [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw] + 0x6d33
 2: (0xb6a447ed) [/usr/lib/libevas.so.1] + 0x667ed
 3: (0xb5e8d219) [/usr/lib/libeo.so.1] + 0xb219
 4: eo_event_callback_call + 0x68 (0xb5e8bfb9) [/usr/lib/libeo.so.1] + 0x9fb9
 5: evas_object_smart_callback_call + 0x38 (0xb6a45edd) [/usr/lib/libevas.so.1] + 0x67edd
 6: (0xb6961dd7) [/usr/lib/libedje.so.1] + 0x56dd7
 7: (0xb696611f) [/usr/lib/libedje.so.1] + 0x5b11f
 8: (0xb6962791) [/usr/lib/libedje.so.1] + 0x57791
 9: (0xb6962b61) [/usr/lib/libedje.so.1] + 0x57b61
10: (0xb6962cb5) [/usr/lib/libedje.so.1] + 0x57cb5
11: (0xb69afd11) [/usr/lib/libecore.so.1] + 0xfd11
12: (0xb69abc4b) [/usr/lib/libecore.so.1] + 0xbc4b
13: (0xb69b1a5d) [/usr/lib/libecore.so.1] + 0x11a5d
14: ecore_main_loop_begin + 0x3e (0xb69b1c83) [/usr/lib/libecore.so.1] + 0x11c83
15: appcore_efl_main + 0x20c (0xb6eb72bd) [/usr/lib/libappcore-efl.so.1] + 0x32bd
16: ui_app_main + 0xc0 (0xb437f909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
17: main + 0x9a (0xb29b93a3) [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw] + 0x63a3
18: (0xb6f30baf) [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw] + 0x1baf
19: __libc_start_main + 0x114 (0xb66534bc) [/lib/libc.so.6] + 0x164bc
20: (0xb6f30e94) [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw] + 0x1e94
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
07-25 22:06:16.255+0600 D/avoidrickshaw(32394): event-values: 0.180060, -0.077767, 10.169496, 0.000000
07-25 22:06:16.315+0600 D/avoidrickshaw(32394): event-values: 0.207577, -0.081954, 10.169496, 0.000000
07-25 22:06:16.375+0600 D/avoidrickshaw(32394): event-values: 0.209970, -0.074776, 10.167702, 0.000000
07-25 22:06:16.435+0600 D/avoidrickshaw(32394): event-values: 0.205185, -0.084347, 10.168301, 0.000000
07-25 22:06:16.495+0600 D/avoidrickshaw(32394): event-values: 0.188435, -0.076570, 10.164711, 0.000000
07-25 22:06:16.555+0600 D/avoidrickshaw(32394): event-values: 0.220738, -0.046062, 10.191629, 0.000000
07-25 22:06:16.615+0600 D/avoidrickshaw(32394): event-values: 0.192024, -0.068195, 10.180264, 0.000000
07-25 22:06:16.675+0600 D/avoidrickshaw(32394): event-values: 0.200399, -0.072383, 10.177272, 0.000000
07-25 22:06:16.735+0600 D/avoidrickshaw(32394): event-values: 0.171685, -0.080160, 10.182656, 0.000000
07-25 22:06:16.796+0600 D/avoidrickshaw(32394): event-values: 0.202792, -0.064606, 10.181459, 0.000000
07-25 22:06:16.856+0600 D/avoidrickshaw(32394): event-values: 0.221336, -0.069990, 10.156934, 0.000000
07-25 22:06:16.916+0600 D/avoidrickshaw(32394): event-values: 0.208774, -0.071186, 10.170692, 0.000000
07-25 22:06:16.976+0600 D/avoidrickshaw(32394): event-values: 0.199202, -0.077169, 10.170094, 0.000000
07-25 22:06:17.036+0600 D/avoidrickshaw(32394): event-values: 0.171685, -0.070588, 10.184451, 0.000000
07-25 22:06:17.096+0600 D/avoidrickshaw(32394): event-values: 0.214756, -0.081356, 10.162916, 0.000000
07-25 22:06:17.156+0600 D/avoidrickshaw(32394): event-values: 0.204586, -0.076570, 10.193424, 0.000000
07-25 22:06:17.216+0600 D/avoidrickshaw(32394): event-values: 0.195613, -0.076570, 10.185050, 0.000000
07-25 22:06:17.276+0600 D/avoidrickshaw(32394): event-values: 0.210568, -0.074178, 10.164113, 0.000000
07-25 22:06:17.336+0600 D/avoidrickshaw(32394): event-values: 0.194417, -0.080758, 10.177272, 0.000000
07-25 22:06:17.396+0600 D/avoidrickshaw(32394): event-values: 0.204586, -0.077169, 10.189835, 0.000000
07-25 22:06:17.456+0600 D/avoidrickshaw(32394): event-values: 0.199801, -0.079561, 10.158729, 0.000000
07-25 22:06:17.516+0600 D/avoidrickshaw(32394): event-values: 0.186042, -0.084945, 10.176675, 0.000000
07-25 22:06:17.576+0600 D/avoidrickshaw(32394): event-values: 0.199801, -0.076570, 10.157533, 0.000000
07-25 22:06:17.636+0600 D/avoidrickshaw(32394): event-values: 0.187837, -0.055035, 10.151550, 0.000000
07-25 22:06:17.696+0600 D/avoidrickshaw(32394): event-values: 0.191426, -0.078365, 10.171290, 0.000000
07-25 22:06:17.756+0600 D/avoidrickshaw(32394): event-values: 0.205783, -0.052044, 10.171290, 0.000000
07-25 22:06:17.817+0600 D/avoidrickshaw(32394): event-values: 0.210568, -0.078963, 10.185647, 0.000000
07-25 22:06:17.857+0600 I/Tizen::Net::Wifi( 1305): (941) > The background scan result updated.
07-25 22:06:17.877+0600 D/avoidrickshaw(32394): event-values: 0.203390, -0.084945, 10.173683, 0.000000
07-25 22:06:17.927+0600 D/avoidrickshaw(32394): horizontal_acc: 16.000000, vertical_acc: -1.000000
07-25 22:06:17.927+0600 D/avoidrickshaw(32394): previous lat: 23.742160, previous long: 90.411682
07-25 22:06:17.927+0600 D/avoidrickshaw(32394): current lat: 23.742160, current long: 90.411682
07-25 22:06:17.937+0600 D/avoidrickshaw(32394): because step count did not update, distance not updated.
07-25 22:06:17.937+0600 D/avoidrickshaw(32394): event-values: 0.188435, -0.075972, 10.181459, 0.000000
07-25 22:06:17.997+0600 D/avoidrickshaw(32394): event-values: 0.211765, -0.066999, 10.182656, 0.000000
07-25 22:06:18.057+0600 D/avoidrickshaw(32394): event-values: 0.193220, -0.074178, 10.192227, 0.000000
07-25 22:06:18.117+0600 D/avoidrickshaw(32394): event-values: 0.198006, -0.087338, 10.188040, 0.000000
07-25 22:06:18.177+0600 D/avoidrickshaw(32394): event-values: 0.184247, -0.071785, 10.161720, 0.000000
07-25 22:06:18.237+0600 D/avoidrickshaw(32394): event-values: 0.211765, -0.072383, 10.175477, 0.000000
07-25 22:06:18.297+0600 D/avoidrickshaw(32394): event-values: 0.206381, -0.069990, 10.193424, 0.000000
07-25 22:06:18.357+0600 D/avoidrickshaw(32394): event-values: 0.199202, -0.073579, 10.167104, 0.000000
07-25 22:06:18.417+0600 D/avoidrickshaw(32394): event-values: 0.186640, -0.071186, 10.180862, 0.000000
07-25 22:06:18.477+0600 D/avoidrickshaw(32394): event-values: 0.200997, -0.096311, 10.192227, 0.000000
07-25 22:06:18.537+0600 D/avoidrickshaw(32394): event-values: 0.211167, -0.073579, 10.197014, 0.000000
07-25 22:06:18.597+0600 D/avoidrickshaw(32394): event-values: 0.193220, -0.078365, 10.200603, 0.000000
07-25 22:06:18.657+0600 D/avoidrickshaw(32394): event-values: 0.189631, -0.068794, 10.165309, 0.000000
07-25 22:06:18.717+0600 D/avoidrickshaw(32394): event-values: 0.199202, -0.077169, 10.191031, 0.000000
07-25 22:06:18.777+0600 D/avoidrickshaw(32394): event-values: 0.205783, -0.075374, 10.186246, 0.000000
07-25 22:06:18.838+0600 D/avoidrickshaw(32394): event-values: 0.200997, -0.071186, 10.186246, 0.000000
07-25 22:06:18.898+0600 D/avoidrickshaw(32394): event-values: 0.197408, -0.071785, 10.177871, 0.000000
07-25 22:06:18.958+0600 D/avoidrickshaw(32394): event-values: 0.198604, -0.092722, 10.191031, 0.000000
07-25 22:06:19.018+0600 D/avoidrickshaw(32394): event-values: 0.188435, -0.067597, 10.162319, 0.000000
07-25 22:06:19.078+0600 D/avoidrickshaw(32394): event-values: 0.189631, -0.072383, 10.173084, 0.000000
07-25 22:06:19.138+0600 D/avoidrickshaw(32394): event-values: 0.190828, -0.076570, 10.174281, 0.000000
07-25 22:06:19.198+0600 D/avoidrickshaw(32394): event-values: 0.226720, -0.083151, 10.195816, 0.000000
07-25 22:06:19.258+0600 D/avoidrickshaw(32394): event-values: 0.202792, -0.075374, 10.186844, 0.000000
07-25 22:06:19.318+0600 D/avoidrickshaw(32394): event-values: 0.198604, -0.068195, 10.174880, 0.000000
07-25 22:06:19.378+0600 D/avoidrickshaw(32394): event-values: 0.192622, -0.086142, 10.183254, 0.000000
07-25 22:06:19.438+0600 D/avoidrickshaw(32394): event-values: 0.205783, -0.068794, 10.175477, 0.000000
07-25 22:06:19.498+0600 D/avoidrickshaw(32394): event-values: 0.194417, -0.070588, 10.191629, 0.000000
07-25 22:06:19.558+0600 D/avoidrickshaw(32394): event-values: 0.184247, -0.080160, 10.162916, 0.000000
07-25 22:06:19.618+0600 D/avoidrickshaw(32394): event-values: 0.190229, -0.071186, 10.170692, 0.000000
07-25 22:06:19.678+0600 D/avoidrickshaw(32394): event-values: 0.213559, -0.068195, 10.164113, 0.000000
07-25 22:06:19.738+0600 D/avoidrickshaw(32394): event-values: 0.189631, -0.094516, 10.174281, 0.000000
07-25 22:06:19.798+0600 D/avoidrickshaw(32394): event-values: 0.209372, -0.067597, 10.177272, 0.000000
07-25 22:06:19.858+0600 D/avoidrickshaw(32394): event-values: 0.200997, -0.072981, 10.184451, 0.000000
07-25 22:06:19.919+0600 D/avoidrickshaw(32394): event-values: 0.212961, -0.077169, 10.179665, 0.000000
07-25 22:06:19.979+0600 D/avoidrickshaw(32394): event-values: 0.205185, -0.082552, 10.192227, 0.000000
07-25 22:06:20.039+0600 D/avoidrickshaw(32394): event-values: 0.190229, -0.077169, 10.159328, 0.000000
07-25 22:06:20.099+0600 D/avoidrickshaw(32394): event-values: 0.220140, -0.061615, 10.171888, 0.000000
07-25 22:06:20.159+0600 D/avoidrickshaw(32394): event-values: 0.192622, -0.068195, 10.171888, 0.000000
07-25 22:06:20.219+0600 D/avoidrickshaw(32394): event-values: 0.177069, -0.078963, 10.150952, 0.000000
07-25 22:06:20.279+0600 D/avoidrickshaw(32394): event-values: 0.188435, -0.080758, 10.168897, 0.000000
07-25 22:06:20.339+0600 D/avoidrickshaw(32394): event-values: 0.204586, -0.070588, 10.170094, 0.000000
07-25 22:06:20.399+0600 D/avoidrickshaw(32394): event-values: 0.205185, -0.066999, 10.179665, 0.000000
07-25 22:06:20.459+0600 D/avoidrickshaw(32394): event-values: 0.199801, -0.082552, 10.176675, 0.000000
07-25 22:06:20.519+0600 D/avoidrickshaw(32394): event-values: 0.202193, -0.068195, 10.173683, 0.000000
07-25 22:06:20.579+0600 D/avoidrickshaw(32394): event-values: 0.211765, -0.076570, 10.187442, 0.000000
07-25 22:06:20.639+0600 D/avoidrickshaw(32394): event-values: 0.199801, -0.074178, 10.167702, 0.000000
07-25 22:06:20.699+0600 D/avoidrickshaw(32394): event-values: 0.189033, -0.074178, 10.156934, 0.000000
07-25 22:06:20.759+0600 D/avoidrickshaw(32394): event-values: 0.202792, -0.075374, 10.183254, 0.000000
07-25 22:06:20.819+0600 D/avoidrickshaw(32394): event-values: 0.214158, -0.072981, 10.164113, 0.000000
07-25 22:06:20.879+0600 D/avoidrickshaw(32394): event-values: 0.203390, -0.068794, 10.179665, 0.000000
07-25 22:06:20.940+0600 D/avoidrickshaw(32394): event-values: 0.172881, -0.066401, 10.182058, 0.000000
07-25 22:06:21.000+0600 D/avoidrickshaw(32394): event-values: 0.211167, -0.070588, 10.176675, 0.000000
07-25 22:06:21.060+0600 D/avoidrickshaw(32394): event-values: 0.220140, -0.059821, 10.157533, 0.000000
07-25 22:06:21.120+0600 D/avoidrickshaw(32394): event-values: 0.164507, -0.088534, 10.161720, 0.000000
07-25 22:06:21.180+0600 D/avoidrickshaw(32394): event-values: 0.202193, -0.069990, 10.160523, 0.000000
07-25 22:06:21.240+0600 D/avoidrickshaw(32394): event-values: 0.209372, -0.075972, 10.168301, 0.000000
07-25 22:06:21.300+0600 D/avoidrickshaw(32394): event-values: 0.191426, -0.089133, 10.175477, 0.000000
07-25 22:06:21.360+0600 D/avoidrickshaw(32394): event-values: 0.192622, -0.078963, 10.165309, 0.000000
07-25 22:06:21.420+0600 D/avoidrickshaw(32394): event-values: 0.194417, -0.080160, 10.170094, 0.000000
07-25 22:06:21.480+0600 D/avoidrickshaw(32394): event-values: 0.147159, -0.075972, 10.184451, 0.000000
07-25 22:06:21.540+0600 D/avoidrickshaw(32394): event-values: 0.180658, -0.042473, 10.193424, 0.000000
07-25 22:06:21.600+0600 D/avoidrickshaw(32394): event-values: 0.180658, -0.086740, 10.192826, 0.000000
07-25 22:06:21.660+0600 D/avoidrickshaw(32394): event-values: 0.171087, -0.076570, 10.179067, 0.000000
07-25 22:06:21.720+0600 D/avoidrickshaw(32394): event-values: 0.198604, -0.065204, 10.189237, 0.000000
07-25 22:06:21.780+0600 D/avoidrickshaw(32394): event-values: 0.200997, -0.066401, 10.158729, 0.000000
07-25 22:06:21.840+0600 D/avoidrickshaw(32394): event-values: 0.168096, -0.071785, 10.189237, 0.000000
07-25 22:06:21.910+0600 D/avoidrickshaw(32394): horizontal_acc: 24.000000, vertical_acc: -1.000000
07-25 22:06:21.910+0600 D/avoidrickshaw(32394): previous lat: 23.742160, previous long: 90.411682
07-25 22:06:21.910+0600 D/avoidrickshaw(32394): current lat: 23.742160, current long: 90.411682
07-25 22:06:21.921+0600 D/avoidrickshaw(32394): because step count did not update, distance not updated.
07-25 22:06:21.921+0600 D/avoidrickshaw(32394): event-values: 0.205783, -0.062812, 10.167702, 0.000000
07-25 22:06:21.961+0600 D/avoidrickshaw(32394): event-values: 0.246461, -0.056830, 10.133603, 0.000000
07-25 22:06:22.021+0600 D/avoidrickshaw(32394): event-values: 0.181855, -0.092124, 10.174880, 0.000000
07-25 22:06:22.081+0600 D/avoidrickshaw(32394): event-values: 0.196211, -0.086142, 10.180862, 0.000000
07-25 22:06:22.141+0600 D/avoidrickshaw(32394): event-values: 0.196211, -0.079561, 10.120443, 0.000000
07-25 22:06:22.201+0600 D/avoidrickshaw(32394): event-values: 0.201595, -0.089731, 10.142577, 0.000000
07-25 22:06:22.251+0600 D/avoidrickshaw(32394): event-values: 0.189033, -0.072383, 10.204790, 0.000000
07-25 22:06:22.311+0600 D/avoidrickshaw(32394): event-values: 0.215952, -0.083749, 10.159925, 0.000000
07-25 22:06:22.371+0600 D/avoidrickshaw(32394): event-values: 0.238684, -0.093320, 10.170692, 0.000000
07-25 22:06:22.431+0600 D/avoidrickshaw(32394): event-values: 0.178863, -0.067597, 10.189835, 0.000000
07-25 22:06:22.491+0600 D/avoidrickshaw(32394): event-values: 0.178265, -0.055035, 10.202397, 0.000000
07-25 22:06:22.551+0600 D/avoidrickshaw(32394): event-values: 0.211765, -0.092722, 10.164113, 0.000000
07-25 22:06:22.611+0600 D/avoidrickshaw(32394): event-values: 0.201595, -0.083151, 10.177272, 0.000000
07-25 22:06:22.671+0600 D/avoidrickshaw(32394): event-values: 0.171087, -0.069990, 10.178469, 0.000000
07-25 22:06:22.731+0600 D/avoidrickshaw(32394): event-values: 0.183649, -0.022134, 10.189835, 0.000000
07-25 22:06:22.791+0600 D/avoidrickshaw(32394): event-values: 0.182453, -0.085543, 10.168897, 0.000000
07-25 22:06:22.851+0600 D/avoidrickshaw(32394): event-values: 0.193819, -0.081954, 10.165309, 0.000000
07-25 22:06:22.911+0600 D/avoidrickshaw(32394): event-values: 0.211765, -0.079561, 10.171290, 0.000000
07-25 22:06:22.972+0600 D/avoidrickshaw(32394): event-values: 0.183649, -0.065803, 10.172487, 0.000000
07-25 22:06:23.032+0600 D/avoidrickshaw(32394): event-values: 0.187238, -0.090329, 10.120443, 0.000000
07-25 22:06:23.092+0600 D/avoidrickshaw(32394): event-values: 0.218345, -0.085543, 10.197612, 0.000000
07-25 22:06:23.152+0600 D/avoidrickshaw(32394): event-values: 0.198604, -0.056830, 10.196415, 0.000000
07-25 22:06:23.212+0600 D/avoidrickshaw(32394): event-values: 0.189033, -0.069990, 10.145569, 0.000000
07-25 22:06:23.272+0600 D/avoidrickshaw(32394): event-values: 0.199202, -0.069392, 10.148559, 0.000000
07-25 22:06:23.332+0600 D/avoidrickshaw(32394): event-values: 0.213559, -0.052642, 10.145569, 0.000000
07-25 22:06:23.392+0600 D/avoidrickshaw(32394): event-values: 0.215354, -0.062812, 10.179665, 0.000000
07-25 22:06:23.452+0600 D/avoidrickshaw(32394): event-values: 0.186640, -0.080160, 10.173084, 0.000000
07-25 22:06:23.512+0600 D/avoidrickshaw(32394): event-values: 0.209372, -0.071186, 10.159925, 0.000000
07-25 22:06:23.572+0600 D/avoidrickshaw(32394): event-values: 0.189631, -0.092124, 10.156934, 0.000000
07-25 22:06:23.632+0600 D/avoidrickshaw(32394): event-values: 0.197408, -0.075374, 10.185050, 0.000000
07-25 22:06:23.692+0600 D/avoidrickshaw(32394): event-values: 0.181256, -0.078963, 10.173683, 0.000000
07-25 22:06:23.752+0600 D/avoidrickshaw(32394): event-values: 0.212363, -0.095713, 10.165309, 0.000000
07-25 22:06:23.812+0600 D/avoidrickshaw(32394): event-values: 0.193220, -0.081356, 10.159328, 0.000000
07-25 22:06:23.872+0600 D/avoidrickshaw(32394): event-values: 0.196211, -0.068195, 10.192227, 0.000000
07-25 22:06:23.932+0600 D/avoidrickshaw(32394): event-values: 0.175274, -0.082552, 10.178469, 0.000000
07-25 22:06:23.993+0600 D/avoidrickshaw(32394): event-values: 0.195015, -0.095115, 10.164113, 0.000000
07-25 22:06:24.053+0600 D/avoidrickshaw(32394): event-values: 0.165703, -0.062812, 10.183852, 0.000000
07-25 22:06:24.113+0600 D/avoidrickshaw(32394): event-values: 0.219541, -0.066401, 10.210773, 0.000000
07-25 22:06:24.173+0600 D/avoidrickshaw(32394): event-values: 0.210568, -0.061615, 10.182058, 0.000000
07-25 22:06:24.233+0600 D/avoidrickshaw(32394): event-values: 0.210568, -0.084945, 10.177272, 0.000000
07-25 22:06:24.293+0600 D/avoidrickshaw(32394): event-values: 0.178265, -0.080758, 10.191031, 0.000000
07-25 22:06:24.353+0600 D/avoidrickshaw(32394): event-values: 0.185444, -0.091525, 10.143176, 0.000000
07-25 22:06:24.413+0600 D/avoidrickshaw(32394): event-values: 0.208176, -0.079561, 10.180862, 0.000000
07-25 22:06:24.473+0600 D/avoidrickshaw(32394): event-values: 0.199202, -0.071785, 10.167104, 0.000000
07-25 22:06:24.533+0600 D/avoidrickshaw(32394): event-values: 0.165105, -0.067597, 10.174880, 0.000000
07-25 22:06:24.593+0600 D/avoidrickshaw(32394): event-values: 0.209372, -0.069392, 10.174281, 0.000000
07-25 22:06:24.653+0600 D/avoidrickshaw(32394): event-values: 0.216550, -0.075972, 10.179067, 0.000000
07-25 22:06:24.713+0600 D/avoidrickshaw(32394): event-values: 0.196211, -0.071186, 10.168897, 0.000000
07-25 22:06:24.773+0600 D/avoidrickshaw(32394): event-values: 0.181256, -0.075374, 10.167702, 0.000000
07-25 22:06:24.833+0600 D/avoidrickshaw(32394): event-values: 0.204586, -0.090329, 10.170094, 0.000000
07-25 22:06:24.893+0600 D/avoidrickshaw(32394): event-values: 0.205783, -0.064008, 10.173683, 0.000000
07-25 22:06:24.953+0600 D/avoidrickshaw(32394): event-values: 0.192622, -0.075374, 10.177272, 0.000000
07-25 22:06:25.014+0600 D/avoidrickshaw(32394): event-values: 0.189033, -0.074776, 10.176675, 0.000000
07-25 22:06:25.074+0600 D/avoidrickshaw(32394): event-values: 0.193220, -0.061615, 10.174281, 0.000000
07-25 22:06:25.134+0600 D/avoidrickshaw(32394): event-values: 0.198604, -0.071785, 10.189835, 0.000000
07-25 22:06:25.194+0600 D/avoidrickshaw(32394): event-values: 0.185444, -0.080160, 10.182058, 0.000000
07-25 22:06:25.254+0600 D/avoidrickshaw(32394): event-values: 0.191426, -0.076570, 10.173683, 0.000000
07-25 22:06:25.314+0600 D/avoidrickshaw(32394): event-values: 0.195613, -0.084945, 10.177272, 0.000000
07-25 22:06:25.374+0600 D/avoidrickshaw(32394): event-values: 0.211167, -0.079561, 10.161121, 0.000000
07-25 22:06:25.434+0600 D/avoidrickshaw(32394): event-values: 0.190828, -0.077169, 10.177871, 0.000000
07-25 22:06:25.494+0600 D/avoidrickshaw(32394): event-values: 0.187238, -0.073579, 10.152746, 0.000000
07-25 22:06:25.554+0600 D/avoidrickshaw(32394): event-values: 0.192622, -0.083749, 10.184451, 0.000000
07-25 22:06:25.614+0600 D/avoidrickshaw(32394): event-values: 0.195015, -0.069392, 10.175477, 0.000000
07-25 22:06:25.674+0600 D/avoidrickshaw(32394): event-values: 0.190229, -0.062812, 10.158132, 0.000000
07-25 22:06:25.734+0600 D/avoidrickshaw(32394): event-values: 0.196810, -0.090927, 10.168301, 0.000000
07-25 22:06:25.794+0600 D/avoidrickshaw(32394): event-values: 0.203390, -0.085543, 10.168897, 0.000000
07-25 22:06:25.854+0600 D/avoidrickshaw(32394): event-values: 0.199801, -0.089731, 10.164113, 0.000000
07-25 22:06:25.904+0600 D/avoidrickshaw(32394): horizontal_acc: 16.000000, vertical_acc: -1.000000
07-25 22:06:25.904+0600 D/avoidrickshaw(32394): previous lat: 23.742160, previous long: 90.411682
07-25 22:06:25.904+0600 D/avoidrickshaw(32394): current lat: 23.742172, current long: 90.411648
07-25 22:06:25.914+0600 D/avoidrickshaw(32394): because step count did not update, saving position only.
07-25 22:06:25.914+0600 D/avoidrickshaw(32394): event-values: 0.192024, -0.087338, 10.165309, 0.000000
07-25 22:06:25.974+0600 D/avoidrickshaw(32394): event-values: 0.206979, -0.086142, 10.160523, 0.000000
07-25 22:06:26.035+0600 D/avoidrickshaw(32394): event-values: 0.202193, -0.081356, 10.177272, 0.000000
07-25 22:06:26.095+0600 D/avoidrickshaw(32394): event-values: 0.200399, -0.066999, 10.177871, 0.000000
07-25 22:06:26.155+0600 D/avoidrickshaw(32394): event-values: 0.207577, -0.089133, 10.179665, 0.000000
07-25 22:06:26.215+0600 D/avoidrickshaw(32394): event-values: 0.180060, -0.072981, 10.161121, 0.000000
07-25 22:06:26.275+0600 D/avoidrickshaw(32394): event-values: 0.218345, -0.071785, 10.169496, 0.000000
07-25 22:06:26.335+0600 D/avoidrickshaw(32394): event-values: 0.207577, -0.096909, 10.186844, 0.000000
07-25 22:06:26.395+0600 D/avoidrickshaw(32394): event-values: 0.182453, -0.078963, 10.177272, 0.000000
07-25 22:06:26.455+0600 D/avoidrickshaw(32394): event-values: 0.177069, -0.097508, 10.171888, 0.000000
07-25 22:06:26.515+0600 D/avoidrickshaw(32394): event-values: 0.223729, -0.061615, 10.179665, 0.000000
07-25 22:06:26.575+0600 D/avoidrickshaw(32394): event-values: 0.196810, -0.080160, 10.148559, 0.000000
07-25 22:06:26.635+0600 D/avoidrickshaw(32394): event-values: 0.169292, -0.072383, 10.162916, 0.000000
07-25 22:06:26.695+0600 D/avoidrickshaw(32394): event-values: 0.214756, -0.075972, 10.182058, 0.000000
07-25 22:06:26.755+0600 D/avoidrickshaw(32394): event-values: 0.226720, -0.073579, 10.173084, 0.000000
07-25 22:06:26.815+0600 D/avoidrickshaw(32394): event-values: 0.199801, -0.087936, 10.165908, 0.000000
07-25 22:06:26.875+0600 D/avoidrickshaw(32394): event-values: 0.180658, -0.072383, 10.173683, 0.000000
07-25 22:06:26.935+0600 D/avoidrickshaw(32394): event-values: 0.207577, -0.068794, 10.167702, 0.000000
07-25 22:06:26.995+0600 D/avoidrickshaw(32394): event-values: 0.214158, -0.058624, 10.189835, 0.000000
07-25 22:06:27.056+0600 D/avoidrickshaw(32394): event-values: 0.200997, -0.071785, 10.175477, 0.000000
07-25 22:06:27.116+0600 D/avoidrickshaw(32394): event-values: 0.186042, -0.096311, 10.179665, 0.000000
07-25 22:06:27.176+0600 D/avoidrickshaw(32394): event-values: 0.200399, -0.083151, 10.183254, 0.000000
07-25 22:06:27.236+0600 D/avoidrickshaw(32394): event-values: 0.190828, -0.084347, 10.182656, 0.000000
07-25 22:06:27.296+0600 D/avoidrickshaw(32394): event-values: 0.195613, -0.072383, 10.177272, 0.000000
07-25 22:06:27.356+0600 D/avoidrickshaw(32394): event-values: 0.192024, -0.061615, 10.165908, 0.000000
07-25 22:06:27.416+0600 D/avoidrickshaw(32394): event-values: 0.208774, -0.065803, 10.167104, 0.000000
07-25 22:06:27.476+0600 D/avoidrickshaw(32394): event-values: 0.215354, -0.071186, 10.161720, 0.000000
07-25 22:06:27.536+0600 D/avoidrickshaw(32394): event-values: 0.184247, -0.083749, 10.168301, 0.000000
07-25 22:06:27.596+0600 D/avoidrickshaw(32394): event-values: 0.202792, -0.077767, 10.176675, 0.000000
07-25 22:06:27.656+0600 D/avoidrickshaw(32394): event-values: 0.217149, -0.061017, 10.190434, 0.000000
07-25 22:06:27.716+0600 D/avoidrickshaw(32394): event-values: 0.212363, -0.075972, 10.187442, 0.000000
07-25 22:06:27.776+0600 D/avoidrickshaw(32394): event-values: 0.223729, -0.055633, 10.161121, 0.000000
07-25 22:06:27.836+0600 D/avoidrickshaw(32394): event-values: 0.192024, -0.077767, 10.165908, 0.000000
07-25 22:06:27.896+0600 D/avoidrickshaw(32394): event-values: 0.219541, -0.077169, 10.179067, 0.000000
07-25 22:06:27.956+0600 D/avoidrickshaw(32394): event-values: 0.202792, -0.067597, 10.167104, 0.000000
07-25 22:06:28.016+0600 D/avoidrickshaw(32394): event-values: 0.195613, -0.064008, 10.166506, 0.000000
07-25 22:06:28.077+0600 D/avoidrickshaw(32394): event-values: 0.203390, -0.083749, 10.158132, 0.000000
07-25 22:06:28.137+0600 D/avoidrickshaw(32394): event-values: 0.205185, -0.074178, 10.182656, 0.000000
07-25 22:06:28.197+0600 D/avoidrickshaw(32394): event-values: 0.217747, -0.069392, 10.179665, 0.000000
07-25 22:06:28.257+0600 D/avoidrickshaw(32394): event-values: 0.181256, -0.071785, 10.155738, 0.000000
07-25 22:06:28.317+0600 D/avoidrickshaw(32394): event-values: 0.202792, -0.077169, 10.189835, 0.000000
07-25 22:06:28.377+0600 D/avoidrickshaw(32394): event-values: 0.181256, -0.064008, 10.198210, 0.000000
07-25 22:06:28.437+0600 D/avoidrickshaw(32394): event-values: 0.184247, -0.077169, 10.182656, 0.000000
07-25 22:06:28.497+0600 D/avoidrickshaw(32394): event-values: 0.189033, -0.065803, 10.152746, 0.000000
07-25 22:06:28.557+0600 D/avoidrickshaw(32394): event-values: 0.189033, -0.087936, 10.141381, 0.000000
07-25 22:06:28.617+0600 D/avoidrickshaw(32394): event-values: 0.207577, -0.061017, 10.170094, 0.000000
07-25 22:06:28.677+0600 D/avoidrickshaw(32394): event-values: 0.187238, -0.079561, 10.183852, 0.000000
07-25 22:06:28.737+0600 D/avoidrickshaw(32394): event-values: 0.174078, -0.069990, 10.171290, 0.000000
07-25 22:06:28.797+0600 D/avoidrickshaw(32394): event-values: 0.209372, -0.075374, 10.155738, 0.000000
07-25 22:06:28.857+0600 D/avoidrickshaw(32394): event-values: 0.212961, -0.081954, 10.182058, 0.000000
07-25 22:06:28.917+0600 D/avoidrickshaw(32394): event-values: 0.195015, -0.072981, 10.185050, 0.000000
07-25 22:06:28.977+0600 D/avoidrickshaw(32394): event-values: 0.179462, -0.090927, 10.167702, 0.000000
07-25 22:06:29.037+0600 D/avoidrickshaw(32394): event-values: 0.207577, -0.077169, 10.168897, 0.000000
07-25 22:06:29.098+0600 D/avoidrickshaw(32394): event-values: 0.205783, -0.068195, 10.191629, 0.000000
07-25 22:06:29.158+0600 D/avoidrickshaw(32394): event-values: 0.178265, -0.087936, 10.172487, 0.000000
07-25 22:06:29.218+0600 D/avoidrickshaw(32394): event-values: 0.190229, -0.075374, 10.142577, 0.000000
07-25 22:06:29.278+0600 D/avoidrickshaw(32394): event-values: 0.205185, -0.087338, 10.153345, 0.000000
07-25 22:06:29.338+0600 D/avoidrickshaw(32394): event-values: 0.214158, -0.065803, 10.176076, 0.000000
07-25 22:06:29.398+0600 D/avoidrickshaw(32394): event-values: 0.185444, -0.076570, 10.167702, 0.000000
07-25 22:06:29.458+0600 D/avoidrickshaw(32394): event-values: 0.202193, -0.085543, 10.158132, 0.000000
07-25 22:06:29.518+0600 D/avoidrickshaw(32394): event-values: 0.190828, -0.080758, 10.161121, 0.000000
07-25 22:06:29.578+0600 D/avoidrickshaw(32394): event-values: 0.193819, -0.074178, 10.184451, 0.000000
07-25 22:06:29.638+0600 D/avoidrickshaw(32394): event-values: 0.173480, -0.074776, 10.158729, 0.000000
07-25 22:06:29.698+0600 D/avoidrickshaw(32394): event-values: 0.197408, -0.080758, 10.171290, 0.000000
07-25 22:06:29.758+0600 D/avoidrickshaw(32394): event-values: 0.201595, -0.097508, 10.176675, 0.000000
07-25 22:06:29.818+0600 D/avoidrickshaw(32394): event-values: 0.198006, -0.072981, 10.170692, 0.000000
07-25 22:06:29.878+0600 D/avoidrickshaw(32394): event-values: 0.195015, -0.078365, 10.147961, 0.000000
07-25 22:06:29.918+0600 D/avoidrickshaw(32394): horizontal_acc: 16.000000, vertical_acc: -1.000000
07-25 22:06:29.918+0600 D/avoidrickshaw(32394): previous lat: 23.742172, previous long: 90.411648
07-25 22:06:29.918+0600 D/avoidrickshaw(32394): current lat: 23.742172, current long: 90.411648
07-25 22:06:29.918+0600 D/avoidrickshaw(32394): because step count did not update, distance not updated.
07-25 22:06:29.938+0600 D/avoidrickshaw(32394): event-values: 0.202792, -0.062213, 10.163515, 0.000000
07-25 22:06:29.998+0600 D
