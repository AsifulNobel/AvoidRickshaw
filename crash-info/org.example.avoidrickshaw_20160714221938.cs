S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPD6
Build-Date: 2016.04.28 20:23:28

Crash Information
Process Name: avoidrickshaw
PID: 15932
Date: 2016-07-14 22:19:38+0600
Executable File Path: /opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 15932, uid 5000)

Register Information
r0   = 0xb88eab68, r1   = 0x00000011
r2   = 0xffffffff, r3   = 0xc0000002
r4   = 0x79636176, r5   = 0xb88eab68
r6   = 0x00000011, r7   = 0xb29dfe1c
r8   = 0x00000000, r9   = 0xb87d9088
r10  = 0xbed39548, fp   = 0x00000000
ip   = 0xb29f256c, sp   = 0xbed39408
lr   = 0xb632a073, pc   = 0xb63372b2
cpsr = 0xa00e0030

Memory Information
MemTotal:   730440 KB
MemFree:     89664 KB
Buffers:     39332 KB
Cached:     228176 KB
VmPeak:     115696 KB
VmSize:     115692 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22476 KB
VmRSS:       22472 KB
VmData:      42120 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36232 KB
VmPTE:          84 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 15932 TID = 15932
15932 15933 19375 

Maps Information
b0d8c000 b0d94000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.49
b0da4000 b0da6000 r-xp /usr/lib/liblbs-agps.so.0.1.0
b0db6000 b0dc4000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
b0ddb000 b0ddd000 r-xp /usr/lib/location/module/libwps.so.0.6.8_9
b0ded000 b0df0000 r-xp /usr/lib/location/module/libgps.so.0.6.8_9
b170d000 b1f0c000 rw-p [stack:19375]
b2569000 b2571000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2582000 b2583000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b2593000 b25a7000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b25bb000 b25bc000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b25cc000 b25cf000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b25e0000 b25e1000 r-xp /usr/lib/libxshmfence.so.1.0.0
b25f1000 b25f3000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2603000 b2605000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2615000 b2625000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2635000 b2641000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b2891000 b2893000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b28a3000 b28a9000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b28b9000 b28cd000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b28dd000 b28f7000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b2907000 b290d000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
b291d000 b2924000 r-xp /usr/lib/libeventsystem.so.0.0.1
b2934000 b2957000 r-xp /usr/lib/libSLP-location-product.so.0.9.0
b2968000 b297f000 r-xp /usr/lib/libSLP-location.so.0.11.5_5
b298f000 b2996000 r-xp /usr/lib/libefl-extension.so.0.1.0
b29a7000 b29af000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b29bf000 b29c3000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
b29d4000 b29e3000 r-xp /usr/lib/libcapi-location-manager.so.0.6.1_3
b29f5000 b29fb000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2a0b000 b2a0f000 r-xp /opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw
b2b31000 b2c14000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2c4b000 b2c73000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2c85000 b3484000 rw-p [stack:15933]
b3484000 b3486000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3496000 b34a0000 r-xp /lib/libnss_files-2.20-2014.11.so
b34b1000 b34ba000 r-xp /lib/libnss_nis-2.20-2014.11.so
b34cb000 b34dc000 r-xp /lib/libnsl-2.20-2014.11.so
b34ef000 b34f5000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3506000 b3507000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b352f000 b3536000 r-xp /usr/lib/libminizip.so.1.0.0
b3546000 b354b000 r-xp /usr/lib/libstorage.so.0.1
b355b000 b35b0000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b35c6000 b35da000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b35ea000 b362e000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b363e000 b3646000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3656000 b3686000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3699000 b3752000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3766000 b37ba000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b37cb000 b37e6000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b37f6000 b38b7000 r-xp /usr/lib/libprotobuf.so.9.0.1
b38ca000 b38dc000 r-xp /usr/lib/libefl-assist.so.0.1.0
b38ec000 b38f0000 r-xp /usr/lib/libogg.so.0.7.1
b3900000 b3922000 r-xp /usr/lib/libvorbis.so.0.4.3
b3932000 b3a16000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b3a32000 b3a3f000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3a50000 b3a93000 r-xp /usr/lib/libsndfile.so.1.0.25
b3aa8000 b3aef000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3b00000 b3b06000 r-xp /usr/lib/libjson-c.so.2.0.1
b3b17000 b3b1e000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3b2e000 b3b6e000 r-xp /usr/lib/libmdm.so.1.2.10
b3b7e000 b3b86000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3b95000 b3ba5000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3bc6000 b3c26000 r-xp /usr/lib/libasound.so.2.0.0
b3c38000 b3c6e000 r-xp /usr/lib/libpulse.so.0.16.2
b3c7f000 b3c82000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3c92000 b3c95000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3ca5000 b3caa000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3cba000 b3cbb000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3ccb000 b3cd6000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3cea000 b3cf1000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3d01000 b3d07000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3d17000 b3d1c000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3d2c000 b3d47000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3d57000 b3d5e000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3d6e000 b3d71000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3d82000 b3db0000 r-xp /usr/lib/libidn.so.11.5.44
b3dc0000 b3dd6000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3de7000 b3df1000 r-xp /usr/lib/libcares.so.2.1.0
b3e01000 b3e0b000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3e1b000 b3e1d000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3e2d000 b3e2e000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3e3e000 b3e42000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3e53000 b3e7b000 r-xp /usr/lib/libui-extension.so.0.1.0
b3e8c000 b3eb5000 r-xp /usr/lib/libturbojpeg.so
b3ed5000 b3edb000 r-xp /usr/lib/libgif.so.4.1.6
b3eeb000 b3f31000 r-xp /usr/lib/libcurl.so.4.3.0
b3f42000 b3f63000 r-xp /usr/lib/libexif.so.12.3.3
b3f7e000 b3f93000 r-xp /usr/lib/libtts.so
b3fa4000 b3fac000 r-xp /usr/lib/libfeedback.so.0.1.4
b3fbc000 b407c000 r-xp /usr/lib/libdali-core.so.0.0.0
b4087000 b417a000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b419a000 b4274000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b428b000 b428d000 r-xp /usr/lib/libboost_system.so.1.51.0
b429d000 b42a3000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b42b3000 b42d6000 r-xp /usr/lib/libboost_thread.so.1.51.0
b42e7000 b42e9000 r-xp /usr/lib/libappsvc.so.0.1.0
b42f9000 b42fb000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b430c000 b4311000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4328000 b432a000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b433a000 b4341000 r-xp /usr/lib/libsensord-share.so
b4351000 b4369000 r-xp /usr/lib/libsensor.so.1.1.0
b437a000 b437d000 r-xp /usr/lib/libXv.so.1.0.0
b438d000 b4392000 r-xp /usr/lib/libutilX.so.1.1.0
b43a2000 b43a7000 r-xp /usr/lib/libappcore-common.so.1.1
b43b7000 b43be000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b43d1000 b43d5000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b43e6000 b44b0000 r-xp /usr/lib/libCOREGL.so.4.0
b44c7000 b44ca000 r-xp /usr/lib/libuuid.so.1.3.0
b44db000 b44f2000 r-xp /usr/lib/libblkid.so.1.1.0
b4503000 b4505000 r-xp /usr/lib/libXau.so.6.0.0
b4515000 b4518000 r-xp /usr/lib/libEGL.so.1.4
b4520000 b4526000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4536000 b4538000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4549000 b4557000 r-xp /usr/lib/libGLESv2.so.2.0
b4560000 b45c2000 r-xp /usr/lib/libpixman-1.so.0.28.2
b45d7000 b45ef000 r-xp /usr/lib/libmount.so.1.1.0
b4600000 b4614000 r-xp /usr/lib/libxcb.so.1.1.0
b4625000 b462c000 r-xp /lib/libcrypt-2.20-2014.11.so
b4664000 b4675000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b4686000 b4688000 r-xp /usr/lib/libiri.so
b4698000 b46a3000 r-xp /usr/lib/libgpg-error.so.0.15.0
b46b4000 b46c9000 r-xp /lib/libexpat.so.1.5.2
b46db000 b4799000 r-xp /usr/lib/libcairo.so.2.11200.14
b47ac000 b47b4000 r-xp /usr/lib/libdrm.so.2.4.0
b47c4000 b47c7000 r-xp /usr/lib/libdri2.so.0.0.0
b47d8000 b4826000 r-xp /usr/lib/libssl.so.1.0.0
b483b000 b4847000 r-xp /usr/lib/libeeze.so.1.13.0
b4857000 b4860000 r-xp /usr/lib/libethumb.so.1.13.0
b4870000 b4873000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4883000 b4a3a000 r-xp /usr/lib/libcrypto.so.1.0.0
b5691000 b569a000 r-xp /usr/lib/libXi.so.6.1.0
b56aa000 b56ac000 r-xp /usr/lib/libXgesture.so.7.0.0
b56bc000 b56c0000 r-xp /usr/lib/libXtst.so.6.1.0
b56d0000 b56d6000 r-xp /usr/lib/libXrender.so.1.3.0
b56e6000 b56ec000 r-xp /usr/lib/libXrandr.so.2.2.0
b56fd000 b56ff000 r-xp /usr/lib/libXinerama.so.1.0.0
b570f000 b5712000 r-xp /usr/lib/libXfixes.so.3.1.0
b5722000 b572d000 r-xp /usr/lib/libXext.so.6.4.0
b573d000 b573f000 r-xp /usr/lib/libXdamage.so.1.1.0
b574f000 b5751000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5762000 b5844000 r-xp /usr/lib/libX11.so.6.3.0
b5857000 b585e000 r-xp /usr/lib/libXcursor.so.1.0.2
b586e000 b5886000 r-xp /usr/lib/libudev.so.1.6.0
b5888000 b588b000 r-xp /lib/libattr.so.1.1.0
b589b000 b58bb000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58bd000 b58c2000 r-xp /usr/lib/libffi.so.6.0.2
b58d2000 b58ea000 r-xp /lib/libz.so.1.2.8
b58fa000 b58fc000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b590c000 b59e1000 r-xp /usr/lib/libxml2.so.2.9.2
b59f6000 b5a91000 r-xp /usr/lib/libstdc++.so.6.0.20
b5aad000 b5ab0000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5ac0000 b5ad9000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5aea000 b5afb000 r-xp /lib/libresolv-2.20-2014.11.so
b5b0f000 b5b89000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b9e000 b5ba0000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bb0000 b5bb7000 r-xp /usr/lib/libembryo.so.1.13.0
b5bc7000 b5bdf000 r-xp /usr/lib/libpng12.so.0.50.0
b5bf0000 b5c13000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c34000 b5c48000 r-xp /usr/lib/libector.so.1.13.0
b5c59000 b5c71000 r-xp /usr/lib/liblua-5.1.so
b5c82000 b5cd9000 r-xp /usr/lib/libfreetype.so.6.11.3
b5ced000 b5d15000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d26000 b5d39000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d4a000 b5d81000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d92000 b5da0000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5db0000 b5db8000 r-xp /usr/lib/libtbm.so.1.0.0
b5dc8000 b5dd5000 r-xp /usr/lib/libeio.so.1.13.0
b5de5000 b5de7000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5df7000 b5dfc000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e0c000 b5e23000 r-xp /usr/lib/libefreet.so.1.13.0
b5e35000 b5e55000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e65000 b5e85000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e87000 b5e8d000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e9d000 b5eae000 r-xp /usr/lib/libemotion.so.1.13.0
b5ebf000 b5ec6000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5ed6000 b5ee5000 r-xp /usr/lib/libeo.so.1.13.0
b5ef6000 b5f08000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f19000 b5f1e000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f2e000 b5f47000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f57000 b5f74000 r-xp /usr/lib/libeet.so.1.13.0
b5f8d000 b5fd5000 r-xp /usr/lib/libeina.so.1.13.0
b5fe6000 b5ff6000 r-xp /usr/lib/libefl.so.1.13.0
b6007000 b60ec000 r-xp /usr/lib/libicuuc.so.51.1
b6109000 b6249000 r-xp /usr/lib/libicui18n.so.51.1
b6260000 b6298000 r-xp /usr/lib/libecore_x.so.1.13.0
b62aa000 b62ad000 r-xp /lib/libcap.so.2.21
b62bd000 b62e6000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62f7000 b62fe000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6310000 b6347000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6358000 b6443000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6456000 b64cf000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64e1000 b64e6000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64f6000 b6500000 r-xp /usr/lib/libvconf.so.0.2.45
b6510000 b6512000 r-xp /usr/lib/libvasum.so.0.3.1
b6522000 b6524000 r-xp /usr/lib/libttrace.so.1.1
b6534000 b6537000 r-xp /usr/lib/libiniparser.so.0
b6547000 b656d000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b657d000 b6582000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6593000 b65aa000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65bb000 b6626000 r-xp /lib/libm-2.20-2014.11.so
b6637000 b663d000 r-xp /lib/librt-2.20-2014.11.so
b664e000 b665b000 r-xp /usr/lib/libunwind.so.8.0.1
b6691000 b67b5000 r-xp /lib/libc-2.20-2014.11.so
b67ca000 b67e3000 r-xp /lib/libgcc_s-4.9.so.1
b67f3000 b68d5000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68e6000 b6910000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6921000 b695d000 r-xp /usr/lib/libsystemd.so.0.4.0
b695f000 b69e1000 r-xp /usr/lib/libedje.so.1.13.0
b69f4000 b6a12000 r-xp /usr/lib/libecore.so.1.13.0
b6a32000 b6bb9000 r-xp /usr/lib/libevas.so.1.13.0
b6bee000 b6c02000 r-xp /lib/libpthread-2.20-2014.11.so
b6c16000 b6e4b000 r-xp /usr/lib/libelementary.so.1.13.0
b6e79000 b6e7d000 r-xp /usr/lib/libsmack.so.1.0.0
b6e8d000 b6e94000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6ea4000 b6ea6000 r-xp /usr/lib/libdlog.so.0.0.0
b6eb6000 b6eb9000 r-xp /usr/lib/libbundle.so.0.1.22
b6ec9000 b6ecb000 r-xp /lib/libdl-2.20-2014.11.so
b6edc000 b6ef4000 r-xp /usr/lib/libaul.so.0.1.0
b6f08000 b6f0d000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f1e000 b6f2b000 r-xp /usr/lib/liblptcp.so
b6f3d000 b6f41000 r-xp /usr/lib/libsys-assert.so
b6f52000 b6f72000 r-xp /lib/ld-2.20-2014.11.so
b6f83000 b6f88000 r-xp /usr/bin/launchpad-loader
b8672000 b8933000 rw-p [heap]
bed19000 bed3a000 rw-p [stack]
b8672000 b8933000 rw-p [heap]
bed19000 bed3a000 rw-p [stack]
End of Maps Information

