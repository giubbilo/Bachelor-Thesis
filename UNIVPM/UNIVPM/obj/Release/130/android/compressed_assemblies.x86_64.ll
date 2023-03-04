; ModuleID = 'obj\Release\130\android\compressed_assemblies.x86_64.ll'
source_filename = "obj\Release\130\android\compressed_assemblies.x86_64.ll"
target datalayout = "e-m:e-p270:32:32-p271:32:32-p272:64:64-i64:64-f80:128-n8:16:32:64-S128"
target triple = "x86_64-unknown-linux-android"


%struct.CompressedAssemblyDescriptor = type {
	i32,; uint32_t uncompressed_file_size
	i8,; bool loaded
	i8*; uint8_t* data
}

%struct.CompressedAssemblies = type {
	i32,; uint32_t count
	%struct.CompressedAssemblyDescriptor*; CompressedAssemblyDescriptor* descriptors
}
@__CompressedAssemblyDescriptor_data_0 = internal global [164864 x i8] zeroinitializer, align 16
@__CompressedAssemblyDescriptor_data_1 = internal global [1148928 x i8] zeroinitializer, align 16
@__CompressedAssemblyDescriptor_data_2 = internal global [109568 x i8] zeroinitializer, align 16
@__CompressedAssemblyDescriptor_data_3 = internal global [88576 x i8] zeroinitializer, align 16
@__CompressedAssemblyDescriptor_data_4 = internal global [5120 x i8] zeroinitializer, align 16
@__CompressedAssemblyDescriptor_data_5 = internal global [5120 x i8] zeroinitializer, align 16
@__CompressedAssemblyDescriptor_data_6 = internal global [38400 x i8] zeroinitializer, align 16
@__CompressedAssemblyDescriptor_data_7 = internal global [4608 x i8] zeroinitializer, align 16
@__CompressedAssemblyDescriptor_data_8 = internal global [38912 x i8] zeroinitializer, align 16
@__CompressedAssemblyDescriptor_data_9 = internal global [145408 x i8] zeroinitializer, align 16
@__CompressedAssemblyDescriptor_data_10 = internal global [212480 x i8] zeroinitializer, align 16
@__CompressedAssemblyDescriptor_data_11 = internal global [25600 x i8] zeroinitializer, align 16
@__CompressedAssemblyDescriptor_data_12 = internal global [387072 x i8] zeroinitializer, align 16
@__CompressedAssemblyDescriptor_data_13 = internal global [143872 x i8] zeroinitializer, align 16
@__CompressedAssemblyDescriptor_data_14 = internal global [14336 x i8] zeroinitializer, align 16
@__CompressedAssemblyDescriptor_data_15 = internal global [14848 x i8] zeroinitializer, align 16
@__CompressedAssemblyDescriptor_data_16 = internal global [8704 x i8] zeroinitializer, align 16
@__CompressedAssemblyDescriptor_data_17 = internal global [138752 x i8] zeroinitializer, align 16
@__CompressedAssemblyDescriptor_data_18 = internal global [48640 x i8] zeroinitializer, align 16
@__CompressedAssemblyDescriptor_data_19 = internal global [36352 x i8] zeroinitializer, align 16
@__CompressedAssemblyDescriptor_data_20 = internal global [140288 x i8] zeroinitializer, align 16
@__CompressedAssemblyDescriptor_data_21 = internal global [34304 x i8] zeroinitializer, align 16
@__CompressedAssemblyDescriptor_data_22 = internal global [52224 x i8] zeroinitializer, align 16
@__CompressedAssemblyDescriptor_data_23 = internal global [302592 x i8] zeroinitializer, align 16
@__CompressedAssemblyDescriptor_data_24 = internal global [1900544 x i8] zeroinitializer, align 16


