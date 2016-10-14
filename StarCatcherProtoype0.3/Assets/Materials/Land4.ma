//Maya ASCII 2017 scene
//Name: Land4.ma
//Last modified: Sat, Oct 01, 2016 05:22:39 PM
//Codeset: 1252
requires maya "2017";
currentUnit -l centimeter -a degree -t film;
fileInfo "application" "maya";
fileInfo "product" "Maya 2017";
fileInfo "version" "2017";
fileInfo "cutIdentifier" "201606150345-997974";
fileInfo "osv" "Microsoft Windows 8 Home Premium Edition, 64-bit  (Build 9200)\n";
fileInfo "license" "student";
createNode transform -n "pCube4";
	rename -uid "7F04BDED-4A0F-F841-8E3A-F18083E073AA";
	setAttr ".t" -type "double3" 75 0 0 ;
	setAttr ".s" -type "double3" 25 10 4 ;
createNode mesh -n "pCubeShape4" -p "pCube4";
	rename -uid "21FB818E-48EA-266B-42AA-9BAF2418B7CE";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.59999990463256836 0.375 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 59 ".uvst[0].uvsp[0:58]" -type "float2" 0.375 0 0.40000001
		 0 0.42500001 0 0.45000002 0 0.47500002 0 0.5 0 0.52499998 0 0.54999995 0 0.57499993
		 0 0.5999999 0 0.62499988 0 0.375 0.25 0.40000001 0.25 0.42500001 0.25 0.45000002
		 0.25 0.47500002 0.25 0.5 0.25 0.52499998 0.25 0.54999995 0.25 0.57499993 0.25 0.5999999
		 0.25 0.62499988 0.25 0.375 0.5 0.40000001 0.5 0.42500001 0.5 0.45000002 0.5 0.47500002
		 0.5 0.5 0.5 0.52499998 0.5 0.54999995 0.5 0.57499993 0.5 0.5999999 0.5 0.62499988
		 0.5 0.375 0.75 0.40000001 0.75 0.42500001 0.75 0.45000002 0.75 0.47500002 0.75 0.5
		 0.75 0.52499998 0.75 0.54999995 0.75 0.57499993 0.75 0.5999999 0.75 0.62499988 0.75
		 0.375 1 0.40000001 1 0.42500001 1 0.45000002 1 0.47500002 1 0.5 1 0.52499998 1 0.54999995
		 1 0.57499993 1 0.5999999 1 0.62499988 1 0.875 0 0.875 0.25 0.125 0 0.125 0.25;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 15 ".pt";
	setAttr ".pt[13]" -type "float3" 0.056909379 0.086362079 0 ;
	setAttr ".pt[14]" -type "float3" 0 -0.080419034 0 ;
	setAttr ".pt[15]" -type "float3" 0 -0.20443735 0 ;
	setAttr ".pt[16]" -type "float3" 0 -0.18948561 0 ;
	setAttr ".pt[17]" -type "float3" 0 -0.10290235 0 ;
	setAttr ".pt[19]" -type "float3" 0 -0.13443853 0 ;
	setAttr ".pt[20]" -type "float3" 0 -0.16251056 0 ;
	setAttr ".pt[24]" -type "float3" 0.056909379 0.086362079 0 ;
	setAttr ".pt[25]" -type "float3" 0 -0.080419034 0 ;
	setAttr ".pt[26]" -type "float3" 0 -0.20443735 0 ;
	setAttr ".pt[27]" -type "float3" 0 -0.18948561 0 ;
	setAttr ".pt[28]" -type "float3" 0 -0.10290235 0 ;
	setAttr ".pt[30]" -type "float3" 0 -0.13443853 0 ;
	setAttr ".pt[31]" -type "float3" 0 -0.16251056 0 ;
	setAttr -s 44 ".vt[0:43]"  -0.5 -0.5 0.5 -0.40000001 -0.5 0.5 -0.30000001 -0.5 0.5
		 -0.20000002 -0.5 0.5 -0.10000002 -0.5 0.5 -1.4901161e-008 -0.5 0.5 0.099999987 -0.5 0.5
		 0.19999999 -0.5 0.5 0.29999998 -0.5 0.5 0.39999998 -0.5 0.5 0.49999997 -0.5 0.5 -0.5 0.5 0.5
		 -0.40000001 0.5 0.5 -0.30000001 0.5 0.5 -0.20000002 0.5 0.5 -0.10000002 0.5 0.5 -1.4901161e-008 0.5 0.5
		 0.099999987 0.5 0.5 0.19999999 0.5 0.5 0.29999998 0.5 0.5 0.39999998 0.5 0.5 0.49999997 0.5 0.5
		 -0.5 0.5 -0.5 -0.40000001 0.5 -0.5 -0.30000001 0.5 -0.5 -0.20000002 0.5 -0.5 -0.10000002 0.5 -0.5
		 -1.4901161e-008 0.5 -0.5 0.099999987 0.5 -0.5 0.19999999 0.5 -0.5 0.29999998 0.5 -0.5
		 0.39999998 0.5 -0.5 0.49999997 0.5 -0.5 -0.5 -0.5 -0.5 -0.40000001 -0.5 -0.5 -0.30000001 -0.5 -0.5
		 -0.20000002 -0.5 -0.5 -0.10000002 -0.5 -0.5 -1.4901161e-008 -0.5 -0.5 0.099999987 -0.5 -0.5
		 0.19999999 -0.5 -0.5 0.29999998 -0.5 -0.5 0.39999998 -0.5 -0.5 0.49999997 -0.5 -0.5;
	setAttr -s 84 ".ed[0:83]"  0 1 0 1 2 0 2 3 0 3 4 0 4 5 0 5 6 0 6 7 0
		 7 8 0 8 9 0 9 10 0 11 12 0 12 13 0 13 14 0 14 15 0 15 16 0 16 17 0 17 18 0 18 19 0
		 19 20 0 20 21 0 22 23 0 23 24 0 24 25 0 25 26 0 26 27 0 27 28 0 28 29 0 29 30 0 30 31 0
		 31 32 0 33 34 0 34 35 0 35 36 0 36 37 0 37 38 0 38 39 0 39 40 0 40 41 0 41 42 0 42 43 0
		 0 11 0 1 12 1 2 13 1 3 14 1 4 15 1 5 16 1 6 17 1 7 18 1 8 19 1 9 20 1 10 21 0 11 22 0
		 12 23 1 13 24 1 14 25 1 15 26 1 16 27 1 17 28 1 18 29 1 19 30 1 20 31 1 21 32 0 22 33 0
		 23 34 1 24 35 1 25 36 1 26 37 1 27 38 1 28 39 1 29 40 1 30 41 1 31 42 1 32 43 0 33 0 0
		 34 1 1 35 2 1 36 3 1 37 4 1 38 5 1 39 6 1 40 7 1 41 8 1 42 9 1 43 10 0;
	setAttr -s 42 -ch 168 ".fc[0:41]" -type "polyFaces" 
		f 4 0 41 -11 -41
		mu 0 4 0 1 12 11
		f 4 1 42 -12 -42
		mu 0 4 1 2 13 12
		f 4 2 43 -13 -43
		mu 0 4 2 3 14 13
		f 4 3 44 -14 -44
		mu 0 4 3 4 15 14
		f 4 4 45 -15 -45
		mu 0 4 4 5 16 15
		f 4 5 46 -16 -46
		mu 0 4 5 6 17 16
		f 4 6 47 -17 -47
		mu 0 4 6 7 18 17
		f 4 7 48 -18 -48
		mu 0 4 7 8 19 18
		f 4 8 49 -19 -49
		mu 0 4 8 9 20 19
		f 4 9 50 -20 -50
		mu 0 4 9 10 21 20
		f 4 10 52 -21 -52
		mu 0 4 11 12 23 22
		f 4 11 53 -22 -53
		mu 0 4 12 13 24 23
		f 4 12 54 -23 -54
		mu 0 4 13 14 25 24
		f 4 13 55 -24 -55
		mu 0 4 14 15 26 25
		f 4 14 56 -25 -56
		mu 0 4 15 16 27 26
		f 4 15 57 -26 -57
		mu 0 4 16 17 28 27
		f 4 16 58 -27 -58
		mu 0 4 17 18 29 28
		f 4 17 59 -28 -59
		mu 0 4 18 19 30 29
		f 4 18 60 -29 -60
		mu 0 4 19 20 31 30
		f 4 19 61 -30 -61
		mu 0 4 20 21 32 31
		f 4 20 63 -31 -63
		mu 0 4 22 23 34 33
		f 4 21 64 -32 -64
		mu 0 4 23 24 35 34
		f 4 22 65 -33 -65
		mu 0 4 24 25 36 35
		f 4 23 66 -34 -66
		mu 0 4 25 26 37 36
		f 4 24 67 -35 -67
		mu 0 4 26 27 38 37
		f 4 25 68 -36 -68
		mu 0 4 27 28 39 38
		f 4 26 69 -37 -69
		mu 0 4 28 29 40 39
		f 4 27 70 -38 -70
		mu 0 4 29 30 41 40
		f 4 28 71 -39 -71
		mu 0 4 30 31 42 41
		f 4 29 72 -40 -72
		mu 0 4 31 32 43 42
		f 4 30 74 -1 -74
		mu 0 4 33 34 45 44
		f 4 31 75 -2 -75
		mu 0 4 34 35 46 45
		f 4 32 76 -3 -76
		mu 0 4 35 36 47 46
		f 4 33 77 -4 -77
		mu 0 4 36 37 48 47
		f 4 34 78 -5 -78
		mu 0 4 37 38 49 48
		f 4 35 79 -6 -79
		mu 0 4 38 39 50 49
		f 4 36 80 -7 -80
		mu 0 4 39 40 51 50
		f 4 37 81 -8 -81
		mu 0 4 40 41 52 51
		f 4 38 82 -9 -82
		mu 0 4 41 42 53 52
		f 4 39 83 -10 -83
		mu 0 4 42 43 54 53
		f 4 -84 -73 -62 -51
		mu 0 4 10 55 56 21
		f 4 73 40 51 62
		mu 0 4 57 0 11 58;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