Callstack Information (PID:15932)
Call Stack Count: 13
 0: g_type_check_instance + 0x9 (0xb63372b2) [/usr/lib/libgobject-2.0.so.0] + 0x272b2
 1: g_signal_handler_disconnect + 0xe (0xb632a073) [/usr/lib/libgobject-2.0.so.0] + 0x1a073
 2: location_manager_destroy + 0x6c (0xb29d8155) [/usr/lib/libcapi-location-manager.so.0] + 0x4155
 3: _data_distance_tracker_destroy + 0x22 (0xb2a0d373) [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw] + 0x2373
 4: data_finalize + 0x8 (0xb2a0d349) [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw] + 0x2349
 5: app_terminate + 0x10 (0xb2a0dcbd) [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw] + 0x2cbd
 6: (0xb43d3589) [/usr/lib/libcapi-appfw-application.so.0] + 0x2589
 7: appcore_efl_main + 0x25e (0xb6f0b30f) [/usr/lib/libappcore-efl.so.1] + 0x330f
 8: ui_app_main + 0xc0 (0xb43d3909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
 9: main + 0x9a (0xb2a0dbd3) [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw] + 0x2bd3
10: selectAllItemcb + 0xa2 (0xb6f84baf) [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw] + 0x1baf
11: __libc_start_main + 0x114 (0xb66a74bc) [/lib/libc.so.6] + 0x164bc
12: deleteMsgAll + 0x3b (0xb6f84e94) [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw] + 0x1e94
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
07-14 21:58:44.614+0600 D/avoidrickshaw( 8684): event-values: -2.657828, -7.911270, 0.917049, 0.000000
07-14 21:58:44.674+0600 D/avoidrickshaw( 8684): event-values: -5.201996, -10.389636, 0.924228, 0.000000
07-14 21:58:44.734+0600 D/avoidrickshaw( 8684): event-values: -1.921437, -8.738588, -3.280560, 0.000000
07-14 21:58:44.794+0600 D/avoidrickshaw( 8684): event-values: -0.097508, -6.431309, 0.028116, 0.000000
07-14 21:58:44.854+0600 D/avoidrickshaw( 8684): event-values: -3.723232, -6.527620, -0.460020, 0.000000
07-14 21:58:44.914+0600 D/avoidrickshaw( 8684): event-values: -1.569093, -9.829715, -0.342772, 0.000000
07-14 21:58:44.974+0600 D/avoidrickshaw( 8684): event-values: 3.218945, -12.482160, -5.633901, 0.000000
07-14 21:58:45.034+0600 D/avoidrickshaw( 8684): event-values: 4.794618, -8.909675, -1.925624, 0.000000
07-14 21:58:45.094+0600 D/avoidrickshaw( 8684): event-values: -7.059425, -17.941383, 3.364907, 0.000000
07-14 21:58:45.154+0600 D/avoidrickshaw( 8684): event-values: -4.615157, -5.731409, 1.640280, 0.000000
07-14 21:58:45.214+0600 D/avoidrickshaw( 8684): event-values: -4.142574, -9.656834, 1.990230, 0.000000
07-14 21:58:45.274+0600 D/avoidrickshaw( 8684): event-values: -1.986043, -9.530612, 1.197608, 0.000000
07-14 21:58:45.334+0600 D/avoidrickshaw( 8684): event-values: -0.246461, -10.299307, 3.627519, 0.000000
07-14 21:58:45.394+0600 D/avoidrickshaw( 8684): event-values: -0.003589, -9.754940, 2.836093, 0.000000
07-14 21:58:45.454+0600 D/avoidrickshaw( 8684): event-values: 0.116052, -9.859627, 2.268994, 0.000000
07-14 21:58:45.514+0600 D/avoidrickshaw( 8684): event-values: -0.532403, -10.323833, 1.586441, 0.000000
07-14 21:58:45.574+0600 D/avoidrickshaw( 8684): event-values: -1.104886, -9.508479, 1.722234, 0.000000
07-14 21:58:45.635+0600 D/avoidrickshaw( 8684): event-values: -1.780260, -9.824929, 2.014757, 0.000000
07-14 21:58:45.695+0600 D/avoidrickshaw( 8684): event-values: -2.350948, -9.614362, 0.996611, 0.000000
07-14 21:58:45.755+0600 D/avoidrickshaw( 8684): event-values: -1.010968, -10.518847, -0.240479, 0.000000
07-14 21:58:45.815+0600 D/avoidrickshaw( 8684): event-values: -2.654238, -8.470592, 0.850649, 0.000000
07-14 21:58:45.875+0600 D/avoidrickshaw( 8684): event-values: -1.626521, -9.157930, -0.208176, 0.000000
07-14 21:58:45.935+0600 D/avoidrickshaw( 8684): event-values: 1.703092, -10.501500, -1.630110, 0.000000
07-14 21:58:45.995+0600 D/avoidrickshaw( 8684): event-values: -0.329611, -8.304890, -0.666999, 0.000000
07-14 21:58:46.055+0600 D/avoidrickshaw( 8684): event-values: -2.691327, -7.841280, -2.513660, 0.000000
07-14 21:58:46.115+0600 D/avoidrickshaw( 8684): event-values: -2.736193, -9.161520, -1.611566, 0.000000
07-14 21:58:46.175+0600 D/avoidrickshaw( 8684): event-values: -1.572084, -9.177671, -0.778864, 0.000000
07-14 21:58:46.235+0600 D/avoidrickshaw( 8684): event-values: -0.661017, -9.160921, -2.795415, 0.000000
07-14 21:58:46.295+0600 D/avoidrickshaw( 8684): event-values: 0.425922, -9.044271, -4.042076, 0.000000
07-14 21:58:46.355+0600 D/avoidrickshaw( 8684): event-values: -2.255235, -10.841879, -5.009972, 0.000000
07-14 21:58:46.425+0600 D/avoidrickshaw( 8684): horizontal_acc: 24.000000, vertical_acc: -1.000000
07-14 21:58:46.425+0600 D/avoidrickshaw( 8684): previous lat: 23.741849, previous long: 90.411761
07-14 21:58:46.425+0600 D/avoidrickshaw( 8684): current lat: 23.741849, current long: 90.411761
07-14 21:58:46.435+0600 D/avoidrickshaw( 8684): total distance: 188.000000 meters
07-14 21:58:46.435+0600 D/avoidrickshaw( 8684): event-values: -1.830509, -8.656634, 2.269592, 0.000000
07-14 21:58:46.475+0600 D/avoidrickshaw( 8684): event-values: -2.180459, -8.863613, 1.333400, 0.000000
07-14 21:58:46.535+0600 D/avoidrickshaw( 8684): event-values: -1.122234, -8.347960, 2.103291, 0.000000
07-14 21:58:46.595+0600 D/avoidrickshaw( 8684): event-values: -0.170489, -10.410573, 2.461018, 0.000000
07-14 21:58:46.656+0600 D/avoidrickshaw( 8684): event-values: -0.125025, -8.928220, 1.683351, 0.000000
07-14 21:58:46.716+0600 D/avoidrickshaw( 8684): event-values: -0.628116, -10.095917, 1.122832, 0.000000
07-14 21:58:46.776+0600 D/avoidrickshaw( 8684): event-values: -0.333799, -10.053445, 0.632902, 0.000000
07-14 21:58:46.836+0600 D/avoidrickshaw( 8684): event-values: -0.136391, -9.421141, 0.689133, 0.000000
07-14 21:58:46.896+0600 D/avoidrickshaw( 8684): event-values: -0.923031, -9.918848, -0.151944, 0.000000
07-14 21:58:46.956+0600 D/avoidrickshaw( 8684): event-values: -0.709472, -10.261021, 0.432503, 0.000000
07-14 21:58:47.016+0600 D/avoidrickshaw( 8684): event-values: 0.510269, -11.569896, 0.739980, 0.000000
07-14 21:58:47.076+0600 D/avoidrickshaw( 8684): event-values: 1.345365, -12.071791, 1.147358, 0.000000
07-14 21:58:47.136+0600 D/avoidrickshaw( 8684): event-values: 0.463011, -11.894722, 0.063410, 0.000000
07-14 21:58:47.196+0600 D/avoidrickshaw( 8684): event-values: -3.827918, -9.524033, -2.712265, 0.000000
07-14 21:58:47.256+0600 D/avoidrickshaw( 8684): event-values: -4.532006, -8.962915, 1.573879, 0.000000
07-14 21:58:47.316+0600 D/avoidrickshaw( 8684): event-values: -3.829713, -9.062816, 0.610170, 0.000000
07-14 21:58:47.376+0600 D/avoidrickshaw( 8684): event-values: 0.397807, -7.288538, -1.331008, 0.000000
07-14 21:58:47.436+0600 D/avoidrickshaw( 8684): event-values: -3.251846, -6.224928, 1.584049, 0.000000
07-14 21:58:47.486+0600 D/avoidrickshaw( 8684): event-values: -0.066999, -7.649854, 0.165105, 0.000000
07-14 21:58:47.546+0600 D/avoidrickshaw( 8684): event-values: -3.374478, -9.344570, -4.141378, 0.000000
07-14 21:58:47.606+0600 D/avoidrickshaw( 8684): event-values: 6.232106, -15.769300, -11.054242, 0.000000
07-14 21:58:47.666+0600 D/avoidrickshaw( 8684): event-values: -1.433301, -4.585845, 2.644069, 0.000000
07-14 21:58:47.727+0600 D/avoidrickshaw( 8684): event-values: -6.083153, -19.503897, 3.972684, 0.000000
07-14 21:58:47.787+0600 D/avoidrickshaw( 8684): event-values: 1.213161, -4.055236, -4.715655, 0.000000
07-14 21:58:47.847+0600 D/avoidrickshaw( 8684): event-values: -1.674378, -10.296914, 0.516252, 0.000000
07-14 21:58:47.907+0600 D/avoidrickshaw( 8684): event-values: -1.433301, -10.456635, 2.093720, 0.000000
07-14 21:58:47.967+0600 D/avoidrickshaw( 8684): event-values: 0.808176, -9.386445, 1.467997, 0.000000
07-14 21:58:48.027+0600 D/avoidrickshaw( 8684): event-values: 0.516252, -8.268997, 0.983450, 0.000000
07-14 21:58:48.087+0600 D/avoidrickshaw( 8684): event-values: -0.613161, -9.762716, 0.723231, 0.000000
07-14 21:58:48.147+0600 D/avoidrickshaw( 8684): event-values: -0.991825, -10.016356, 0.728615, 0.000000
07-14 21:58:48.207+0600 D/avoidrickshaw( 8684): event-values: -1.223929, -9.731011, 0.143569, 0.000000
07-14 21:58:48.267+0600 D/avoidrickshaw( 8684): event-values: -0.659821, -10.089933, 1.091127, 0.000000
07-14 21:58:48.327+0600 D/avoidrickshaw( 8684): event-values: 0.220140, -11.740983, 0.410967, 0.000000
07-14 21:58:48.387+0600 D/avoidrickshaw( 8684): event-values: 1.787439, -15.434902, -0.152542, 0.000000
07-14 21:58:48.447+0600 D/avoidrickshaw( 8684): event-values: -0.513859, -9.181261, -2.343171, 0.000000
07-14 21:58:48.507+0600 D/avoidrickshaw( 8684): event-values: -3.853043, -7.729415, 2.423331, 0.000000
07-14 21:58:48.567+0600 D/avoidrickshaw( 8684): event-values: -4.324429, -10.774881, 1.034896, 0.000000
07-14 21:58:48.627+0600 D/avoidrickshaw( 8684): event-values: 0.077767, -9.189635, -3.081357, 0.000000
07-14 21:58:48.687+0600 D/avoidrickshaw( 8684): event-values: -2.289931, -5.860621, 1.609771, 0.000000
07-14 21:58:48.748+0600 D/avoidrickshaw( 8684): event-values: -1.773680, -7.052845, -0.907478, 0.000000
07-14 21:58:48.808+0600 D/avoidrickshaw( 8684): event-values: -0.665803, -9.060423, 0.007178, 0.000000
07-14 21:58:48.868+0600 D/avoidrickshaw( 8684): event-values: 3.895515, -14.275579, -7.574480, 0.000000
07-14 21:58:48.928+0600 D/avoidrickshaw( 8684): event-values: -0.149551, -7.741978, -3.262614, 0.000000
07-14 21:58:48.988+0600 D/avoidrickshaw( 8684): event-values: -4.683352, -18.858433, 5.720641, 0.000000
07-14 21:58:49.048+0600 D/avoidrickshaw( 8684): event-values: -1.211366, -3.547958, -1.759921, 0.000000
07-14 21:58:49.108+0600 D/avoidrickshaw( 8684): event-values: -2.190031, -10.290334, 1.507478, 0.000000
07-14 21:58:49.168+0600 D/avoidrickshaw( 8684): event-values: -1.743171, -9.182457, 1.123430, 0.000000
07-14 21:58:49.228+0600 D/avoidrickshaw( 8684): event-values: 0.514457, -9.285348, 1.101895, 0.000000
07-14 21:58:49.288+0600 D/avoidrickshaw( 8684): event-values: -0.020937, -9.879367, 2.157728, 0.000000
07-14 21:58:49.348+0600 D/avoidrickshaw( 8684): event-values: -0.190828, -9.715458, 0.482752, 0.000000
07-14 21:58:49.408+0600 D/avoidrickshaw( 8684): event-values: -0.274576, -9.639486, 0.781855, 0.000000
07-14 21:58:49.468+0600 D/avoidrickshaw( 8684): event-values: -1.024128, -9.907482, 0.817149, 0.000000
07-14 21:58:49.528+0600 D/avoidrickshaw( 8684): event-values: -0.785444, -9.824332, 0.630509, 0.000000
07-14 21:58:49.588+0600 D/avoidrickshaw( 8684): event-values: -0.873380, -10.963913, -0.678963, 0.000000
07-14 21:58:49.648+0600 D/avoidrickshaw( 8684): event-values: -0.461815, -14.531013, -2.067997, 0.000000
07-14 21:58:49.708+0600 D/avoidrickshaw( 8684): event-values: -0.385843, -8.054241, 0.058026, 0.000000
07-14 21:58:49.769+0600 D/avoidrickshaw( 8684): event-values: -3.964309, -7.737192, 1.918446, 0.000000
07-14 21:58:49.829+0600 D/avoidrickshaw( 8684): event-values: -5.018347, -10.257432, 0.330808, 0.000000
07-14 21:58:49.889+0600 D/avoidrickshaw( 8684): event-values: -1.077368, -7.902297, -0.757328, 0.000000
07-14 21:58:49.949+0600 D/avoidrickshaw( 8684): event-values: -0.997209, -7.065407, 0.325424, 0.000000
07-14 21:58:50.009+0600 D/avoidrickshaw( 8684): event-values: -1.064806, -7.131808, -0.644267, 0.000000
07-14 21:58:50.069+0600 D/avoidrickshaw( 8684): event-values: -1.401596, -8.537591, -1.543969, 0.000000
07-14 21:58:50.129+0600 D/avoidrickshaw( 8684): event-values: 4.728816, -13.887344, -5.675776, 0.000000
07-14 21:58:50.189+0600 D/avoidrickshaw( 8684): event-values: 0.707079, -7.395617, -1.986043, 0.000000
07-14 21:58:50.249+0600 D/avoidrickshaw( 8684): event-values: -5.833104, -19.599611, 4.441677, 0.000000
07-14 21:58:50.309+0600 D/avoidrickshaw( 8684): event-values: -1.482952, -3.526422, -3.557529, 0.000000
07-14 21:58:50.369+0600 D/avoidrickshaw( 8684): event-values: -2.484348, -10.220942, 1.601995, 0.000000
07-14 21:58:50.419+0600 D/avoidrickshaw( 8684): horizontal_acc: 24.000000, vertical_acc: -1.000000
07-14 21:58:50.419+0600 D/avoidrickshaw( 8684): previous lat: 23.741849, previous long: 90.411761
07-14 21:58:50.419+0600 D/avoidrickshaw( 8684): current lat: 23.741849, current long: 90.411761
07-14 21:58:50.419+0600 D/avoidrickshaw( 8684): total distance: 188.000000 meters
07-14 21:58:50.429+0600 D/avoidrickshaw( 8684): event-values: -1.861616, -9.068199, 1.885544, 0.000000
07-14 21:58:50.489+0600 D/avoidrickshaw( 8684): event-values: 0.389432, -9.623933, 2.351547, 0.000000
07-14 21:58:50.549+0600 D/avoidrickshaw( 8684): event-values: 0.034098, -9.460623, 2.897708, 0.000000
07-14 21:58:50.609+0600 D/avoidrickshaw( 8684): event-values: -0.466002, -9.527023, 0.764507, 0.000000
07-14 21:58:50.669+0600 D/avoidrickshaw( 8684): event-values: -0.507278, -9.884750, 0.704088, 0.000000
07-14 21:58:50.729+0600 D/avoidrickshaw( 8684): event-values: -0.774676, -9.820145, 0.345763, 0.000000
07-14 21:58:50.790+0600 D/avoidrickshaw( 8684): event-values: -0.264407, -9.699904, 1.009173, 0.000000
07-14 21:58:50.850+0600 D/avoidrickshaw( 8684): event-values: 0.210568, -10.643873, 0.378664, 0.000000
07-14 21:58:50.910+0600 D/avoidrickshaw( 8684): event-values: 0.464806, -12.828521, 1.643869, 0.000000
07-14 21:58:50.970+0600 D/avoidrickshaw( 8684): event-values: -0.530010, -11.167901, -1.511666, 0.000000
07-14 21:58:51.030+0600 D/avoidrickshaw( 8684): event-values: -3.805784, -8.205586, -0.327219, 0.000000
07-14 21:58:51.090+0600 D/avoidrickshaw( 8684): event-values: -3.756732, -10.001998, 1.297508, 0.000000
07-14 21:58:51.150+0600 D/avoidrickshaw( 8684): event-values: -2.799603, -9.521640, -0.627518, 0.000000
07-14 21:58:51.210+0600 D/avoidrickshaw( 8684): event-values: -1.048056, -7.396813, -1.451845, 0.000000
07-14 21:58:51.270+0600 D/avoidrickshaw( 8684): event-values: -1.615754, -6.572486, -0.997807, 0.000000
07-14 21:58:51.330+0600 D/avoidrickshaw( 8684): event-values: -0.671187, -8.286943, 0.157328, 0.000000
07-14 21:58:51.390+0600 D/avoidrickshaw( 8684): event-values: -1.819143, -10.516455, -3.699902, 0.000000
07-14 21:58:51.450+0600 D/avoidrickshaw( 8684): event-values: 8.630912, -12.026326, -7.183852, 0.000000
07-14 21:58:51.510+0600 D/avoidrickshaw( 8684): event-values: -5.985646, -17.422739, 3.544369, 0.000000
07-14 21:58:51.570+0600 D/avoidrickshaw( 8684): event-values: -3.760919, -4.411169, 1.360918, 0.000000
07-14 21:58:51.630+0600 D/avoidrickshaw( 8684): event-values: -4.337589, -9.792626, 1.963311, 0.000000
07-14 21:58:51.690+0600 D/avoidrickshaw( 8684): event-values: -3.079563, -8.414361, 1.110270, 0.000000
07-14 21:58:51.750+0600 D/avoidrickshaw( 8684): event-values: -1.222732, -10.867003, 2.264807, 0.000000
07-14 21:58:51.811+0600 D/avoidrickshaw( 8684): event-values: -0.023928, -9.197412, 2.983252, 0.000000
07-14 21:58:51.871+0600 D/avoidrickshaw( 8684): event-values: -0.239880, -9.890733, 1.683351, 0.000000
07-14 21:58:51.931+0600 D/avoidrickshaw( 8684): event-values: -0.970888, -10.140184, 1.204786, 0.000000
07-14 21:58:51.991+0600 D/avoidrickshaw( 8684): event-values: -1.886142, -10.016954, 1.088136, 0.000000
07-14 21:58:52.051+0600 D/avoidrickshaw( 8684): event-values: -1.907080, -9.583853, 1.154537, 0.000000
07-14 21:58:52.111+0600 D/avoidrickshaw( 8684): event-values: -2.214557, -9.530014, 1.813759, 0.000000
07-14 21:58:52.171+0600 D/avoidrickshaw( 8684): event-values: -3.020939, -10.377073, 1.636093, 0.000000
07-14 21:58:52.231+0600 D/avoidrickshaw( 8684): event-values: -3.572484, -9.221939, 0.270389, 0.000000
07-14 21:58:52.291+0600 D/avoidrickshaw( 8684): event-values: -3.254239, -8.090732, 0.074776, 0.000000
07-14 21:58:52.351+0600 D/avoidrickshaw( 8684): event-values: -2.254637, -10.509278, 0.061017, 0.000000
07-14 21:58:52.411+0600 D/avoidrickshaw( 8684): event-values: -0.809970, -9.780663, 1.247259, 0.000000
07-14 21:58:52.471+0600 D/avoidrickshaw( 8684): event-values: 0.628714, -9.028718, -1.801795, 0.000000
07-14 21:58:52.531+0600 D/avoidrickshaw( 8684): event-values: -1.331008, -8.495118, -1.562513, 0.000000
07-14 21:58:52.591+0600 D/avoidrickshaw( 8684): event-values: -2.105684, -7.783852, -0.858425, 0.000000
07-14 21:58:52.651+0600 D/avoidrickshaw( 8684): event-values: -3.279363, -10.707881, -1.877169, 0.000000
07-14 21:58:52.711+0600 D/avoidrickshaw( 8684): event-values: -1.437488, -8.396415, -0.894916, 0.000000
07-14 21:58:52.771+0600 D/avoidrickshaw( 8684): event-values: -0.040678, -9.174082, -1.711466, 0.000000
07-14 21:58:52.832+0600 D/avoidrickshaw( 8684): event-values: -0.649651, -9.461819, -3.485744, 0.000000
07-14 21:58:52.892+0600 D/avoidrickshaw( 8684): event-values: -2.822335, -16.508680, 0.213559, 0.000000
07-14 21:58:52.952+0600 D/avoidrickshaw( 8684): event-values: -3.059822, -7.855038, 0.102891, 0.000000
07-14 21:58:53.012+0600 D/avoidrickshaw( 8684): event-values: -2.567499, -9.387043, 1.806581, 0.000000
07-14 21:58:53.072+0600 D/avoidrickshaw( 8684): event-values: -0.716650, -9.357133, 2.852843, 0.000000
07-14 21:58:53.132+0600 D/avoidrickshaw( 8684): event-values: -0.723231, -9.669396, 2.555535, 0.000000
07-14 21:58:53.192+0600 D/avoidrickshaw( 8684): event-values: -0.914058, -9.704691, 1.314856, 0.000000
07-14 21:58:53.252+0600 D/avoidrickshaw( 8684): event-values: -0.920040, -10.010373, 0.948754, 0.000000
07-14 21:58:53.312+0600 D/avoidrickshaw( 8684): event-values: -0.918844, -9.675976, 0.631107, 0.000000
07-14 21:58:53.372+0600 D/avoidrickshaw( 8684): event-values: -1.013959, -9.652647, 0.536590, 0.000000
07-14 21:58:53.432+0600 D/avoidrickshaw( 8684): event-values: -1.305883, -9.480962, 0.506082, 0.000000
07-14 21:58:53.492+0600 D/avoidrickshaw( 8684): event-values: -0.636491, -9.816555, 0.957727, 0.000000
07-14 21:58:53.552+0600 D/avoidrickshaw( 8684): event-values: -0.397209, -10.463216, 1.435694, 0.000000
07-14 21:58:53.612+0600 D/avoidrickshaw( 8684): event-values: 0.128016, -10.990234, 1.051646, 0.000000
07-14 21:58:53.672+0600 D/avoidrickshaw( 8684): event-values: 0.080758, -12.571891, 0.497109, 0.000000
07-14 21:58:53.732+0600 D/avoidrickshaw( 8684): event-values: -2.065604, -9.778270, -2.240878, 0.000000
07-14 21:58:53.792+0600 D/avoidrickshaw( 8684): event-values: -2.303690, -8.536395, -0.099900, 0.000000
07-14 21:58:53.853+0600 D/avoidrickshaw( 8684): event-values: -2.634498, -9.994222, 1.174876, 0.000000
07-14 21:58:53.913+0600 D/avoidrickshaw( 8684): event-values: -2.827718, -9.492328, 1.898705, 0.000000
07-14 21:58:53.973+0600 D/avoidrickshaw( 8684): event-values: 0.023330, -8.134400, -3.221338, 0.000000
07-14 21:58:54.033+0600 D/avoidrickshaw( 8684): event-values: -1.986641, -9.034700, 0.220738, 0.000000
07-14 21:58:54.093+0600 D/avoidrickshaw( 8684): event-values: -1.712065, -7.000801, 0.094516, 0.000000
07-14 21:58:54.153+0600 D/avoidrickshaw( 8684): event-values: -3.517449, -7.969894, -1.500300, 0.000000
07-14 21:58:54.213+0600 D/avoidrickshaw( 8684): event-values: 2.343171, -12.195619, -4.347161, 0.000000
07-14 21:58:54.273+0600 D/avoidrickshaw( 8684): event-values: 2.851646, -11.257034, -4.630112, 0.000000
07-14 21:58:54.333+0600 D/avoidrickshaw( 8684): event-values: -2.361118, -12.519846, 3.706482, 0.000000
07-14 21:58:54.393+0600 D/avoidrickshaw( 8684): event-values: -2.854039, -6.017351, -4.338188, 0.000000
07-14 21:58:54.423+0600 D/avoidrickshaw( 8684): horizontal_acc: 24.000000, vertical_acc: -1.000000
07-14 21:58:54.423+0600 D/avoidrickshaw( 8684): previous lat: 23.741849, previous long: 90.411761
07-14 21:58:54.423+0600 D/avoidrickshaw( 8684): current lat: 23.741742, current long: 90.411744
07-14 21:58:54.433+0600 D/avoidrickshaw( 8684): total distance: 199.000000 meters
07-14 21:58:54.453+0600 D/avoidrickshaw( 8684): event-values: -2.153540, -7.571489, 2.285744, 0.000000
07-14 21:58:54.513+0600 D/avoidrickshaw( 8684): event-values: -2.652444, -8.717053, 0.479761, 0.000000
07-14 21:58:54.573+0600 D/avoidrickshaw( 8684): event-values: -1.454238, -10.451849, 1.749752, 0.000000
07-14 21:58:54.633+0600 D/avoidrickshaw( 8684): event-values: -0.282353, -8.618947, 1.077368, 0.000000
07-14 21:58:54.693+0600 D/avoidrickshaw( 8684): event-values: -0.404387, -10.272985, 1.546362, 0.000000
07-14 21:58:54.753+0600 D/avoidrickshaw( 8684): event-values: -0.292523, -9.096315, 0.708874, 0.000000
07-14 21:58:54.813+0600 D/avoidrickshaw( 8684): event-values: -0.952942, -9.820743, 0.789631, 0.000000
07-14 21:58:54.874+0600 D/avoidrickshaw( 8684): event-values: -1.464408, -9.765109, 0.627518, 0.000000
07-14 21:58:54.934+0600 D/avoidrickshaw( 8684): event-values: -1.328017, -10.042078, 0.208176, 0.000000
07-14 21:58:54.994+0600 D/avoidrickshaw( 8684): event-values: 0.064008, -10.956136, -0.105284, 0.000000
07-14 21:58:55.054+0600 D/avoidrickshaw( 8684): event-values: 0.990030, -14.452648, -0.443270, 0.000000
07-14 21:58:55.114+0600 D/avoidrickshaw( 8684): event-values: -0.300897, -10.411769, -0.973879, 0.000000
07-14 21:58:55.174+0600 D/avoidrickshaw( 8684): event-values: -2.693720, -7.418947, 1.970490, 0.000000
07-14 21:58:55.234+0600 D/avoidrickshaw( 8684): event-values: -3.687938, -10.159328, 2.156531, 0.000000
07-14 21:58:55.294+0600 D/avoidrickshaw( 8684): event-values: -2.386242, -7.530811, 0.772283, 0.000000
07-14 21:58:55.354+0600 D/avoidrickshaw( 8684): event-values: -0.925424, -7.334600, 0.570688, 0.000000
07-14 21:58:55.414+0600 D/avoidrickshaw( 8684): event-values: -2.325225, -7.459624, -1.540380, 0.000000
07-14 21:58:55.474+0600 D/avoidrickshaw( 8684): event-values: -1.173679, -7.962118, 0.997807, 0.000000
07-14 21:58:55.534+0600 D/avoidrickshaw( 8684): event-values: -0.585643, -11.806786, -5.511269, 0.000000
07-14 21:58:55.594+0600 D/avoidrickshaw( 8684): event-values: 5.693721, -12.639487, -5.107480, 0.000000
07-14 21:58:55.654+0600 D/avoidrickshaw( 8684): event-values: -1.685145, -5.841478, 1.718645, 0.000000
07-14 21:58:55.714+0600 D/avoidrickshaw( 8684): event-values: -7.706684, -19.281963, 1.143171, 0.000000
07-14 21:58:55.774+0600 D/avoidrickshaw( 8684): event-values: -2.401796, -5.726623, 1.442872, 0.000000
07-14 21:58:55.834+0600 D/avoidrickshaw( 8684): event-values: -2.784647, -9.538389, 0.333201, 0.000000
07-14 21:58:55.895+0600 D/avoidrickshaw( 8684): event-values: -2.138585, -9.419346, 2.206781, 0.000000
07-14 21:58:55.955+0600 D/avoidrickshaw( 8684): event-values: 0.084347, -10.302896, 1.005584, 0.000000
07-14 21:58:56.015+0600 D/avoidrickshaw( 8684): event-values: 0.129212, -9.023932, 1.433301, 0.000000
07-14 21:58:56.075+0600 D/avoidrickshaw( 8684): event-values: -0.285344, -10.144372, 0.896710, 0.000000
07-14 21:58:56.135+0600 D/avoidrickshaw( 8684): event-values: -0.213559, -9.387043, 0.410369, 0.000000
07-14 21:58:56.195+0600 D/avoidrickshaw( 8684): event-values: -1.080359, -9.605388, 0.527617, 0.000000
07-14 21:58:56.255+0600 D/avoidrickshaw( 8684): event-values: -1.348954, -9.829117, 0.915255, 0.000000
07-14 21:58:56.285+0600 I/Tizen::Net::Wifi( 1367): (941) > The background scan result updated.
07-14 21:58:56.315+0600 D/avoidrickshaw( 8684): event-values: -1.094716, -11.032109, 0.757328, 0.000000
07-14 21:58:56.375+0600 D/avoidrickshaw( 8684): event-values: -0.285942, -10.038489, -0.668794, 0.000000
07-14 21:58:56.435+0600 D/avoidrickshaw( 8684): event-values: -1.134198, -14.149359, -0.911067, 0.000000
07-14 21:58:56.495+0600 D/avoidrickshaw( 8684): event-values: -1.587638, -7.834699, -1.138385, 0.000000
07-14 21:58:56.555+0600 D/avoidrickshaw( 8684): event-values: -3.643072, -7.735995, 2.041676, 0.000000
07-14 21:58:56.615+0600 D/avoidrickshaw( 8684): event-values: -3.772285, -10.654043, 1.055235, 0.000000
07-14 21:58:56.675+0600 D/avoidrickshaw( 8684): event-values: 1.326222, -8.066205, -2.333600, 0.000000
07-14 21:58:56.735+0600 D/avoidrickshaw( 8684): event-values: -1.336990, -7.133004, 0.834497, 0.000000
07-14 21:58:56.795+0600 D/avoidrickshaw( 8684): event-values: -1.155733, -7.759924, -1.639682, 0.000000
07-14 21:58:56.855+0600 D/avoidrickshaw( 8684): event-values: -2.199004, -8.764311, -0.928415, 0.000000
07-14 21:58:56.916+0600 D/avoidrickshaw( 8684): event-values: 4.798207, -13.392628, -6.747161, 0.000000
07-14 21:58:56.976+0600 D/avoidrickshaw( 8684): event-values: 3.439682, -9.285348, -4.024129, 0.000000
07-14 21:58:57.036+0600 D/avoidrickshaw( 8684): event-values: -5.017749, -16.461424, 4.677370, 0.000000
07-14 21:58:57.096+0600 D/avoidrickshaw( 8684): event-values: -4.124628, -3.047858, -1.835893, 0.000000
07-14 21:58:57.156+0600 D/avoidrickshaw( 8684): event-values: -4.156333, -8.454441, -0.178265, 0.000000
07-14 21:58:57.216+0600 D/avoidrickshaw( 8684): event-values: -1.820340, -9.683154, 1.325026, 0.000000
07-14 21:58:57.276+0600 D/avoidrickshaw( 8684): event-values: 0.180658, -10.782058, 1.288535, 0.000000
07-14 21:58:57.336+0600 D/avoidrickshaw( 8684): event-values: 0.781855, -9.191430, 1.630110, 0.000000
07-14 21:58:57.396+0600 D/avoidrickshaw( 8684): event-values: -0.276371, -9.445667, 1.148555, 0.000000
07-14 21:58:57.456+0600 D/avoidrickshaw( 8684): event-values: -0.724427, -9.576674, 0.850649, 0.000000
07-14 21:58:57.516+0600 D/avoidrickshaw( 8684): event-values: -1.182054, -10.077971, 0.444467, 0.000000
07-14 21:58:57.576+0600 D/avoidrickshaw( 8684): event-values: -1.313660, -9.509675, 0.808774, 0.000000
07-14 21:58:57.636+0600 D/avoidrickshaw( 8684): event-values: -1.232902, -10.073784, 0.800399, 0.000000
07-14 21:58:57.686+0600 D/avoidrickshaw( 8684): event-values: -0.415753, -12.041282, -0.010169, 0.000000
07-14 21:58:57.746+0600 D/avoidrickshaw( 8684): event-values: -1.135993, -13.640285, -0.874577, 0.000000
07-14 21:58:57.806+0600 D/avoidrickshaw( 8684): event-values: -1.125823, -8.044071, -0.801596, 0.000000
07-14 21:58:57.866+0600 D/avoidrickshaw( 8684): event-values: -3.079563, -8.359325, 1.527219, 0.000000
07-14 21:58:57.927+0600 D/avoidrickshaw( 8684): event-values: -3.667599, -9.698709, 0.372084, 0.000000
07-14 21:58:57.987+0600 D/avoidrickshaw( 8684): event-values: -1.405185, -8.114659, -0.497109, 0.000000
07-14 21:58:58.047+0600 D/avoidrickshaw( 8684): event-values: -1.301097, -7.734201, 0.113659, 0.000000
07-14 21:58:58.107+0600 D/avoidrickshaw( 8684): event-values: -0.710070, -9.541381, -0.445663, 0.000000
07-14 21:58:58.167+0600 D/avoidrickshaw( 8684): event-values: 0.372084, -10.197014, -3.840480, 0.000000
07-14 21:58:58.227+0600 D/avoidrickshaw( 8684): event-values: -0.434297, -9.872188, -1.684547, 0.000000
07-14 21:58:58.287+0600 D/avoidrickshaw( 8684): event-values: -1.208375, -7.893324, -0.393619, 0.000000
07-14 21:58:58.347+0600 D/avoidrickshaw( 8684): event-values: -2.438884, -8.484949, 1.735395, 0.000000
07-14 21:58:58.407+0600 D/avoidrickshaw( 8684): event-values: -6.089135, -14.233108, 2.108077, 0.000000
07-14 21:58:58.467+0600 D/avoidrickshaw( 8684): event-values: -3.138785, -6.900302, 1.212563, 0.000000
07-14 21:58:58.527+0600 D/avoidrickshaw( 8684): event-values: -0.099900, -9.440284, 1.433301, 0.000000
07-14 21:58:58.587+0600 D/avoidrickshaw( 8684): event-values: -0.395414, -10.241282, 0.867398, 0.000000
07-14 21:58:58.647+0600 D/avoidrickshaw( 8684): event-values: -0.793221, -11.692528, 2.501098, 0.000000
07-14 21:58:58.707+0600 D/avoidrickshaw( 8684): event-values: -0.711865, -8.328818, 1.661217, 0.000000
07-14 21:58:58.767+0600 D/avoidrickshaw( 8684): event-values: -2.274976, -9.458827, 0.874577, 0.000000
07-14 21:58:58.827+0600 D/avoidrickshaw( 8684): event-values: -2.443072, -9.685548, 0.985245, 0.000000
07-14 21:58:58.887+0600 D/avoidrickshaw( 8684): event-values: -2.528615, -9.894321, 1.456033, 0.000000
07-14 21:58:58.947+0600 D/avoidrickshaw( 8684): event-values: -1.316651, -8.946764, 1.009771, 0.000000
07-14 21:58:59.008+0600 D/avoidrickshaw( 8684): event-values: -0.771685, -10.457233, 0.963709, 0.000000
07-14 21:58:59.068+0600 D/avoidrickshaw( 8684): event-values: -0.372682, -9.649655, 1.107279, 0.000000
07-14 21:58:59.128+0600 D/avoidrickshaw( 8684): event-values: -0.779462, -9.452846, 1.135394, 0.000000
07-14 21:58:59.188+0600 D/avoidrickshaw( 8684): event-values: -1.173679, -10.677971, 0.698106, 0.000000
07-14 21:58:59.248+0600 D/avoidrickshaw( 8684): event-values: -2.665006, -9.920044, 1.265803, 0.000000
07-14 21:58:59.308+0600 D/avoidrickshaw( 8684): event-values: -1.514059, -9.357732, 1.278365, 0.000000
07-14 21:58:59.368+0600 D/avoidrickshaw( 8684): event-values: -2.275574, -11.723635, 1.363909, 0.000000
07-14 21:58:59.438+0600 D/avoidrickshaw( 8684): event-values: -3.208775, -10.118649, 1.980659, 0.000000
07-14 21:58:59.488+0600 D/avoidrickshaw( 8684): event-values: -3.252444, -8.877372, -0.162712, 0.000000
07-14 21:58:59.548+0600 D/avoidrickshaw( 8684): event-values: -5.121239, -9.742377, -1.281955, 0.000000
07-14 21:58:59.608+0600 D/avoidrickshaw( 8684): event-values: -2.883351, -6.580861, -3.383451, 0.000000
07-14 21:58:59.668+0600 D/avoidrickshaw( 8684): event-values: -1.540978, -5.714659, -0.076570, 0.000000
07-14 21:58:59.728+0600 D/avoidrickshaw( 8684): event-values: -2.764907, -11.331212, 3.390630, 0.000000
07-14 21:58:59.788+0600 D/avoidrickshaw( 8684): event-values: -5.172684, -8.131410, 2.815156, 0.000000
07-14 21:58:59.848+0600 D/avoidrickshaw( 8684): event-values: -3.706482, -8.270193, -1.942972, 0.000000
07-14 21:58:59.908+0600 D/avoidrickshaw( 8684): event-values: -1.412363, -7.280163, -2.417349, 0.000000
07-14 21:58:59.968+0600 D/avoidrickshaw( 8684): event-values: -1.179662, -10.609177, -0.661615, 0.000000
07-14 21:59:00.029+0600 D/avoidrickshaw( 8684): event-values: -3.236891, -8.313264, -5.029713, 0.000000
07-14 21:59:00.089+0600 D/avoidrickshaw( 8684): event-values: -2.386242, -6.321239, -11.147562, 0.000000
07-14 21:59:00.149+0600 D/avoidrickshaw( 8684): event-values: -4.372285, -15.436697, -5.126623, 0.000000
07-14 21:59:00.209+0600 D/avoidrickshaw( 8684): event-values: -2.106880, -5.693123, 1.039083, 0.000000
07-14 21:59:00.269+0600 D/avoidrickshaw( 8684): event-values: -1.951347, -7.621140, 2.006980, 0.000000
07-14 21:59:00.329+0600 D/avoidrickshaw( 8684): event-values: -4.834698, -9.655638, 0.073579, 0.000000
07-14 21:59:00.389+0600 D/avoidrickshaw( 8684): event-values: -3.032902, -12.185450, 1.837090, 0.000000
07-14 21:59:00.449+0600 D/avoidrickshaw( 8684): event-values: -1.070788, -9.021540, -1.301696, 0.000000
07-14 21:59:00.509+0600 D/avoidrickshaw( 8684): event-values: -0.898505, -8.979067, 1.919642, 0.000000
07-14 21:59:00.569+0600 D/avoidrickshaw( 8684): event-values: -2.257628, -9.598209, 1.618146, 0.000000
07-14 21:59:00.629+0600 D/avoidrickshaw( 8684): event-values: -1.792822, -10.061819, 0.123230, 0.000000
07-14 21:59:00.689+0600 D/avoidrickshaw( 8684): event-values: -2.027917, -9.388239, 0.270987, 0.000000
07-14 21:59:00.749+0600 D/avoidrickshaw( 8684): event-values: -3.773481, -9.290731, -0.066999, 0.000000
07-14 21:59:00.809+0600 D/avoidrickshaw( 8684): event-values: -2.436492, -9.443872, 1.769492, 0.000000
07-14 21:59:00.869+0600 D/avoidrickshaw( 8684): event-values: -2.883351, -10.165908, 0.407378, 0.000000
07-14 21:59:00.929+0600 D/avoidrickshaw( 8684): event-values: -3.610171, -9.914660, 1.327418, 0.000000
07-14 21:59:00.989+0600 D/avoidrickshaw( 8684): event-values: -3.506083, -11.849855, 1.774876, 0.000000
07-14 21:59:01.050+0600 D/avoidrickshaw( 8684): event-values: -0.626920, -8.583055, 0.110070, 0.000000
07-14 21:59:01.110+0600 D/avoidrickshaw( 8684): event-values: -5.903692, -7.707880, 1.362713, 0.000000
07-14 21:59:01.170+0600 D/avoidrickshaw( 8684): event-values: -1.207777, -8.450851, -0.436690, 0.000000
07-14 21:59:01.230+0600 D/avoidrickshaw( 8684): event-values: -1.849652, -9.775877, -1.081556, 0.000000
07-14 21:59:01.290+0600 D/avoidrickshaw( 8684): event-values: -1.174278, -8.288737, 1.168894, 0.000000
07-14 21:59:01.350+0600 D/avoidrickshaw( 8684): event-values: -1.306481, -9.151351, 0.464806, 0.000000
07-14 21:59:01.410+0600 D/avoidrickshaw( 8684): event-values: -0.886541, -9.817751, 0.685544, 0.000000
07-14 21:59:01.470+0600 D/avoidrickshaw( 8684): event-values: 0.666401, -10.375278, 0.396610, 0.000000
07-14 21:59:01.530+0600 D/avoidrickshaw( 8684): event-values: 1.105484, -10.594223, 0.041874, 0.000000
07-14 21:59:01.590+0600 D/avoidrickshaw( 8684): event-values: 1.908874, -10.480563, 0.520439, 0.000000
07-14 21:59:01.650+0600 D/avoidrickshaw( 8684): event-values: 0.991227, -11.111073, -0.336790, 0.000000
07-14 21:59:01.710+0600 D/avoidrickshaw( 8684): event-values: -0.325424, -9.708879, 1.664806, 0.000000
07-14 21:59:01.770+0600 D/avoidrickshaw( 8684): event-values: 1.627718, -11.464014, 4.415954, 0.000000
07-14 21:59:01.830+0600 D/avoidrickshaw( 8684): event-values: 2.751148, -9.131610, 1.852643, 0.000000
07-14 21:59:01.890+0600 D/avoidrickshaw( 8684): event-values: 1.314258, -8.328818, 2.551945, 0.000000
07-14 21:59:01.950+0600 D/avoidrickshaw( 8684): event-values: 2.057229, -11.223535, 4.378267, 0.000000
07-14 21:59:02.010+0600 D/avoidrickshaw( 8684): event-values: 4.292724, -11.198411, 3.522833, 0.000000
07-14 21:59:02.071+0600 D/avoidrickshaw( 8684): event-values: 3.160321, -9.811769, 2.824727, 0.000000
07-14 21:59:02.131+0600 D/avoidrickshaw( 8684): event-values: 4.434498, -7.632506, 4.248457, 0.000000
07-14 21:59:02.191+0600 D/avoidrickshaw( 8684): event-values: 5.634500, -4.730012, 6.026324, 0.000000
07-14 21:59:02.251+0600 D/avoidrickshaw( 8684): event-values: 5.064409, -4.291528, 9.483355, 0.000000
07-14 21:59:02.311+0600 D/avoidrickshaw( 8684): event-values: 3.030510, -4.904090, 10.437491, 0.000000
07-14 21:59:02.371+0600 D/avoidrickshaw( 8684): event-values: 2.128416, -4.432106, 10.743176, 0.000000
07-14 21:59:02.431+0600 D/avoidrickshaw( 8684): event-values: 1.838884, -5.477170, 10.463216, 0.000000
07-14 21:59:02.491+0600 D/avoidrickshaw( 8684): event-values: 1.524228, -4.457231, 10.391430, 0.000000
07-14 21:59:02.551+0600 D/avoidrickshaw( 8684): event-values: 1.967498, -2.371886, 8.955138, 0.000000
07-14 21:59:02.611+0600 D/avoidrickshaw( 8684): event-values: 1.910669, -3.097509, 9.436694, 0.000000
07-14 21:59:02.671+0600 D/avoidrickshaw( 8684): event-values: 2.925226, -1.264009, 8.272586, 0.000000
07-14 21:59:02.731+0600 D/avoidrickshaw( 8684): event-values: 3.881158, 0.168694, 7.949555, 0.000000
07-14 21:59:02.791+0600 D/avoidrickshaw( 8684): event-values: 3.272783, -0.400798, 8.743972, 0.000000
07-14 21:59:02.851+0600 D/avoidrickshaw( 8684): event-values: 2.147558, -0.307478, 8.952147, 0.000000
07-14 21:59:02.911+0600 D/avoidrickshaw( 8684): event-values: 2.669194, 0.899701, 7.619346, 0.000000
07-14 21:59:02.971+0600 D/avoidrickshaw( 8684): event-values: 3.666403, 1.071386, 8.518449, 0.000000
07-14 21:59:03.031+0600 D/avoidrickshaw( 8684): event-values: 3.464209, 0.645464, 9.529416, 0.000000
07-14 21:59:03.092+0600 D/avoidrickshaw( 8684): event-values: 2.552544, 0.890130, 9.017352, 0.000000
07-14 21:59:03.152+0600 D/avoidrickshaw( 8684): event-values: 3.617948, 1.779064, 8.087142, 0.000000
07-14 21:59:03.212+0600 D/avoidrickshaw( 8684): event-values: 3.842873, 1.363909, 7.826923, 0.000000
07-14 21:59:03.272+0600 D/avoidrickshaw( 8684): event-values: 3.313461, 1.185045, 7.940581, 0.000000
07-14 21:59:03.332+0600 D/avoidrickshaw( 8684): event-values: 2.567499, 0.753141, 11.499906, 0.000000
07-14 21:59:03.392+0600 D/avoidrickshaw( 8684): event-values: 3.336791, 1.751546, 9.918848, 0.000000
07-14 21:59:03.452+0600 D/avoidrickshaw( 8684): event-values: 2.509473, 1.240080, 9.474979, 0.000000
07-14 21:59:03.512+0600 D/avoidrickshaw( 8684): event-values: 3.163311, 2.416153, 9.223135, 0.000000
07-14 21:59:03.572+0600 D/avoidrickshaw( 8684): event-values: 1.468595, 1.729412, 12.281161, 0.000000
07-14 21:59:03.632+0600 D/avoidrickshaw( 8684): event-values: 1.429712, 1.332802, 9.002397, 0.000000
07-14 21:59:03.692+0600 D/avoidrickshaw( 8684): event-values: 1.415953, 2.118844, 9.050852, 0.000000
07-14 21:59:03.752+0600 D/avoidrickshaw( 8684): event-values: 1.772483, 3.349353, 9.517452, 0.000000
07-14 21:59:03.812+0600 D/avoidrickshaw( 8684): event-values: -2.662614, 2.889333, 12.589238, 0.000000
07-14 21:59:03.872+0600 D/avoidrickshaw( 8684): event-values: -0.171685, 1.491925, 8.656035, 0.000000
07-14 21:59:03.932+0600 D/avoidrickshaw( 8684): event-values: -0.354736, 4.153940, 9.480364, 0.000000
07-14 21:59:03.992+0600 D/avoidrickshaw( 8684): event-values: -1.487139, 3.374478, 9.288938, 0.000000
07-14 21:59:04.052+0600 D/avoidrickshaw( 8684): event-values: -3.814159, 3.243471, 9.337392, 0.000000
07-14 21:59:04.113+0600 D/avoidrickshaw( 8684): event-values: 0.332602, 3.146562, 9.071789, 0.000000
07-14 21:59:04.173+0600 D/avoidrickshaw( 8684): event-values: -0.629312, 4.275974, 9.369097, 0.000000
07-14 21:59:04.233+0600 D/avoidrickshaw( 8684): event-values: -1.420140, 3.904488, 10.441679, 0.000000
07-14 21:59:04.293+0600 D/avoidrickshaw( 8684): event-values: 0.862014, 3.111268, 9.121440, 0.000000
07-14 21:59:04.353+0600 D/avoidrickshaw( 8684): event-values: 0.922433, 3.641278, 10.612766, 0.000000
07-14 21:59:04.413+0600 D/avoidrickshaw( 8684): event-values: 1.066002, 3.699304, 8.393423, 0.000000
07-14 21:59:04.473+0600 D/avoidrickshaw( 8684): event-values: 3.240480, 0.951147, 11.839686, 0.000000
07-14 21:59:04.533+0600 D/avoidrickshaw( 8684): event-values: 2.274976, 0.444467, 7.999206, 0.000000
07-14 21:59:04.593+0600 D/avoidrickshaw( 8684): event-values: 1.909473, 3.392424, 9.455239, 0.000000
07-14 21:59:04.653+0600 D/avoidrickshaw( 8684): event-values: 3.577868, 0.286541, 10.740783, 0.000000
07-14 21:59:04.713+0600 D/avoidrickshaw( 8684): event-values: 4.066602, 2.945565, 8.937192, 0.000000
07-14 21:59:04.773+0600 D/avoidrickshaw( 8684): event-values: 3.119045, 2.140380, 8.112267, 0.000000
07-14 21:59:04.833+0600 D/avoidrickshaw( 8684): event-values: 2.410769, 2.071586, 8.370692, 0.000000
07-14 21:59:04.893+0600 D/avoidrickshaw( 8684): event-values: 3.525226, 2.828914, 10.110274, 0.000000
07-14 21:59:04.953+0600 D/avoidrickshaw( 8684): event-values: 3.171686, 2.720639, 8.230712, 0.000000
07-14 21:59:05.013+0600 D/avoidrickshaw( 8684): event-values: 3.410370, 3.092125, 9.173484, 0.000000
07-14 21:59:05.073+0600 D/avoidrickshaw( 8684): event-values: 3.005385, 3.393621, 9.056834, 0.000000
07-14 21:59:05.134+0600 D/avoidrickshaw( 8684): event-values: 2.991028, 3.128017, 9.376873, 0.000000
07-14 21:59:05.194+0600 D/avoidrickshaw( 8684): event-values: 2.671587, 3.664608, 9.226725, 0.000000
07-14 21:59:05.254+0600 D/avoidrickshaw( 8684): event-values: 2.462214, 5.044668, 8.860621, 0.000000
07-14 21:59:05.314+0600 D/avoidrickshaw( 8684): event-values: 2.405385, 5.772087, 9.380463, 0.000000
07-14 21:59:05.374+0600 D/avoidrickshaw( 8684): event-values: 1.406980, 4.262814, 9.528220, 0.000000
07-14 21:59:05.434+0600 D/avoidrickshaw( 8684): event-values: 0.189631, 5.405386, 6.681957, 0.000000
07-14 21:59:05.494+0600 D/avoidrickshaw( 8684): event-values: 1.735993, 5.486742, 9.919446, 0.000000
07-14 21:59:05.554+0600 D/avoidrickshaw( 8684): event-values: 1.176670, 4.775476, 9.153145, 0.000000
07-14 21:59:05.614+0600 D/avoidrickshaw( 8684): event-values: 0.608375, 4.210770, 7.663613, 0.000000
07-14 21:59:05.674+0600 D/avoidrickshaw( 8684): event-values: 0.016152, 4.582854, 6.722037, 0.000000
07-14 21:59:05.734+0600 D/avoidrickshaw( 8684): event-values: 0.765703, 5.938387, 8.063214, 0.000000
07-14 21:59:05.794+0600 D/avoidrickshaw( 8684): event-values: 0.924228, 5.344967, 8.274979, 0.000000
07-14 21:59:05.854+0600 D/avoidrickshaw( 8684): event-values: 1.249053, 5.483751, 8.128418, 0.000000
07-14 21:59:05.914+0600 D/avoidrickshaw( 8684): event-values: 1.427319, 5.679365, 8.024929, 0.000000
07-14 21:59:05.974+0600 D/avoidrickshaw( 8684): event-values: 1.643271, 6.101099, 7.184450, 0.000000
07-14 21:59:06.034+0600 D/avoidrickshaw( 8684): event-values: 3.833302, 4.495515, 11.652448, 0.000000
07-14 21:59:06.094+0600 D/avoidrickshaw( 8684): event-values: 2.417349, 4.901099, 7.485348, 0.000000
07-14 21:59:06.155+0600 D/avoidrickshaw( 8684): event-values: 2.219343, 5.417949, 6.165108, 0.000000
07-14 21:59:06.215+0600 D/avoidrickshaw( 8684): event-values: 4.100101, 5.925825, 7.864609, 0.000000
07-14 21:59:06.275+0600 D/avoidrickshaw( 8684): event-values: 4.457231, 5.156533, 7.846066, 0.000000
07-14 21:59:06.335+0600 D/avoidrickshaw( 8684): event-values: 4.732405, 5.889933, 6.187242, 0.000000
07-14 21:59:06.395+0600 D/avoidrickshaw( 8684): event-values: 4.466204, 6.064609, 5.392824, 0.000000
07-14 21:59:06.425+0600 D/avoidrickshaw( 8684): horizontal_acc: 24.000000, vertical_acc: -1.000000
07-14 21:59:06.425+0600 D/avoidrickshaw( 8684): previous lat: 23.741742, previous long: 90.411744
07-14 21:59:06.425+0600 D/avoidrickshaw( 8684): current lat: 23.741742, current long: 90.411744
07-14 21:59:06.435+0600 D/avoidrickshaw( 8684): total distance: 199.000000 meters
07-14 21:59:06.475+0600 D/avoidrickshaw( 8684): event-values: 5.548956, 6.046663, 4.926822, 0.000000
07-14 21:59:06.515+0600 D/avoidrickshaw( 8684): event-values: 5.456832, 5.845665, 4.829913, 0.000000
07-14 21:59:06.575+0600 D/avoidrickshaw( 8684): event-values: 6.138786, 4.619344, 3.306881, 0.000000
07-14 21:59:06.635+0600 D/avoidrickshaw( 8684): event-values: 8.291728, 4.255635, 3.411567, 0.000000
07-14 21:59:06.695+0600 D/avoidrickshaw( 8684): event-values: 9.263813, 4.612165, 4.356133, 0.000000
07-14 21:59:06.755+0600 D/avoidrickshaw( 8684): event-values: 16.133009, 4.229912, 6.848258, 0.000000
07-14 21:59:06.815+0600 D/avoidrickshaw( 8684): event-values: 15.288939, 4.765306, 5.820541, 0.000000
07-14 21:59:06.875+0600 D/avoidrickshaw( 8684): event-values: 6.985846, 2.598605, 2.413162, 0.000000
07-14 21:59:06.935+0600 D/avoidrickshaw( 8684): event-values: 0.213559, -0.296710, 0.291326, 0.000000
07-14 21:59:06.995+0600 D/avoidrickshaw( 8684): event-values: -0.749552, -1.228714, 2.288136, 0.000000
07-14 21:59:07.055+0600 D/avoidrickshaw( 8684): event-values: 7.527820, -2.588436, 2.342573, 0.000000
07-14 21:59:07.115+0600 D/avoidrickshaw( 8684): event-values: 19.568504, 1.161715, 7.858029, 0.000000
07-14 21:59:07.176+0600 D/avoidrickshaw( 8684): event-values: 19.468006, 3.891926, 5.595018, 0.000000
07-14 21:59:07.236+0600 D/avoidrickshaw( 8684): event-values: 6.185446, 1.350748, 1.916053, 0.000000
07-14 21:59:07.296+0600 D/avoidrickshaw( 8684): event-values: -2.698505, 0.494716, 0.457627, 0.000000
07-14 21:59:07.356+0600 D/avoidrickshaw( 8684): event-values: -2.383251, -0.010169, 0.747757, 0.000000
07-14 21:59:07.416+0600 D/avoidrickshaw( 8684): event-values: 17.020746, 2.299503, 4.250251, 0.000000
07-14 21:59:07.476+0600 D/avoidrickshaw( 8684): event-values: 19.568504, 1.693520, 9.497711, 0.000000
07-14 21:59:07.536+0600 D/avoidrickshaw( 8684): event-values: 9.343374, 3.248855, 2.730809, 0.000000
07-14 21:59:07.596+0600 D/avoidrickshaw( 8684): event-values: 1.856830, 2.220540, 1.996810, 0.000000
07-14 21:59:07.656+0600 D/avoidrickshaw( 8684): event-values: 1.106082, -1.445265, 1.834098, 0.000000
07-14 21:59:07.716+0600 D/avoidrickshaw( 8684): event-values: 13.691133, 1.421337, 5.627919, 0.000000
07-14 21:59:07.776+0600 D/avoidrickshaw( 8684): event-values: 16.679169, -2.152344, 7.788638, 0.000000
07-14 21:59:07.836+0600 D/avoidrickshaw( 8684): event-values: 8.562716, 1.441077, 2.730809, 0.000000
07-14 21:59:07.896+0600 D/avoidrickshaw( 8684): event-values: 2.511866, 0.022732, 1.451247, 0.000000
07-14 21:59:07.946+0600 D/avoidrickshaw( 8684): event-values: 4.894519, -1.711466, 3.177669, 0.000000
07-14 21:59:08.006+0600 D/avoidrickshaw( 8684): event-values: 14.060226, 1.060619, 6.008976, 0.000000
07-14 21:59:08.066+0600 D/avoidrickshaw( 8684): event-values: 12.052648, 0.921835, 4.752146, 0.000000
07-14 21:59:08.126+0600 D/avoidrickshaw( 8684): event-values: 8.622537, 1.780260, 4.211966, 0.000000
07-14 21:59:08.187+0600 D/avoidrickshaw( 8684): event-values: 4.280161, 0.312862, 5.281558, 0.000000
07-14 21:59:08.247+0600 D/avoidrickshaw( 8684): event-values: 0.147159, 1.939383, 10.523634, 0.000000
07-14 21:59:08.307+0600 D/avoidrickshaw( 8684): event-values: 10.260423, 6.391828, 12.664613, 0.000000
07-14 21:59:08.367+0600 D/avoidrickshaw( 8684): event-values: 9.506684, 7.048657, 6.995417, 0.000000
07-14 21:59:08.427+0600 D/avoidrickshaw( 8684): event-values: 3.817749, 3.921238, 5.702694, 0.000000
07-14 21:59:08.487+0600 D/avoidrickshaw( 8684): event-values: -7.032506, -0.995414, 2.931208, 0.000000
07-14 21:59:08.547+0600 D/avoidrickshaw( 8684): event-values: -5.584250, -1.689931, 10.578669, 0.000000
07-14 21:59:08.607+0600 D/avoidrickshaw( 8684): event-values: 4.354339, 6.374479, 14.124832, 0.000000
07-14 21:59:08.667+0600 D/avoidrickshaw( 8684): event-values: 4.920840, 6.357729, 11.240882, 0.000000
07-14 21:59:08.727+0600 D/avoidrickshaw( 8684): event-values: -2.358725, 1.222732, 5.915058, 0.000000
07-14 21:59:08.787+0600 D/avoidrickshaw( 8684): event-values: -7.978269, -1.593620, 4.864608, 0.000000
07-14 21:59:08.847+0600 D/avoidrickshaw( 8684): event-values: -8.218747, -3.632903, 8.248059, 0.000000
07-14 21:59:08.907+0600 D/avoidrickshaw( 8684): event-values: -3.169892, 0.055633, 12.923635, 0.000000
07-14 21:59:08.967+0600 D/avoidrickshaw( 8684): event-values: 2.666801, 4.449454, 10.178469, 0.000000
07-14 21:59:09.027+0600 D/avoidrickshaw( 8684): event-values: 5.590232, 2.588436, 7.715657, 0.000000
07-14 21:59:09.087+0600 D/avoidrickshaw( 8684): event-values: 5.096114, 3.555136, 9.156734, 0.000000
07-14 21:59:09.147+0600 D/avoidrickshaw( 8684): event-values: 4.970490, 3.225525, 12.302697, 0.000000
07-14 21:59:09.208+0600 D/avoidrickshaw( 8684): event-values: 2.427519, 2.531606, 13.013965, 0.000000
07-14 21:59:09.268+0600 D/avoidrickshaw( 8684): event-values: -5.644071, -0.446261, 1.918446, 0.000000
07-14 21:59:09.328+0600 D/avoidrickshaw( 8684): event-values: 3.099902, 4.271189, 6.577869, 0.000000
07-14 21:59:09.388+0600 D/avoidrickshaw( 8684): event-values: 12.174682, 7.727022, 11.769098, 0.000000
07-14 21:59:09.448+0600 D/avoidrickshaw( 8684): event-values: 6.909873, 3.646063, 6.323632, 0.000000
07-14 21:59:09.508+0600 D/avoidrickshaw( 8684): event-values: 2.937190, 4.362714, 5.749953, 0.000000
07-14 21:59:09.568+0600 D/avoidrickshaw( 8684): event-values: 3.363710, 1.877768, 7.195218, 0.000000
07-14 21:59:09.628+0600 D/avoidrickshaw( 8684): event-values: 5.465207, 3.728018, 8.563314, 0.000000
07-14 21:59:09.688+0600 D/avoidrickshaw( 8684): event-values: 8.464610, 3.839882, 8.672188, 0.000000
07-14 21:59:09.748+0600 D/avoidrickshaw( 8684): event-values: 7.147361, 3.467200, 7.899903, 0.000000
07-14 21:59:09.808+0600 D/avoidrickshaw( 8684): event-values: 8.846266, 2.600998, 5.295915, 0.000000
07-14 21:59:09.868+0600 D/avoidrickshaw( 8684): event-values: 8.036893, 1.954936, 5.530411, 0.000000
07-14 21:59:09.928+0600 D/avoidrickshaw( 8684): event-values: 6.430112, 3.100500, 5.786443, 0.000000
07-14 21:59:09.988+0600 D/avoidrickshaw( 8684): event-values: 6.645466, 2.482554, 6.159724, 0.000000
07-14 21:59:10.048+0600 D/avoidrickshaw( 8684): event-values: 5.584250, 3.831507, 5.800800, 0.000000
07-14 21:59:10.108+0600 D/avoidrickshaw( 8684): event-values: 4.268198, 3.479762, 7.666604, 0.000000
07-14 21:59:10.168+0600 D/avoidrickshaw( 8684): event-values: 3.421736, 3.598207, 7.130013, 0.000000
07-14 21:59:10.229+0600 D/avoidrickshaw( 8684): event-values: 3.537788, 3.287738, 8.502895, 0.000000
07-14 21:59:10.289+0600 D/avoidrickshaw( 8684): event-values: 2.657229, 3.221936, 8.426923, 0.000000
07-14 21:59:10.349+0600 D/avoidrickshaw( 8684): event-values: 2.724229, 2.312663, 10.135997, 0.000000
07-14 21:59:10.429+0600 D/avoidrickshaw( 8684): horizontal_acc: 24.000000, vertical_acc: -1.000000
07-14 21:59:10.429+0600 D/avoidrickshaw( 8684): previous lat: 23.741742, previous long: 90.411744
07-14 21:59:10.429+0600 D/avoidrickshaw( 8684): current lat: 23.741742, current long: 90.411744
07-14 21:59:10.429+0600 D/avoidrickshaw( 8684): total distance: 199.000000 meters
07-14 21:59:10.429+0600 D/avoidrickshaw( 8684): event-values: 2.834298, 1.961516, 7.186245, 0.000000
07-14 21:59:10.469+0600 D/avoidrickshaw( 8684): event-values: 2.953939, 3.382255, 13.070196, 0.000000
07-14 21:59:10.529+0600 D/avoidrickshaw( 8684): event-values: 1.216750, 0.154935, 10.299307, 0.000000
07-14 21:59:10.589+0600 D/avoidrickshaw( 8684): event-values: 0.422333, 1.357927, 9.969695, 0.000000
07-14 21:59:10.649+0600 D/avoidrickshaw( 8684): event-values: 0.943370, 0.756132, 11.378470, 0.000000
07-14 21:59:10.709+0600 D/avoidrickshaw( 8684): event-values: 1.807179, 0.290728, 11.048260, 0.000000
07-14 21:59:10.769+0600 D/avoidrickshaw( 8684): event-values: 1.329213, 5.449055, 9.381061, 0.000000
07-14 21:59:10.829+0600 D/avoidrickshaw( 8684): event-values: -0.108275, 0.222532, 9.548558, 0.000000
07-14 21:59:10.889+0600 D/avoidrickshaw( 8684): event-values: -0.379861, 3.627519, 6.109474, 0.000000
07-14 21:59:10.949+0600 D/avoidrickshaw( 8684): event-values: -0.929013, 1.162314, 9.677772, 0.000000
07-14 21:59:11.009+0600 D/avoidrickshaw( 8684): event-values: 0.261416, 5.000401, 8.720044, 0.000000
07-14 21:59:11.069+0600 D/avoidrickshaw( 8684): event-values: 0.058026, 1.014557, 10.897512, 0.000000
07-14 21:59:11.129+0600 D/avoidrickshaw( 8684): event-values: -0.795613, 1.058824, 9.227921, 0.000000
07-14 21:59:11.189+0600 D/avoidrickshaw( 8684): event-values: -0.151346, 6.521039, 9.244670, 0.000000
07-14 21:59:11.250+0600 D/avoidrickshaw( 8684): event-values: 0.287737, 0.619741, 10.191031, 0.000000
07-14 21:59:11.310+0600 D/avoidrickshaw( 8684): event-values: -0.421735, 1.034298, 9.573684, 0.000000
07-14 21:59:11.370+0600 D/avoidrickshaw( 8684): event-values: 0.168096, 5.451448, 9.534800, 0.000000
07-14 21:59:11.430+0600 D/avoidrickshaw( 8684): event-values: 0.522234, 0.865604, 10.130613, 0.000000
07-14 21:59:11.490+0600 D/avoidrickshaw( 8684): event-values: 0.185444, 1.377069, 9.062218, 0.000000
07-14 21:59:11.550+0600 D/avoidrickshaw( 8684): event-values: -0.232104, 5.694918, 9.325428, 0.000000
07-14 21:59:11.610+0600 D/avoidrickshaw( 8684): event-values: 0.532403, 0.744168, 10.941780, 0.000000
07-14 21:59:11.670+0600 D/avoidrickshaw( 8684): event-values: -0.440878, 4.443472, 7.649256, 0.000000
07-14 21:59:11.730+0600 D/avoidrickshaw( 8684): event-values: 1.235893, 3.424727, 11.133803, 0.000000
07-14 21:59:11.790+0600 D/avoidrickshaw( 8684): event-values: 0.439083, 0.303290, 9.413363, 0.000000
07-14 21:59:11.850+0600 D/avoidrickshaw( 8684): event-values: 0.102293, 2.457429, 9.697513, 0.000000
07-14 21:59:11.910+0600 D/avoidrickshaw( 8684): event-values: 0.044267, 2.743371, 10.085149, 0.000000
07-14 21:59:11.970+0600 D/avoidrickshaw( 8684): event-values: 0.918844, 2.788237, 9.120243, 0.000000
07-14 21:59:12.030+0600 D/avoidrickshaw( 8684): event-values: 0.527019, 2.520839, 9.870394, 0.000000
07-14 21:59:12.090+0600 D/avoidrickshaw( 8684): event-values: 1.589432, 1.815554, 9.793823, 0.00000
