<a name="readme-top"></a>

# ISS - QLNoiBo and Oracle

-   Group project from HCMUS's 2024 Data Security in Information Systems course.

-   Demo for Admin subsystem: [Demo ATBM CSDL trong HTTT 2024 - Phân hệ 1 - ATBM-A-01](https://youtu.be/Q9bQsbvNSeU).

## Usage

### To set up the database

1. Well, good luck setting up `Oracle Database 21c Express Edition`.
1. [Have a `PDB` and enable `OLS`](#to-enable-ols).
1. Navigate into `SQL` folder.
1. If a different `PDB` is used, replace all instances of `XEPDB1`.
1. `SYS.XEPDB1` Run the files in the specified order, `createDB.sql` &rarr; `data.sql` &rarr; `users.sql` &rarr; `policies.sql` &rarr; `ols.sql`.

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

## Meet The Team

<div align="center">
  <a href="https://github.com/phongan1x5"><img alt="phongan1x5" src="https://github.com/phongan1x5.png" width="60px" height="auto"></a>&nbsp;&nbsp;&nbsp;
  <a href="https://github.com/kru01"><img alt="kru01" src="https://github.com/kru01.png" width="60px" height="auto"></a>&nbsp;&nbsp;&nbsp;
  <a href="https://github.com/Uri2803"><img alt="Uri2803" src="https://github.com/Uri2803.png" width="60px" height="auto"></a>&nbsp;&nbsp;&nbsp;
  <a href="https://github.com/faithdanghuy"><img alt="faithdanghuy" src="https://github.com/faithdanghuy.png" width="60px" height="auto"></a>&nbsp;&nbsp;&nbsp;
</div>

<p align="right">(<a href="#readme-top">back to top</a>)</p>