select -ne :time1;
	setAttr ".o" 1;
	setAttr ".unw" 1;
select -ne :hardwareRenderingGlobals;
	setAttr ".otfna" -type "stringArray" 22 "NURBS Curves" "NURBS Surfaces" "Polygons" "Subdiv Surface" "Particles" "Particle Instance" "Fluids" "Strokes" "Image Planes" "UI" "Lights" "Cameras" "Locators" "Joints" "IK Handles" "Deformers" "Motion Trails" "Components" "Hair Systems" "Follicles" "Misc. UI" "Ornaments"  ;
	setAttr ".otfva" -type "Int32Array" 22 0 1 1 1 1 1
		 1 1 1 0 0 0 0 0 0 0 0 0
		 0 0 0 0 ;
	setAttr ".fprt" yes;
select -ne :renderPartition;
	setAttr -s 2 ".st";
select -ne :renderGlobalsList1;
select -ne :defaultShaderList1;
	setAttr -s 4 ".s";
select -ne :postProcessList1;
	setAttr -s 2 ".p";
select -ne :defaultRenderingList1;
select -ne :initialShadingGroup;
	setAttr -s 5 ".dsm";
	setAttr ".ro" yes;
select -ne :initialParticleSE;
	setAttr ".ro" yes;
select -ne :defaultRenderGlobals;
	setAttr ".ren" -type "string" "arnold";
select -ne :defaultResolution;
	setAttr ".pa" 1;
select -ne :hardwareRenderGlobals;
	setAttr ".ctrs" 256;
	setAttr ".btrs" 512;
select -ne :ikSystem;
	setAttr -s 4 ".sol";
connectAttr "pCubeShape4.iog" ":initialShadingGroup.dsm" -na;
// End of Land4.ma
