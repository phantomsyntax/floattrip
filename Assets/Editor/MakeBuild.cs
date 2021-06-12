﻿#if UNITY_EDITOR || UNITY_EDITOR_64
using UnityEditor;
#endif
using UnityEditor.Build.Reporting;
using UnityEngine;

public class MakeBuild : MonoBehaviour {
    private static readonly string[] SceneArray = {
        "Assets/PhantomSyntax/Scenes/03_TheConstruct/03_TheConstruct.unity",
        "Assets/PhantomSyntax/Scenes/04_ButtercupCreek/04_ButtercupCreek.unity"};
    
    [MenuItem("Build/Standalone Linux x64")]
    static void Linux() {
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = SceneArray;
        // TODO: pull project/title name by code
        buildPlayerOptions.locationPathName = "Builds/Linux/FloatTrip";
        buildPlayerOptions.target = BuildTarget.StandaloneLinux64;
        buildPlayerOptions.options = BuildOptions.None;

        BuildReport report = BuildPipeline.BuildPlayer(buildPlayerOptions);
        BuildSummary summary = report.summary;
        
        if (summary.result == BuildResult.Succeeded) {
            Debug.Log("Build succeeded: " + summary.totalSize + " bytes");
        }

        if (summary.result == BuildResult.Failed) {
            Debug.Log("Build failed");
            foreach (var buildStep in report.steps) {
                Debug.Log(buildStep.ToString());
            }
        }
    }

    [MenuItem("Build/Standalone Windows x64")]
    static void Windows() {
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = SceneArray;
        buildPlayerOptions.locationPathName = "Builds/Windows/FloatTrip.exe";
        buildPlayerOptions.target = BuildTarget.StandaloneWindows64;
        buildPlayerOptions.options = BuildOptions.None;

        BuildReport report = BuildPipeline.BuildPlayer(buildPlayerOptions);
        BuildSummary summary = report.summary;

        if (summary.result == BuildResult.Succeeded) {
            Debug.Log("Build succeeded: " + summary.totalSize + " bytes");
        }

        if (summary.result == BuildResult.Failed) {
            Debug.Log("Build failed");
            foreach (var buildStep in report.steps) {
                Debug.Log(buildStep.ToString());
            }
        }
    }
}