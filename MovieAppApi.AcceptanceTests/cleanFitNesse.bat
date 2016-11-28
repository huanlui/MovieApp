CD %~dp0
erase *.zip /S

set ERROR_LOGS="%~dp0%1%FitNesseRoot\ErrorLogs"

echo Se borran los directorios de %ERROR_LOGS%
rmdir %ERROR_LOGS% /S /Q

echo Se crea el directorio %ERROR_LOGS%
md %ERROR_LOGS%

set RECENT_CHANGES="%~dp0%1%FitNesseRoot\RecentChanges"

echo Se borran los directorios de %RECENT_CHANGES%
rmdir %RECENT_CHANGES% /S /Q

echo Se crea el directorio %RECENT_CHANGES%
md %RECENT_CHANGES%

set TEST_PROGRESS="%~dp0%1%FitNesseRoot\files\testProgress"

echo Se borran todos los ficheros %TEST_PROGRESS%
rmdir %TEST_PROGRESS% /S /Q

echo Se crea el directorio %TEST_PROGRESS%
md %TEST_PROGRESS%

set TEST_RESULT="%~dp0%1%FitNesseRoot\files\testResults"

echo Se borran todos los ficheros %TEST_RESULT%
rmdir %TEST_RESULT% /S /Q

echo Se crea el directorio %TEST_RESULT%
md %TEST_RESULT%

