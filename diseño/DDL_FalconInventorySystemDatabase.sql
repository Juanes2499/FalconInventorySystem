-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema FalconInventorySystem_ER
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema FalconInventorySystem_ER
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `FalconInventorySystem_ER` DEFAULT CHARACTER SET utf8 ;
USE `FalconInventorySystem_ER` ;

-- -----------------------------------------------------
-- Table `FalconInventorySystem_ER`.`Supplier`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `FalconInventorySystem_ER`.`Supplier` (
  `Id` INT NOT NULL,
  `Name` VARCHAR(100) NOT NULL,
  `Nit` VARCHAR(20) NOT NULL,
  `Address` VARCHAR(100) NOT NULL,
  `Phone` VARCHAR(20) NOT NULL,
  `Email` VARCHAR(100) NOT NULL,
  PRIMARY KEY (`Id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `FalconInventorySystem_ER`.`PurchaseOrder`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `FalconInventorySystem_ER`.`PurchaseOrder` (
  `Id` INT NOT NULL,
  `NumberOrder` VARCHAR(20) NOT NULL,
  `DateDelivered` DATE NOT NULL,
  `IdSupplier` INT NULL,
  `Observation` VARCHAR(500) NULL,
  `Taxes` DOUBLE NULL,
  PRIMARY KEY (`Id`),
  INDEX `FK_Supplier_PurchaseOrder_idx` (`IdSupplier` ASC) VISIBLE,
  CONSTRAINT `FK_Supplier_PurchaseOrder`
    FOREIGN KEY (`IdSupplier`)
    REFERENCES `FalconInventorySystem_ER`.`Supplier` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `FalconInventorySystem_ER`.`Brand`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `FalconInventorySystem_ER`.`Brand` (
  `Id` INT NOT NULL,
  `Name` VARCHAR(50) NOT NULL,
  PRIMARY KEY (`Id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `FalconInventorySystem_ER`.`Category`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `FalconInventorySystem_ER`.`Category` (
  `Id` INT NOT NULL,
  `Name` VARCHAR(50) NOT NULL,
  PRIMARY KEY (`Id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `FalconInventorySystem_ER`.`Product`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `FalconInventorySystem_ER`.`Product` (
  `Id` INT NOT NULL,
  `Name` VARCHAR(50) NOT NULL,
  `Description` VARCHAR(500) NULL,
  `IdBrand` INT NOT NULL,
  `IdCategory` INT NOT NULL,
  PRIMARY KEY (`Id`),
  INDEX `FK_Brand_Product_idx` (`IdBrand` ASC) VISIBLE,
  INDEX `FK_Category_Product_idx` (`IdCategory` ASC) VISIBLE,
  CONSTRAINT `FK_Brand_Product`
    FOREIGN KEY (`IdBrand`)
    REFERENCES `FalconInventorySystem_ER`.`Brand` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_Category_Product`
    FOREIGN KEY (`IdCategory`)
    REFERENCES `FalconInventorySystem_ER`.`Category` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `FalconInventorySystem_ER`.`PurchaseOrderItems`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `FalconInventorySystem_ER`.`PurchaseOrderItems` (
  `Id` INT NOT NULL,
  `IdProduct` INT NULL,
  `Deadline` DATE NULL,
  `Amount` INT NOT NULL,
  `UnitValue` DOUBLE NOT NULL,
  `IdPurchaseOrder` INT NOT NULL,
  PRIMARY KEY (`Id`),
  INDEX `FK_PurchaseOrderItem_PurchaseOrder_idx` (`IdPurchaseOrder` ASC) VISIBLE,
  INDEX `FK_Product_PurchaseOrderItems_idx` (`IdProduct` ASC) VISIBLE,
  CONSTRAINT `FK_PurchaseOrder_PurchaseOrderItems`
    FOREIGN KEY (`IdPurchaseOrder`)
    REFERENCES `FalconInventorySystem_ER`.`PurchaseOrder` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_Product_PurchaseOrderItems`
    FOREIGN KEY (`IdProduct`)
    REFERENCES `FalconInventorySystem_ER`.`Product` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `FalconInventorySystem_ER`.`Warehouse`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `FalconInventorySystem_ER`.`Warehouse` (
  `Id` INT NOT NULL,
  `MaximunCapacity` DOUBLE NOT NULL,
  `MinimumCapacity` DOUBLE NOT NULL,
  `Observation` VARCHAR(500) NULL,
  PRIMARY KEY (`Id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `FalconInventorySystem_ER`.`Storage`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `FalconInventorySystem_ER`.`Storage` (
  `Id` INT NOT NULL,
  `IdPurchaseOrder` INT NOT NULL,
  `IdWarehouse` INT NOT NULL,
  `DateEntry` DATE NOT NULL,
  `Observation` VARCHAR(500) NULL,
  PRIMARY KEY (`Id`),
  INDEX `FK_PuchaseOrder_Storage_idx` (`IdPurchaseOrder` ASC) VISIBLE,
  INDEX `FK_Warehouse_Storage_idx` (`IdWarehouse` ASC) VISIBLE,
  CONSTRAINT `FK_PuchaseOrder_Storage`
    FOREIGN KEY (`IdPurchaseOrder`)
    REFERENCES `FalconInventorySystem_ER`.`PurchaseOrder` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_Warehouse_Storage`
    FOREIGN KEY (`IdWarehouse`)
    REFERENCES `FalconInventorySystem_ER`.`Warehouse` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `FalconInventorySystem_ER`.`BillOrder`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `FalconInventorySystem_ER`.`BillOrder` (
  `Id` INT NOT NULL,
  `DateOut` DATETIME NOT NULL,
  PRIMARY KEY (`Id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `FalconInventorySystem_ER`.`BillOrderItems`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `FalconInventorySystem_ER`.`BillOrderItems` (
  `Id` INT NOT NULL,
  `IdProduct` INT NOT NULL,
  `IdWarehouse` INT NOT NULL,
  `IdBillOrder` INT NOT NULL,
  `Amount` INT NOT NULL,
  PRIMARY KEY (`Id`),
  INDEX `FK_Warehouse_BillOrderItems_idx` (`IdWarehouse` ASC) VISIBLE,
  INDEX `FK_BillOrder_BillOrderItems_idx` (`IdBillOrder` ASC) VISIBLE,
  CONSTRAINT `FK_Warehouse_BillOrderItems`
    FOREIGN KEY (`IdWarehouse`)
    REFERENCES `FalconInventorySystem_ER`.`Warehouse` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_BillOrder_BillOrderItems`
    FOREIGN KEY (`IdBillOrder`)
    REFERENCES `FalconInventorySystem_ER`.`BillOrder` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
