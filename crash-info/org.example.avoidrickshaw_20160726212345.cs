S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPD6
Build-Date: 2016.04.28 20:23:28

Crash Information
Process Name: avoidrickshaw
PID: 25340
Date: 2016-07-26 21:23:45+0600
Executable File Path: /opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 25340, uid 5000)

Register Information
r0   = 0x000001e0, r1   = 0xb79d8f28
r2   = 0xb2a6c12b, r3   = 0xb2a6c12f
r4   = 0xb6ae752d, r5   = 0xb60626ec
r6   = 0xb604fe30, r7   = 0xb2a6c12b
r8   = 0xb2a6c12f, r9   = 0x00000000
r10  = 0xb7a222a0, fp   = 0x00000000
ip   = 0x00000001, sp   = 0xbeaa2168
lr   = 0xb6048a17, pc   = 0xb6ae7546
cpsr = 0x600d0030

Memory Information
MemTotal:   730440 KB
MemFree:     43716 KB
Buffers:     46488 KB
Cached:     276588 KB
VmPeak:     115416 KB
VmSize:     115412 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24028 KB
VmRSS:       24028 KB
VmData:      42780 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36276 KB
VmPTE:          82 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 25340 TID = 25340
25340 25341 28301 28308 28330 

Maps Information
b056e000 b0d6d000 rw-p [stack:28330]
b13b8000 b1bb7000 rw-p [stack:28308]
b1bb7000 b1bbf000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.49
b1bcf000 b1bd1000 r-xp /usr/lib/liblbs-agps.so.0.1.0
b1be1000 b1bef000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
b1d0b000 b1d0d000 r-xp /usr/lib/location/module/libwps.so.0.6.8_9
b1d1d000 b1d20000 r-xp /usr/lib/location/module/libgps.so.0.6.8_9
b1d31000 b2530000 rw-p [stack:28301]
b25ac000 b25b4000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b25c5000 b25c6000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b25d6000 b25ea000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b25fe000 b25ff000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b260f000 b2612000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2623000 b2624000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2634000 b2636000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2646000 b2648000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2658000 b2668000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2678000 b2684000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b28d4000 b28d6000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b28e6000 b28ec000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b28fc000 b2910000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b2920000 b293a000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b294a000 b2950000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
b2960000 b2967000 r-xp /usr/lib/libeventsystem.so.0.0.1
b2977000 b299a000 r-xp /usr/lib/libSLP-location-product.so.0.9.0
b29ab000 b29c2000 r-xp /usr/lib/libSLP-location.so.0.11.5_5
b29d2000 b29d9000 r-xp /usr/lib/libefl-extension.so.0.1.0
b29ea000 b29f2000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b2a02000 b2a06000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
b2a17000 b2a26000 r-xp /usr/lib/libcapi-location-manager.so.0.6.1_3
b2a36000 b2a3d000 r-xp /usr/lib/libcapi-appfw-preference.so.0.3.1.0
b2a4f000 b2a55000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2a65000 b2a6d000 r-xp /opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw
b2b8e000 b2c71000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2ca8000 b2cd0000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2ce2000 b34e1000 rw-p [stack:25341]
b34e1000 b34e3000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b34f3000 b34fd000 r-xp /lib/libnss_files-2.20-2014.11.so
b350e000 b3517000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3528000 b3539000 r-xp /lib/libnsl-2.20-2014.11.so
b354c000 b3552000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3563000 b3564000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b358c000 b3593000 r-xp /usr/lib/libminizip.so.1.0.0
b35a3000 b35a8000 r-xp /usr/lib/libstorage.so.0.1
b35b8000 b360d000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3623000 b3637000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b3647000 b368b000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b369b000 b36a3000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b36b3000 b36e3000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b36f6000 b37af000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b37c3000 b3817000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3828000 b3843000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3853000 b3914000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3927000 b3939000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3949000 b394d000 r-xp /usr/lib/libogg.so.0.7.1
b395d000 b397f000 r-xp /usr/lib/libvorbis.so.0.4.3
b398f000 b3a73000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b3a8f000 b3a9c000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3aad000 b3af0000 r-xp /usr/lib/libsndfile.so.1.0.25
b3b05000 b3b4c000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3b5d000 b3b63000 r-xp /usr/lib/libjson-c.so.2.0.1
b3b74000 b3b7b000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3b8b000 b3bcb000 r-xp /usr/lib/libmdm.so.1.2.10
b3bdb000 b3be3000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3bf2000 b3c02000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3c23000 b3c83000 r-xp /usr/lib/libasound.so.2.0.0
b3c95000 b3ccb000 r-xp /usr/lib/libpulse.so.0.16.2
b3cdc000 b3cdf000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3cef000 b3cf2000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3d02000 b3d07000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3d17000 b3d18000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3d28000 b3d33000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3d47000 b3d4e000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3d5e000 b3d64000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3d74000 b3d79000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3d89000 b3da4000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3db4000 b3dbb000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3dcb000 b3dce000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3ddf000 b3e0d000 r-xp /usr/lib/libidn.so.11.5.44
b3e1d000 b3e33000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3e44000 b3e4e000 r-xp /usr/lib/libcares.so.2.1.0
b3e5e000 b3e68000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3e78000 b3e7a000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3e8a000 b3e8b000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3e9b000 b3e9f000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3eb0000 b3ed8000 r-xp /usr/lib/libui-extension.so.0.1.0
b3ee9000 b3f12000 r-xp /usr/lib/libturbojpeg.so
b3f32000 b3f38000 r-xp /usr/lib/libgif.so.4.1.6
b3f48000 b3f8e000 r-xp /usr/lib/libcurl.so.4.3.0
b3f9f000 b3fc0000 r-xp /usr/lib/libexif.so.12.3.3
b3fdb000 b3ff0000 r-xp /usr/lib/libtts.so
b4001000 b4009000 r-xp /usr/lib/libfeedback.so.0.1.4
b4019000 b40d9000 r-xp /usr/lib/libdali-core.so.0.0.0
b40e4000 b41d7000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b41f7000 b42d1000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b42e8000 b42ea000 r-xp /usr/lib/libboost_system.so.1.51.0
b42fa000 b4300000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b4310000 b4333000 r-xp /usr/lib/libboost_thread.so.1.51.0
b4344000 b4346000 r-xp /usr/lib/libappsvc.so.0.1.0
b4356000 b4358000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4369000 b436e000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4385000 b4387000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b4397000 b439e000 r-xp /usr/lib/libsensord-share.so
b43ae000 b43c6000 r-xp /usr/lib/libsensor.so.1.1.0
b43d7000 b43da000 r-xp /usr/lib/libXv.so.1.0.0
b43ea000 b43ef000 r-xp /usr/lib/libutilX.so.1.1.0
b43ff000 b4404000 r-xp /usr/lib/libappcore-common.so.1.1
b4414000 b441b000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b442e000 b4432000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b4443000 b450d000 r-xp /usr/lib/libCOREGL.so.4.0
b4524000 b4527000 r-xp /usr/lib/libuuid.so.1.3.0
b4538000 b454f000 r-xp /usr/lib/libblkid.so.1.1.0
b4560000 b4562000 r-xp /usr/lib/libXau.so.6.0.0
b4572000 b4575000 r-xp /usr/lib/libEGL.so.1.4
b457d000 b4583000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4593000 b4595000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b45a6000 b45b4000 r-xp /usr/lib/libGLESv2.so.2.0
b45bd000 b461f000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4634000 b464c000 r-xp /usr/lib/libmount.so.1.1.0
b465d000 b4671000 r-xp /usr/lib/libxcb.so.1.1.0
b4682000 b4689000 r-xp /lib/libcrypt-2.20-2014.11.so
b46c1000 b46d2000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b46e3000 b46e5000 r-xp /usr/lib/libiri.so
b46f5000 b4700000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4711000 b4726000 r-xp /lib/libexpat.so.1.5.2
b4738000 b47f6000 r-xp /usr/lib/libcairo.so.2.11200.14
b4809000 b4811000 r-xp /usr/lib/libdrm.so.2.4.0
b4821000 b4824000 r-xp /usr/lib/libdri2.so.0.0.0
b4835000 b4883000 r-xp /usr/lib/libssl.so.1.0.0
b4898000 b48a4000 r-xp /usr/lib/libeeze.so.1.13.0
b48b4000 b48bd000 r-xp /usr/lib/libethumb.so.1.13.0
b48cd000 b48d0000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b48e0000 b4a97000 r-xp /usr/lib/libcrypto.so.1.0.0
b56ee000 b56f7000 r-xp /usr/lib/libXi.so.6.1.0
b5707000 b5709000 r-xp /usr/lib/libXgesture.so.7.0.0
b5719000 b571d000 r-xp /usr/lib/libXtst.so.6.1.0
b572d000 b5733000 r-xp /usr/lib/libXrender.so.1.3.0
b5743000 b5749000 r-xp /usr/lib/libXrandr.so.2.2.0
b575a000 b575c000 r-xp /usr/lib/libXinerama.so.1.0.0
b576c000 b576f000 r-xp /usr/lib/libXfixes.so.3.1.0
b577f000 b578a000 r-xp /usr/lib/libXext.so.6.4.0
b579a000 b579c000 r-xp /usr/lib/libXdamage.so.1.1.0
b57ac000 b57ae000 r-xp /usr/lib/libXcomposite.so.1.0.0
b57bf000 b58a1000 r-xp /usr/lib/libX11.so.6.3.0
b58b4000 b58bb000 r-xp /usr/lib/libXcursor.so.1.0.2
b58cb000 b58e3000 r-xp /usr/lib/libudev.so.1.6.0
b58e5000 b58e8000 r-xp /lib/libattr.so.1.1.0
b58f8000 b5918000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b591a000 b591f000 r-xp /usr/lib/libffi.so.6.0.2
b592f000 b5947000 r-xp /lib/libz.so.1.2.8
b5957000 b5959000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5969000 b5a3e000 r-xp /usr/lib/libxml2.so.2.9.2
b5a53000 b5aee000 r-xp /usr/lib/libstdc++.so.6.0.20
b5b0a000 b5b0d000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5b1d000 b5b36000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b47000 b5b58000 r-xp /lib/libresolv-2.20-2014.11.so
b5b6c000 b5be6000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5bfb000 b5bfd000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5c0d000 b5c14000 r-xp /usr/lib/libembryo.so.1.13.0
b5c24000 b5c3c000 r-xp /usr/lib/libpng12.so.0.50.0
b5c4d000 b5c70000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c91000 b5ca5000 r-xp /usr/lib/libector.so.1.13.0
b5cb6000 b5cce000 r-xp /usr/lib/liblua-5.1.so
b5cdf000 b5d36000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d4a000 b5d72000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d83000 b5d96000 r-xp /usr/lib/libfribidi.so.0.3.1
b5da7000 b5dde000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5def000 b5dfd000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5e0d000 b5e15000 r-xp /usr/lib/libtbm.so.1.0.0
b5e25000 b5e32000 r-xp /usr/lib/libeio.so.1.13.0
b5e42000 b5e44000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e54000 b5e59000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e69000 b5e80000 r-xp /usr/lib/libefreet.so.1.13.0
b5e92000 b5eb2000 r-xp /usr/lib/libeldbus.so.1.13.0
b5ec2000 b5ee2000 r-xp /usr/lib/libecore_con.so.1.13.0
b5ee4000 b5eea000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5efa000 b5f0b000 r-xp /usr/lib/libemotion.so.1.13.0
b5f1c000 b5f23000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f33000 b5f42000 r-xp /usr/lib/libeo.so.1.13.0
b5f53000 b5f65000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f76000 b5f7b000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f8b000 b5fa4000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5fb4000 b5fd1000 r-xp /usr/lib/libeet.so.1.13.0
b5fea000 b6032000 r-xp /usr/lib/libeina.so.1.13.0
b6043000 b6053000 r-xp /usr/lib/libefl.so.1.13.0
b6064000 b6149000 r-xp /usr/lib/libicuuc.so.51.1
b6166000 b62a6000 r-xp /usr/lib/libicui18n.so.51.1
b62bd000 b62f5000 r-xp /usr/lib/libecore_x.so.1.13.0
b6307000 b630a000 r-xp /lib/libcap.so.2.21
b631a000 b6343000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6354000 b635b000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b636d000 b63a4000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b63b5000 b64a0000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b64b3000 b652c000 r-xp /usr/lib/libsqlite3.so.0.8.6
b653e000 b6543000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6553000 b655d000 r-xp /usr/lib/libvconf.so.0.2.45
b656d000 b656f000 r-xp /usr/lib/libvasum.so.0.3.1
b657f000 b6581000 r-xp /usr/lib/libttrace.so.1.1
b6591000 b6594000 r-xp /usr/lib/libiniparser.so.0
b65a4000 b65ca000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65da000 b65df000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65f0000 b6607000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6618000 b6683000 r-xp /lib/libm-2.20-2014.11.so
b6694000 b669a000 r-xp /lib/librt-2.20-2014.11.so
b66ab000 b66b8000 r-xp /usr/lib/libunwind.so.8.0.1
b66ee000 b6812000 r-xp /lib/libc-2.20-2014.11.so
b6827000 b6840000 r-xp /lib/libgcc_s-4.9.so.1
b6850000 b6932000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6943000 b696d000 r-xp /usr/lib/libdbus-1.so.3.8.12
b697e000 b69ba000 r-xp /usr/lib/libsystemd.so.0.4.0
b69bc000 b6a3e000 r-xp /usr/lib/libedje.so.1.13.0
b6a51000 b6a6f000 r-xp /usr/lib/libecore.so.1.13.0
b6a8f000 b6c16000 r-xp /usr/lib/libevas.so.1.13.0
b6c4b000 b6c5f000 r-xp /lib/libpthread-2.20-2014.11.so
b6c73000 b6ea8000 r-xp /usr/lib/libelementary.so.1.13.0
b6ed6000 b6eda000 r-xp /usr/lib/libsmack.so.1.0.0
b6eea000 b6ef1000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6f01000 b6f03000 r-xp /usr/lib/libdlog.so.0.0.0
b6f13000 b6f16000 r-xp /usr/lib/libbundle.so.0.1.22
b6f26000 b6f28000 r-xp /lib/libdl-2.20-2014.11.so
b6f39000 b6f51000 r-xp /usr/lib/libaul.so.0.1.0
b6f65000 b6f6a000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f7b000 b6f88000 r-xp /usr/lib/liblptcp.so
b6f9a000 b6f9e000 r-xp /usr/lib/libsys-assert.so
b6faf000 b6fcf000 r-xp /lib/ld-2.20-2014.11.so
b6fe0000 b6fe5000 r-xp /usr/bin/launchpad-loader
b7807000 b7b00000 rw-p [heap]
bea82000 beaa3000 rw-p [stack]
b7807000 b7b00000 rw-p [heap]
bea82000 beaa3000 rw-p [stack]
End of Maps Information

