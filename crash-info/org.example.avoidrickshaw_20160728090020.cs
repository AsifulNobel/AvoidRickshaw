S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPD6
Build-Date: 2016.04.28 20:23:28

Crash Information
Process Name: avoidrickshaw
PID: 15534
Date: 2016-07-28 09:00:20+0600
Executable File Path: /opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 15534, uid 5000)

Register Information
r0   = 0x80031f90, r1   = 0x00000000
r2   = 0xb42a6000, r3   = 0xb42a6010
r4   = 0xb29910e0, r5   = 0xb7d99f78
r6   = 0xb7db0380, r7   = 0xbea54208
r8   = 0x800168b5, r9   = 0xb5e77708
r10  = 0xb7daf370, fp   = 0x00000000
ip   = 0xb5f67120, sp   = 0xbea541b8
lr   = 0xb5f2bbd9, pc   = 0xb29900b4
cpsr = 0x800e0030

Memory Information
MemTotal:   730440 KB
MemFree:     46424 KB
Buffers:     45232 KB
Cached:     276048 KB
VmPeak:     106948 KB
VmSize:     106944 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       23888 KB
VmRSS:       23884 KB
VmData:      33216 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36164 KB
VmPTE:          82 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 15534 TID = 15534
15534 15536 18559 18624 

