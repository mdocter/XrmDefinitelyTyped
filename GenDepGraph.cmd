powershell "packages\FAKE\tools\FAKE.exe build.fsx -dg | & 'C:/Program Files (x86)/Graphviz2.38/bin/dot.exe' -Tpng -o ./graph.png"