; Compressed assembly data storage
@compressed_assembly_descriptors = internal global [25 x %struct.CompressedAssemblyDescriptor] [
	; 0
	%struct.CompressedAssemblyDescriptor {
		i32 164864, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([164864 x i8], [164864 x i8]* @__CompressedAssemblyDescriptor_data_0, i32 0, i32 0); data
	}, 
	; 1
	%struct.CompressedAssemblyDescriptor {
		i32 1148928, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([1148928 x i8], [1148928 x i8]* @__CompressedAssemblyDescriptor_data_1, i32 0, i32 0); data
	}, 
	; 2
	%struct.CompressedAssemblyDescriptor {
		i32 109568, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([109568 x i8], [109568 x i8]* @__CompressedAssemblyDescriptor_data_2, i32 0, i32 0); data
	}, 
	; 3
	%struct.CompressedAssemblyDescriptor {
		i32 88576, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([88576 x i8], [88576 x i8]* @__CompressedAssemblyDescriptor_data_3, i32 0, i32 0); data
	}, 
	; 4
	%struct.CompressedAssemblyDescriptor {
		i32 5120, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([5120 x i8], [5120 x i8]* @__CompressedAssemblyDescriptor_data_4, i32 0, i32 0); data
	}, 
	; 5
	%struct.CompressedAssemblyDescriptor {
		i32 5120, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([5120 x i8], [5120 x i8]* @__CompressedAssemblyDescriptor_data_5, i32 0, i32 0); data
	}, 
	; 6
	%struct.CompressedAssemblyDescriptor {
		i32 38400, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([38400 x i8], [38400 x i8]* @__CompressedAssemblyDescriptor_data_6, i32 0, i32 0); data
	}, 
	; 7
	%struct.CompressedAssemblyDescriptor {
		i32 4608, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([4608 x i8], [4608 x i8]* @__CompressedAssemblyDescriptor_data_7, i32 0, i32 0); data
	}, 
	; 8
	%struct.CompressedAssemblyDescriptor {
		i32 38912, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([38912 x i8], [38912 x i8]* @__CompressedAssemblyDescriptor_data_8, i32 0, i32 0); data
	}, 
	; 9
	%struct.CompressedAssemblyDescriptor {
		i32 145408, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([145408 x i8], [145408 x i8]* @__CompressedAssemblyDescriptor_data_9, i32 0, i32 0); data
	}, 
	; 10
	%struct.CompressedAssemblyDescriptor {
		i32 212480, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([212480 x i8], [212480 x i8]* @__CompressedAssemblyDescriptor_data_10, i32 0, i32 0); data
	}, 
	; 11
	%struct.CompressedAssemblyDescriptor {
		i32 25600, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([25600 x i8], [25600 x i8]* @__CompressedAssemblyDescriptor_data_11, i32 0, i32 0); data
	}, 
	; 12
	%struct.CompressedAssemblyDescriptor {
		i32 387072, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([387072 x i8], [387072 x i8]* @__CompressedAssemblyDescriptor_data_12, i32 0, i32 0); data
	}, 
	; 13
	%struct.CompressedAssemblyDescriptor {
		i32 143872, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([143872 x i8], [143872 x i8]* @__CompressedAssemblyDescriptor_data_13, i32 0, i32 0); data
	}, 
	; 14
	%struct.CompressedAssemblyDescriptor {
		i32 14336, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([14336 x i8], [14336 x i8]* @__CompressedAssemblyDescriptor_data_14, i32 0, i32 0); data
	}, 
	; 15
	%struct.CompressedAssemblyDescriptor {
		i32 14848, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([14848 x i8], [14848 x i8]* @__CompressedAssemblyDescriptor_data_15, i32 0, i32 0); data
	}, 
	; 16
	%struct.CompressedAssemblyDescriptor {
		i32 8704, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([8704 x i8], [8704 x i8]* @__CompressedAssemblyDescriptor_data_16, i32 0, i32 0); data
	}, 
	; 17
	%struct.CompressedAssemblyDescriptor {
		i32 138752, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([138752 x i8], [138752 x i8]* @__CompressedAssemblyDescriptor_data_17, i32 0, i32 0); data
	}, 
	; 18
	%struct.CompressedAssemblyDescriptor {
		i32 48640, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([48640 x i8], [48640 x i8]* @__CompressedAssemblyDescriptor_data_18, i32 0, i32 0); data
	}, 
	; 19
	%struct.CompressedAssemblyDescriptor {
		i32 36352, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([36352 x i8], [36352 x i8]* @__CompressedAssemblyDescriptor_data_19, i32 0, i32 0); data
	}, 
	; 20
	%struct.CompressedAssemblyDescriptor {
		i32 140288, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([140288 x i8], [140288 x i8]* @__CompressedAssemblyDescriptor_data_20, i32 0, i32 0); data
	}, 
	; 21
	%struct.CompressedAssemblyDescriptor {
		i32 34304, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([34304 x i8], [34304 x i8]* @__CompressedAssemblyDescriptor_data_21, i32 0, i32 0); data
	}, 
	; 22
	%struct.CompressedAssemblyDescriptor {
		i32 52224, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([52224 x i8], [52224 x i8]* @__CompressedAssemblyDescriptor_data_22, i32 0, i32 0); data
	}, 
	; 23
	%struct.CompressedAssemblyDescriptor {
		i32 302592, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([302592 x i8], [302592 x i8]* @__CompressedAssemblyDescriptor_data_23, i32 0, i32 0); data
	}, 
	; 24
	%struct.CompressedAssemblyDescriptor {
		i32 1900544, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([1900544 x i8], [1900544 x i8]* @__CompressedAssemblyDescriptor_data_24, i32 0, i32 0); data
	}
], align 16; end of 'compressed_assembly_descriptors' array


; compressed_assemblies
@compressed_assemblies = local_unnamed_addr global %struct.CompressedAssemblies {
	i32 25, ; count
	%struct.CompressedAssemblyDescriptor* getelementptr inbounds ([25 x %struct.CompressedAssemblyDescriptor], [25 x %struct.CompressedAssemblyDescriptor]* @compressed_assembly_descriptors, i32 0, i32 0); descriptors
}, align 8


!llvm.module.flags = !{!0, !1}
!llvm.ident = !{!2}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{!"Xamarin.Android remotes/origin/d17-5 @ 797e2e13d1706ace607da43703769c5a55c4de60"}
