S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPD6
Build-Date: 2016.04.28 20:23:28

Crash Information
Process Name: avoidrickshaw
PID: 18622
Date: 2016-07-26 20:57:11+0600
Executable File Path: /opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 18622, uid 5000)

Register Information
r0   = 0x8002d96d, r1   = 0x00000001
r2   = 0xb4320000, r3   = 0xb4320010
r4   = 0xb2a0b13b, r5   = 0xb8937400
r6   = 0xb8943270, r7   = 0xbed53208
r8   = 0x800168b5, r9   = 0xb5ef1708
r10  = 0xb8942260, fp   = 0x00000000
ip   = 0xb5fe1120, sp   = 0xbed531c8
lr   = 0xb5fa5bd9, pc   = 0xb2a0a338
cpsr = 0x80000030

Memory Information
MemTotal:   730440 KB
MemFree:     41072 KB
Buffers:     46428 KB
Cached:     276248 KB
VmPeak:     116952 KB
VmSize:     116948 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24344 KB
VmRSS:       24340 KB
VmData:      42780 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36276 KB
VmPTE:          84 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 18622 TID = 18622
18622 18625 22042 22049 22085 

Maps Information
b01ef000 b09ee000 rw-p [stack:22085]
b1301000 b1b00000 rw-p [stack:22049]
b1c5b000 b1c63000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.49
b1c73000 b1c75000 r-xp /usr/lib/liblbs-agps.so.0.1.0
b1c85000 b1c93000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
b1caa000 b1cac000 r-xp /usr/lib/location/module/libwps.so.0.6.8_9
b1cbc000 b1cbf000 r-xp /usr/lib/location/module/libgps.so.0.6.8_9
b1cd0000 b24cf000 rw-p [stack:22042]
b254b000 b2553000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2564000 b2565000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b2575000 b2589000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b259d000 b259e000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b25ae000 b25b1000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b25c2000 b25c3000 r-xp /usr/lib/libxshmfence.so.1.0.0
b25d3000 b25d5000 r-xp /usr/lib/libxcb-present.so.0.0.0
b25e5000 b25e7000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b25f7000 b2607000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2617000 b2623000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b2873000 b2875000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b2885000 b288b000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b289b000 b28af000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b28bf000 b28d9000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b28e9000 b28ef000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
b28ff000 b2906000 r-xp /usr/lib/libeventsystem.so.0.0.1
b2916000 b2939000 r-xp /usr/lib/libSLP-location-product.so.0.9.0
b294a000 b2961000 r-xp /usr/lib/libSLP-location.so.0.11.5_5
b2971000 b2978000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2989000 b2991000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b29a1000 b29a5000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
b29b6000 b29c5000 r-xp /usr/lib/libcapi-location-manager.so.0.6.1_3
b29d5000 b29dc000 r-xp /usr/lib/libcapi-appfw-preference.so.0.3.1.0
b29ee000 b29f4000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2a04000 b2a0c000 r-xp /opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw
b2b2d000 b2c10000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2c47000 b2c6f000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2c81000 b3480000 rw-p [stack:18625]
b3480000 b3482000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3492000 b349c000 r-xp /lib/libnss_files-2.20-2014.11.so
b34ad000 b34b6000 r-xp /lib/libnss_nis-2.20-2014.11.so
b34c7000 b34d8000 r-xp /lib/libnsl-2.20-2014.11.so
b34eb000 b34f1000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3502000 b3503000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b352b000 b3532000 r-xp /usr/lib/libminizip.so.1.0.0
b3542000 b3547000 r-xp /usr/lib/libstorage.so.0.1
b3557000 b35ac000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b35c2000 b35d6000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b35e6000 b362a000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b363a000 b3642000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3652000 b3682000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3695000 b374e000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3762000 b37b6000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b37c7000 b37e2000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b37f2000 b38b3000 r-xp /usr/lib/libprotobuf.so.9.0.1
b38c6000 b38d8000 r-xp /usr/lib/libefl-assist.so.0.1.0
b38e8000 b38ec000 r-xp /usr/lib/libogg.so.0.7.1
b38fc000 b391e000 r-xp /usr/lib/libvorbis.so.0.4.3
b392e000 b3a12000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b3a2e000 b3a3b000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3a4c000 b3a8f000 r-xp /usr/lib/libsndfile.so.1.0.25
b3aa4000 b3aeb000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3afc000 b3b02000 r-xp /usr/lib/libjson-c.so.2.0.1
b3b13000 b3b1a000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3b2a000 b3b6a000 r-xp /usr/lib/libmdm.so.1.2.10
b3b7a000 b3b82000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3b91000 b3ba1000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3bc2000 b3c22000 r-xp /usr/lib/libasound.so.2.0.0
b3c34000 b3c6a000 r-xp /usr/lib/libpulse.so.0.16.2
b3c7b000 b3c7e000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3c8e000 b3c91000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3ca1000 b3ca6000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3cb6000 b3cb7000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3cc7000 b3cd2000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3ce6000 b3ced000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3cfd000 b3d03000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3d13000 b3d18000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3d28000 b3d43000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3d53000 b3d5a000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3d6a000 b3d6d000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3d7e000 b3dac000 r-xp /usr/lib/libidn.so.11.5.44
b3dbc000 b3dd2000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3de3000 b3ded000 r-xp /usr/lib/libcares.so.2.1.0
b3dfd000 b3e07000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3e17000 b3e19000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3e29000 b3e2a000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3e3a000 b3e3e000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3e4f000 b3e77000 r-xp /usr/lib/libui-extension.so.0.1.0
b3e88000 b3eb1000 r-xp /usr/lib/libturbojpeg.so
b3ed1000 b3ed7000 r-xp /usr/lib/libgif.so.4.1.6
b3ee7000 b3f2d000 r-xp /usr/lib/libcurl.so.4.3.0
b3f3e000 b3f5f000 r-xp /usr/lib/libexif.so.12.3.3
b3f7a000 b3f8f000 r-xp /usr/lib/libtts.so
b3fa0000 b3fa8000 r-xp /usr/lib/libfeedback.so.0.1.4
b3fb8000 b4078000 r-xp /usr/lib/libdali-core.so.0.0.0
b4083000 b4176000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b4196000 b4270000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b4287000 b4289000 r-xp /usr/lib/libboost_system.so.1.51.0
b4299000 b429f000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b42af000 b42d2000 r-xp /usr/lib/libboost_thread.so.1.51.0
b42e3000 b42e5000 r-xp /usr/lib/libappsvc.so.0.1.0
b42f5000 b42f7000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4308000 b430d000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4324000 b4326000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b4336000 b433d000 r-xp /usr/lib/libsensord-share.so
b434d000 b4365000 r-xp /usr/lib/libsensor.so.1.1.0
b4376000 b4379000 r-xp /usr/lib/libXv.so.1.0.0
b4389000 b438e000 r-xp /usr/lib/libutilX.so.1.1.0
b439e000 b43a3000 r-xp /usr/lib/libappcore-common.so.1.1
b43b3000 b43ba000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b43cd000 b43d1000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b43e2000 b44ac000 r-xp /usr/lib/libCOREGL.so.4.0
b44c3000 b44c6000 r-xp /usr/lib/libuuid.so.1.3.0
b44d7000 b44ee000 r-xp /usr/lib/libblkid.so.1.1.0
b44ff000 b4501000 r-xp /usr/lib/libXau.so.6.0.0
b4511000 b4514000 r-xp /usr/lib/libEGL.so.1.4
b451c000 b4522000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4532000 b4534000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4545000 b4553000 r-xp /usr/lib/libGLESv2.so.2.0
b455c000 b45be000 r-xp /usr/lib/libpixman-1.so.0.28.2
b45d3000 b45eb000 r-xp /usr/lib/libmount.so.1.1.0
b45fc000 b4610000 r-xp /usr/lib/libxcb.so.1.1.0
b4621000 b4628000 r-xp /lib/libcrypt-2.20-2014.11.so
b4660000 b4671000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b4682000 b4684000 r-xp /usr/lib/libiri.so
b4694000 b469f000 r-xp /usr/lib/libgpg-error.so.0.15.0
b46b0000 b46c5000 r-xp /lib/libexpat.so.1.5.2
b46d7000 b4795000 r-xp /usr/lib/libcairo.so.2.11200.14
b47a8000 b47b0000 r-xp /usr/lib/libdrm.so.2.4.0
b47c0000 b47c3000 r-xp /usr/lib/libdri2.so.0.0.0
b47d4000 b4822000 r-xp /usr/lib/libssl.so.1.0.0
b4837000 b4843000 r-xp /usr/lib/libeeze.so.1.13.0
b4853000 b485c000 r-xp /usr/lib/libethumb.so.1.13.0
b486c000 b486f000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b487f000 b4a36000 r-xp /usr/lib/libcrypto.so.1.0.0
b568d000 b5696000 r-xp /usr/lib/libXi.so.6.1.0
b56a6000 b56a8000 r-xp /usr/lib/libXgesture.so.7.0.0
b56b8000 b56bc000 r-xp /usr/lib/libXtst.so.6.1.0
b56cc000 b56d2000 r-xp /usr/lib/libXrender.so.1.3.0
b56e2000 b56e8000 r-xp /usr/lib/libXrandr.so.2.2.0
b56f9000 b56fb000 r-xp /usr/lib/libXinerama.so.1.0.0
b570b000 b570e000 r-xp /usr/lib/libXfixes.so.3.1.0
b571e000 b5729000 r-xp /usr/lib/libXext.so.6.4.0
b5739000 b573b000 r-xp /usr/lib/libXdamage.so.1.1.0
b574b000 b574d000 r-xp /usr/lib/libXcomposite.so.1.0.0
b575e000 b5840000 r-xp /usr/lib/libX11.so.6.3.0
b5853000 b585a000 r-xp /usr/lib/libXcursor.so.1.0.2
b586a000 b5882000 r-xp /usr/lib/libudev.so.1.6.0
b5884000 b5887000 r-xp /lib/libattr.so.1.1.0
b5897000 b58b7000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58b9000 b58be000 r-xp /usr/lib/libffi.so.6.0.2
b58ce000 b58e6000 r-xp /lib/libz.so.1.2.8
b58f6000 b58f8000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5908000 b59dd000 r-xp /usr/lib/libxml2.so.2.9.2
b59f2000 b5a8d000 r-xp /usr/lib/libstdc++.so.6.0.20
b5aa9000 b5aac000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5abc000 b5ad5000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5ae6000 b5af7000 r-xp /lib/libresolv-2.20-2014.11.so
b5b0b000 b5b85000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b9a000 b5b9c000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bac000 b5bb3000 r-xp /usr/lib/libembryo.so.1.13.0
b5bc3000 b5bdb000 r-xp /usr/lib/libpng12.so.0.50.0
b5bec000 b5c0f000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c30000 b5c44000 r-xp /usr/lib/libector.so.1.13.0
b5c55000 b5c6d000 r-xp /usr/lib/liblua-5.1.so
b5c7e000 b5cd5000 r-xp /usr/lib/libfreetype.so.6.11.3
b5ce9000 b5d11000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d22000 b5d35000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d46000 b5d7d000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d8e000 b5d9c000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5dac000 b5db4000 r-xp /usr/lib/libtbm.so.1.0.0
b5dc4000 b5dd1000 r-xp /usr/lib/libeio.so.1.13.0
b5de1000 b5de3000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5df3000 b5df8000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e08000 b5e1f000 r-xp /usr/lib/libefreet.so.1.13.0
b5e31000 b5e51000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e61000 b5e81000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e83000 b5e89000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e99000 b5eaa000 r-xp /usr/lib/libemotion.so.1.13.0
b5ebb000 b5ec2000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5ed2000 b5ee1000 r-xp /usr/lib/libeo.so.1.13.0
b5ef2000 b5f04000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f15000 b5f1a000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f2a000 b5f43000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f53000 b5f70000 r-xp /usr/lib/libeet.so.1.13.0
b5f89000 b5fd1000 r-xp /usr/lib/libeina.so.1.13.0
b5fe2000 b5ff2000 r-xp /usr/lib/libefl.so.1.13.0
b6003000 b60e8000 r-xp /usr/lib/libicuuc.so.51.1
b6105000 b6245000 r-xp /usr/lib/libicui18n.so.51.1
b625c000 b6294000 r-xp /usr/lib/libecore_x.so.1.13.0
b62a6000 b62a9000 r-xp /lib/libcap.so.2.21
b62b9000 b62e2000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62f3000 b62fa000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b630c000 b6343000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6354000 b643f000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6452000 b64cb000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64dd000 b64e2000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64f2000 b64fc000 r-xp /usr/lib/libvconf.so.0.2.45
b650c000 b650e000 r-xp /usr/lib/libvasum.so.0.3.1
b651e000 b6520000 r-xp /usr/lib/libttrace.so.1.1
b6530000 b6533000 r-xp /usr/lib/libiniparser.so.0
b6543000 b6569000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6579000 b657e000 r-xp /usr/lib/libxdgmime.so.1.1.0
b658f000 b65a6000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65b7000 b6622000 r-xp /lib/libm-2.20-2014.11.so
b6633000 b6639000 r-xp /lib/librt-2.20-2014.11.so
b664a000 b6657000 r-xp /usr/lib/libunwind.so.8.0.1
b668d000 b67b1000 r-xp /lib/libc-2.20-2014.11.so
b67c6000 b67df000 r-xp /lib/libgcc_s-4.9.so.1
b67ef000 b68d1000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68e2000 b690c000 r-xp /usr/lib/libdbus-1.so.3.8.12
b691d000 b6959000 r-xp /usr/lib/libsystemd.so.0.4.0
b695b000 b69dd000 r-xp /usr/lib/libedje.so.1.13.0
b69f0000 b6a0e000 r-xp /usr/lib/libecore.so.1.13.0
b6a2e000 b6bb5000 r-xp /usr/lib/libevas.so.1.13.0
b6bea000 b6bfe000 r-xp /lib/libpthread-2.20-2014.11.so
b6c12000 b6e47000 r-xp /usr/lib/libelementary.so.1.13.0
b6e75000 b6e79000 r-xp /usr/lib/libsmack.so.1.0.0
b6e89000 b6e90000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6ea0000 b6ea2000 r-xp /usr/lib/libdlog.so.0.0.0
b6eb2000 b6eb5000 r-xp /usr/lib/libbundle.so.0.1.22
b6ec5000 b6ec7000 r-xp /lib/libdl-2.20-2014.11.so
b6ed8000 b6ef0000 r-xp /usr/lib/libaul.so.0.1.0
b6f04000 b6f09000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f1a000 b6f27000 r-xp /usr/lib/liblptcp.so
b6f39000 b6f3d000 r-xp /usr/lib/libsys-assert.so
b6f4e000 b6f6e000 r-xp /lib/ld-2.20-2014.11.so
b6f7f000 b6f84000 r-xp /usr/bin/launchpad-loader
b8727000 b8a20000 rw-p [heap]
bed33000 bed54000 rw-p [stack]
b8727000 b8a20000 rw-p [heap]
bed33000 bed54000 rw-p [stack]
End of Maps Information