Maps Information
b0ca0000 b149f000 rw-p [stack:18624]
b1c55000 b2454000 rw-p [stack:18559]
b24d0000 b24d8000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b24e9000 b24ea000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b24fa000 b250e000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2522000 b2523000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2533000 b2536000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2547000 b2548000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2558000 b255a000 r-xp /usr/lib/libxcb-present.so.0.0.0
b256a000 b256c000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b257c000 b258c000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b259c000 b25a8000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b27f8000 b27fa000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b280a000 b2810000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b2820000 b2834000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b2844000 b285e000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b286e000 b2874000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
b2884000 b288b000 r-xp /usr/lib/libeventsystem.so.0.0.1
b289b000 b28be000 r-xp /usr/lib/libSLP-location-product.so.0.9.0
b28cf000 b28e6000 r-xp /usr/lib/libSLP-location.so.0.11.5_5
b28f6000 b28fd000 r-xp /usr/lib/libefl-extension.so.0.1.0
b290e000 b2916000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b2926000 b292a000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
b293b000 b294a000 r-xp /usr/lib/libcapi-location-manager.so.0.6.1_3
b295a000 b2961000 r-xp /usr/lib/libcapi-appfw-preference.so.0.3.1.0
b2973000 b2979000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2989000 b2992000 r-xp /opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw
b2ab3000 b2b96000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2bcd000 b2bf5000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2c07000 b3406000 rw-p [stack:15536]
b3406000 b3408000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3418000 b3422000 r-xp /lib/libnss_files-2.20-2014.11.so
b3433000 b343c000 r-xp /lib/libnss_nis-2.20-2014.11.so
b344d000 b345e000 r-xp /lib/libnsl-2.20-2014.11.so
b3471000 b3477000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3488000 b3489000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b34b1000 b34b8000 r-xp /usr/lib/libminizip.so.1.0.0
b34c8000 b34cd000 r-xp /usr/lib/libstorage.so.0.1
b34dd000 b3532000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3548000 b355c000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b356c000 b35b0000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b35c0000 b35c8000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b35d8000 b3608000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b361b000 b36d4000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b36e8000 b373c000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b374d000 b3768000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3778000 b3839000 r-xp /usr/lib/libprotobuf.so.9.0.1
b384c000 b385e000 r-xp /usr/lib/libefl-assist.so.0.1.0
b386e000 b3872000 r-xp /usr/lib/libogg.so.0.7.1
b3882000 b38a4000 r-xp /usr/lib/libvorbis.so.0.4.3
b38b4000 b3998000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b39b4000 b39c1000 r-xp /usr/lib/libmdm-common.so.1.0.98
b39d2000 b3a15000 r-xp /usr/lib/libsndfile.so.1.0.25
b3a2a000 b3a71000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3a82000 b3a88000 r-xp /usr/lib/libjson-c.so.2.0.1
b3a99000 b3aa0000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3ab0000 b3af0000 r-xp /usr/lib/libmdm.so.1.2.10
b3b00000 b3b08000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3b17000 b3b27000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3b48000 b3ba8000 r-xp /usr/lib/libasound.so.2.0.0
b3bba000 b3bf0000 r-xp /usr/lib/libpulse.so.0.16.2
b3c01000 b3c04000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3c14000 b3c17000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3c27000 b3c2c000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3c3c000 b3c3d000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3c4d000 b3c58000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3c6c000 b3c73000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3c83000 b3c89000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3c99000 b3c9e000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3cae000 b3cc9000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3cd9000 b3ce0000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3cf0000 b3cf3000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3d04000 b3d32000 r-xp /usr/lib/libidn.so.11.5.44
b3d42000 b3d58000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3d69000 b3d73000 r-xp /usr/lib/libcares.so.2.1.0
b3d83000 b3d8d000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3d9d000 b3d9f000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3daf000 b3db0000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3dc0000 b3dc4000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3dd5000 b3dfd000 r-xp /usr/lib/libui-extension.so.0.1.0
b3e0e000 b3e37000 r-xp /usr/lib/libturbojpeg.so
b3e57000 b3e5d000 r-xp /usr/lib/libgif.so.4.1.6
b3e6d000 b3eb3000 r-xp /usr/lib/libcurl.so.4.3.0
b3ec4000 b3ee5000 r-xp /usr/lib/libexif.so.12.3.3
b3f00000 b3f15000 r-xp /usr/lib/libtts.so
b3f26000 b3f2e000 r-xp /usr/lib/libfeedback.so.0.1.4
b3f3e000 b3ffe000 r-xp /usr/lib/libdali-core.so.0.0.0
b4009000 b40fc000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b411c000 b41f6000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b420d000 b420f000 r-xp /usr/lib/libboost_system.so.1.51.0
b421f000 b4225000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b4235000 b4258000 r-xp /usr/lib/libboost_thread.so.1.51.0
b4269000 b426b000 r-xp /usr/lib/libappsvc.so.0.1.0
b427b000 b427d000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b428e000 b4293000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b42aa000 b42ac000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b42bc000 b42c3000 r-xp /usr/lib/libsensord-share.so
b42d3000 b42eb000 r-xp /usr/lib/libsensor.so.1.1.0
b42fc000 b42ff000 r-xp /usr/lib/libXv.so.1.0.0
b430f000 b4314000 r-xp /usr/lib/libutilX.so.1.1.0
b4324000 b4329000 r-xp /usr/lib/libappcore-common.so.1.1
b4339000 b4340000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b4353000 b4357000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b4368000 b4432000 r-xp /usr/lib/libCOREGL.so.4.0
b4449000 b444c000 r-xp /usr/lib/libuuid.so.1.3.0
b445d000 b4474000 r-xp /usr/lib/libblkid.so.1.1.0
b4485000 b4487000 r-xp /usr/lib/libXau.so.6.0.0
b4497000 b449a000 r-xp /usr/lib/libEGL.so.1.4
b44a2000 b44a8000 r-xp /usr/lib/libxcb-render.so.0.0.0
b44b8000 b44ba000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b44cb000 b44d9000 r-xp /usr/lib/libGLESv2.so.2.0
b44e2000 b4544000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4559000 b4571000 r-xp /usr/lib/libmount.so.1.1.0
b4582000 b4596000 r-xp /usr/lib/libxcb.so.1.1.0
b45a7000 b45ae000 r-xp /lib/libcrypt-2.20-2014.11.so
b45e6000 b45f7000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b4608000 b460a000 r-xp /usr/lib/libiri.so
b461a000 b4625000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4636000 b464b000 r-xp /lib/libexpat.so.1.5.2
b465d000 b471b000 r-xp /usr/lib/libcairo.so.2.11200.14
b472e000 b4736000 r-xp /usr/lib/libdrm.so.2.4.0
b4746000 b4749000 r-xp /usr/lib/libdri2.so.0.0.0
b475a000 b47a8000 r-xp /usr/lib/libssl.so.1.0.0
b47bd000 b47c9000 r-xp /usr/lib/libeeze.so.1.13.0
b47d9000 b47e2000 r-xp /usr/lib/libethumb.so.1.13.0
b47f2000 b47f5000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4805000 b49bc000 r-xp /usr/lib/libcrypto.so.1.0.0
b5613000 b561c000 r-xp /usr/lib/libXi.so.6.1.0
b562c000 b562e000 r-xp /usr/lib/libXgesture.so.7.0.0
b563e000 b5642000 r-xp /usr/lib/libXtst.so.6.1.0
b5652000 b5658000 r-xp /usr/lib/libXrender.so.1.3.0
b5668000 b566e000 r-xp /usr/lib/libXrandr.so.2.2.0
b567f000 b5681000 r-xp /usr/lib/libXinerama.so.1.0.0
b5691000 b5694000 r-xp /usr/lib/libXfixes.so.3.1.0
b56a4000 b56af000 r-xp /usr/lib/libXext.so.6.4.0
b56bf000 b56c1000 r-xp /usr/lib/libXdamage.so.1.1.0
b56d1000 b56d3000 r-xp /usr/lib/libXcomposite.so.1.0.0
b56e4000 b57c6000 r-xp /usr/lib/libX11.so.6.3.0
b57d9000 b57e0000 r-xp /usr/lib/libXcursor.so.1.0.2
b57f0000 b5808000 r-xp /usr/lib/libudev.so.1.6.0
b580a000 b580d000 r-xp /lib/libattr.so.1.1.0
b581d000 b583d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b583f000 b5844000 r-xp /usr/lib/libffi.so.6.0.2
b5854000 b586c000 r-xp /lib/libz.so.1.2.8
b587c000 b587e000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b588e000 b5963000 r-xp /usr/lib/libxml2.so.2.9.2
b5978000 b5a13000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a2f000 b5a32000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a42000 b5a5b000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a6c000 b5a7d000 r-xp /lib/libresolv-2.20-2014.11.so
b5a91000 b5b0b000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b20000 b5b22000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b32000 b5b39000 r-xp /usr/lib/libembryo.so.1.13.0
b5b49000 b5b61000 r-xp /usr/lib/libpng12.so.0.50.0
b5b72000 b5b95000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bb6000 b5bca000 r-xp /usr/lib/libector.so.1.13.0
b5bdb000 b5bf3000 r-xp /usr/lib/liblua-5.1.so
b5c04000 b5c5b000 r-xp /usr/lib/libfreetype.so.6.11.3
b5c6f000 b5c97000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5ca8000 b5cbb000 r-xp /usr/lib/libfribidi.so.0.3.1
b5ccc000 b5d03000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d14000 b5d22000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d32000 b5d3a000 r-xp /usr/lib/libtbm.so.1.0.0
b5d4a000 b5d57000 r-xp /usr/lib/libeio.so.1.13.0
b5d67000 b5d69000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5d79000 b5d7e000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5d8e000 b5da5000 r-xp /usr/lib/libefreet.so.1.13.0
b5db7000 b5dd7000 r-xp /usr/lib/libeldbus.so.1.13.0
b5de7000 b5e07000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e09000 b5e0f000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e1f000 b5e30000 r-xp /usr/lib/libemotion.so.1.13.0
b5e41000 b5e48000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e58000 b5e67000 r-xp /usr/lib/libeo.so.1.13.0
b5e78000 b5e8a000 r-xp /usr/lib/libecore_input.so.1.13.0
b5e9b000 b5ea0000 r-xp /usr/lib/libecore_file.so.1.13.0
b5eb0000 b5ec9000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5ed9000 b5ef6000 r-xp /usr/lib/libeet.so.1.13.0
b5f0f000 b5f57000 r-xp /usr/lib/libeina.so.1.13.0
b5f68000 b5f78000 r-xp /usr/lib/libefl.so.1.13.0
b5f89000 b606e000 r-xp /usr/lib/libicuuc.so.51.1
b608b000 b61cb000 r-xp /usr/lib/libicui18n.so.51.1
b61e2000 b621a000 r-xp /usr/lib/libecore_x.so.1.13.0
b622c000 b622f000 r-xp /lib/libcap.so.2.21
b623f000 b6268000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6279000 b6280000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6292000 b62c9000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b62da000 b63c5000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b63d8000 b6451000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6463000 b6468000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6478000 b6482000 r-xp /usr/lib/libvconf.so.0.2.45
b6492000 b6494000 r-xp /usr/lib/libvasum.so.0.3.1
b64a4000 b64a6000 r-xp /usr/lib/libttrace.so.1.1
b64b6000 b64b9000 r-xp /usr/lib/libiniparser.so.0
b64c9000 b64ef000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b64ff000 b6504000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6515000 b652c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b653d000 b65a8000 r-xp /lib/libm-2.20-2014.11.so
b65b9000 b65bf000 r-xp /lib/librt-2.20-2014.11.so
b65d0000 b65dd000 r-xp /usr/lib/libunwind.so.8.0.1
b6613000 b6737000 r-xp /lib/libc-2.20-2014.11.so
b674c000 b6765000 r-xp /lib/libgcc_s-4.9.so.1
b6775000 b6857000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6868000 b6892000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68a3000 b68df000 r-xp /usr/lib/libsystemd.so.0.4.0
b68e1000 b6963000 r-xp /usr/lib/libedje.so.1.13.0
b6976000 b6994000 r-xp /usr/lib/libecore.so.1.13.0
b69b4000 b6b3b000 r-xp /usr/lib/libevas.so.1.13.0
b6b70000 b6b84000 r-xp /lib/libpthread-2.20-2014.11.so
b6b98000 b6dcd000 r-xp /usr/lib/libelementary.so.1.13.0
b6dfb000 b6dff000 r-xp /usr/lib/libsmack.so.1.0.0
b6e0f000 b6e16000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e26000 b6e28000 r-xp /usr/lib/libdlog.so.0.0.0
b6e38000 b6e3b000 r-xp /usr/lib/libbundle.so.0.1.22
b6e4b000 b6e4d000 r-xp /lib/libdl-2.20-2014.11.so
b6e5e000 b6e76000 r-xp /usr/lib/libaul.so.0.1.0
b6e8a000 b6e8f000 r-xp /usr/lib/libappcore-efl.so.1.1
b6ea0000 b6ead000 r-xp /usr/lib/liblptcp.so
b6ebf000 b6ec3000 r-xp /usr/lib/libsys-assert.so
b6ed4000 b6ef4000 r-xp /lib/ld-2.20-2014.11.so
b6f05000 b6f0a000 r-xp /usr/bin/launchpad-loader
b7b94000 b7e44000 rw-p [heap]
bea34000 bea55000 rw-p [stack]
b7b94000 b7e44000 rw-p [heap]
bea34000 bea55000 rw-p [stack]
End of Maps Information

