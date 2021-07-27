USE `dbrestapp`;

CREATE TABLE `users` (
	`id` INT(11) NOT NULL AUTO_INCREMENT,
	`first_name` VARCHAR(50) NOT NULL DEFAULT '0',
	`last_name` VARCHAR(120) NOT NULL DEFAULT '0',
	`email` VARCHAR(50) NOT NULL DEFAULT '0',
	`password` VARCHAR(130) NOT NULL DEFAULT '0',
	`refresh_token` VARCHAR(500) NULL DEFAULT '0',
	`refresh_token_expiry_time` DATETIME NULL DEFAULT NULL,
	PRIMARY KEY (`id`),
	UNIQUE `email` (`email`)
)
ENGINE=InnoDB DEFAULT CHARSET=latin1;