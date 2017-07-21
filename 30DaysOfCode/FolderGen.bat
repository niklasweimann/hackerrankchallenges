@echo off
set "Folder=G:\Programmieren\Projekte\HackerRankChallenges\30DaysOfCode"
if not exist "%Folder%" (
    md "%Folder%"
    goto EndBatch
)
for /L %%N in (1 1 65534) do (
    if not exist "Day %%N" (
        md "Day %%N"
        goto EndBatch
    )
)
:EndBatch
set "Folder="