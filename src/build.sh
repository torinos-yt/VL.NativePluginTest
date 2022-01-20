echo "\033[32mbuild native plugins\033[m"
cd `dirname $0`
cd native
make
echo ""

echo "\033[32mbuild managed plugins\033[m"
cd ../
dotnet.exe build -c release -o ../lib/netstanderd2.0