Callstack Information (PID:25340)
Call Stack Count: 1
 0: (0xb6ae7546) [/usr/lib/libevas.so.1] + 0x58546
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
07-25 22:05:15.055+0600 D/avoidrickshaw(32394): event-values: 0.196211, -0.069392, 10.180264, 0.000000
07-25 22:05:15.115+0600 D/avoidrickshaw(32394): event-values: 0.180658, -0.080160, 10.164711, 0.000000
07-25 22:05:15.175+0600 D/avoidrickshaw(32394): event-values: 0.212961, -0.063410, 10.182656, 0.000000
07-25 22:05:15.235+0600 D/avoidrickshaw(32394): event-values: 0.203390, -0.087936, 10.170692, 0.000000
07-25 22:05:15.296+0600 D/avoidrickshaw(32394): event-values: 0.180658, -0.046660, 10.162916, 0.000000
07-25 22:05:15.356+0600 D/avoidrickshaw(32394): event-values: 0.186640, -0.076570, 10.167104, 0.000000
07-25 22:05:15.416+0600 D/avoidrickshaw(32394): event-values: 0.199801, -0.074776, 10.176076, 0.000000
07-25 22:05:15.476+0600 D/avoidrickshaw(32394): event-values: 0.187238, -0.057428, 10.168301, 0.000000
07-25 22:05:15.536+0600 D/avoidrickshaw(32394): event-values: 0.178265, -0.089731, 10.176076, 0.000000
07-25 22:05:15.596+0600 D/avoidrickshaw(32394): event-values: 0.202193, -0.072383, 10.159328, 0.000000
07-25 22:05:15.656+0600 D/avoidrickshaw(32394): event-values: 0.200399, -0.066999, 10.173084, 0.000000
07-25 22:05:15.716+0600 D/avoidrickshaw(32394): event-values: 0.190828, -0.077767, 10.185050, 0.000000
07-25 22:05:15.776+0600 D/avoidrickshaw(32394): event-values: 0.192024, -0.059821, 10.174880, 0.000000
07-25 22:05:15.836+0600 D/avoidrickshaw(32394): event-values: 0.206381, -0.075972, 10.185050, 0.000000
07-25 22:05:15.896+0600 D/avoidrickshaw(32394): event-values: 0.219541, -0.080758, 10.182058, 0.000000
07-25 22:05:15.956+0600 D/avoidrickshaw(32394): event-values: 0.186042, -0.072383, 10.139585, 0.000000
07-25 22:05:16.016+0600 D/avoidrickshaw(32394): event-values: 0.189631, -0.079561, 10.197612, 0.000000
07-25 22:05:16.076+0600 D/avoidrickshaw(32394): event-values: 0.214158, -0.072383, 10.171888, 0.000000
07-25 22:05:16.136+0600 D/avoidrickshaw(32394): event-values: 0.190229, -0.072981, 10.168897, 0.000000
07-25 22:05:16.196+0600 D/avoidrickshaw(32394): event-values: 0.190828, -0.085543, 10.197612, 0.000000
07-25 22:05:16.256+0600 D/avoidrickshaw(32394): event-values: 0.198604, -0.061615, 10.176675, 0.000000
07-25 22:05:16.317+0600 D/avoidrickshaw(32394): event-values: 0.179462, -0.081954, 10.197014, 0.000000
07-25 22:05:16.377+0600 D/avoidrickshaw(32394): event-values: 0.205185, -0.068195, 10.194022, 0.000000
07-25 22:05:16.437+0600 D/avoidrickshaw(32394): event-values: 0.207577, -0.084347, 10.182058, 0.000000
07-25 22:05:16.497+0600 D/avoidrickshaw(32394): event-values: 0.180060, -0.077767, 10.173683, 0.000000
07-25 22:05:16.557+0600 D/avoidrickshaw(32394): event-values: 0.196211, -0.070588, 10.133006, 0.000000
07-25 22:05:16.617+0600 D/avoidrickshaw(32394): event-values: 0.190229, -0.092124, 10.147961, 0.000000
07-25 22:05:16.677+0600 D/avoidrickshaw(32394): event-values: 0.183649, -0.072981, 10.158132, 0.000000
07-25 22:05:16.737+0600 D/avoidrickshaw(32394): event-values: 0.192024, -0.063410, 10.167702, 0.000000
07-25 22:05:16.797+0600 D/avoidrickshaw(32394): event-values: 0.193819, -0.099302, 10.184451, 0.000000
07-25 22:05:16.857+0600 D/avoidrickshaw(32394): event-values: 0.215354, -0.066401, 10.162916, 0.000000
07-25 22:05:16.917+0600 D/avoidrickshaw(32394): event-values: 0.160917, -0.071785, 10.193424, 0.000000
07-25 22:05:16.977+0600 D/avoidrickshaw(32394): event-values: 0.178863, -0.067597, 10.196415, 0.000000
07-25 22:05:17.037+0600 D/avoidrickshaw(32394): event-values: 0.213559, -0.078963, 10.164113, 0.000000
07-25 22:05:17.097+0600 D/avoidrickshaw(32394): event-values: 0.215952, -0.078963, 10.179067, 0.000000
07-25 22:05:17.157+0600 D/avoidrickshaw(32394): event-values: 0.223729, -0.083749, 10.153345, 0.000000
07-25 22:05:17.217+0600 D/avoidrickshaw(32394): event-values: 0.172881, -0.083749, 10.170094, 0.000000
07-25 22:05:17.277+0600 D/avoidrickshaw(32394): event-values: 0.183051, -0.068794, 10.164113, 0.000000
07-25 22:05:17.338+0600 D/avoidrickshaw(32394): event-values: 0.217149, -0.061017, 10.186246, 0.000000
07-25 22:05:17.398+0600 D/avoidrickshaw(32394): event-values: 0.190229, -0.068195, 10.176675, 0.000000
07-25 22:05:17.458+0600 D/avoidrickshaw(32394): event-values: 0.174676, -0.086740, 10.161121, 0.000000
07-25 22:05:17.518+0600 D/avoidrickshaw(32394): event-values: 0.211765, -0.084347, 10.171888, 0.000000
07-25 22:05:17.578+0600 D/avoidrickshaw(32394): event-values: 0.193220, -0.092722, 10.176076, 0.000000
07-25 22:05:17.638+0600 D/avoidrickshaw(32394): event-values: 0.186042, -0.055633, 10.194620, 0.000000
07-25 22:05:17.698+0600 D/avoidrickshaw(32394): event-values: 0.180060, -0.081356, 10.185647, 0.000000
07-25 22:05:17.758+0600 D/avoidrickshaw(32394): event-values: 0.206979, -0.089133, 10.179665, 0.000000
07-25 22:05:17.818+0600 D/avoidrickshaw(32394): event-values: 0.186640, -0.069392, 10.177272, 0.000000
07-25 22:05:17.878+0600 D/avoidrickshaw(32394): event-values: 0.195015, -0.098704, 10.183254, 0.000000
07-25 22:05:17.908+0600 D/avoidrickshaw(32394): horizontal_acc: 32.000000, vertical_acc: -1.000000
07-25 22:05:17.908+0600 D/avoidrickshaw(32394): previous lat: 23.742101, previous long: 90.411688
07-25 22:05:17.908+0600 D/avoidrickshaw(32394): current lat: 23.742104, current long: 90.411684
07-25 22:05:17.908+0600 D/avoidrickshaw(32394): because step count did not update, distance not updated.
07-25 22:05:17.938+0600 D/avoidrickshaw(32394): event-values: 0.210568, -0.080758, 10.185050, 0.000000
07-25 22:05:17.998+0600 D/avoidrickshaw(32394): event-values: 0.192622, -0.076570, 10.178469, 0.000000
07-25 22:05:18.058+0600 D/avoidrickshaw(32394): event-values: 0.169890, -0.081954, 10.166506, 0.000000
07-25 22:05:18.118+0600 D/avoidrickshaw(32394): event-values: 0.196810, -0.068195, 10.177871, 0.000000
07-25 22:05:18.178+0600 D/avoidrickshaw(32394): event-values: 0.199202, -0.082552, 10.186844, 0.000000
07-25 22:05:18.238+0600 D/avoidrickshaw(32394): event-values: 0.198604, -0.066999, 10.159328, 0.000000
07-25 22:05:18.298+0600 D/avoidrickshaw(32394): event-values: 0.166899, -0.096909, 10.190434, 0.000000
07-25 22:05:18.358+0600 D/avoidrickshaw(32394): event-values: 0.190828, -0.090927, 10.156336, 0.000000
07-25 22:05:18.419+0600 D/avoidrickshaw(32394): event-values: 0.214158, -0.083749, 10.176675, 0.000000
07-25 22:05:18.479+0600 D/avoidrickshaw(32394): event-values: 0.188435, -0.090329, 10.171290, 0.000000
07-25 22:05:18.539+0600 D/avoidrickshaw(32394): event-values: 0.181256, -0.066401, 10.168301, 0.000000
07-25 22:05:18.599+0600 D/avoidrickshaw(32394): event-values: 0.191426, -0.075972, 10.162319, 0.000000
07-25 22:05:18.659+0600 D/avoidrickshaw(32394): event-values: 0.215952, -0.083749, 10.196415, 0.000000
07-25 22:05:18.719+0600 D/avoidrickshaw(32394): event-values: 0.193220, -0.083151, 10.138988, 0.000000
07-25 22:05:18.779+0600 D/avoidrickshaw(32394): event-values: 0.203988, -0.084347, 10.163515, 0.000000
07-25 22:05:18.839+0600 D/avoidrickshaw(32394): event-values: 0.201595, -0.071186, 10.188040, 0.000000
07-25 22:05:18.899+0600 D/avoidrickshaw(32394): event-values: 0.209970, -0.089731, 10.176076, 0.000000
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
07-25 22:05:33.974+0600 D/avoid
