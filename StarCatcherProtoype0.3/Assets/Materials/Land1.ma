//Maya ASCII 2017 scene
//Name: Land1.ma
//Last modified: Sat, Oct 01, 2016 05:09:50 PM
//Codeset: 1252
requires maya "2017";
currentUnit -l centimeter -a degree -t film;
fileInfo "application" "maya";
fileInfo "product" "Maya 2017";
fileInfo "version" "2017";
fileInfo "cutIdentifier" "201606150345-997974";
fileInfo "osv" "Microsoft Windows 8 Home Premium Edition, 64-bit  (Build 9200)\n";
fileInfo "license" "student";
createNode transform -n "pCube1";
	rename -uid "A38BDE1B-4B55-B443-4DB2-F1897B875ED3";
	setAttr ".s" -type "double3" 25 10 4 ;
createNode mesh -n "pCubeShape1" -p "pCube1";
	rename -uid "C0BD8B72-4CDE-0002-C4A6-4AB9D782B7F6";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.59999990463256836 0.375 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 10 ".pt";
	setAttr ".pt[13]" -type "float3" 0.036915831 0.17378552 0 ;
	setAttr ".pt[16]" -type "float3" 0 0.11978638 0 ;
	setAttr ".pt[17]" -type "float3" 0 0.16372131 0 ;
	setAttr ".pt[19]" -type "float3" 0 0.2131215 0 ;
	setAttr ".pt[20]" -type "float3" 0 0.041017871 0 ;
	setAttr ".pt[24]" -type "float3" 0.036915831 0.17378552 0 ;
	setAttr ".pt[27]" -type "float3" 0 0.11978638 0 ;
	setAttr ".pt[28]" -type "float3" 0 0.16372131 0 ;
	setAttr ".pt[30]" -type "float3" 0 0.2131215 0 ;
	setAttr ".pt[31]" -type "float3" 0 0.041017871 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode polyCube -n "polyCube1";
	rename -uid "2E436283-49DE-A6E3-5DAA-BCBD16C4DFEA";
	setAttr ".sw" 10;
	setAttr ".cuv" 4;
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
connectAttr "polyCube1.out" "pCubeShape1.i";
connectAttr "pCubeShape1.iog" ":initialShadingGroup.dsm" -na;
// End of Land1.ma
