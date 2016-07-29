S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPD6
Build-Date: 2016.04.28 20:23:28

Crash Information
Process Name: avoidrickshaw
PID: 3660
Date: 2016-07-29 22:40:11+0600
Executable File Path: /opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 3660, uid 5000)

Register Information
r0   = 0xb644b180, r1   = 0xb2995131
r2   = 0x00000032, r3   = 0xb644b17f
r4   = 0xb299512a, r5   = 0x00000008
r6   = 0xbe922db0, r7   = 0x00000008
r8   = 0x00000008, r9   = 0x00000008
r10  = 0xb674d000, fp   = 0xbe922da4
ip   = 0xb2995134, sp   = 0xbe922858
lr   = 0xb66551e8, pc   = 0xb6682b58
cpsr = 0x800d0010

Memory Information
MemTotal:   730440 KB
MemFree:     21316 KB
Buffers:     35900 KB
Cached:     231244 KB
VmPeak:     119948 KB
VmSize:     119944 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       25364 KB
VmRSS:       25364 KB
VmData:      44336 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36280 KB
VmPTE:          88 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 3660 TID = 3660
3660 3666 4768 4776 4949 

Maps Information
b031a000 b0b19000 rw-p [stack:4949]
b12d7000 b1ad6000 rw-p [stack:4776]
b1ad6000 b1ade000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.49
b1aee000 b1af0000 r-xp /usr/lib/liblbs-agps.so.0.1.0
b1c0e000 b1c1c000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
b1c33000 b1c35000 r-xp /usr/lib/location/module/libwps.so.0.6.8_9
b1c45000 b1c48000 r-xp /usr/lib/location/module/libgps.so.0.6.8_9
b1c59000 b2458000 rw-p [stack:4768]
b24d4000 b24dc000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b24ed000 b24ee000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b24fe000 b2512000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2526000 b2527000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2537000 b253a000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b254b000 b254c000 r-xp /usr/lib/libxshmfence.so.1.0.0
b255c000 b255e000 r-xp /usr/lib/libxcb-present.so.0.0.0
b256e000 b2570000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2580000 b2590000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b25a0000 b25ac000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b27fc000 b27fe000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b280e000 b2814000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b2824000 b2838000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b2848000 b2862000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b2872000 b2878000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
b2888000 b288f000 r-xp /usr/lib/libeventsystem.so.0.0.1
b289f000 b28c2000 r-xp /usr/lib/libSLP-location-product.so.0.9.0
b28d3000 b28ea000 r-xp /usr/lib/libSLP-location.so.0.11.5_5
b28fa000 b2901000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2912000 b291a000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b292a000 b292e000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
b293f000 b294e000 r-xp /usr/lib/libcapi-location-manager.so.0.6.1_3
b295e000 b2965000 r-xp /usr/lib/libcapi-appfw-preference.so.0.3.1.0
b2977000 b297d000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b298d000 b2996000 r-xp /opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw
b2ab8000 b2b9b000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2bd2000 b2bfa000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2c0c000 b340b000 rw-p [stack:3666]
b340b000 b340d000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b341d000 b3427000 r-xp /lib/libnss_files-2.20-2014.11.so
b3438000 b3441000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3452000 b3463000 r-xp /lib/libnsl-2.20-2014.11.so
b3476000 b347c000 r-xp /lib/libnss_compat-2.20-2014.11.so
b348d000 b348e000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b34b6000 b34bd000 r-xp /usr/lib/libminizip.so.1.0.0
b34cd000 b34d2000 r-xp /usr/lib/libstorage.so.0.1
b34e2000 b3537000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b354d000 b3561000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b3571000 b35b5000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b35c5000 b35cd000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b35dd000 b360d000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3620000 b36d9000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b36ed000 b3741000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3752000 b376d000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b377d000 b383e000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3851000 b3863000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3873000 b3877000 r-xp /usr/lib/libogg.so.0.7.1
b3887000 b38a9000 r-xp /usr/lib/libvorbis.so.0.4.3
b38b9000 b399d000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b39b9000 b39c6000 r-xp /usr/lib/libmdm-common.so.1.0.98
b39d7000 b3a1a000 r-xp /usr/lib/libsndfile.so.1.0.25
b3a2f000 b3a76000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3a87000 b3a8d000 r-xp /usr/lib/libjson-c.so.2.0.1
b3a9e000 b3aa5000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3ab5000 b3af5000 r-xp /usr/lib/libmdm.so.1.2.10
b3b05000 b3b0d000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3b1c000 b3b2c000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3b4d000 b3bad000 r-xp /usr/lib/libasound.so.2.0.0
b3bbf000 b3bf5000 r-xp /usr/lib/libpulse.so.0.16.2
b3c06000 b3c09000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3c19000 b3c1c000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3c2c000 b3c31000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3c41000 b3c42000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3c52000 b3c5d000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3c71000 b3c78000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3c88000 b3c8e000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3c9e000 b3ca3000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3cb3000 b3cce000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3cde000 b3ce5000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3cf5000 b3cf8000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3d09000 b3d37000 r-xp /usr/lib/libidn.so.11.5.44
b3d47000 b3d5d000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3d6e000 b3d78000 r-xp /usr/lib/libcares.so.2.1.0
b3d88000 b3d92000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3da2000 b3da4000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3db4000 b3db5000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3dc5000 b3dc9000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3dda000 b3e02000 r-xp /usr/lib/libui-extension.so.0.1.0
b3e13000 b3e3c000 r-xp /usr/lib/libturbojpeg.so
b3e5c000 b3e62000 r-xp /usr/lib/libgif.so.4.1.6
b3e72000 b3eb8000 r-xp /usr/lib/libcurl.so.4.3.0
b3ec9000 b3eea000 r-xp /usr/lib/libexif.so.12.3.3
b3f05000 b3f1a000 r-xp /usr/lib/libtts.so
b3f2b000 b3f33000 r-xp /usr/lib/libfeedback.so.0.1.4
b3f43000 b4003000 r-xp /usr/lib/libdali-core.so.0.0.0
b400e000 b4101000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b4121000 b41fb000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b4212000 b4214000 r-xp /usr/lib/libboost_system.so.1.51.0
b4224000 b422a000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b423a000 b425d000 r-xp /usr/lib/libboost_thread.so.1.51.0
b426e000 b4270000 r-xp /usr/lib/libappsvc.so.0.1.0
b4280000 b4282000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4293000 b4298000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b42af000 b42b1000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b42c1000 b42c8000 r-xp /usr/lib/libsensord-share.so
b42d8000 b42f0000 r-xp /usr/lib/libsensor.so.1.1.0
b4301000 b4304000 r-xp /usr/lib/libXv.so.1.0.0
b4314000 b4319000 r-xp /usr/lib/libutilX.so.1.1.0
b4329000 b432e000 r-xp /usr/lib/libappcore-common.so.1.1
b433e000 b4345000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b4358000 b435c000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b436d000 b4437000 r-xp /usr/lib/libCOREGL.so.4.0
b444e000 b4451000 r-xp /usr/lib/libuuid.so.1.3.0
b4462000 b4479000 r-xp /usr/lib/libblkid.so.1.1.0
b448a000 b448c000 r-xp /usr/lib/libXau.so.6.0.0
b449c000 b449f000 r-xp /usr/lib/libEGL.so.1.4
b44a7000 b44ad000 r-xp /usr/lib/libxcb-render.so.0.0.0
b44bd000 b44bf000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b44d0000 b44de000 r-xp /usr/lib/libGLESv2.so.2.0
b44e7000 b4549000 r-xp /usr/lib/libpixman-1.so.0.28.2
b455e000 b4576000 r-xp /usr/lib/libmount.so.1.1.0
b4587000 b459b000 r-xp /usr/lib/libxcb.so.1.1.0
b45ac000 b45b3000 r-xp /lib/libcrypt-2.20-2014.11.so
b45eb000 b45fc000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b460d000 b460f000 r-xp /usr/lib/libiri.so
b461f000 b462a000 r-xp /usr/lib/libgpg-error.so.0.15.0
b463b000 b4650000 r-xp /lib/libexpat.so.1.5.2
b4662000 b4720000 r-xp /usr/lib/libcairo.so.2.11200.14
b4733000 b473b000 r-xp /usr/lib/libdrm.so.2.4.0
b474b000 b474e000 r-xp /usr/lib/libdri2.so.0.0.0
b475f000 b47ad000 r-xp /usr/lib/libssl.so.1.0.0
b47c2000 b47ce000 r-xp /usr/lib/libeeze.so.1.13.0
b47de000 b47e7000 r-xp /usr/lib/libethumb.so.1.13.0
b47f7000 b47fa000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b480a000 b49c1000 r-xp /usr/lib/libcrypto.so.1.0.0
b5618000 b5621000 r-xp /usr/lib/libXi.so.6.1.0
b5631000 b5633000 r-xp /usr/lib/libXgesture.so.7.0.0
b5643000 b5647000 r-xp /usr/lib/libXtst.so.6.1.0
b5657000 b565d000 r-xp /usr/lib/libXrender.so.1.3.0
b566d000 b5673000 r-xp /usr/lib/libXrandr.so.2.2.0
b5684000 b5686000 r-xp /usr/lib/libXinerama.so.1.0.0
b5696000 b5699000 r-xp /usr/lib/libXfixes.so.3.1.0
b56a9000 b56b4000 r-xp /usr/lib/libXext.so.6.4.0
b56c4000 b56c6000 r-xp /usr/lib/libXdamage.so.1.1.0
b56d6000 b56d8000 r-xp /usr/lib/libXcomposite.so.1.0.0
b56e9000 b57cb000 r-xp /usr/lib/libX11.so.6.3.0
b57de000 b57e5000 r-xp /usr/lib/libXcursor.so.1.0.2
b57f5000 b580d000 r-xp /usr/lib/libudev.so.1.6.0
b580f000 b5812000 r-xp /lib/libattr.so.1.1.0
b5822000 b5842000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5844000 b5849000 r-xp /usr/lib/libffi.so.6.0.2
b5859000 b5871000 r-xp /lib/libz.so.1.2.8
b5881000 b5883000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5893000 b5968000 r-xp /usr/lib/libxml2.so.2.9.2
b597d000 b5a18000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a34000 b5a37000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a47000 b5a60000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a71000 b5a82000 r-xp /lib/libresolv-2.20-2014.11.so
b5a96000 b5b10000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b25000 b5b27000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b37000 b5b3e000 r-xp /usr/lib/libembryo.so.1.13.0
b5b4e000 b5b66000 r-xp /usr/lib/libpng12.so.0.50.0
b5b77000 b5b9a000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bbb000 b5bcf000 r-xp /usr/lib/libector.so.1.13.0
b5be0000 b5bf8000 r-xp /usr/lib/liblua-5.1.so
b5c09000 b5c60000 r-xp /usr/lib/libfreetype.so.6.11.3
b5c74000 b5c9c000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5cad000 b5cc0000 r-xp /usr/lib/libfribidi.so.0.3.1
b5cd1000 b5d08000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d19000 b5d27000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d37000 b5d3f000 r-xp /usr/lib/libtbm.so.1.0.0
b5d4f000 b5d5c000 r-xp /usr/lib/libeio.so.1.13.0
b5d6c000 b5d6e000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5d7e000 b5d83000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5d93000 b5daa000 r-xp /usr/lib/libefreet.so.1.13.0
b5dbc000 b5ddc000 r-xp /usr/lib/libeldbus.so.1.13.0
b5dec000 b5e0c000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e0e000 b5e14000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e24000 b5e35000 r-xp /usr/lib/libemotion.so.1.13.0
b5e46000 b5e4d000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e5d000 b5e6c000 r-xp /usr/lib/libeo.so.1.13.0
b5e7d000 b5e8f000 r-xp /usr/lib/libecore_input.so.1.13.0
b5ea0000 b5ea5000 r-xp /usr/lib/libecore_file.so.1.13.0
b5eb5000 b5ece000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5ede000 b5efb000 r-xp /usr/lib/libeet.so.1.13.0
b5f14000 b5f5c000 r-xp /usr/lib/libeina.so.1.13.0
b5f6d000 b5f7d000 r-xp /usr/lib/libefl.so.1.13.0
b5f8e000 b6073000 r-xp /usr/lib/libicuuc.so.51.1
b6090000 b61d0000 r-xp /usr/lib/libicui18n.so.51.1
b61e7000 b621f000 r-xp /usr/lib/libecore_x.so.1.13.0
b6231000 b6234000 r-xp /lib/libcap.so.2.21
b6244000 b626d000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b627e000 b6285000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6297000 b62ce000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b62df000 b63ca000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b63dd000 b6456000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6468000 b646d000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b647d000 b6487000 r-xp /usr/lib/libvconf.so.0.2.45
b6497000 b6499000 r-xp /usr/lib/libvasum.so.0.3.1
b64a9000 b64ab000 r-xp /usr/lib/libttrace.so.1.1
b64bb000 b64be000 r-xp /usr/lib/libiniparser.so.0
b64ce000 b64f4000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6504000 b6509000 r-xp /usr/lib/libxdgmime.so.1.1.0
b651a000 b6531000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6542000 b65ad000 r-xp /lib/libm-2.20-2014.11.so
b65be000 b65c4000 r-xp /lib/librt-2.20-2014.11.so
b65d5000 b65e2000 r-xp /usr/lib/libunwind.so.8.0.1
b6618000 b673c000 r-xp /lib/libc-2.20-2014.11.so
b6751000 b676a000 r-xp /lib/libgcc_s-4.9.so.1
b677a000 b685c000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b686d000 b6897000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68a8000 b68e4000 r-xp /usr/lib/libsystemd.so.0.4.0
b68e6000 b6968000 r-xp /usr/lib/libedje.so.1.13.0
b697b000 b6999000 r-xp /usr/lib/libecore.so.1.13.0
b69b9000 b6b40000 r-xp /usr/lib/libevas.so.1.13.0
b6b75000 b6b89000 r-xp /lib/libpthread-2.20-2014.11.so
b6b9d000 b6dd2000 r-xp /usr/lib/libelementary.so.1.13.0
b6e00000 b6e04000 r-xp /usr/lib/libsmack.so.1.0.0
b6e14000 b6e1b000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e2b000 b6e2d000 r-xp /usr/lib/libdlog.so.0.0.0
b6e3d000 b6e40000 r-xp /usr/lib/libbundle.so.0.1.22
b6e50000 b6e52000 r-xp /lib/libdl-2.20-2014.11.so
b6e63000 b6e7b000 r-xp /usr/lib/libaul.so.0.1.0
b6e8f000 b6e94000 r-xp /usr/lib/libappcore-efl.so.1.1
b6ea5000 b6eb2000 r-xp /usr/lib/liblptcp.so
b6ec4000 b6ec8000 r-xp /usr/lib/libsys-assert.so
b6ed9000 b6ef9000 r-xp /lib/ld-2.20-2014.11.so
b6f0a000 b6f0f000 r-xp /usr/bin/launchpad-loader
b7ccc000 b802c000 rw-p [heap]
be903000 be924000 rw-p [stack]
b7ccc000 b802c000 rw-p [heap]
be903000 be924000 rw-p [stack]
End of Maps Information