Callstack Information (PID:18622)
Call Stack Count: 21
 0: view_history_create + 0x23 (0xb2a0a338) [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw] + 0x6338
 1: _show_history_cb + 0x7a (0xb2a09fa3) [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw] + 0x5fa3
 2: (0xb6a947ed) [/usr/lib/libevas.so.1] + 0x667ed
 3: (0xb5edd219) [/usr/lib/libeo.so.1] + 0xb219
 4: eo_event_callback_call + 0x68 (0xb5edbfb9) [/usr/lib/libeo.so.1] + 0x9fb9
 5: evas_object_smart_callback_call + 0x38 (0xb6a95edd) [/usr/lib/libevas.so.1] + 0x67edd
 6: (0xb69b1dd7) [/usr/lib/libedje.so.1] + 0x56dd7
 7: (0xb69b611f) [/usr/lib/libedje.so.1] + 0x5b11f
 8: (0xb69b2791) [/usr/lib/libedje.so.1] + 0x57791
 9: (0xb69b2b61) [/usr/lib/libedje.so.1] + 0x57b61
10: (0xb69b2cb5) [/usr/lib/libedje.so.1] + 0x57cb5
11: (0xb69ffd11) [/usr/lib/libecore.so.1] + 0xfd11
12: (0xb69fbc4b) [/usr/lib/libecore.so.1] + 0xbc4b
13: (0xb6a01a5d) [/usr/lib/libecore.so.1] + 0x11a5d
14: ecore_main_loop_begin + 0x3e (0xb6a01c83) [/usr/lib/libecore.so.1] + 0x11c83
15: appcore_efl_main + 0x20c (0xb6f072bd) [/usr/lib/libappcore-efl.so.1] + 0x32bd
16: ui_app_main + 0xc0 (0xb43cf909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
17: main + 0x9a (0xb2a09613) [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw] + 0x5613
18: (0xb6f80baf) [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw] + 0x1baf
19: __libc_start_main + 0x114 (0xb66a34bc) [/lib/libc.so.6] + 0x164bc
20: (0xb6f80e94) [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw] + 0x1e94
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
07-25 22:05:15.055+0600 D/avoid
