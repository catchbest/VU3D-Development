cd Samples\VC
for /d %%i in (*) do ( 
cd %%i
rd x86 x64 ipch /s /q
del *.sdf *.suo *.log *.filters *.ipch *.aps /s /a
cd..)
cd..

cd C#\KSJGigeVision3D_CSharpDemo
rd obj /s /q
del *.suo /s
