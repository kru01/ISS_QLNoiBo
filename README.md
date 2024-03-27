<a name="readme-top"></a>

# ISS - QLNoiBo and Oracle

-   Group project from HCMUS's 2024 Data Security in Information Systems course.

-   Demo for Admin subsystem: [Demo ATBM CSDL trong HTTT 2024 - Phân hệ 1 - ATBM-A-01](https://youtu.be/Q9bQsbvNSeU).

<details open>
  <summary>Table of Contents</summary>
  <ul>
    <li>
      <a href="#content">Content</a>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li>
      <a href="#usage">Usage</a>
      <ul>
        <li><a href="#to-set-up-the-database">To set up the database</a></li>
        <li><a href="#to-uninstall-the-database">To uninstall the database</a></li>
        <li><a href="#to-enable-ols">To enable OLS</a></li>
        <li><a href="#to-enable-unified-auditing">To enable Unified Auditing</a></li>
        <li><a href="#to-link-oracle-with-winforms">To link Oracle with WinForms</a></li>
      </ul>
    </li>
    <li><a href="#built-with">Built With</a></li>
    <li><a href="#meet-the-team">Meet The Team</a></li>
  </ul>
</details>

## Content

## Getting Started

### Prerequisites

-   Windows 10 or 11.
-   [Oracle Database 21c Express Edition](https://www.oracle.com/database/technologies/xe-downloads.html) and
    [SQL Developer 23.1.1](https://www.oracle.com/database/sqldeveloper/technologies/download/).
-   **_For WinForms development:_**

    -   [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) and its `.NET desktop development` workload.

-   _(Optional)_ Any decent code editor, preferably [VSCode](https://code.visualstudio.com/).
    -   It just makes editing the database's source code easier.

### Installation

-   Clone the repo.

## Usage

### To set up the database

1. Well, good luck setting up `Oracle Database 21c Express Edition`.
1. [Have a `PDB` and enable `OLS`](#to-enable-ols), and [`Unified Auditing`](#to-enable-unified-auditing).
1. Navigate into `SQL` folder.
1. If a different `PDB` is used, replace all instances of `XEPDB1`.
1. `SYS.XEPDB1` Run the files in the specified order, `createDB.sql` &rarr; `data.sql` &rarr; `policies.sql` &rarr; `ols.sql`.

### To uninstall the database

1. Run `cleanupDB.sql`.

### To enable OLS

1. The `XEPDB1`, created by Oracle Express during installation, was used. If you don't have it or desire another, then look into the hassle of making and configuring one.
1. `SYS.XEPDB1` Check if OLS is enabled.

    ```sql
    SELECT VALUE FROM V$OPTION WHERE PARAMETER = 'Oracle Label Security';
    SELECT STATUS FROM DBA_OLS_STATUS WHERE NAME = 'OLS_CONFIGURE_STATUS';
    ```

1. `SYS.XEPDB1` Register and enable OLS.

    ```sql
    EXEC LBACSYS.CONFIGURE_OLS;
    EXEC LBACSYS.OLS_ENFORCEMENT.ENABLE_OLS;
    ```

1. Restart the IDE/server/service.
    - Basically just close then open the program again.
1. `SYS.XE` Unlock `LBACSYS`, the OLS Admin.

    ```sql
    ALTER USER LBACSYS ACCOUNT UNLOCK IDENTIFIED BY your_password;
    ```

1. After `LBACSYS` has been unlocked, switch to any `PDB`, `XEPDB1` in my case, and go wild.
    - All the privileges an admin needs to effectively manage OLS can be found in `SQL/users.sql`.

### To enable Pure Unified Auditing

#### Windows

1. `SYS.XEPDB1` Check if Unified Auditing is enabled.

    ```sql
    SELECT VALUE FROM V$OPTION WHERE PARAMETER = 'Unified Auditing';
    ```

1. Open up Windows' Services, `Windows + R` &rarr; `services.msc`.
1. Stop Oracle's service and listener.
    - Should be similar to `OracleServiceXE` and `OracleOraDB21Home1TNSListener`.
1. Locate `orauniaud` with Windows File Explorer.
    - Just navigate to Oracle's folder then do a search.
    - Or manually, mine was in `...\Oracle21c\dbhomeXE\bin`.
1. Rename the file to `orauniaud.dll`.
    - Initially, it should have one of these formats, `orauniaud.dll.option`, `orauniaud.dll.dbl`, or the former two but with a version number right after `orauniaud`, e.g., `orauniaud12.dll.option`.
    - Might need to enable `Show File name extensions`.
1. Start Oracle's service and listener.

Alternatively, [Setup Unified Auditing in Oracle 19c in Windows OS - Bulent Soylu](https://youtu.be/vo3g_kAQM1E?si=gVRoRmi5TetTVfgQ).

#### UNIX

-   [Auditing Database Activity - Oracle Database Online Documentation 12c Release 1 (12.1) ](https://docs.oracle.com/database/121/TDPSG/GUID-BF747771-01D1-4BFB-8489-08988E1181F6.htm#TDPSG55281)

-   [Enabling Unified Auditing in Oracle 12c - IBM](https://www.ibm.com/docs/en/dsm?topic=record-enabling-unified-auditing-in-oracle-12c)

<p align="right">(<a href="#to-set-up-the-database">back to database set up</a>)</p>

### To link Oracle with WinForms

1. Open `ISS_QLNoiBo.sln` with Visual Studio 2022.
1. On the taskbar, select `Project` &rarr; `Manage NuGet Packages...`.
1. Move to `Browse` tab, search for `oracle`, and install `Oracle.ManagedDataAccess.Core`.
1. Try to run the program, if it still fails, proceed to step 5.
1. Locate the path to `Oracle.DataAccess.dll` with Windows File Explorer.
    - Mine was `...\Oracle21c\dbhomeXE\ODP.NET\bin\4`.
1. Back to VS2022, in the `Solution Explorer`, right-click `ISS_QLNoiBo`.
    - It's right beneath `Solution 'ISS_QLNoiBo' (1 of 1 project)`.
1. Select `Add` &rarr; `Project Reference...`.
1. Move to `Browse` tab, then click `Browse...` at bottom right of the window.
1. Navigate to the path at step 5.
1. Select `Oracle.DataAccess.dll` then `Add`.
    - Try to run the app, if it still fails, o7 then since I got mine to work at this point.

## Built With

[vsicon]: https://skillicons.dev/icons?i=visualstudio&theme=dark
[vsurl]: https://visualstudio.microsoft.com/vs/
[dotneticon]: https://skillicons.dev/icons?i=dotnet
[dotneturl]: https://dotnet.microsoft.com/en-us/download/dotnet/8.0
[oracleicon]: https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/oracle/oracle-original.svg
[oracleurl]: https://www.oracle.com/database/technologies/xe-downloads.html
[sqldevicon]: https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/sqldeveloper/sqldeveloper-original.svg
[sqldevurl]: https://www.oracle.com/database/sqldeveloper/technologies/download/
[vscodeicon]: https://skillicons.dev/icons?i=vscode&theme=dark
[vscodeurl]: https://code.visualstudio.com/
[windowsicon]: https://cdn.jsdelivr.net/gh/devicons/devicon/icons/windows8/windows8-original.svg
[windowsurl]: https://www.microsoft.com/en-us/windows/

| [![VisualStudio2022][vsicon]][vsurl] | [![.NET8.0][dotneticon]][dotneturl] | [![Oracle 21c Express][oracleicon]][oracleurl] | [![SQL Developer][sqldevicon]][sqldevurl] | [![VSCode][vscodeicon]][vscodeurl] | [![Windows][windowsicon]][windowsurl] |
| :----------------------------------: | :---------------------------------: | :--------------------------------------------: | :---------------------------------------: | :--------------------------------: | :-----------------------------------: |
|             2022 v17.9.4             |                 8.0                 |              21c Express Edition               |                23.1.1.345                 |               1.87.2               |     &nbsp;&nbsp; 11 &nbsp;&nbsp;      |

## Meet The Team

<div align="center">
  <a href="https://github.com/phongan1x5"><img alt="phongan1x5" src="https://github.com/phongan1x5.png" width="60px" height="auto"></a>&nbsp;&nbsp;&nbsp;
  <a href="https://github.com/kru01"><img alt="kru01" src="https://github.com/kru01.png" width="60px" height="auto"></a>&nbsp;&nbsp;&nbsp;
  <a href="https://github.com/Uri2803"><img alt="Uri2803" src="https://github.com/Uri2803.png" width="60px" height="auto"></a>&nbsp;&nbsp;&nbsp;
  <a href="https://github.com/faithdanghuy"><img alt="faithdanghuy" src="https://github.com/faithdanghuy.png" width="60px" height="auto"></a>&nbsp;&nbsp;&nbsp;
</div>

<p align="right">(<a href="#readme-top">back to top</a>)</p>