Callstack Information (PID:15534)
Call Stack Count: 21
 0: view_history_create + 0x47 (0xb29900b4) [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw] + 0x70b4
 1: _show_history_cb + 0x7a (0xb298fcfb) [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw] + 0x6cfb
 2: (0xb6a1a7ed) [/usr/lib/libevas.so.1] + 0x667ed
 3: (0xb5e63219) [/usr/lib/libeo.so.1] + 0xb219
 4: eo_event_callback_call + 0x68 (0xb5e61fb9) [/usr/lib/libeo.so.1] + 0x9fb9
 5: evas_object_smart_callback_call + 0x38 (0xb6a1bedd) [/usr/lib/libevas.so.1] + 0x67edd
 6: (0xb6937dd7) [/usr/lib/libedje.so.1] + 0x56dd7
 7: (0xb693c11f) [/usr/lib/libedje.so.1] + 0x5b11f
 8: (0xb6938791) [/usr/lib/libedje.so.1] + 0x57791
 9: (0xb6938b61) [/usr/lib/libedje.so.1] + 0x57b61
10: (0xb6938cb5) [/usr/lib/libedje.so.1] + 0x57cb5
11: (0xb6985d11) [/usr/lib/libecore.so.1] + 0xfd11
12: (0xb6981c4b) [/usr/lib/libecore.so.1] + 0xbc4b
13: (0xb6987a5d) [/usr/lib/libecore.so.1] + 0x11a5d
14: ecore_main_loop_begin + 0x3e (0xb6987c83) [/usr/lib/libecore.so.1] + 0x11c83
15: appcore_efl_main + 0x20c (0xb6e8d2bd) [/usr/lib/libappcore-efl.so.1] + 0x32bd
16: ui_app_main + 0xc0 (0xb4355909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
17: main + 0x9a (0xb298f36b) [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw] + 0x636b
18: (0xb6f06baf) [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw] + 0x1baf
19: __libc_start_main + 0x114 (0xb66294bc) [/lib/libc.so.6] + 0x164bc
20: (0xb6f06e94) [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw] + 0x1e94
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
07-25 22:06:22.251+0600 D/avoidri
