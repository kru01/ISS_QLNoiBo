<a name="readme-top"></a>

# ISS - QLNoiBo and Oracle

-   Group project from HCMUS's 2024 Data Security in Information Systems course.

## Usage

### To set up the database

1. Well, good luck setting up `Oracle Database 21c Express Edition`.
1. [Have a `PDB` and enable `OLS`](#to-enable-ols).
1. Navigate into `SQL` folder.
1. If a different `PDB` is used, replace all instances of `XEPDB1`.
1. Run the files in the specified order with `SYS.XEPDB1` login, `createDB.sql` &rarr; `data.sql` &rarr; `users.sql` &rarr; `policies.sql` &rarr; `ols.sql`.

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

## Meet The Team

<div align="center">
  <a href="https://github.com/phongan1x5"><img alt="phongan1x5" src="https://github.com/phongan1x5.png" width="60px" height="auto"></a>&nbsp;&nbsp;&nbsp;
  <a href="https://github.com/kru01"><img alt="kru01" src="https://github.com/kru01.png" width="60px" height="auto"></a>&nbsp;&nbsp;&nbsp;
  <a href="https://github.com/Uri2803"><img alt="Uri2803" src="https://github.com/Uri2803.png" width="60px" height="auto"></a>&nbsp;&nbsp;&nbsp;
  <a href="https://github.com/faithdanghuy"><img alt="faithdanghuy" src="https://github.com/faithdanghuy.png" width="60px" height="auto"></a>&nbsp;&nbsp;&nbsp;
</div>

<p align="right">(<a href="#readme-top">back to top</a>)</p>
