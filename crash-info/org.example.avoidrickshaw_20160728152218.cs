S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPD6
Build-Date: 2016.04.28 20:23:28

Crash Information
Process Name: avoidrickshaw
PID: 3541
Date: 2016-07-28 15:22:18+0600
Executable File Path: /opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 3541, uid 5000)

Register Information
r0   = 0x8002d76c, r1   = 0x00000000
r2   = 0xb432c000, r3   = 0xb432c010
r4   = 0xb2a170f0, r5   = 0xb7a2a4c0
r6   = 0xb7a36328, r7   = 0xbe939208
r8   = 0x800168b5, r9   = 0xb5efd708
r10  = 0xb7a35318, fp   = 0x00000000
ip   = 0xb5fed120, sp   = 0xbe9391b8
lr   = 0xb5fb1bd9, pc   = 0xb2a160ba
cpsr = 0x800e0030

Memory Information
MemTotal:   730440 KB
MemFree:     46140 KB
Buffers:     45264 KB
Cached:     276252 KB
VmPeak:     105664 KB
VmSize:     105660 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       23796 KB
VmRSS:       23796 KB
VmData:      33464 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36164 KB
VmPTE:          80 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 3541 TID = 3541
3541 3544 3900 3912 

Maps Information
b0e91000 b1690000 rw-p [stack:3912]
b1cdb000 b24da000 rw-p [stack:3900]
b2556000 b255e000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b256f000 b2570000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b2580000 b2594000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b25a8000 b25a9000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b25b9000 b25bc000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b25cd000 b25ce000 r-xp /usr/lib/libxshmfence.so.1.0.0
b25de000 b25e0000 r-xp /usr/lib/libxcb-present.so.0.0.0
b25f0000 b25f2000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2602000 b2612000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2622000 b262e000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b287e000 b2880000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b2890000 b2896000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b28a6000 b28ba000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b28ca000 b28e4000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b28f4000 b28fa000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
b290a000 b2911000 r-xp /usr/lib/libeventsystem.so.0.0.1
b2921000 b2944000 r-xp /usr/lib/libSLP-location-product.so.0.9.0
b2955000 b296c000 r-xp /usr/lib/libSLP-location.so.0.11.5_5
b297c000 b2983000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2994000 b299c000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b29ac000 b29b0000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
b29c1000 b29d0000 r-xp /usr/lib/libcapi-location-manager.so.0.6.1_3
b29e0000 b29e7000 r-xp /usr/lib/libcapi-appfw-preference.so.0.3.1.0
b29f9000 b29ff000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2a0f000 b2a18000 r-xp /opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw
b2b39000 b2c1c000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2c53000 b2c7b000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2c8d000 b348c000 rw-p [stack:3544]
b348c000 b348e000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b349e000 b34a8000 r-xp /lib/libnss_files-2.20-2014.11.so
b34b9000 b34c2000 r-xp /lib/libnss_nis-2.20-2014.11.so
b34d3000 b34e4000 r-xp /lib/libnsl-2.20-2014.11.so
b34f7000 b34fd000 r-xp /lib/libnss_compat-2.20-2014.11.so
b350e000 b350f000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3537000 b353e000 r-xp /usr/lib/libminizip.so.1.0.0
b354e000 b3553000 r-xp /usr/lib/libstorage.so.0.1
b3563000 b35b8000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b35ce000 b35e2000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b35f2000 b3636000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3646000 b364e000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b365e000 b368e000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b36a1000 b375a000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b376e000 b37c2000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b37d3000 b37ee000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b37fe000 b38bf000 r-xp /usr/lib/libprotobuf.so.9.0.1
b38d2000 b38e4000 r-xp /usr/lib/libefl-assist.so.0.1.0
b38f4000 b38f8000 r-xp /usr/lib/libogg.so.0.7.1
b3908000 b392a000 r-xp /usr/lib/libvorbis.so.0.4.3
b393a000 b3a1e000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b3a3a000 b3a47000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3a58000 b3a9b000 r-xp /usr/lib/libsndfile.so.1.0.25
b3ab0000 b3af7000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3b08000 b3b0e000 r-xp /usr/lib/libjson-c.so.2.0.1
b3b1f000 b3b26000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3b36000 b3b76000 r-xp /usr/lib/libmdm.so.1.2.10
b3b86000 b3b8e000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3b9d000 b3bad000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3bce000 b3c2e000 r-xp /usr/lib/libasound.so.2.0.0
b3c40000 b3c76000 r-xp /usr/lib/libpulse.so.0.16.2
b3c87000 b3c8a000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3c9a000 b3c9d000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3cad000 b3cb2000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3cc2000 b3cc3000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3cd3000 b3cde000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3cf2000 b3cf9000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3d09000 b3d0f000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3d1f000 b3d24000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3d34000 b3d4f000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3d5f000 b3d66000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3d76000 b3d79000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3d8a000 b3db8000 r-xp /usr/lib/libidn.so.11.5.44
b3dc8000 b3dde000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3def000 b3df9000 r-xp /usr/lib/libcares.so.2.1.0
b3e09000 b3e13000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3e23000 b3e25000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3e35000 b3e36000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3e46000 b3e4a000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3e5b000 b3e83000 r-xp /usr/lib/libui-extension.so.0.1.0
b3e94000 b3ebd000 r-xp /usr/lib/libturbojpeg.so
b3edd000 b3ee3000 r-xp /usr/lib/libgif.so.4.1.6
b3ef3000 b3f39000 r-xp /usr/lib/libcurl.so.4.3.0
b3f4a000 b3f6b000 r-xp /usr/lib/libexif.so.12.3.3
b3f86000 b3f9b000 r-xp /usr/lib/libtts.so
b3fac000 b3fb4000 r-xp /usr/lib/libfeedback.so.0.1.4
b3fc4000 b4084000 r-xp /usr/lib/libdali-core.so.0.0.0
b408f000 b4182000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b41a2000 b427c000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b4293000 b4295000 r-xp /usr/lib/libboost_system.so.1.51.0
b42a5000 b42ab000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b42bb000 b42de000 r-xp /usr/lib/libboost_thread.so.1.51.0
b42ef000 b42f1000 r-xp /usr/lib/libappsvc.so.0.1.0
b4301000 b4303000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4314000 b4319000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4330000 b4332000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b4342000 b4349000 r-xp /usr/lib/libsensord-share.so
b4359000 b4371000 r-xp /usr/lib/libsensor.so.1.1.0
b4382000 b4385000 r-xp /usr/lib/libXv.so.1.0.0
b4395000 b439a000 r-xp /usr/lib/libutilX.so.1.1.0
b43aa000 b43af000 r-xp /usr/lib/libappcore-common.so.1.1
b43bf000 b43c6000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b43d9000 b43dd000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b43ee000 b44b8000 r-xp /usr/lib/libCOREGL.so.4.0
b44cf000 b44d2000 r-xp /usr/lib/libuuid.so.1.3.0
b44e3000 b44fa000 r-xp /usr/lib/libblkid.so.1.1.0
b450b000 b450d000 r-xp /usr/lib/libXau.so.6.0.0
b451d000 b4520000 r-xp /usr/lib/libEGL.so.1.4
b4528000 b452e000 r-xp /usr/lib/libxcb-render.so.0.0.0
b453e000 b4540000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4551000 b455f000 r-xp /usr/lib/libGLESv2.so.2.0
b4568000 b45ca000 r-xp /usr/lib/libpixman-1.so.0.28.2
b45df000 b45f7000 r-xp /usr/lib/libmount.so.1.1.0
b4608000 b461c000 r-xp /usr/lib/libxcb.so.1.1.0
b462d000 b4634000 r-xp /lib/libcrypt-2.20-2014.11.so
b466c000 b467d000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b468e000 b4690000 r-xp /usr/lib/libiri.so
b46a0000 b46ab000 r-xp /usr/lib/libgpg-error.so.0.15.0
b46bc000 b46d1000 r-xp /lib/libexpat.so.1.5.2
b46e3000 b47a1000 r-xp /usr/lib/libcairo.so.2.11200.14
b47b4000 b47bc000 r-xp /usr/lib/libdrm.so.2.4.0
b47cc000 b47cf000 r-xp /usr/lib/libdri2.so.0.0.0
b47e0000 b482e000 r-xp /usr/lib/libssl.so.1.0.0
b4843000 b484f000 r-xp /usr/lib/libeeze.so.1.13.0
b485f000 b4868000 r-xp /usr/lib/libethumb.so.1.13.0
b4878000 b487b000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b488b000 b4a42000 r-xp /usr/lib/libcrypto.so.1.0.0
b5699000 b56a2000 r-xp /usr/lib/libXi.so.6.1.0
b56b2000 b56b4000 r-xp /usr/lib/libXgesture.so.7.0.0
b56c4000 b56c8000 r-xp /usr/lib/libXtst.so.6.1.0
b56d8000 b56de000 r-xp /usr/lib/libXrender.so.1.3.0
b56ee000 b56f4000 r-xp /usr/lib/libXrandr.so.2.2.0
b5705000 b5707000 r-xp /usr/lib/libXinerama.so.1.0.0
b5717000 b571a000 r-xp /usr/lib/libXfixes.so.3.1.0
b572a000 b5735000 r-xp /usr/lib/libXext.so.6.4.0
b5745000 b5747000 r-xp /usr/lib/libXdamage.so.1.1.0
b5757000 b5759000 r-xp /usr/lib/libXcomposite.so.1.0.0
b576a000 b584c000 r-xp /usr/lib/libX11.so.6.3.0
b585f000 b5866000 r-xp /usr/lib/libXcursor.so.1.0.2
b5876000 b588e000 r-xp /usr/lib/libudev.so.1.6.0
b5890000 b5893000 r-xp /lib/libattr.so.1.1.0
b58a3000 b58c3000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58c5000 b58ca000 r-xp /usr/lib/libffi.so.6.0.2
b58da000 b58f2000 r-xp /lib/libz.so.1.2.8
b5902000 b5904000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5914000 b59e9000 r-xp /usr/lib/libxml2.so.2.9.2
b59fe000 b5a99000 r-xp /usr/lib/libstdc++.so.6.0.20
b5ab5000 b5ab8000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5ac8000 b5ae1000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5af2000 b5b03000 r-xp /lib/libresolv-2.20-2014.11.so
b5b17000 b5b91000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5ba6000 b5ba8000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bb8000 b5bbf000 r-xp /usr/lib/libembryo.so.1.13.0
b5bcf000 b5be7000 r-xp /usr/lib/libpng12.so.0.50.0
b5bf8000 b5c1b000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c3c000 b5c50000 r-xp /usr/lib/libector.so.1.13.0
b5c61000 b5c79000 r-xp /usr/lib/liblua-5.1.so
b5c8a000 b5ce1000 r-xp /usr/lib/libfreetype.so.6.11.3
b5cf5000 b5d1d000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d2e000 b5d41000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d52000 b5d89000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d9a000 b5da8000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5db8000 b5dc0000 r-xp /usr/lib/libtbm.so.1.0.0
b5dd0000 b5ddd000 r-xp /usr/lib/libeio.so.1.13.0
b5ded000 b5def000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5dff000 b5e04000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e14000 b5e2b000 r-xp /usr/lib/libefreet.so.1.13.0
b5e3d000 b5e5d000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e6d000 b5e8d000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e8f000 b5e95000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5ea5000 b5eb6000 r-xp /usr/lib/libemotion.so.1.13.0
b5ec7000 b5ece000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5ede000 b5eed000 r-xp /usr/lib/libeo.so.1.13.0
b5efe000 b5f10000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f21000 b5f26000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f36000 b5f4f000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f5f000 b5f7c000 r-xp /usr/lib/libeet.so.1.13.0
b5f95000 b5fdd000 r-xp /usr/lib/libeina.so.1.13.0
b5fee000 b5ffe000 r-xp /usr/lib/libefl.so.1.13.0
b600f000 b60f4000 r-xp /usr/lib/libicuuc.so.51.1
b6111000 b6251000 r-xp /usr/lib/libicui18n.so.51.1
b6268000 b62a0000 r-xp /usr/lib/libecore_x.so.1.13.0
b62b2000 b62b5000 r-xp /lib/libcap.so.2.21
b62c5000 b62ee000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62ff000 b6306000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6318000 b634f000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6360000 b644b000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b645e000 b64d7000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64e9000 b64ee000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64fe000 b6508000 r-xp /usr/lib/libvconf.so.0.2.45
b6518000 b651a000 r-xp /usr/lib/libvasum.so.0.3.1
b652a000 b652c000 r-xp /usr/lib/libttrace.so.1.1
b653c000 b653f000 r-xp /usr/lib/libiniparser.so.0
b654f000 b6575000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6585000 b658a000 r-xp /usr/lib/libxdgmime.so.1.1.0
b659b000 b65b2000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65c3000 b662e000 r-xp /lib/libm-2.20-2014.11.so
b663f000 b6645000 r-xp /lib/librt-2.20-2014.11.so
b6656000 b6663000 r-xp /usr/lib/libunwind.so.8.0.1
b6699000 b67bd000 r-xp /lib/libc-2.20-2014.11.so
b67d2000 b67eb000 r-xp /lib/libgcc_s-4.9.so.1
b67fb000 b68dd000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68ee000 b6918000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6929000 b6965000 r-xp /usr/lib/libsystemd.so.0.4.0
b6967000 b69e9000 r-xp /usr/lib/libedje.so.1.13.0
b69fc000 b6a1a000 r-xp /usr/lib/libecore.so.1.13.0
b6a3a000 b6bc1000 r-xp /usr/lib/libevas.so.1.13.0
b6bf6000 b6c0a000 r-xp /lib/libpthread-2.20-2014.11.so
b6c1e000 b6e53000 r-xp /usr/lib/libelementary.so.1.13.0
b6e81000 b6e85000 r-xp /usr/lib/libsmack.so.1.0.0
b6e95000 b6e9c000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6eac000 b6eae000 r-xp /usr/lib/libdlog.so.0.0.0
b6ebe000 b6ec1000 r-xp /usr/lib/libbundle.so.0.1.22
b6ed1000 b6ed3000 r-xp /lib/libdl-2.20-2014.11.so
b6ee4000 b6efc000 r-xp /usr/lib/libaul.so.0.1.0
b6f10000 b6f15000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f26000 b6f33000 r-xp /usr/lib/liblptcp.so
b6f45000 b6f49000 r-xp /usr/lib/libsys-assert.so
b6f5a000 b6f7a000 r-xp /lib/ld-2.20-2014.11.so
b6f8b000 b6f90000 r-xp /usr/bin/launchpad-loader
b781a000 b7b0a000 rw-p [heap]
be919000 be93a000 rw-p [stack]
b781a000 b7b0a000 rw-p [heap]
be919000 be93a000 rw-p [stack]
End of Maps Information

