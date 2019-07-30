DO
$do$
BEGIN
   IF NOT EXISTS (
      SELECT
      FROM   pg_catalog.pg_roles
      WHERE  rolname = 'rider_user') THEN

      CREATE ROLE rider_user LOGIN PASSWORD 'rider_password';
      GRANT SELECT ON ALL TABLES IN SCHEMA public TO rider_user;
      ALTER ROLE rider_user WITH CREATEDB;
   END IF;
END
$do$;

CREATE EXTENSION pgcrypto;
