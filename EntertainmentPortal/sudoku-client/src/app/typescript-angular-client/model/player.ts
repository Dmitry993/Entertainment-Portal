/**
 * My Title
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */
import { AvatarIcon } from './avatarIcon';
import { Session } from './session';


export interface Player { 
  [key: string]: any | any;


    id: number;
    nickName?: string;
    experiencePoint: number;
    level: number;
    icon?: AvatarIcon;
    gameSession?: Session;
    userId: number;
}