Callstack Information (PID:3541)
Call Stack Count: 21
 0: view_history_create + 0x4d (0xb2a160ba) [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw] + 0x70ba
 1: _show_history_cb + 0x7a (0xb2a15cfb) [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw] + 0x6cfb
 2: (0xb6aa07ed) [/usr/lib/libevas.so.1] + 0x667ed
 3: (0xb5ee9219) [/usr/lib/libeo.so.1] + 0xb219
 4: eo_event_callback_call + 0x68 (0xb5ee7fb9) [/usr/lib/libeo.so.1] + 0x9fb9
 5: evas_object_smart_callback_call + 0x38 (0xb6aa1edd) [/usr/lib/libevas.so.1] + 0x67edd
 6: (0xb69bddd7) [/usr/lib/libedje.so.1] + 0x56dd7
 7: (0xb69c211f) [/usr/lib/libedje.so.1] + 0x5b11f
 8: (0xb69be791) [/usr/lib/libedje.so.1] + 0x57791
 9: (0xb69beb61) [/usr/lib/libedje.so.1] + 0x57b61
10: (0xb69becb5) [/usr/lib/libedje.so.1] + 0x57cb5
11: (0xb6a0bd11) [/usr/lib/libecore.so.1] + 0xfd11
12: (0xb6a07c4b) [/usr/lib/libecore.so.1] + 0xbc4b
13: (0xb6a0da5d) [/usr/lib/libecore.so.1] + 0x11a5d
14: ecore_main_loop_begin + 0x3e (0xb6a0dc83) [/usr/lib/libecore.so.1] + 0x11c83
15: appcore_efl_main + 0x20c (0xb6f132bd) [/usr/lib/libappcore-efl.so.1] + 0x32bd
16: ui_app_main + 0xc0 (0xb43db909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
17: main + 0x9a (0xb2a1536b) [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw] + 0x636b
18: (0xb6f8cbaf) [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw] + 0x1baf
19: __libc_start_main + 0x114 (0xb66af4bc) [/lib/libc.so.6] + 0x164bc
20: (0xb6f8ce94) [/opt/usr/apps/org.example.avoidrickshaw/bin/avoidrickshaw] + 0x1e94
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
07-25 22:06:29.998+0600 D/avoidrickshaw(32394): event-values: 0.194417, -0.085543, 10.164711, 0.000000
07-25 22:06:30.058+0600 D/avoidrickshaw(32394): event-values: 0.209372, -0.079561, 10.182058, 0.000000
07-25 22:06:30.119+0600 D/avoidrickshaw(32394): event-values: 0.194417, -0.092124, 10.157533, 0.000000
07-25 22:06:30.179+0600 D/avoidrickshaw(32394): event-values: 0.198006, -0.066999, 10.167702, 0.000000
07-25 22:06:30.239+0600 D/avoidrickshaw(32394): event-values: 0.218943, -0.064008, 10.168301, 0.000000
07-25 22:06:30.299+0600 D/avoidrickshaw(32394): event-values: 0.198006, -0.068794, 10.180264, 0.000000
07-25 22:06:30.359+0600 D/avoidrickshaw(32394): event-values: 0.212961, -0.069990, 10.176675, 0.000000
07-25 22:06:30.419+0600 D/avoidrickshaw(32394): event-values: 0.195015, -0.062812, 10.149756, 0.000000
07-25 22:06:30.479+0600 D/avoidrickshaw(32394): event-values: 0.192622, -0.064606, 10.159925, 0.000000
07-25 22:06:30.539+0600 D/avoidrickshaw(32394): event-values: 0.194417, -0.075374, 10.164711, 0.000000
07-25 22:06:30.599+0600 D/avoidrickshaw(32394): event-values: 0.209372, -0.067597, 10.230514, 0.000000
07-25 22:06:30.659+0600 D/avoidrickshaw(32394): event-values: 0.204586, -0.071785, 10.172487, 0.000000
07-25 22:06:30.719+0600 D/avoidrickshaw(32394): event-values: 0.193220, -0.090927, 10.167104, 0.000000
07-25 22:06:30.779+0600 D/avoidrickshaw(32394): event-values: 0.184846, -0.059222, 10.157533, 0.000000
07-25 22:06:30.839+0600 D/avoidrickshaw(32394): event-values: 0.211167, -0.084347, 10.159328, 0.000000
07-25 22:06:30.899+0600 D/avoidrickshaw(32394): event-values: 0.189631, -0.074776, 10.167702, 0.000000
07-25 22:06:30.959+0600 D/avoidrickshaw(32394): event-values: 0.196211, -0.078963, 10.167104, 0.000000
07-25 22:06:31.019+0600 D/avoidrickshaw(32394): event-values: 0.205185, -0.093320, 10.170692, 0.000000
07-25 22:06:31.079+0600 D/avoidrickshaw(32394): event-values: 0.193819, -0.079561, 10.180264, 0.000000
07-25 22:06:31.140+0600 D/avoidrickshaw(32394): event-values: 0.203988, -0.064606, 10.161121, 0.000000
07-25 22:06:31.200+0600 D/avoidrickshaw(32394): event-values: 0.187837, -0.075972, 10.174281, 0.000000
07-25 22:06:31.260+0600 D/avoidrickshaw(32394): event-values: 0.194417, -0.087936, 10.189835, 0.000000
07-25 22:06:31.320+0600 D/avoidrickshaw(32394): event-values: 0.192622, -0.075374, 10.176076, 0.000000
07-25 22:06:31.380+0600 D/avoidrickshaw(32394): event-values: 0.189631, -0.072981, 10.170094, 0.000000
07-25 22:06:31.440+0600 D/avoidrickshaw(32394): event-values: 0.207577, -0.074178, 10.183852, 0.000000
07-25 22:06:31.500+0600 D/avoidrickshaw(32394): event-values: 0.183649, -0.078365, 10.154541, 0.000000
07-25 22:06:31.560+0600 D/avoidrickshaw(32394): event-values: 0.217747, -0.075374, 10.168897, 0.000000
07-25 22:06:31.620+0600 D/avoidrickshaw(32394): event-values: 0.206381, -0.065803, 10.165908, 0.000000
07-25 22:06:31.680+0600 D/avoidrickshaw(32394): event-values: 0.183051, -0.091525, 10.172487, 0.000000
07-25 22:06:31.740+0600 D/avoidrickshaw(32394): event-values: 0.189033, -0.080160, 10.159925, 0.000000
07-25 22:06:31.800+0600 D/avoidrickshaw(32394): event-values: 0.206979, -0.077169, 10.177871, 0.000000
07-25 22:06:31.860+0600 D/avoidrickshaw(32394): event-values: 0.197408, -0.069392, 10.150952, 0.000000
07-25 22:06:31.920+0600 D/avoidrickshaw(32394): event-values: 0.209970, -0.065803, 10.171888, 0.000000
07-25 22:06:31.990+0600 D/avoidrickshaw(32394): event-values: 0.187238, -0.072383, 10.168301, 0.000000
07-25 22:06:32.050+0600 D/avoidrickshaw(32394): event-values: 0.226122, -0.075972, 10.194022, 0.000000
07-25 22:06:32.110+0600 D/avoidrickshaw(32394): event-values: 0.187837, -0.078365, 10.181459, 0.000000
07-25 22:06:32.171+0600 D/avoidrickshaw(32394): event-values: 0.181256, -0.075374, 10.164711, 0.000000
07-25 22:06:32.231+0600 D/avoidrickshaw(32394): event-values: 0.199202, -0.069392, 10.162319, 0.000000
07-25 22:06:32.291+0600 D/avoidrickshaw(32394): event-values: 0.206979, -0.087936, 10.153944, 0.000000
07-25 22:06:32.351+0600 D/avoidrickshaw(32394): event-values: 0.183051, -0.072981, 10.156934, 0.000000
07-25 22:06:32.411+0600 D/avoidrickshaw(32394): event-values: 0.202193, -0.082552, 10.184451, 0.000000
07-25 22:06:32.461+0600 D/avoidrickshaw(32394): event-values: 0.153141, -0.094516, 10.156336, 0.000000
07-25 22:06:32.531+0600 D/avoidrickshaw(32394): event-values: 0.187238, -0.076570, 10.168301, 0.000000
07-25 22:06:32.591+0600 D/avoidrickshaw(32394): event-values: 0.204586, -0.075972, 10.161720, 0.000000
07-25 22:06:32.651+0600 D/avoidrickshaw(32394): event-values: 0.196810, -0.059222, 10.183254, 0.000000
07-25 22:06:32.711+0600 D/avoidrickshaw(32394): event-values: 0.206381, -0.067597, 10.176076, 0.000000
07-25 22:06:32.771+0600 D/avoidrickshaw(32394): event-values: 0.181855, -0.086740, 10.181459, 0.000000
07-25 22:06:32.841+0600 D/avoidrickshaw(32394): event-values: 0.182453, -0.078963, 10.198808, 0.000000
07-25 22:06:32.841+0600 I/Tizen::Net::Wifi( 1305): (941) > The background scan result updated.
07-25 22:06:32.901+0600 D/avoidrickshaw(32394): event-values: 0.202193, -0.080758, 10.150353, 0.000000
07-25 22:06:32.961+0600 D/avoidrickshaw(32394): event-values: 0.205185, -0.071186, 10.191031, 0.000000
07-25 22:06:33.021+0600 D/avoidrickshaw(32394): event-values: 0.161516, -0.054437, 10.112068, 0.000000
07-25 22:06:33.081+0600 D/avoidrickshaw(32394): event-values: 0.208176, -0.085543, 10.204191, 0.000000
07-25 22:06:33.141+0600 D/avoidrickshaw(32394): event-values: 0.181855, -0.077169, 10.161121, 0.000000
07-25 22:06:33.202+0600 D/avoidrickshaw(32394): event-values: 0.214158, -0.071186, 10.198808, 0.000000
07-25 22:06:33.262+0600 D/avoidrickshaw(32394): event-values: 0.174078, -0.058026, 10.183852, 0.000000
07-25 22:06:33.322+0600 D/avoidrickshaw(32394): event-values: 0.181256, -0.097508, 10.177272, 0.000000
07-25 22:06:33.382+0600 D/avoidrickshaw(32394): event-values: 0.228515, -0.071785, 10.153345, 0.000000
07-25 22:06:33.442+0600 D/avoidrickshaw(32394): event-values: 0.156730, -0.076570, 10.147961, 0.000000
07-25 22:06:33.502+0600 D/avoidrickshaw(32394): event-values: 0.180658, -0.089731, 10.171290, 0.000000
07-25 22:06:33.562+0600 D/avoidrickshaw(32394): event-values: 0.215354, -0.062213, 10.186246, 0.000000
07-25 22:06:33.622+0600 D/avoidrickshaw(32394): event-values: 0.218943, -0.072981, 10.139585, 0.000000
07-25 22:06:33.682+0600 D/avoidrickshaw(32394): event-values: 0.197408, -0.052044, 10.177272, 0.000000
07-25 22:06:33.742+0600 D/avoidrickshaw(32394): event-values: 0.161516, -0.090927, 10.148559, 0.000000
07-25 22:06:33.802+0600 D/avoidrickshaw(32394): event-values: 0.227916, -0.090927, 10.168897, 0.000000
07-25 22:06:33.872+0600 D/avoidrickshaw(32394): event-values: 0.206381, -0.085543, 10.191031, 0.000000
07-25 22:06:33.902+0600 D/avoidrickshaw(32394): horizontal_acc: 16.000000, vertical_acc: -1.000000
07-25 22:06:33.902+0600 D/avoidrickshaw(32394): previous lat: 23.742172, previous long: 90.411648
07-25 22:06:33.902+0600 D/avoidrickshaw(32394): current lat: 23.742172, current long: 90.411648
07-25 22:06:33.912+0600 D/avoidrickshaw(32394): because step count did not update, distance not updated.
07-25 22:06:33.932+0600 D/avoidrickshaw(32394): event-values: 0.125025, -0.084347, 10.167104, 0.000000
07-25 22:06:33.992+0600 D/avoidrickshaw(32394): event-values: 0.196211, -0.068794, 10.168897, 0.000000
07-25 22:06:34.052+0600 D/avoidrickshaw(32394): event-values: 0.247657, -0.084945, 10.183254, 0.000000
07-25 22:06:34.112+0600 D/avoidrickshaw(32394): event-values: 0.189033, -0.074776, 10.174281, 0.000000
07-25 22:06:34.172+0600 D/avoidrickshaw(32394): event-values: 0.144168, -0.066999, 10.157533, 0.000000
07-25 22:06:34.233+0600 D/avoidrickshaw(32394): event-values: 0.210568, -0.078365, 10.156934, 0.000000
07-25 22:06:34.293+0600 D/avoidrickshaw(32394): event-values: 0.252443, -0.074776, 10.199407, 0.000000
07-25 22:06:34.353+0600 D/avoidrickshaw(32394): event-values: 0.235095, -0.080758, 10.200004, 0.000000
07-25 22:06:34.413+0600 D/avoidrickshaw(32394): event-values: 0.164507, -0.104088, 10.208978, 0.000000
07-25 22:06:34.473+0600 D/avoidrickshaw(32394): event-values: 0.206979, -0.058026, 10.202397, 0.000000
07-25 22:06:34.533+0600 D/avoidrickshaw(32394): event-values: 0.240479, -0.084945, 10.179665, 0.000000
07-25 22:06:34.593+0600 D/avoidrickshaw(32394): event-values: 0.218943, -0.069392, 10.204790, 0.000000
07-25 22:06:34.653+0600 D/avoidrickshaw(32394): event-values: 0.170489, -0.080758, 10.174281, 0.000000
07-25 22:06:34.713+0600 D/avoidrickshaw(32394): event-values: 0.200399, -0.071186, 10.161121, 0.000000
07-25 22:06:34.773+0600 D/avoidrickshaw(32394): event-values: 0.220140, -0.070588, 10.169496, 0.000000
07-25 22:06:34.833+0600 D/avoidrickshaw(32394): event-values: 0.238086, -0.070588, 10.174880, 0.000000
07-25 22:06:34.893+0600 D/avoidrickshaw(32394): event-values: 0.131605, -0.077169, 10.195816, 0.000000
07-25 22:06:34.953+0600 D/avoidrickshaw(32394): event-values: 0.244068, -0.059222, 10.202995, 0.000000
07-25 22:06:35.013+0600 D/avoidrickshaw(32394): event-values: 0.239880, -0.078365, 10.177272, 0.000000
07-25 22:06:35.073+0600 D/avoidrickshaw(32394): event-values: 0.172283, -0.090329, 10.140184, 0.000000
07-25 22:06:35.133+0600 D/avoidrickshaw(32394): event-values: 0.161516, 0.008973, 10.182058, 0.000000
07-25 22:06:35.193+0600 D/avoidrickshaw(32394): event-values: 0.183649, -0.106481, 10.164711, 0.000000
07-25 22:06:35.254+0600 D/avoidrickshaw(32394): event-values: 0.233898, -0.093918, 10.183254, 0.000000
07-25 22:06:35.314+0600 D/avoidrickshaw(32394): event-values: 0.141177, -0.074776, 10.181459, 0.000000
07-25 22:06:35.374+0600 D/avoidrickshaw(32394): event-values: 0.196211, -0.047856, 10.194620, 0.000000
07-25 22:06:35.434+0600 D/avoidrickshaw(32394): event-values: 0.218943, -0.074178, 10.130613, 0.000000
07-25 22:06:35.494+0600 D/avoidrickshaw(32394): event-values: 0.233300, -0.108275, 10.205389, 0.000000
07-25 22:06:35.554+0600 D/avoidrickshaw(32394): event-values: 0.196211, -0.068195, 10.165309, 0.000000
07-25 22:06:35.614+0600 D/avoidrickshaw(32394): event-values: 0.173480, -0.070588, 10.189835, 0.000000
07-25 22:06:35.674+0600 D/avoidrickshaw(32394): event-values: 0.187238, -0.069990, 10.172487, 0.000000
07-25 22:06:35.734+0600 D/avoidrickshaw(32394): event-values: 0.258425, -0.050847, 10.206585, 0.000000
07-25 22:06:35.794+0600 D/avoidrickshaw(32394): event-values: 0.181855, -0.076570, 10.191629, 0.000000
07-25 22:06:35.854+0600 D/avoidrickshaw(32394): event-values: 0.186640, -0.077169, 10.167104, 0.000000
07-25 22:06:35.914+0600 D/avoidrickshaw(32394): event-values: 0.209970, -0.081356, 10.171888, 0.000000
07-25 22:06:35.974+0600 D/avoidrickshaw(32394): event-values: 0.192622, -0.086740, 10.173084, 0.000000
07-25 22:06:36.034+0600 D/avoidrickshaw(32394): event-values: 0.206979, -0.081954, 10.182058, 0.000000
07-25 22:06:36.094+0600 D/avoidrickshaw(32394): event-values: 0.191426, -0.074776, 10.160523, 0.000000
07-25 22:06:36.154+0600 D/avoidrickshaw(32394): event-values: 0.218345, -0.064008, 10.179665, 0.000000
07-25 22:06:36.214+0600 D/avoidrickshaw(32394): event-values: 0.209970, -0.081356, 10.176675, 0.000000
07-25 22:06:36.275+0600 D/avoidrickshaw(32394): event-values: 0.201595, -0.076570, 10.179067, 0.000000
07-25 22:06:36.335+0600 D/avoidrickshaw(32394): event-values: 0.189631, -0.086142, 10.173084, 0.000000
07-25 22:06:36.395+0600 D/avoidrickshaw(32394): event-values: 0.198006, -0.089133, 10.170692, 0.000000
07-25 22:06:36.455+0600 D/avoidrickshaw(32394): event-values: 0.192024, -0.078963, 10.178469, 0.000000
07-25 22:06:36.515+0600 D/avoidrickshaw(32394): event-values: 0.183649, -0.061615, 10.168897, 0.000000
07-25 22:06:36.575+0600 D/avoidrickshaw(32394): event-values: 0.200997, -0.061615, 10.189237, 0.000000
07-25 22:06:36.635+0600 D/avoidrickshaw(32394): event-values: 0.178265, -0.062812, 10.176675, 0.000000
07-25 22:06:36.695+0600 D/avoidrickshaw(32394): event-values: 0.194417, -0.083151, 10.175477, 0.000000
07-25 22:06:36.755+0600 D/avoidrickshaw(32394): event-values: 0.182453, -0.083151, 10.188639, 0.000000
07-25 22:06:36.815+0600 D/avoidrickshaw(32394): event-values: 0.181256, -0.068195, 10.162319, 0.000000
07-25 22:06:36.875+0600 D/avoidrickshaw(32394): event-values: 0.193220, -0.071186, 10.180862, 0.000000
07-25 22:06:36.935+0600 D/avoidrickshaw(32394): event-values: 0.183051, -0.085543, 10.170094, 0.000000
07-25 22:06:36.995+0600 D/avoidrickshaw(32394): event-values: 0.187837, -0.060419, 10.174880, 0.000000
07-25 22:06:37.055+0600 D/avoidrickshaw(32394): event-values: 0.196810, -0.084945, 10.165908, 0.000000
07-25 22:06:37.115+0600 D/avoidrickshaw(32394): event-values: 0.205783, -0.080160, 10.165309, 0.000000
07-25 22:06:37.175+0600 D/avoidrickshaw(32394): event-values: 0.196211, -0.070588, 10.177871, 0.000000
07-25 22:06:37.235+0600 D/avoidrickshaw(32394): event-values: 0.180658, -0.083749, 10.179067, 0.000000
07-25 22:06:37.296+0600 D/avoidrickshaw(32394): event-values: 0.197408, -0.081954, 10.180862, 0.000000
07-25 22:06:37.356+0600 D/avoidrickshaw(32394): event-values: 0.197408, -0.080160, 10.185647, 0.000000
07-25 22:06:37.416+0600 D/avoidrickshaw(32394): event-values: 0.202792, -0.058026, 10.179067, 0.000000
07-25 22:06:37.476+0600 D/avoidrickshaw(32394): event-values: 0.184247, -0.086142, 10.176076, 0.000000
07-25 22:06:37.536+0600 D/avoidrickshaw(32394): event-values: 0.202193, -0.061615, 10.179665, 0.000000
07-25 22:06:37.596+0600 D/avoidrickshaw(32394): event-values: 0.205783, -0.072383, 10.168301, 0.000000
07-25 22:06:37.656+0600 D/avoidrickshaw(32394): event-values: 0.193819, -0.083749, 10.173084, 0.000000
07-25 22:06:37.716+0600 D/avoidrickshaw(32394): event-values: 0.189033, -0.077169, 10.162319, 0.000000
07-25 22:06:37.776+0600 D/avoidrickshaw(32394): event-values: 0.189033, -0.064606, 10.174880, 0.000000
07-25 22:06:37.836+0600 D/avoidrickshaw(32394): event-values: 0.206381, -0.066401, 10.186246, 0.000000
07-25 22:06:37.906+0600 D/avoidrickshaw(32394): horizontal_acc: 16.000000, vertical_acc: -1.000000
07-25 22:06:37.906+0600 D/avoidrickshaw(32394): previous lat: 23.742172, previous long: 90.411648
07-25 22:06:37.906+0600 D/avoidrickshaw(32394): current lat: 23.742157, current long: 90.411653
07-25 22:06:37.916+0600 D/avoidrickshaw(32394): because step count did not update, saving position only.
07-25 22:06:37.916+0600 D/avoidrickshaw(32394): event-values: 0.195015, -0.085543, 10.178469, 0.000000
07-25 22:06:37.956+0600 D/avoidrickshaw(32394): event-values: 0.204586, -0.081356, 10.176076, 0.000000
07-25 22:06:38.016+0600 D/avoidrickshaw(32394): event-values: 0.209970, -0.067597, 10.186246, 0.000000
07-25 22:06:38.076+0600 D/avoidrickshaw(32394): event-values: 0.192622, -0.077169, 10.174281, 0.000000
07-25 22:06:38.136+0600 D/avoidrickshaw(32394): event-values: 0.179462, -0.081356, 10.177272, 0.000000
07-25 22:06:38.196+0600 D/avoidrickshaw(32394): event-values: 0.200997, -0.080758, 10.179665, 0.000000
07-25 22:06:38.256+0600 D/avoidrickshaw(32394): event-values: 0.194417, -0.077767, 10.168897, 0.000000
07-25 22:06:38.317+0600 D/avoidrickshaw(32394): event-values: 0.184247, -0.080160, 10.177871, 0.000000
07-25 22:06:38.377+0600 D/avoidrickshaw(32394): event-values: 0.196211, -0.075374, 10.151550, 0.000000
07-25 22:06:38.437+0600 D/avoidrickshaw(32394): event-values: 0.186640, -0.079561, 10.183852, 0.000000
07-25 22:06:38.497+0600 D/avoidrickshaw(32394): event-values: 0.198006, -0.073579, 10.161121, 0.000000
07-25 22:06:38.557+0600 D/avoidrickshaw(32394): event-values: 0.197408, -0.060419, 10.166506, 0.000000
07-25 22:06:38.617+0600 D/avoidrickshaw(32394): event-values: 0.189033, -0.089133, 10.170094, 0.000000
07-25 22:06:38.677+0600 D/avoidrickshaw(32394): event-values: 0.218345, -0.071186, 10.169496, 0.000000
07-25 22:06:38.737+0600 D/avoidrickshaw(32394): event-values: 0.175872, -0.069392, 10.188040, 0.000000
07-25 22:06:38.797+0600 D/avoidrickshaw(32394): event-values: 0.195015, -0.062812, 10.183852, 0.000000
07-25 22:06:38.857+0600 D/avoidrickshaw(32394): event-values: 0.186640, -0.082552, 10.182058, 0.000000
07-25 22:06:38.917+0600 D/avoidrickshaw(32394): event-values: 0.206381, -0.081356, 10.168301, 0.000000
07-25 22:06:38.977+0600 D/avoidrickshaw(32394): event-values: 0.203390, -0.068195, 10.176076, 0.000000
07-25 22:06:39.037+0600 D/avoidrickshaw(32394): event-values: 0.194417, -0.074178, 10.167702, 0.000000
07-25 22:06:39.097+0600 D/avoidrickshaw(32394): event-values: 0.189631, -0.077767, 10.197612, 0.000000
07-25 22:06:39.157+0600 D/avoidrickshaw(32394): event-values: 0.203390, -0.070588, 10.165908, 0.000000
07-25 22:06:39.217+0600 D/avoidrickshaw(32394): event-values: 0.196810, -0.069392, 10.204191, 0.000000
07-25 22:06:39.277+0600 D/avoidrickshaw(32394): event-values: 0.189033, -0.062812, 10.172487, 0.000000
07-25 22:06:39.338+0600 D/avoidrickshaw(32394): event-values: 0.174078, -0.072981, 10.186844, 0.000000
07-25 22:06:39.398+0600 D/avoidrickshaw(32394): event-values: 0.226122, -0.074776, 10.175477, 0.000000
07-25 22:06:39.458+0600 D/avoidrickshaw(32394): event-values: 0.199202, -0.066999, 10.186246, 0.000000
07-25 22:06:39.518+0600 D/avoidrickshaw(32394): event-values: 0.183649, -0.084347, 10.141381, 0.000000
07-25 22:06:39.578+0600 D/avoidrickshaw(32394): event-values: 0.226720, -0.065803, 10.160523, 0.000000
07-25 22:06:39.638+0600 D/avoidrickshaw(32394): event-values: 0.166899, -0.065204, 10.167104, 0.000000
07-25 22:06:39.698+0600 D/avoidrickshaw(32394): event-values: 0.186042, -0.072981, 10.169496, 0.000000
07-25 22:06:39.758+0600 D/avoidrickshaw(32394): event-values: 0.201595, -0.092124, 10.176076, 0.000000
07-25 22:06:39.818+0600 D/avoidrickshaw(32394): event-values: 0.212363, -0.083749, 10.163515, 0.000000
07-25 22:06:39.878+0600 D/avoidrickshaw(32394): event-values: 0.212961, -0.064606, 10.170692, 0.000000
07-25 22:06:39.938+0600 D/avoidrickshaw(32394): event-values: 0.163908, -0.069990, 10.193424, 0.000000
07-25 22:06:39.998+0600 D/avoidrickshaw(32394): event-values: 0.207577, -0.091525, 10.185647, 0.000000
07-25 22:06:40.058+0600 D/avoidrickshaw(32394): event-values: 0.224925, -0.090927, 10.169496, 0.000000
07-25 22:06:40.118+0600 D/avoidrickshaw(32394): event-values: 0.184247, -0.068195, 10.182656, 0.000000
07-25 22:06:40.178+0600 D/avoidrickshaw(32394): event-values: 0.151944, -0.059222, 10.168897, 0.000000
07-25 22:06:40.238+0600 D/avoidrickshaw(32394): event-values: 0.211167, -0.075374, 10.156336, 0.000000
07-25 22:06:40.298+0600 D/avoidrickshaw(32394): event-values: 0.211765, -0.070588, 10.170692, 0.000000
07-25 22:06:40.358+0600 D/avoidrickshaw(32394): event-values: 0.196211, -0.083151, 10.167702, 0.000000
07-25 22:06:40.419+0600 D/avoidrickshaw(32394): event-values: 0.159123, -0.085543, 10.168897, 0.000000
07-25 22:06:40.479+0600 D/avoidrickshaw(32394): event-values: 0.215952, -0.075972, 10.174281, 0.000000
07-25 22:06:40.539+0600 D/avoidrickshaw(32394): event-values: 0.232702, -0.072981, 10.164711, 0.000000
07-25 22:06:40.599+0600 D/avoidrickshaw(32394): event-values: 0.159123, -0.092722, 10.155140, 0.000000
07-25 22:06:40.659+0600 D/avoidrickshaw(32394): event-values: 0.163908, -0.073579, 10.168897, 0.000000
07-25 22:06:40.719+0600 D/avoidrickshaw(32394): event-values: 0.221336, -0.074178, 10.192227, 0.000000
07-25 22:06:40.779+0600 D/avoidrickshaw(32394): event-values: 0.215354, -0.071186, 10.167702, 0.000000
07-25 22:06:40.839+0600 D/avoidrickshaw(32394): event-values: 0.189631, -0.082552, 10.175477, 0.000000
07-25 22:06:40.899+0600 D/avoidrickshaw(32394): event-values: 0.176471, -0.076570, 10.164113, 0.000000
07-25 22:06:40.959+0600 D/avoidrickshaw(32394): event-values: 0.206381, -0.066401, 10.153944, 0.000000
07-25 22:06:41.019+0600 D/avoidrickshaw(32394): event-values: 0.220738, -0.087338, 10.173683, 0.000000
07-25 22:06:41.079+0600 D/avoidrickshaw(32394): event-values: 0.172881, -0.072383, 10.186844, 0.000000
07-25 22:06:41.139+0600 D/avoidrickshaw(32394): event-values: 0.199801, -0.063410, 10.177871, 0.000000
07-25 22:06:41.199+0600 D/avoidrickshaw(32394): event-values: 0.213559, -0.078963, 10.182058, 0.000000
07-25 22:06:41.259+0600 D/avoidrickshaw(32394): event-values: 0.200997, -0.072981, 10.176076, 0.000000
07-25 22:06:41.319+0600 D/avoidrickshaw(32394): event-values: 0.187837, -0.070588, 10.188040, 0.000000
07-25 22:06:41.379+0600 D/avoidrickshaw(32394): event-values: 0.193220, -0.058026, 10.192227, 0.000000
07-25 22:06:41.440+0600 D/avoidrickshaw(32394): event-values: 0.227916, -0.064606, 10.169496, 0.000000
07-25 22:06:41.500+0600 D/avoidrickshaw(32394): event-values: 0.200997, -0.087936, 10.165309, 0.000000
07-25 22:06:41.560
