; ModuleID = 'obj\Release\130\android\marshal_methods.x86_64.ll'
source_filename = "obj\Release\130\android\marshal_methods.x86_64.ll"
target datalayout = "e-m:e-p270:32:32-p271:32:32-p272:64:64-i64:64-f80:128-n8:16:32:64-S128"
target triple = "x86_64-unknown-linux-android"


%struct.MonoImage = type opaque

%struct.MonoClass = type opaque

%struct.MarshalMethodsManagedClass = type {
	i32,; uint32_t token
	%struct.MonoClass*; MonoClass* klass
}

%struct.MarshalMethodName = type {
	i64,; uint64_t id
	i8*; char* name
}

%class._JNIEnv = type opaque

%class._jobject = type {
	i8; uint8_t b
}

%class._jclass = type {
	i8; uint8_t b
}

%class._jstring = type {
	i8; uint8_t b
}

%class._jthrowable = type {
	i8; uint8_t b
}

%class._jarray = type {
	i8; uint8_t b
}

%class._jobjectArray = type {
	i8; uint8_t b
}

%class._jbooleanArray = type {
	i8; uint8_t b
}

%class._jbyteArray = type {
	i8; uint8_t b
}

%class._jcharArray = type {
	i8; uint8_t b
}

%class._jshortArray = type {
	i8; uint8_t b
}

%class._jintArray = type {
	i8; uint8_t b
}

%class._jlongArray = type {
	i8; uint8_t b
}

%class._jfloatArray = type {
	i8; uint8_t b
}

%class._jdoubleArray = type {
	i8; uint8_t b
}

