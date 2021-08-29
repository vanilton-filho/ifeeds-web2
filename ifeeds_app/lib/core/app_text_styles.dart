import 'package:flutter/material.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:ifeeds_app/core/app_colors.dart';

class AppTextStyles {
  static final TextStyle heading1 = GoogleFonts.titilliumWeb(
    color: AppColors.heading1,
    fontStyle: FontStyle.normal,
    fontWeight: FontWeight.bold,
    fontSize: 50,
  );
  static final TextStyle heading2 = GoogleFonts.titilliumWeb(
    color: AppColors.heading1,
    fontStyle: FontStyle.normal,
    fontWeight: FontWeight.bold,
    fontSize: 36,
  );

  static final TextStyle button = GoogleFonts.sourceSansPro(
    color: Colors.white,
    fontStyle: FontStyle.normal,
    fontWeight: FontWeight.w900,
    fontSize: 18,
  );

  static final TextStyle normal = GoogleFonts.sourceSansPro(
    color: AppColors.normal,
    fontStyle: FontStyle.normal,
    fontWeight: FontWeight.w400,
    fontSize: 18,
  );

  static final TextStyle tile = GoogleFonts.sourceSansPro(
    color: AppColors.normal,
    fontStyle: FontStyle.normal,
    fontWeight: FontWeight.w400,
    fontSize: 20,
  );

  static final TextStyle normal2 = GoogleFonts.roboto(
    color: AppColors.normal,
    fontStyle: FontStyle.normal,
    fontWeight: FontWeight.w400,
    fontSize: 21,
  );

  static final TextStyle categoria = GoogleFonts.titilliumWeb(
    color: AppColors.normal2,
    fontStyle: FontStyle.normal,
    fontWeight: FontWeight.w700,
    fontSize: 36,
  );

  static final TextStyle categoria2 = GoogleFonts.titilliumWeb(
    color: Colors.black,
    fontStyle: FontStyle.normal,
    fontWeight: FontWeight.w700,
    fontSize: 18,
  );

  static final TextStyle link = GoogleFonts.sourceSansPro(
    color: AppColors.link,
    fontStyle: FontStyle.normal,
    fontWeight: FontWeight.w400,
    fontSize: 18,
  );
}
