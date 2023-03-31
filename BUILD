load("//java/com/google/android/gmscore/tools/sdk/libwrapper/automation:libwrapper.bzl", "libwrapper_cs")
load("//java/com/google/android/gmscore/tools/sdk/libwrapper/automation:unity_package.bzl", "unity_package")

libwrapper_cs(
    name = "java_cs",
    filter_block_path = ":blocklist.txt",
    jar_paths = [
        "//third_party/library_wrapper/public/libraries/openjdk8:java_lang",
        "//third_party/library_wrapper/public/libraries/openjdk8:java_util",
    ],
    namespace = "Java",
)

unity_package(
    name = "com.google.librarywrapper.openjdk8",
    files = glob(
        ["**"],
        exclude = [
            "BUILD",
            "blocklist.txt",
        ],
    ) + [":java_cs"],
)
