import 'package:flutter/material.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:ifeeds_app/core/app_colors.dart';
import 'package:ifeeds_app/core/app_text_styles.dart';
import 'package:ifeeds_app/models/avaliacao_model.dart';

class CardAvaliacaoWidget extends StatelessWidget {
  final AvaliacaoModel avaliacaoModel;

  const CardAvaliacaoWidget({
    Key? key,
    required this.avaliacaoModel,
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Card(
      elevation: 3,
      child: InkWell(
        hoverColor: AppColors.primarySwatch[50],
        onTap: () {},
        child: Padding(
          padding: const EdgeInsets.all(8.0),
          child: SizedBox(
            height: 350,
            width: 300,
            child: Column(
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                Padding(
                  padding: EdgeInsets.all(3.0),
                  child: Container(
                    color: Colors.blue,
                    height: 100, // altura da img ou icon
                  ),
                ),
                Expanded(
                  child: Padding(
                    padding: EdgeInsets.all(3.0),
                    child: Row(
                      children: [
                        Expanded(
                          child: Column(
                            crossAxisAlignment: CrossAxisAlignment.start,
                            children: [
                              Padding(
                                padding: const EdgeInsets.all(5.0),
                                child: Text(
                                  avaliacaoModel.titulo!,
                                  style: AppTextStyles.categoria2,
                                ),
                              ),
                            ],
                          ),
                        ),
                        Align(
                          alignment: Alignment.topCenter,
                          child: Column(
                            mainAxisAlignment: MainAxisAlignment.start,
                            children: [
                              IconTheme(
                                data: IconThemeData(
                                  color: Colors.amber,
                                  size: 25,
                                ),
                                child: Icon(
                                  Icons.star_rounded,
                                ),
                              ),
                              Text(
                                '${avaliacaoModel.mediaAvaliacao!}',
                                style: GoogleFonts.robotoMono(
                                  fontSize: 14,
                                  fontWeight: FontWeight.w300,
                                ),
                              ),
                            ],
                          ),
                        ),
                      ],
                    ),
                  ),
                ),
                Padding(
                  padding: const EdgeInsets.only(left: 10.0, bottom: 5),
                  child: Text(avaliacaoModel.campus!),
                )
              ],
            ),
          ),
        ),
      ),
    );
  }
}