Callstack Information (PID:3660)
Call Stack Count: 4
 0: _IO_default_xsputn + 0x58 (0xb6682b58) [/lib/libc.so.6] + 0x6ab58
 1: _IO_vfprintf + 0xb8 (0xb66551e8) [/lib/libc.so.6] + 0x3d1e8
 2: vsprintf + 0x68 (0xb6677d04) [/lib/libc.so.6] + 0x5fd04
 3: (0xb644b180) [/usr/lib/libsqlite3.so.0] + 0x6e180
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
07-29 10:42:30.601+0600 D/avoidrickshaw(28893): event-values: 1.761117, 2.845664, 10.228719, 0.000000
07-29 10:42:30.661+0600 D/avoidrickshaw(28893): event-values: 1.360918, 3.061018, 9.969097, 0.000000
07-29 10:42:30.721+0600 D/avoidrickshaw(28893): event-values: 1.261017, 3.293720, 9.092726, 0.000000
07-29 10:42:30.781+0600 D/avoidrickshaw(28893): event-values: 1.059422, 3.789633, 8.952746, 0.000000
07-29 10:42:30.841+0600 D/avoidrickshaw(28893): event-values: 1.721038, 2.946163, 9.492328, 0.000000
07-29 10:42:30.901+0600 D/avoidrickshaw(28893): event-values: 1.564308, 2.611168, 9.524631, 0.000000
07-29 10:42:30.961+0600 D/avoidrickshaw(28893): event-values: 1.554138, 2.132005, 9.583255, 0.000000
07-29 10:42:31.021+0600 D/avoidrickshaw(28893): event-values: 2.427519, 2.291128, 10.209577, 0.000000
07-29 10:42:31.081+0600 D/avoidrickshaw(28893): event-values: 1.787439, 1.845464, 10.982458, 0.000000
07-29 10:42:31.141+0600 D/avoidrickshaw(28893): event-values: 2.210370, 2.221138, 8.894720, 0.000000
07-29 10:42:31.201+0600 D/avoidrickshaw(28893): event-values: 2.328217, 2.068595, 8.173882, 0.000000
07-29 10:42:31.261+0600 D/avoidrickshaw(28893): event-values: 2.445465, 1.762912, 9.108877, 0.000000
07-29 10:42:31.321+0600 D/avoidrickshaw(28893): event-values: 2.247459, 1.093520, 9.801600, 0.000000
07-29 10:42:31.382+0600 D/avoidrickshaw(28893): event-values: 2.868396, 2.258226, 9.369695, 0.000000
07-29 10:42:31.442+0600 D/avoidrickshaw(28893): event-values: 3.029912, 1.415355, 10.993823, 0.000000
07-29 10:42:31.502+0600 D/avoidrickshaw(28893): event-values: 2.148755, 1.954338, 9.357133, 0.000000
07-29 10:42:31.562+0600 D/avoidrickshaw(28893): event-values: 2.447858, 2.294119, 8.704491, 0.000000
07-29 10:42:31.622+0600 D/avoidrickshaw(28893): event-values: 3.157928, 2.597409, 9.563514, 0.000000
07-29 10:42:31.682+0600 D/avoidrickshaw(28893): event-values: 3.129812, 2.080559, 9.076574, 0.000000
07-29 10:42:31.742+0600 D/avoidrickshaw(28893): event-values: 2.230709, 1.316052, 10.680364, 0.000000
07-29 10:42:31.802+0600 D/avoidrickshaw(28893): event-values: 3.141776, 1.121037, 9.084351, 0.000000
07-29 10:42:31.862+0600 D/avoidrickshaw(28893): event-values: 2.249851, 1.643271, 8.960523, 0.000000
07-29 10:42:31.922+0600 D/avoidrickshaw(28893): event-values: 3.029313, 1.712663, 9.711869, 0.000000
07-29 10:42:31.982+0600 D/avoidrickshaw(28893): event-values: 2.438286, 1.667199, 10.960323, 0.000000
07-29 10:42:32.042+0600 D/avoidrickshaw(28893): event-values: 3.588037, 2.219941, 10.113264, 0.000000
07-29 10:42:32.102+0600 D/avoidrickshaw(28893): event-values: 3.887140, 1.496711, 9.332606, 0.000000
07-29 10:42:32.162+0600 D/avoidrickshaw(28893): event-values: 3.312265, 1.322633, 9.662218, 0.000000
07-29 10:42:32.222+0600 D/avoidrickshaw(28893): event-values: 3.318247, 2.252244, 10.158729, 0.000000
07-29 10:42:32.282+0600 D/avoidrickshaw(28893): event-values: 4.016951, 2.275574, 9.847064, 0.000000
07-29 10:42:32.342+0600 D/avoidrickshaw(28893): event-values: 2.035096, 2.348556, 9.273384, 0.000000
07-29 10:42:32.403+0600 D/avoidrickshaw(28893): event-values: 1.380659, 1.269392, 9.189037, 0.000000
07-29 10:42:32.463+0600 D/avoidrickshaw(28893): event-values: 0.607179, 1.812563, 7.818548, 0.000000
07-29 10:42:32.523+0600 D/avoidrickshaw(28893): event-values: 2.061417, 2.563910, 7.412964, 0.000000
07-29 10:42:32.523+0600 I/Tizen::Net::Wifi( 1305): (1085) > _WifiService is not registered.
07-29 10:42:32.583+0600 D/avoidrickshaw(28893): event-values: 1.198206, 3.231507, 9.001201, 0.000000
07-29 10:42:32.643+0600 D/avoidrickshaw(28893): event-values: -0.610768, 5.576473, 11.510076, 0.000000
07-29 10:42:32.703+0600 D/avoidrickshaw(28893): event-values: -1.281357, 4.153940, 10.524231, 0.000000
07-29 10:42:32.763+0600 D/avoidrickshaw(28893): event-values: 0.451047, 2.912663, 8.477771, 0.000000
07-29 10:42:32.823+0600 D/avoidrickshaw(28893): event-values: 2.117050, 2.626721, 8.740383, 0.000000
07-29 10:42:32.883+0600 D/avoidrickshaw(28893): event-values: 4.846064, 1.614557, 11.155338, 0.000000
07-29 10:42:32.943+0600 D/avoidrickshaw(28893): event-values: 4.922036, 0.611964, 11.005190, 0.000000
07-29 10:42:33.003+0600 D/avoidrickshaw(28893): event-values: 4.231707, 1.371686, 8.958728, 0.000000
07-29 10:42:33.063+0600 D/avoidrickshaw(28893): event-values: 3.020340, 1.718645, 7.683353, 0.000000
07-29 10:42:33.123+0600 D/avoidrickshaw(28893): event-values: 2.310270, 1.121636, 8.248658, 0.000000
07-29 10:42:33.183+0600 D/avoidrickshaw(28893): event-values: 3.322434, 1.906481, 9.807582, 0.000000
07-29 10:42:33.243+0600 D/avoidrickshaw(28893): event-values: 3.945765, 2.284547, 9.508479, 0.000000
07-29 10:42:33.303+0600 D/avoidrickshaw(28893): event-values: 5.504689, 1.883750, 8.137392, 0.000000
07-29 10:42:33.363+0600 D/avoidrickshaw(28893): event-values: 4.268198, 2.989832, 8.020144, 0.000000
07-29 10:42:33.424+0600 D/avoidrickshaw(28893): event-values: 3.270390, 2.906682, 9.781260, 0.000000
07-29 10:42:33.484+0600 D/avoidrickshaw(28893): event-values: 1.772483, 2.761317, 10.282557, 0.000000
07-29 10:42:33.524+0600 I/Tizen::Net::Wifi( 1305): (1085) > _WifiService is not registered.
07-29 10:42:33.544+0600 D/avoidrickshaw(28893): event-values: 0.894317, 2.961118, 8.323434, 0.000000
07-29 10:42:33.604+0600 D/avoidrickshaw(28893): event-values: 1.892723, 3.819543, 7.721639, 0.000000
07-29 10:42:33.664+0600 D/avoidrickshaw(28893): event-values: 2.480759, 3.972684, 8.928818, 0.000000
07-29 10:42:33.724+0600 D/avoidrickshaw(28893): event-values: 3.489932, 3.354738, 9.739387, 0.000000
07-29 10:42:33.784+0600 D/avoidrickshaw(28893): event-values: 3.508476, 2.866602, 9.947562, 0.000000
07-29 10:42:33.844+0600 D/avoidrickshaw(28893): event-values: 3.133401, 2.769692, 9.700503, 0.000000
07-29 10:42:33.904+0600 D/avoidrickshaw(28893): event-values: 2.009373, 3.106482, 9.139984, 0.000000
07-29 10:42:33.964+0600 D/avoidrickshaw(28893): event-values: 2.816352, 3.467200, 9.043673, 0.000000
07-29 10:42:34.024+0600 D/avoidrickshaw(28893): event-values: 2.840281, 2.803192, 9.428319, 0.000000
07-29 10:42:34.084+0600 D/avoidrickshaw(28893): event-values: 3.178865, 2.217548, 9.403792, 0.000000
07-29 10:42:34.144+0600 D/avoidrickshaw(28893): event-values: 2.880959, 2.333600, 9.211170, 0.000000
07-29 10:42:34.204+0600 D/avoidrickshaw(28893): event-values: 3.026921, 2.502892, 8.736794, 0.000000
07-29 10:42:34.264+0600 D/avoidrickshaw(28893): event-values: 2.981457, 3.081357, 8.794221, 0.000000
07-29 10:42:34.324+0600 D/avoidrickshaw(28893): event-values: 3.088536, 3.207579, 8.805587, 0.000000
07-29 10:42:34.384+0600 D/avoidrickshaw(28893): event-values: 2.548356, 2.474777, 9.815957, 0.000000
07-29 10:42:34.445+0600 D/avoidrickshaw(28893): event-values: 2.488536, 2.068595, 10.056437, 0.000000
07-29 10:42:34.505+0600 D/avoidrickshaw(28893): event-values: 2.627320, 2.419144, 9.609575, 0.000000
07-29 10:42:34.565+0600 D/avoidrickshaw(28893): event-values: 0.583849, 3.413960, 9.279366, 0.000000
07-29 10:42:34.625+0600 D/avoidrickshaw(28893): event-values: 0.975673, 3.032902, 9.312866, 0.000000
07-29 10:42:34.685+0600 D/avoidrickshaw(28893): event-values: 1.365105, 2.545365, 10.413565, 0.000000
07-29 10:42:34.745+0600 D/avoidrickshaw(28893): event-values: 1.664208, 2.431108, 10.271790, 0.000000
07-29 10:42:34.805+0600 D/avoidrickshaw(28893): event-values: 0.659821, 2.490330, 9.318848, 0.000000
07-29 10:42:34.865+0600 D/avoidrickshaw(28893): event-values: 0.169292, 4.208975, 8.677571, 0.000000
07-29 10:42:34.925+0600 D/avoidrickshaw(28893): event-values: -0.123230, 4.363910, 9.957133, 0.000000
07-29 10:42:34.985+0600 D/avoidrickshaw(28893): event-values: 0.600000, 4.436892, 9.468399, 0.000000
07-29 10:42:35.045+0600 D/avoidrickshaw(28893): event-values: -0.959522, 4.141976, 9.327222, 0.000000
07-29 10:42:35.105+0600 D/avoidrickshaw(28893): event-values: -1.575076, 4.316652, 9.336794, 0.000000
07-29 10:42:35.175+0600 D/avoidrickshaw(28893): event-values: -1.214357, 4.923233, 7.811967, 0.000000
07-29 10:42:35.235+0600 D/avoidrickshaw(28893): event-values: -0.387039, 5.213961, 7.825128, 0.000000
07-29 10:42:35.295+0600 D/avoidrickshaw(28893): event-values: -0.540778, 6.387640, 7.365108, 0.000000
07-29 10:42:35.355+0600 D/avoidrickshaw(28893): event-values: -0.707677, 6.502496, 7.116853, 0.000000
07-29 10:42:35.415+0600 D/avoidrickshaw(28893): event-values: -0.716650, 6.854240, 6.815358, 0.000000
07-29 10:42:35.476+0600 D/avoidrickshaw(28893): event-values: -0.557528, 6.668797, 7.330412, 0.000000
07-29 10:42:35.536+0600 D/avoidrickshaw(28893): event-values: -0.735195, 6.460023, 7.883154, 0.000000
07-29 10:42:35.596+0600 D/avoidrickshaw(28893): event-values: -0.424726, 6.406185, 7.636694, 0.000000
07-29 10:42:35.656+0600 D/avoidrickshaw(28893): event-values: -0.384646, 6.476773, 7.721639, 0.000000
07-29 10:42:35.716+0600 D/avoidrickshaw(28893): event-values: -0.649053, 6.583852, 7.353144, 0.000000
07-29 10:42:35.776+0600 D/avoidrickshaw(28893): event-values: -0.854836, 6.823732, 6.820142, 0.000000
07-29 10:42:35.836+0600 D/avoidrickshaw(28893): event-values: -0.848256, 6.768099, 7.300502, 0.000000
07-29 10:42:35.896+0600 D/avoidrickshaw(28893): event-values: -0.940978, 6.844669, 7.442875, 0.000000
07-29 10:42:35.956+0600 D/avoidrickshaw(28893): event-values: -0.260818, 6.659225, 7.759924, 0.000000
07-29 10:42:36.016+0600 D/avoidrickshaw(28893): event-values: -0.428315, 6.206384, 7.956135, 0.000000
07-29 10:42:36.076+0600 D/avoidrickshaw(28893): event-values: -0.156132, 5.970691, 7.694121, 0.000000
07-29 10:42:36.136+0600 D/avoidrickshaw(28893): event-values: -0.335593, 5.935397, 8.112267, 0.000000
07-29 10:42:36.196+0600 D/avoidrickshaw(28893): event-values: -0.184247, 6.104091, 7.504490, 0.000000
07-29 10:42:36.256+0600 D/avoidrickshaw(28893): event-values: -0.171087, 6.210571, 7.396813, 0.000000
07-29 10:42:36.316+0600 D/avoidrickshaw(28893): event-values: -0.551546, 6.433104, 7.832905, 0.000000
07-29 10:42:36.376+0600 D/avoidrickshaw(28893): event-values: -0.501296, 6.329016, 8.039884, 0.000000
07-29 10:42:36.436+0600 D/avoidrickshaw(28893): event-values: -0.275175, 6.428318, 8.101500, 0.000000
07-29 10:42:36.497+0600 D/avoidrickshaw(28893): event-values: -0.019143, 6.447461, 6.984051, 0.000000
07-29 10:42:36.557+0600 D/avoidrickshaw(28893): event-values: -0.282353, 5.678168, 7.758727, 0.000000
07-29 10:42:36.617+0600 D/avoidrickshaw(28893): event-values: 0.726820, 5.678168, 8.519645, 0.000000
07-29 10:42:36.677+0600 D/avoidrickshaw(28893): event-values: 1.040280, 5.081758, 8.511270, 0.000000
07-29 10:42:36.737+0600 D/avoidrickshaw(28893): event-values: 0.923629, 5.204390, 8.782257, 0.000000
07-29 10:42:36.797+0600 D/avoidrickshaw(28893): event-values: 0.651446, 5.249853, 8.735598, 0.000000
07-29 10:42:36.857+0600 D/avoidrickshaw(28893): event-values: 0.666999, 5.443672, 7.942377, 0.000000
07-29 10:42:36.917+0600 D/avoidrickshaw(28893): event-values: 0.384048, 5.514858, 8.136793, 0.000000
07-29 10:42:36.977+0600 D/avoidrickshaw(28893): event-values: 0.180658, 5.191827, 8.104490, 0.000000
07-29 10:42:37.027+0600 D/avoidrickshaw(28893): event-values: 0.498904, 5.127820, 8.465208, 0.000000
07-29 10:42:37.087+0600 D/avoidrickshaw(28893): event-values: 0.335593, 5.129015, 8.702696, 0.000000
07-29 10:42:37.147+0600 D/avoidrickshaw(28893): event-values: 0.384048, 4.994419, 8.459824, 0.000000
07-29 10:42:37.207+0600 D/avoidrickshaw(28893): event-values: -0.401396, 5.809175, 8.157730, 0.000000
07-29 10:42:37.267+0600 D/avoidrickshaw(28893): event-values: 0.519841, 5.059623, 8.425726, 0.000000
07-29 10:42:37.327+0600 D/avoidrickshaw(28893): event-values: -0.723231, 5.417949, 8.598009, 0.000000
07-29 10:42:37.387+0600 D/avoidrickshaw(28893): event-values: -0.396610, 5.289933, 8.451449, 0.000000
07-29 10:42:37.447+0600 D/avoidrickshaw(28893): event-values: -0.169890, 5.529215, 8.800802, 0.000000
07-29 10:42:37.507+0600 D/avoidrickshaw(28893): event-values: -0.224925, 5.143373, 8.864809, 0.000000
07-29 10:42:37.538+0600 I/Tizen::Net::Wifi( 1305): (1085) > _WifiService is not registered.
07-29 10:42:37.568+0600 D/avoidrickshaw(28893): event-values: -0.142971, 4.582854, 8.459824, 0.000000
07-29 10:42:37.628+0600 D/avoidrickshaw(28893): event-values: -0.397807, 4.277769, 8.857033, 0.000000
07-29 10:42:37.688+0600 D/avoidrickshaw(28893): event-values: -0.694517, 4.704289, 8.309077, 0.000000
07-29 10:42:37.748+0600 D/avoidrickshaw(28893): event-values: -1.025923, 5.158926, 8.498110, 0.000000
07-29 10:42:37.808+0600 D/avoidrickshaw(28893): event-values: -0.910469, 5.273183, 8.109874, 0.000000
07-29 10:42:37.868+0600 D/avoidrickshaw(28893): event-values: -1.252044, 5.501099, 8.624331, 0.000000
07-29 10:42:37.928+0600 D/avoidrickshaw(28893): event-values: -1.004387, 5.467001, 8.670991, 0.000000
07-29 10:42:37.988+0600 D/avoidrickshaw(28893): event-values: -0.597009, 5.371289, 8.516654, 0.000000
07-29 10:42:38.048+0600 D/avoidrickshaw(28893): event-values: -0.668196, 5.332406, 8.310871, 0.000000
07-29 10:42:38.108+0600 D/avoidrickshaw(28893): event-values: -0.281755, 5.325825, 8.225926, 0.000000
07-29 10:42:38.168+0600 D/avoidrickshaw(28893): event-values: -0.510868, 5.408377, 7.901100, 0.000000
07-29 10:42:38.228+0600 D/avoidrickshaw(28893): event-values: -0.653839, 5.619544, 8.467601, 0.000000
07-29 10:42:38.288+0600 D/avoidrickshaw(28893): event-values: -0.775873, 5.535795, 8.740383, 0.000000
07-29 10:42:38.348+0600 D/avoidrickshaw(28893): event-values: -1.065404, 5.399404, 8.481958, 0.000000
07-29 10:42:38.398+0600 I/Tizen::Net::Wifi( 1305): (941) > The background scan result updated.
07-29 10:42:38.408+0600 D/avoidrickshaw(28893): event-values: -0.910469, 5.913262, 8.834301, 0.000000
07-29 10:42:38.468+0600 D/avoidrickshaw(28893): event-values: -0.972682, 5.662016, 9.092726, 0.000000
07-29 10:42:38.528+0600 D/avoidrickshaw(28893): event-values: -1.175474, 5.531009, 9.047262, 0.000000
07-29 10:42:38.589+0600 D/avoidrickshaw(28893): horizontal_acc: 31.000000, vertical_acc: -1.000000
07-29 10:42:38.589+0600 D/avoidrickshaw(28893): previous lat: 23.814995, previous long: 90.426570
07-29 10:42:38.589+0600 D/avoidrickshaw(28893): current lat: 23.814995, current long: 90.426570
07-29 10:42:38.589+0600 D/avoidrickshaw(28893): total distance: 0.000000 meters
07-29 10:42:38.589+0600 D/avoidrickshaw(28893): elapsed time; 0.117278
07-29 10:42:38.589+0600 D/avoidrickshaw(28893): event-values: -1.138385, 5.035097, 8.559725, 0.000000
07-29 10:42:38.649+0600 D/avoidrickshaw(28893): event-values: -1.067199, 5.280960, 8.074579, 0.000000
07-29 10:42:38.709+0600 D/avoidrickshaw(28893): event-values: -0.181855, 3.996014, 8.338986, 0.000000
07-29 10:42:38.769+0600 D/avoidrickshaw(28893): event-values: -1.012762, 4.447659, 8.738588, 0.000000
07-29 10:42:38.829+0600 D/avoidrickshaw(28893): event-values: -0.713659, 3.744767, 8.587243, 0.000000
07-29 10:42:38.889+0600 D/avoidrickshaw(28893): event-values: -0.375075, 3.619144, 9.497711, 0.000000
07-29 10:42:38.949+0600 D/avoidrickshaw(28893): event-values: -0.604786, 3.186641, 10.019347, 0.000000
07-29 10:42:39.009+0600 D/avoidrickshaw(28893): event-values: -1.188036, 2.967100, 9.614960, 0.000000
07-29 10:42:39.069+0600 D/avoidrickshaw(28893): event-values: -0.375075, 3.000001, 10.001400, 0.000000
07-29 10:42:39.129+0600 D/avoidrickshaw(28893): event-values: -0.632902, 4.036692, 9.190233, 0.000000
07-29 10:42:39.189+0600 D/avoidrickshaw(28893): event-values: -1.182054, 4.037290, 8.647661, 0.000000
07-29 10:42:39.249+0600 D/avoidrickshaw(28893): event-values: -1.245464, 4.056433, 8.962915, 0.000000
07-29 10:42:39.309+0600 D/avoidrickshaw(28893): event-values: -0.305085, 3.841677, 9.535398, 0.000000
07-29 10:42:39.369+0600 D/avoidrickshaw(28893): event-values: -0.422931, 3.810570, 9.100503, 0.000000
07-29 10:42:39.429+0600 D/avoidrickshaw(28893): event-values: -0.736391, 3.685545, 9.169894, 0.000000
07-29 10:42:39.489+0600 D/avoidrickshaw(28893): event-values: -0.730409, 4.338188, 9.376873, 0.000000
07-29 10:42:39.549+0600 D/avoidrickshaw(28893): event-values: -0.114855, 4.298108, 8.867801, 0.000000
07-29 10:42:39.610+0600 D/avoidrickshaw(28893): event-values: -0.174676, 4.166502, 8.720044, 0.000000
07-29 10:42:39.670+0600 D/avoidrickshaw(28893): event-values: -2.402394, 5.702096, 9.117252, 0.000000
07-29 10:42:39.730+0600 D/avoidrickshaw(28893): event-values: -0.759721, 5.843273, 8.499306, 0.000000
07-29 10:42:39.790+0600 D/avoidrickshaw(28893): event-values: 0.034098, 5.744569, 8.810372, 0.000000
07-29 10:42:39.850+0600 D/avoidrickshaw(28893): event-values: 1.141376, 5.012365, 9.117850, 0.000000
07-29 10:42:39.910+0600 D/avoidrickshaw(28893): event-values: 1.727020, 3.970291, 8.149356, 0.000000
07-29 10:42:39.970+0600 D/avoidrickshaw(28893): event-values: 2.315654, 3.852444, 8.297112, 0.000000
07-29 10:42:40.030+0600 D/avoidrickshaw(28893): event-values: 4.652246, 3.693920, 7.334002, 0.000000
07-29 10:42:40.090+0600 D/avoidrickshaw(28893): event-values: 4.895715, 3.988237, 8.377272, 0.000000
07-29 10:42:40.150+0600 D/avoidrickshaw(28893): event-values: 5.833702, 3.908077, 7.762915, 0.000000
07-29 10:42:40.210+0600 D/avoidrickshaw(28893): event-values: 5.303093, 3.875774, 8.030313, 0.000000
07-29 10:42:40.270+0600 D/avoidrickshaw(28893): event-values: 4.765904, 4.801797, 7.411768, 0.000000
07-29 10:42:40.330+0600 D/avoidrickshaw(28893): event-values: 4.159324, 5.344369, 7.187441, 0.000000
07-29 10:42:40.390+0600 D/avoidrickshaw(28893): event-values: 4.181458, 5.331209, 7.878368, 0.000000
07-29 10:42:40.450+0600 D/avoidrickshaw(28893): event-values: 5.647062, 4.586443, 7.076175, 0.000000
07-29 10:42:40.510+0600 D/avoidrickshaw(28893): event-values: 5.201398, 5.035097, 7.433901, 0.000000
07-29 10:42:40.570+0600 D/avoidrickshaw(28893): event-values: 5.333004, 4.342375, 6.911070, 0.000000
07-29 10:42:40.631+0600 D/avoidrickshaw(28893): event-values: 4.107878, 4.770092, 6.320641, 0.000000
07-29 10:42:40.691+0600 D/avoidrickshaw(28893): event-values: 4.820939, 5.771489, 6.905686, 0.000000
07-29 10:42:40.751+0600 D/avoidrickshaw(28893): event-values: 5.555536, 5.564509, 6.711867, 0.000000
07-29 10:42:40.811+0600 D/avoidrickshaw(28893): event-values: 5.035097, 5.407779, 6.787241, 0.000000
07-29 10:42:40.871+0600 D/avoidrickshaw(28893): event-values: 4.883152, 5.019544, 6.651449, 0.000000
07-29 10:42:40.931+0600 D/avoidrickshaw(28893): event-values: 4.764110, 5.225924, 7.004390, 0.000000
07-29 10:42:40.991+0600 D/avoidrickshaw(28893): event-values: 4.835297, 5.166104, 7.203593, 0.000000
07-29 10:42:41.051+0600 D/avoidrickshaw(28893): event-values: 5.503492, 5.221139, 7.337590, 0.000000
07-29 10:42:41.111+0600 D/avoidrickshaw(28893): event-values: 5.260022, 5.204988, 6.735795, 0.000000
07-29 10:42:41.171+0600 D/avoidrickshaw(28893): event-values: 6.143572, 4.814359, 7.091728, 0.000000
07-29 10:42:41.231+0600 D/avoidrickshaw(28893): event-values: 5.513064, 4.984250, 7.033702, 0.000000
07-29 10:42:41.291+0600 D/avoidrickshaw(28893): event-values: 5.183452, 5.093721, 7.049256, 0.000000
07-29 10:42:41.351+0600 D/avoidrickshaw(28893): event-values: 4.555934, 5.021937, 6.506683, 0.000000
07-29 10:42:41.411+0600 D/avoidrickshaw(28893): event-values: 4.935197, 4.496712, 7.101898, 0.000000
07-29 10:42:41.471+0600 D/avoidrickshaw(28893): event-values: 5.136194, 4.769494, 7.097710, 0.000000
07-29 10:42:41.531+0600 D/avoidrickshaw(28893): event-values: 5.494519, 4.640880, 7.753344, 0.000000
07-29 10:42:41.591+0600 D/avoidrickshaw(28893): event-values: 5.050052, 5.364110, 7.681559, 0.000000
07-29 10:42:41.652+0600 D/avoidrickshaw(28893): event-values: 4.438087, 4.838886, 8.112865, 0.000000
07-29 10:42:41.712+0600 D/avoidrickshaw(28893): event-values: 4.387240, 4.609773, 7.521240, 0.000000
07-29 10:42:41.772+0600 D/avoidrickshaw(28893): event-values: 4.252644, 4.503292, 7.626524, 0.000000
07-29 10:42:41.832+0600 D/avoidrickshaw(28893): event-values: 4.679165, 4.445865, 7.581060, 0.000000
07-29 10:42:41.892+0600 D/avoidrickshaw(28893): event-values: 5.111667, 4.804190, 7.245467, 0.000000
07-29 10:42:41.952+0600 D/avoidrickshaw(28893): event-values: 4.979464, 4.730012, 7.515257, 0.000000
07-29 10:42:42.012+0600 D/avoidrickshaw(28893): event-values: 5.231906, 4.285545, 7.785048, 0.000000
07-29 10:42:42.072+0600 D/avoidrickshaw(28893): event-values: 5.640481, 4.131806, 6.756733, 0.000000
07-29 10:42:42.132+0600 D/avoidrickshaw(28893): event-values: 5.584848, 4.434498, 7.074979, 0.000000
07-29 10:42:42.192+0600 D/avoidrickshaw(28893): event-values: 5.614160, 4.677370, 6.912266, 0.000000
07-29 10:42:42.252+0600 D/avoidrickshaw(28893): event-values: 5.781657, 4.362115, 7.319046, 0.000000
07-29 10:42:42.312+0600 D/avoidrickshaw(28893): event-values: 5.889335, 4.250850, 7.210771, 0.000000
07-29 10:42:42.372+0600 D/avoidrickshaw(28893): event-values: 4.520042, 4.636094, 6.689135, 0.000000
07-29 10:42:42.432+0600 D/avoidrickshaw(28893): event-values: 5.611169, 3.970889, 7.174879, 0.000000
07-29 10:42:42.492+0600 D/avoidrickshaw(28893): event-values: 5.580661, 4.986044, 7.664809, 0.000000
07-29 10:42:42.552+0600 D/avoidrickshaw(28893): event-values: 5.802595, 4.691129, 7.474579, 0.000000
07-29 10:42:42.612+0600 D/avoidrickshaw(28893): event-values: 5.073382, 4.795217, 6.531807, 0.000000
07-29 10:42:42.673+0600 D/avoidrickshaw(28893): event-values: 5.465207, 3.839284, 6.979864, 0.000000
07-29 10:42:42.733+0600 D/avoidrickshaw(28893): event-values: 5.531009, 4.425525, 7.589435, 0.000000
07-29 10:42:42.793+0600 D/avoidrickshaw(28893): event-values: 5.550750, 3.910470, 6.492326, 0.000000
07-29 10:42:42.853+0600 D/avoidrickshaw(28893): event-values: 4.530211, 4.690530, 8.051848, 0.000000
07-29 10:42:42.913+0600 D/avoidrickshaw(28893): event-values: 5.198408, 3.938586, 8.184052, 0.000000
07-29 10:42:42.973+0600 D/avoidrickshaw(28893): event-values: 4.986044, 4.180261, 7.878967, 0.000000
07-29 10:42:43.033+0600 D/avoidrickshaw(28893): event-values: 5.061419, 4.177270, 7.372287, 0.000000
07-29 10:42:43.093+0600 D/avoidrickshaw(28893): event-values: 5.203791, 4.028915, 7.846664, 0.000000
07-29 10:42:43.153+0600 D/avoidrickshaw(28893): event-values: 5.246264, 4.258028, 7.754540, 0.000000
07-29 10:42:43.213+0600 D/avoidrickshaw(28893): event-values: 4.538586, 4.037290, 8.098508, 0.000000
07-29 10:42:43.273+0600 D/avoidrickshaw(28893): event-values: 4.758726, 4.101896, 7.939984, 0.000000
07-29 10:42:43.333+0600 D/avoidrickshaw(28893): event-values: 4.834698, 4.171288, 7.655836, 0.000000
07-29 10:42:43.393+0600 D/avoidrickshaw(28893): event-values: 4.768896, 4.363910, 7.657032, 0.000000
07-29 10:42:43.453+0600 D/avoidrickshaw(28893): event-values: 4.322634, 4.366303, 8.091928, 0.000000
07-29 10:42:43.513+0600 D/avoidrickshaw(28893): event-values: 4.300500, 4.530211, 7.911868, 0.000000
07-29 10:42:43.573+0600 D/avoidrickshaw(28893): event-values: 4.028317, 4.399803, 7.704291, 0.000000
07-29 10:42:43.633+0600 D/avoidrickshaw(28893): event-values: 4.131806, 4.550550, 7.945965, 0.000000
07-29 10:42:43.694+0600 D/avoidrickshaw(28893): event-values: 4.963911, 4.366901, 7.896913, 0.000000
07-29 10:42:43.754+0600 D/avoidrickshaw(28893): event-values: 5.226523, 4.387838, 7.234101, 0.000000
07-29 10:42:43.814+0600 D/avoidrickshaw(28893): event-values: 5.066204, 4.222733, 8.155338, 0.000000
07-29 10:42:43.874+0600 D/avoidrickshaw(28893): event-values: 4.724628, 3.839882, 7.886744, 0.000000
07-29 10:42:43.934+0600 D/avoidrickshaw(28893): event-values: 4.339384, 3.782454, 8.044669, 0.000000
07-29 10:42:43.994+0600 D/avoidrickshaw(28893): event-values: 4.217948, 4.078567, 7.499106, 0.000000
07-29 10:42:44.054+0600 D/avoidrickshaw(28893): event-values: 4.559524, 4.466204, 7.947162, 0.000000
07-29 10:42:44.114+0600 D/avoidrickshaw(28893): event-values: 4.720441, 4.186841, 8.036295, 0.000000
07-29 10:42:44.174+0600 D/avoidrickshaw(28893): event-values: 4.380062, 3.948158, 8.534002, 0.000000
07-29 10:42:44.234+0600 D/avoidrickshaw(28893): event-values: 4.458426, 4.150351, 8.145168, 0.000000
07-29 10:42:44.294+0600 D/avoidrickshaw(28893): event-values: 4.516453, 4.183252, 8.121240, 0.000000
07-29 10:42:44.354+0600 D/avoidrickshaw(28893): event-values: 4.665406, 4.262215, 7.628917, 0.000000
07-29 10:42:44.414+0600 D/avoidrickshaw(28893): event-values: 4.561318, 3.981657, 7.971688, 0.000000
07-29 10:42:44.474+0600 D/avoidrickshaw(28893): event-values: 4.666004, 3.789633, 7.941778, 0.000000
07-29 10:42:44.534+0600 D/avoidrickshaw(28893): event-values: 4.428516, 3.388835, 7.865806, 0.000000
07-29 10:42:44.594+0600 D/avoidrickshaw(28893): event-values: 4.291528, 3.564109, 7.454241, 0.000000
07-29 10:42:44.654+0600 D/avoidrickshaw(28893): event-values: 4.603193, 3.563511, 8.169695, 0.000000
07-29 10:42:44.715+0600 D/avoidrickshaw(28893): event-values: 4.273581, 3.397808, 8.386245, 0.000000
07-29 10:42:44.775+0600 D/avoidrickshaw(28893): event-values: 4.092325, 3.432504, 8.910872, 0.000000
07-29 10:42:44.835+0600 D/avoidrickshaw(28893): event-values: 4.436293, 3.667001, 8.557930, 0.000000
07-29 10:42:44.895+0600 D/avoidrickshaw(28893): event-values: 4.656433, 3.638287, 8.931211, 0.000000
07-29 10:42:44.955+0600 D/avoidrickshaw(28893): event-values: 4.294518, 3.391228, 8.794820, 0.000000
07-29 10:42:45.015+0600 D/avoidrickshaw(28893): event-values: 3.928416, 3.317050, 8.767302, 0.000000
07-29 10:42:45.075+0600 D/avoidrickshaw(28893): event-values: 3.810570, 3.018546, 8.870791, 0.000000
07-29 10:42:45.135+0600 D/avoidrickshaw(28893): event-values: 3.895515, 3.125625, 9.172287, 0.000000
07-29 10:42:45.195+0600 D/avoidrickshaw(28893): event-values: 3.827320, 3.324827, 8.419147, 0.000000
07-29 10:42:45.255+0600 D/avoidrickshaw(28893): event-values: 5.002196, 3.568895, 8.051250, 0.000000
07-29 10:42:45.315+0600 D/avoidrickshaw(28893): event-values: 4.624130, 3.519244, 8.150552, 0.000000
07-29 10:42:45.375+0600 D/avoidrickshaw(28893): event-values: 5.120641, 3.301497, 8.230114, 0.000000
07-29 10:42:45.435+0600 D/avoidrickshaw(28893): event-values: 4.502694, 3.149553, 8.514261, 0.000000
07-29 10:42:45.495+0600 D/avoidrickshaw(28893): event-values: 3.777668, 2.830709, 8.751749, 0.000000
07-29 10:42:45.555+0600 D/avoidrickshaw(28893): event-values: 4.113861, 3.419942, 7.867002, 0.000000
07-29 10:42:45.615+0600 D/avoidrickshaw(28893): event-values: 4.503292, 3.434897, 8.176274, 0.000000
07-29 10:42:45.675+0600 D/avoidrickshaw(28893): event-values: 4.242475, 3.266203, 8.600403, 0.000000
07-29 10:42:45.736+0600 D/avoidrickshaw(28893): event-values: 3.935595, 3.091527, 8.987441, 0.000000
07-29 10:42:45.796+0600 D/avoidrickshaw(28893): event-values: 3.786642, 3.395415, 8.602197, 0.000000
07-29 10:42:45.856+0600 D/avoidrickshaw(28893): event-values: 3.659224, 3.437290, 8.414361, 0.000000
07-29 10:42:45.916+0600 D/avoidrickshaw(28893): event-values: 3.416353, 3.086143, 8.091928, 0.000000
07-29 10:42:45.976+0600 D/avoidrickshaw(28893): event-values: 3.291328, 3.464209, 7.270591, 0.000000
07-29 10:42:46.036+0600 D/avoidrickshaw(28893): event-values: 3.945167, 2.769692, 8.787642, 0.000000
07-29 10:42:46.096+0600 D/avoidrickshaw(28893): event-values: 4.686941, 2.688336, 11.149955, 0.000000
07-29 10:42:46.156+0600 D/avoidrickshaw(28893): event-values: 4.657031, 1.962115, 11.411969, 0.000000
07-29 10:42:46.216+0600 D/avoidrickshaw(28893): event-values: 2.971287, 2.007578, 10.018748, 0.000000
07-29 10:42:46.276+0600 D/avoidrickshaw(28893): event-values: 2.008176, 2.419144, 9.617352, 0.000000
07-29 10:42:46.336+0600 D/avoidrickshaw(28893): event-values: 2.610569, 3.157330, 8.629715, 0.000000
07-29 10:42:46.396+0600 D/avoidrickshaw(28893): event-values: 2.319842, 2.925824, 7.962716, 0.000000
07-29 10:42:46.456+0600 D/avoidrickshaw(28893): event-values: 2.706881, 2.825325, 8.575278, 0.000000
07-29 10:42:46.516+0600 D/avoidrickshaw(28893): event-values: 2.545963, 2.769094, 9.458229, 0.000000
07-29 10:42:46.516+0600 I/Tizen::Net::Wifi( 1305): (1085) > _WifiService is not registered.
07-29 10:42:46.576+0600 D/avoidrickshaw(28893): event-values: 2.754139, 3.136392, 9.205189, 0.000000
07-29 10:42:46.636+0600 D/avoidrickshaw(28893): event-values: 2.760121, 3.698705, 8.854640, 0.000000
07-29 10:42:46.696+0600 D/avoidrickshaw(28893): event-values: 1.999203, 3.681956, 9.446266, 0.000000
07-29 10:42:46.757+0600 D/avoidrickshaw(28893): event-values: 0.996611, 3.904488, 9.869196, 0.000000
07-29 10:42:46.817+0600 D/avoidrickshaw(28893): event-values: 0.705883, 4.116253, 9.570094, 0.000000
07-29 10:42:46.877+0600 D/avoidrickshaw(28893): event-values: -0.268594, 4.119843, 9.285946, 0.000000
07-29 10:42:46.937+0600 D/avoidrickshaw(28893): event-values: 0.147757, 4.351348, 8.800204, 0.000000
07-29 10:42:46.997+0600 D/avoidrickshaw(28893): event-values: 0.136391, 4.439882, 8.760124, 0.000000
07-29 10:42:47.057+0600 D/avoidrickshaw(28893): event-values: 0.302094, 4.297509, 9.299107, 0.000000
07-29 10:42:47.117+0600 D/avoidrickshaw(28893): event-values: 1.476970, 4.651049, 8.522636, 0.000000
07-29 10:42:47.177+0600 D/avoidrickshaw(28893): event-values: 1.980659, 4.329214, 8.863015, 0.000000
07-29 10:42:47.237+0600 D/avoidrickshaw(28893): event-values: 0.500100, 3.705286, 9.668200, 0.000000
07-29 10:42:47.287+0600 D/avoidrickshaw(28893): event-values: -1.215554, 3.035296, 9.118448, 0.000000
07-29 10:42:47.347+0600 D/avoidrickshaw(28893): event-values: -0.087936, 3.759722, 8.797811, 0.000000
07-29 10:42:47.407+0600 D/avoidrickshaw(28893): event-values: -0.688535, 3.903292, 9.521042, 0.000000
07-29 10:42:47.467+0600 D/avoidrickshaw(28893): event-values: -0.043071, 5.394020, 8.320443, 0.000000
07-29 10:42:47.517+0600 I/Tizen::Net::Wifi( 1305): (1085) > _WifiService is not registered.
07-29 10:42:47.527+0600 D/avoidrickshaw(28893): event-values: -1.258027, 4.886742, 8.916255, 0.000000
07-29 10:42:47.587+0600 D/avoidrickshaw(28893): event-values: -0.227916, 5.500501, 7.999804, 0.000000
07-29 10:42:47.647+0600 D/avoidrickshaw(28893): event-values: -0.129212, 4.744967, 8.562118, 0.000000
07-29 10:42:47.707+0600 D/avoidrickshaw(28893): event-values: -0.041276, 4.634897, 8.758329, 0.000000
07-29 10:42:47.768+0600 D/avoidrickshaw(28893): event-values: -0.083749, 4.460221, 8.300702, 0.000000
07-29 10:42:47.828+0600 D/avoidrickshaw(28893): event-values: 0.277567, 4.197011, 9.113065, 0.000000
07-29 10:42:47.888+0600 D/avoidrickshaw(28893): event-values: 0.640080, 3.861418, 9.783654, 0.000000
07-29 10:42:47.948+0600 D/avoidrickshaw(28893): event-values: 1.021137, 3.592225, 8.734401, 0.000000
07-29 10:42:48.008+0600 D/avoidrickshaw(28893): event-values: 0.214756, 3.963711, 10.216157, 0.000000
07-29 10:42:48.068+0600 D/avoidrickshaw(28893): event-values: 0.913460, 4.724628, 9.060423, 0.000000
07-29 10:42:48.128+0600 D/avoidrickshaw(28893): event-values: 0.573081, 4.709075, 8.413164, 0.000000
07-29 10:42:48.188+0600 D/avoidrickshaw(28893): event-values: 0.217747, 4.946563, 8.276175, 0.000000
07-29 10:42:48.248+0600 D/avoidrickshaw(28893): event-values: 0.292523, 4.539783, 8.583055, 0.000000
07-29 10:42:48.308+0600 D/avoidrickshaw(28893): event-values: 0.966102, 4.449454, 8.937790, 0.000000
07-29 10:42:48.368+0600 D/avoidrickshaw(28893): event-values: 1.177867, 3.767499, 9.483953, 0.000000
07-29 10:42:48.428+0600 D/avoidrickshaw(28893): event-values: 0.497109, 4.002594, 10.094720, 0.000000
07-29 10:42:48.488+0600 D/avoidrickshaw(28893): event-values: 0.592822, 4.360321, 9.370892, 0.000000
07-29 10:42:48.548+0600 D/avoidrickshaw(28893): event-values: 0.503689, 5.060820, 8.567502, 0.000000
07-29 10:42:48.608+0600 D/avoidrickshaw(28893): event-values: -0.348754, 5.154738, 8.616554, 0.000000
07-29 10:42:48.668+0600 D/avoidrickshaw(28893): event-values: -0.974477, 4.966902, 8.868997, 0.000000
07-29 10:42:48.728+0600 D/avoidrickshaw(28893): event-values: -0.793819, 4.969295, 9.150752, 0.000000
07-29 10:42:48.788+0600 D/avoidrickshaw(28893): event-values: 0.320638, 4.945366, 8.428120, 0.000000
07-29 10:42:48.849+0600 D/avoidrickshaw(28893): event-values: 0.205783, 4.688736, 8.362915, 0.000000
07-29 10:42:48.909+0600 D/avoidrickshaw(28893): event-values: -0.069392, 4.424927, 8.873184, 0.000000
07-29 10:42:48.969+0600 D/avoidrickshaw(28893): event-values: -0.316451, 4.283751, 9.040084, 0.000000
07-29 10:42:49.029+0600 D/avoidrickshaw(28893): event-values: 0.368495, 4.616353, 8.929416, 0.000000
07-29 10:42:49.089+0600 D/avoidrickshaw(28893): event-values: 0.418744, 4.763512, 8.998209, 0.000000
07-29 10:42:49.149+0600 D/avoidrickshaw(28893): event-values: 0.552742, 4.856832, 8.833105, 0.000000
07-29 10:42:49.209+0600 D/avoidrickshaw(28893): event-values: 0.266800, 4.808975, 8.717053, 0.000000
07-29 10:42:49.269+0600 D/avoidrickshaw(28893): event-values: 0.301496, 4.824529, 8.344969, 0.000000
07-29 10:42:49.329+0600 D/avoidrickshaw(28893): event-values: 0.162114, 5.023133, 8.849854, 0.000000
07-29 10:42:49.389+0600 D/avoidrickshaw(28893): event-values: 0.749552, 4.986642, 8.584251, 0.000000
07-29 10:42:49.449+0600 D/avoidrickshaw(28893): event-values: 0.796212, 4.818546, 8.790632, 0.000000
07-29 10:42:49.509+0600 D/avoidrickshaw(28893): event-values: 0.601795, 4.814359, 9.064610, 0.000000
07-29 10:42:49.569+0600 D/avoidrickshaw(28893): event-values: 0.477966, 4.672585, 9.094521, 0.000000
07-29 10:42:49.629+0600 D/avoidrickshaw(28893): event-values: 0.763310, 4.854439, 9.195019, 0.000000
07-29 10:42:49.689+0600 D/avoidrickshaw(28893): event-values: 0.547358, 6.117849, 6.662815, 0.000000
07-29 10:42:49.749+0600 D/avoidrickshaw(28893): event-values: 0.175274, 4.618148, 9.396016, 0.000000
07-29 10:42:49.809+0600 D/avoidrickshaw(28893): event-values: 0.836291, 4.895117, 8.998209, 0.000000
07-29 10:42:49.870+0600 D/avoidrickshaw(28893): event-values: 0.500100, 4.735396, 8.953942, 0.000000
07-29 10:42:49.930+0600 D/avoidrickshaw(28893): event-values: 0.335593, 4.728218, 9.281161, 0.000000
07-29 10:42:49.990+0600 D/avoidrickshaw(28893): event-values: 0.652642, 5.050650, 9.239884, 0.000000
07-29 10:42:50.050+0600 D/avoidrickshaw(28893): event-values: 0.849452, 4.857430, 8.705089, 0.000000
07-29 10:42:50.110+0600 D/avoidrickshaw(28893): event-values: 0.329013, 4.797609, 8.967103, 0.000000
07-29 10:42:50.170+0600 D/avoidrickshaw(28893): event-values: 0.608973, 4.735396, 9.532408, 0.000000
07-29 10:42:50.230+0600 D/avoidrickshaw(28893): event-values: 1.104288, 4.403990, 8.978469, 0.000000
07-29 10:42:50.290+0600 D/avoidrickshaw(28893): event-values: 0.878764, 4.753940, 8.330013, 0.000000
07-29 10:42:50.350+0600 D/avoidrickshaw(28893): event-values: 0.370289, 4.634299, 8.522636, 0.000000
07-29 10:42:50.410+0600 D/avoidrickshaw(28893): event-values: 0.744168, 5.014758, 8.528618, 0.000000
07-29 10:42:50.470+0600 D/avoidrickshaw(28893): event-values: 0.568295, 5.080561, 9.042477, 0.000000
07-29 10:42:50.530+0600 D/avoidrickshaw(28893): event-values: 0.711865, 4.883751, 9.347562, 0.000000
07-29 10:42:50.590+0600 D/avoidrickshaw(28893): event-values: 1.197010, 4.533801, 8.778069, 0.000000
07-29 10:42:50.650+0600 D/avoidrickshaw(28893): event-values: 0.696311, 4.282554, 8.963513, 0.000000
07-29 10:42:50.710+0600 D/avoidrickshaw(28893): event-values: 1.163510, 4.522435, 9.413962, 0.000000
07-29 10:42:50.770+0600 D/avoidrickshaw(28893): event-values: 0.934397, 4.755136, 8.133802, 0.000000
07-29 10:42:50.830+0600 D/avoidrickshaw(28893): event-values: -0.096311, 4.607978, 8.501699, 0.000000
07-29 10:42:50.891+0600 D/avoidrickshaw(28893): event-values: 0.623929, 5.107480, 8.977272, 0.000000
07-29 10:42:50.951+0600 D/avoidrickshaw(28893): event-values: 0.891925, 4.779065, 8.802596, 0.000000
07-29 10:42:51.011+0600 D/avoidrickshaw(28893): event-values: 0.967299, 4.625925, 9.339785, 0.000000
07-29 10:42:51.071+0600 D/avoidrickshaw(28893): event-values: 1.105484, 4.374080, 9.809975, 0.000000
07-29 10:42:51.131+0600 D/avoidrickshaw(28893): event-values: 1.744966, 3.664608, 9.147761, 0.000000
07-29 10:42:51.191+0600 D/avoidrickshaw(28893): event-values: 1.998007, 4.018147, 8.983253, 0.000000
07-29 10:42:51.251+0600 D/avoidrickshaw(28893): event-values: 1.607378, 4.055236, 9.248260, 0.000000
07-29 10:42:51.311+0600 D/avoidrickshaw(28893): event-values: 1.113261, 4.272983, 9.052048, 0.000000
07-29 10:42:51.371+0600 D/avoidrickshaw(28893): event-values: 1.196411, 4.295116, 8.633903, 0.000000
07-29 10:42:51.431+0600 D/avoidrickshaw(28893): event-values: 1.028316, 4.436892, 8.609376, 0.000000
07-29 10:42:51.491+0600 D/avoidrickshaw(28893): event-values: 1.040878, 4.240680, 9.173484, 0.000000
07-29 10:42:51.551+0600 D/avoidrickshaw(28893): event-values: 1.226920, 4.056433, 9.406186, 0.000000
07-29 10:42:51.611+0600 D/avoidrickshaw(28893): event-values: 1.171885, 4.123431, 9.397811, 0.000000
07-29 10:42:51.671+0600 D/avoidrickshaw(28893): event-values: 1.141376, 4.300500, 8.753544, 0.000000
07-29 10:42:51.731+0600 D/avoidrickshaw(28893): event-values: 0.388235, 4.237689, 8.944371, 0.000000
07-29 10:42:51.791+0600 D/avoidrickshaw(28893): event-values: 0.787837, 4.132405, 9.361918, 0.000000
07-29 10:42:51.851+0600 D/avoidrickshaw(28893): event-values: 0.686740, 4.218546, 9.241080, 0.000000
07-29 10:42:51.912+0600 D/avoidrickshaw(28893): event-values: 0.608973, 4.473382, 9.317053, 0.000000
07-29 10:42:51.972+0600 D/avoidrickshaw(28893): event-values: 0.733998, 4.400999, 8.909077, 0.000000
07-29 10:42:52.032+0600 D/avoidrickshaw(28893): event-values: 0.313460, 4.494319, 8.610572, 0.000000
07-29 10:42:52.092+0600 D/avoidrickshaw(28893): event-values: 0.517448, 4.419543, 8.916853, 0.000000
07-29 10:42:52.152+0600 D/avoidrickshaw(28893): event-values: 0.476770, 4.579264, 9.145369, 0.000000
07-29 10:42:52.212+0600 D/avoidrickshaw(28893): event-values: 0.375075, 4.431508, 8.947960, 0.000000
07-29 10:42:52.272+0600 D/avoidrickshaw(28893): event-values: 0.403191, 4.448855, 8.766704, 0.000000
07-29 10:42:52.332+0600 D/avoidrickshaw(28893): event-values: 0.597607, 4.515854, 9.207582, 0.000000
07-29 10:42:52.392+0600 D/avoidrickshaw(28893): event-values: 0.608973, 4.637290, 8.983253, 0.000000
07-29 10:42:52.452+0600 D/avoidrickshaw(28893): event-values: 0.393021, 4.518247, 8.882756, 0.000000
07-29 10:42:52.512+0600 D/avoidrickshaw(28893): event-values: 0.400798, 4.435097, 9.119645, 0.000000
07-29 10:42:52.572+0600 D/avoidrickshaw(28893): event-values: 0.478565, 4.125226, 9.107083, 0.000000
07-29 10:42:52.632+0600 D/avoidrickshaw(28893): event-values: 0.602991, 4.521238, 8.876774, 0.000000
07-29 10:42:52.692+0600 D/avoidrickshaw(28893): event-values: 0.315853, 4.883152, 8.962317, 0.000000
07-29 10:42:52.752+0600 D/avoidrickshaw(28893): event-values: 0.443869, 4.313063, 8.631510, 0.000000
07-29 10:42:52.812+0600 D/avoidrickshaw(28893): event-values: 0.656830, 4.247859, 9.440882, 0.000000
07-29 10:42:52.872+0600 D/avoidrickshaw(28893): event-values: 0.853041, 4.480560, 8.989237, 0.000000
07-29 10:42:52.933+0600 D/avoidrickshaw(28893): event-values: 0.352343, 4.499703, 8.887542, 0.000000
07-29 10:42:52.993+0600 D/avoidrickshaw(28893): event-values: 0.471386, 4.430909, 9.276375, 0.000000
07-29 10:42:53.053+0600 D/avoidrickshaw(28893): event-values: 0.635893, 4.277769, 8.876774, 0.000000
07-29 10:42:53.113+0600 D/avoidrickshaw(28893): event-values: 0.721436, 4.191627, 9.123235, 0.000000
07-29 10:42:53.173+0600 D/avoidrickshaw(28893): event-values: 0.716052, 4.645665, 8.871988, 0.000000
07-29 10:42:53.233+0600 D/avoidrickshaw(28893): event-values: 0.457627, 4.711468, 8.909077, 0.000000
07-29 10:42:53.293+0600 D/avoidrickshaw(28893): event-values: 0.701097, 4.031308, 8.973085, 0.000000
07-29 10:42:53.353+0600 D/avoidrickshaw(28893): event-values: 0.781257, 4.100101, 8.886944, 0.000000
07-29 10:42:53.413+0600 D/avoidrickshaw(28893): event-values: 0.736989, 4.107878, 9.318848, 0.000000
07-29 10:42:53.423+0600 I/Tizen::Net::Wifi( 1305): (941) > The background scan result updated.
07-29 10:42:53.473+0600 D/avoidrickshaw(28893): event-values: 1.007977, 3.533003, 9.492328, 0.000000
07-29 10:42:53.533+0600 D/avoidrickshaw(28893): event-values: 1.610370, 3.158526, 9.658628, 0.000000
07-29 10:42:53.573+0600 D/avoidrickshaw(28893): horizontal_acc: 31.000000, vertical_acc: -1.000000
07-29 10:42:53.573+0600 D/avoidrickshaw(28893): previous lat: 23.814995, previous long: 90.426570
07-29 10:42:53.573+0600 D/avoidrickshaw(28893): current lat: 23.814995, current long: 90.426570
07-29 10:42:53.583+0600 D/avoidrickshaw(28893): total distance: 0.000000 meters
07-29 10:42:53.583+0600 D/avoidrickshaw(28893): elapsed time; 0.121441
07-29 10:42:53.593+0600 D/avoidrickshaw(28893): event-values: 1.816751, 3.066402, 9.608379, 0.000000
07-29 10:42:53.653+0600 D/avoidrickshaw(28893): event-values: 1.865205, 3.202195, 9.477970, 0.000000
07-29 10:42:53.713+0600 D/avoidrickshaw(28893): event-values: 1.579861, 3.022135, 9.452846, 0.000000
07-29 10:42:53.773+0600 D/avoidrickshaw(28893): event-values: 1.711466, 3.116652, 9.232706, 0.000000
07-29 10:42:53.833+0600 D/avoidrickshaw(28893): event-values: 1.540978, 3.229114, 9.934999, 0.000000
07-29 10:42:53.893+0600 D/avoidrickshaw(28893): event-values: 1.576870, 2.946163, 9.383453, 0.000000
07-29 10:42:53.954+0600 D/avoidrickshaw(28893): event-values: 1.591227, 2.855834, 9.388239, 0.000000
07-29 10:42:54.014+0600 D/avoidrickshaw(28893): event-values: 2.130210, 2.989234, 9.000004, 0.000000
07-29 10:42:54.074+0600 D/avoidrickshaw(28893): event-values: 2.142174, 2.953341, 8.714661, 0.000000
07-29 10:42:54.134+0600 D/avoidrickshaw(28893): event-values: 2.084148, 2.935395, 9.117850, 0.000000
07-29 10:42:54.194+0600 D/avoidrickshaw(28893): event-values: 1.554736, 3.864408, 8.826525, 0.000000
07-29 10:42:54.254+0600 D/avoidrickshaw(28893): event-values: 1.088734, 4.712066, 8.606983, 0.000000
07-29 10:42:54.314+0600 D/avoidrickshaw(28893): event-values: 0.291326, 5.816354, 8.858828, 0.000000
07-29 10:42:54.374+0600 D/avoidrickshaw(28893): event-values: 0.236889, 6.032904, 8.671589, 0.000000
07-29 10:42:54.434+0600 D/avoidrickshaw(28893): event-values: -0.294317, 7.078567, 7.768298, 0.000000
07-29 10:42:54.494+0600 D/avoidrickshaw(28893): event-values: 0.500698, 5.703293, 7.004988, 0.000000
07-29 10:42:54.524+0600 I/Tizen::Net::Wifi( 1305): (1085) > _WifiService is not registered.
07-29 10:42:54.554+0600 D/avoidrickshaw(28893): event-values: -1.624128, 5.678766, 7.868797, 0.000000
07-29 10:42:54.614+0600 D/avoidrickshaw(28893): event-values: -1.155733, 5.796613, 7.273583, 0.000000
07-29 10:42:54.674+0600 D/avoidrickshaw(28893): event-values: -1.133600, 5.831308, 7.719246, 0.000000
07-29 10:42:54.734+0600 D/avoidrickshaw(28893): event-values: -2.510669, 6.852446, 7.859824, 0.000000
07-29 10:42:54.794+0600 D/avoidrickshaw(28893): event-values: -2.484348, 6.748956, 7.467401, 0.000000
07-29 10:42:54.854+0600 D/avoidrickshaw(28893): event-values: -2.841477, 6.736992, 7.312466, 0.000000
07-29 10:42:54.914+0600 D/avoidrickshaw(28893): event-values: -3.322434, 6.789634, 8.094919, 0.000000
07-29 10:42:54.975+0600 D/avoidrickshaw(28893): event-values: -2.428715, 6.244669, 7.160522, 0.000000
07-29 10:42:55.035+0600 D/avoidrickshaw(28893): event-values: -2.330609, 6.943972, 6.757331, 0.000000
07-29 10:42:55.095+0600 D/avoidrickshaw(28893): event-values: -1.738984, 6.887142, 6.774081, 0.000000
07-29 10:42:55.155+0600 D/avoidrickshaw(28893): event-values: -2.261816, 7.141379, 7.473981, 0.000000
07-29 10:42:55.215+0600 D/avoidrickshaw(28893): event-values: -1.898705, 6.972685, 7.082157, 0.000000
07-29 10:42:55.275+0600 D/avoidrickshaw(28893): event-values: -1.776671, 6.527021, 7.325028, 0.000000
07-29 10:42:55.335+0600 D/avoidrickshaw(28893): event-values: -2.070390, 6.329614, 7.010372, 0.000000
07-29 10:42:55.395+0600 D/avoidrickshaw(28893): event-values: -1.841277, 6.601797, 6.939784, 0.000000
07-29 10:42:55.455+0600 D/avoidrickshaw(28893): event-values: -2.020739, 6.948757, 6.981060, 0.000000
07-29 10:42:55.515+0600 D/avoidrickshaw(28893): event-values: -1.714458, 7.055836, 6.867999, 0.000000
07-29 10:42:55.525+0600 I/Tizen::Net::Wifi( 1305): (1085) > _WifiService is not registered.
07-29 10:42:55.575+0600 D/avoidrickshaw(28893): event-values: -1.569093, 7.007381, 7.076773, 0.000000
07-29 10:42:55.635+0600 D/avoidrickshaw(28893): event-values: -1.292722, 6.381658, 7.467401, 0.000000
07-29 10:42:55.695+0600 D/avoidrickshaw(28893): event-values: -1.901696, 6.543174, 7.023532, 0.000000
07-29 10:42:55.755+0600 D/avoidrickshaw(28893): event-values: -2.037488, 6.841678, 6.598807, 0.000000
07-29 10:42:55.815+0600 D/avoidrickshaw(28893): event-values: -2.023132, 7.059425, 6.519245, 0.000000
07-29 10:42:55.875+0600 D/avoidrickshaw(28893): event-values: -1.853241, 7.103094, 6.806983, 0.000000
07-29 10:42:55.935+0600 D/avoidrickshaw(28893): event-values: -1.612164, 7.011569, 7.292725, 0.000000
07-29 10:42:55.996+0600 D/avoidrickshaw(28893): event-values: -1.903490, 7.067202, 7.412964, 0.000000
07-29 10:42:56.056+0600 D/avoidrickshaw(28893): event-values: -1.923829, 6.987641, 7.242476, 0.000000
07-29 10:42:56.116+0600 D/avoidrickshaw(28893): event-values: -1.753939, 6.978668, 7.019944, 0.000000
07-29 10:42:56.176+0600 D/avoidrickshaw(28893): event-values: -1.718645, 6.859624, 7.067800, 0.000000
07-29 10:42:56.236+0600 D/avoidrickshaw(28893): event-values: -1.439283, 6.812964, 7.057032, 0.000000
07-29 10:42:56.296+0600 D/avoidrickshaw(28893): event-values: -1.409373, 6.653841, 7.341778, 0.000000
07-29 10:42:56.356+0600 D/avoidrickshaw(28893): event-values: -1.278365, 6.580861, 7.247860, 0.000000
07-29 10:42:56.416+0600 D/avoidrickshaw(28893): event-values: -1.271785, 6.501299, 7.164709, 0.000000
07-29 10:42:56.476+0600 D/avoidrickshaw(28893): event-values: -1.483550, 6.567101, 7.208378, 0.000000
07-29 10:42:56.536+0600 D/avoidrickshaw(28893): event-values: -1.570888, 6.616155, 7.237092, 0.000000
07-29 10:42:56.596+0600 D/avoidrickshaw(28893): event-values: -1.561317, 6.635896, 7.319644, 0.000000
07-29 10:42:56.656+0600 D/avoidrickshaw(28893): event-values: -1.374677, 6.761519, 7.189236, 0.000000
07-29 10:42:56.716+0600 D/avoidrickshaw(28893): event-values: -1.416551, 6.653841, 7.083353, 0.000000
07-29 10:42:56.776+0600 D/avoidrickshaw(28893): event-values: -1.354338, 6.495915, 7.147960, 0.000000
07-29 10:42:56.836+0600 D/avoidrickshaw(28893): event-values: -1.051047, 6.554540, 7.490133, 0.000000
07-29 10:42:56.896+0600 D/avoidrickshaw(28893): event-values: -1.083350, 6.538986, 7.862815, 0.000000
07-29 10:42:56.956+0600 D/avoidrickshaw(28893): event-values: -0.768096, 6.280561, 7.663613, 0.000000
07-29 10:42:57.017+0600 D/avoidrickshaw(28893): event-values: -1.039083, 6.242277, 7.758727, 0.000000
07-29 10:42:57.077+0600 D/avoidrickshaw(28893): event-values: -1.120439, 6.279365, 8.207381, 0.000000
07-29 10:42:57.137+0600 D/avoidrickshaw(28893): event-values: -0.465404, 5.832505, 8.639286, 0.000000
07-29 10:42:57.197+0600 D/avoidrickshaw(28893): event-values: 0.106481, 4.526024, 9.315857, 0.000000
07-29 10:42:57.257+0600 D/avoidrickshaw(28893): event-values: 0.730409, 3.881158, 9.800404, 0.000000
07-29 10:42:57.317+0600 D/avoidrickshaw(28893): event-values: 0.861416, 2.979662, 10.363315, 0.000000
07-29 10:42:57.377+0600 D/avoidrickshaw(28893): event-values: 1.565504, 2.662015, 10.274182, 0.000000
07-29 10:42:57.437+0600 D/avoidrickshaw(28893): event-values: 1.907678, 3.489932, 9.708280, 0.000000
07-29 10:42:57.497+0600 D/avoidrickshaw(28893): event-values: 1.813161, 3.607180, 9.595219, 0.000000
07-29 10:42:57.547+0600 D/avoidrickshaw(28893): event-values: 2.377867, 2.639283, 8.894121, 0.000000
07-29 10:42:57.607+0600 D/avoidrickshaw(28893): event-values: 4.096512, 2.570490, 8.063214, 0.000000
07-29 10:42:57.667+0600 D/avoidrickshaw(28893): event-values: 5.382655, 2.694318, 7.922636, 0.000000
07-29 10:42:57.727+0600 D/avoidrickshaw(28893): event-values: 5.050052, 3.015555, 8.254640, 0.000000
07-29 10:42:57.787+0600 D/avoidrickshaw(28893): event-values: 6.231508, 3.267998, 7.155736, 0.000000
07-29 10:42:57.847+0600 D/avoidrickshaw(28893): event-values: 5.995815, 3.742374, 7.031310, 0.000000
07-29 10:42:57.907+0600 D/avoidrickshaw(28893): event-values: 6.237490, 3.552743, 7.079763, 0.000000
07-29 10:42:57.967+0600 D/avoidrickshaw(28893): event-values: 5.922236, 3.748955, 5.828318, 0.000000
07-29 10:42:58.028+0600 D/avoidrickshaw(28893): event-values: 6.093323, 4.284349, 6.591628, 0.000000
07-29 10:42:58.088+0600 D/avoidrickshaw(28893): event-values: 6.231508, 3.959523, 6.439085, 0.000000
07-29 10:42:58.148+0600 D/avoidrickshaw(28893): event-values: 6.162715, 4.035495, 6.870392, 0.000000
07-29 10:42:58.208+0600 D/avoidrickshaw(28893): event-values: 5.603990, 4.319643, 6.868597, 0.000000
07-29 10:42:58.268+0600 D/avoidrickshaw(28893): event-values: 5.793622, 4.249055, 6.636494, 0.000000
07-29 10:42:58.328+0600 D/avoidrickshaw(28893): event-values: 6.080760, 4.317848, 6.823133, 0.000000
07-29 10:42:58.388+0600 D/avoidrickshaw(28893): event-values: 6.154938, 3.888337, 7.329814, 0.000000
07-29 10:42:58.448+0600 D/avoidrickshaw(28893): event-values: 5.979663, 4.120440, 6.835098, 0.000000
07-29 10:42:58.508+0600 D/avoidrickshaw(28893): event-values: 6.312266, 3.961916, 7.370492, 0.000000
07-29 10:42:58.568+0600 D/avoidrickshaw(28893): event-values: 5.440680, 4.455436, 6.630512, 0.000000
07-29 10:42:58.628+0600 D/avoidrickshaw(28893): event-values: 5.601000, 3.842275, 6.670591, 0.000000
07-2