; assembly_image_cache
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 8
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [50 x i64] [
	i64 120698629574877762, ; 0: Mono.Android => 0x1accec39cafe242 => 2
	i64 590536689428908136, ; 1: Xamarin.Android.Arch.Lifecycle.ViewModel.dll => 0x83201fd803ec868 => 14
	i64 846634227898301275, ; 2: Xamarin.Android.Arch.Lifecycle.LiveData.Core => 0xbbfd9583890bb5b => 13
	i64 1000557547492888992, ; 3: Mono.Security.dll => 0xde2b1c9cba651a0 => 23
	i64 1301485588176585670, ; 4: SQLitePCLRaw.core => 0x120fce3f338e43c6 => 7
	i64 1342439039765371018, ; 5: Xamarin.Android.Support.Fragment => 0x12a14d31b1d4d88a => 18
	i64 1518315023656898250, ; 6: SQLitePCLRaw.provider.e_sqlite3 => 0x151223783a354eca => 9
	i64 1744702963312407042, ; 7: Xamarin.Android.Support.v7.AppCompat => 0x18366e19eeceb202 => 20
	i64 2624866290265602282, ; 8: mscorlib.dll => 0x246d65fbde2db8ea => 3
	i64 2977248461349026546, ; 9: Xamarin.Android.Support.DrawerLayout => 0x29514fb392c97af2 => 17
	i64 3531994851595924923, ; 10: System.Numerics => 0x31042a9aade235bb => 24
	i64 4252163538099460320, ; 11: Xamarin.Android.Support.ViewPager.dll => 0x3b02b8357f4958e0 => 21
	i64 4337444564132831293, ; 12: SQLitePCLRaw.batteries_v2.dll => 0x3c31b2d9ae16203d => 6
	i64 5507995362134886206, ; 13: System.Core.dll => 0x4c705499688c873e => 10
	i64 6025176081837716467, ; 14: SQLitePCLRaw.lib.e_sqlite3.dll => 0x539db9b9431df3f3 => 8
	i64 6183170893902868313, ; 15: SQLitePCLRaw.batteries_v2 => 0x55cf092b0c9d6f59 => 6
	i64 7147779083324673306, ; 16: UNIVPM.dll => 0x63320334aa88cd1a => 0
	i64 7654504624184590948, ; 17: System.Net.Http => 0x6a3a4366801b8264 => 22
	i64 7879037620440914030, ; 18: Xamarin.Android.Support.v7.AppCompat.dll => 0x6d57f6f88a51d86e => 20
	i64 8167236081217502503, ; 19: Java.Interop.dll => 0x7157d9f1a9b8fd27 => 1
	i64 8626175481042262068, ; 20: Java.Interop => 0x77b654e585b55834 => 1
	i64 8808820144457481518, ; 21: Xamarin.Android.Support.Loader.dll => 0x7a3f374010b17d2e => 19
	i64 9403251673309200028, ; 22: UNIVPM => 0x827f0f9389313e9c => 0
	i64 9475595603812259686, ; 23: Xamarin.Android.Support.Design => 0x838013ff707b9766 => 16
	i64 9662334977499516867, ; 24: System.Numerics.dll => 0x8617827802b0cfc3 => 24
	i64 9793247711277112057, ; 25: SQLitePCLRaw.batteries_green.dll => 0x87e89ae814145af9 => 5
	i64 9808709177481450983, ; 26: Mono.Android.dll => 0x881f890734e555e7 => 2
	i64 9866412715007501892, ; 27: Xamarin.Android.Arch.Lifecycle.Common.dll => 0x88ec8a16fd6b6644 => 12
	i64 9998632235833408227, ; 28: Mono.Security => 0x8ac2470b209ebae3 => 23
	i64 10038780035334861115, ; 29: System.Net.Http.dll => 0x8b50e941206af13b => 22
	i64 10303855825347935641, ; 30: Xamarin.Android.Support.Loader => 0x8efea647eeb3fd99 => 19
	i64 10635644668885628703, ; 31: Xamarin.Android.Support.DrawerLayout.dll => 0x93996679ee34771f => 17
	i64 10807679263882430897, ; 32: SQLitePCLRaw.batteries_green => 0x95fc97076a1149b1 => 5
	i64 11023048688141570732, ; 33: System.Core => 0x98f9bc61168392ac => 10
	i64 11376461258732682436, ; 34: Xamarin.Android.Support.Compat => 0x9de14f3d5fc13cc4 => 15
	i64 11739066727115742305, ; 35: SQLite-net.dll => 0xa2e98afdf8575c61 => 4
	i64 11806260347154423189, ; 36: SQLite-net => 0xa3d8433bc5eb5d95 => 4
	i64 12279246230491828964, ; 37: SQLitePCLRaw.provider.e_sqlite3.dll => 0xaa68a5636e0512e4 => 9
	i64 12414299427252656003, ; 38: Xamarin.Android.Support.Compat.dll => 0xac48738e28bad783 => 15
	i64 13358059602087096138, ; 39: Xamarin.Android.Support.Fragment.dll => 0xb9615c6f1ee5af4a => 18
	i64 15609085926864131306, ; 40: System.dll => 0xd89e9cf3334914ea => 11
	i64 16154507427712707110, ; 41: System => 0xe03056ea4e39aa26 => 11
	i64 16392891804791780225, ; 42: SQLitePCLRaw.lib.e_sqlite3 => 0xe37f403e4206b381 => 8
	i64 16755018182064898362, ; 43: SQLitePCLRaw.core.dll => 0xe885c843c330813a => 7
	i64 16833383113903931215, ; 44: mscorlib => 0xe99c30c1484d7f4f => 3
	i64 17483646997724851973, ; 45: Xamarin.Android.Support.ViewPager => 0xf2a2644fe5b6ef05 => 21
	i64 17760961058993581169, ; 46: Xamarin.Android.Arch.Lifecycle.Common => 0xf67b9bfb46dbac71 => 12
	i64 17841643939744178149, ; 47: Xamarin.Android.Arch.Lifecycle.ViewModel => 0xf79a40a25573dfe5 => 14
	i64 17936749993673010118, ; 48: Xamarin.Android.Support.Design.dll => 0xf8ec231615deabc6 => 16
	i64 17958105683855786126 ; 49: Xamarin.Android.Arch.Lifecycle.LiveData.Core.dll => 0xf93801f92d25c08e => 13
], align 16
@assembly_image_cache_indices = local_unnamed_addr constant [50 x i32] [
	i32 2, i32 14, i32 13, i32 23, i32 7, i32 18, i32 9, i32 20, ; 0..7
	i32 3, i32 17, i32 24, i32 21, i32 6, i32 10, i32 8, i32 6, ; 8..15
	i32 0, i32 22, i32 20, i32 1, i32 1, i32 19, i32 0, i32 16, ; 16..23
	i32 24, i32 5, i32 2, i32 12, i32 23, i32 22, i32 19, i32 17, ; 24..31
	i32 5, i32 10, i32 15, i32 4, i32 4, i32 9, i32 15, i32 18, ; 32..39
	i32 11, i32 11, i32 8, i32 7, i32 3, i32 21, i32 12, i32 14, ; 40..47
	i32 16, i32 13 ; 48..49
], align 16

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 8; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 8

; Function attributes: "frame-pointer"="none" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="x86-64" "target-features"="+cx16,+cx8,+fxsr,+mmx,+popcnt,+sse,+sse2,+sse3,+sse4.1,+sse4.2,+ssse3,+x87" "tune-cpu"="generic" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 8
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 8
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 16; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="none" "target-cpu"="x86-64" "target-features"="+cx16,+cx8,+fxsr,+mmx,+popcnt,+sse,+sse2,+sse3,+sse4.1,+sse4.2,+ssse3,+x87" "tune-cpu"="generic" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="none" "target-cpu"="x86-64" "target-features"="+cx16,+cx8,+fxsr,+mmx,+popcnt,+sse,+sse2,+sse3,+sse4.1,+sse4.2,+ssse3,+x87" "tune-cpu"="generic" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1}
!llvm.ident = !{!2}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{!"Xamarin.Android remotes/origin/d17-5 @ 797e2e13d1706ace607da43703769c5a55c4de60"}
!llvm.linker.options = !{}
