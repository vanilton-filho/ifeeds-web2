import 'package:flutter/material.dart';
import 'package:flutter_rating_bar/flutter_rating_bar.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:ifeeds_app/core/app_colors.dart';
import 'package:ifeeds_app/core/app_text_styles.dart';

class TileWidget extends StatefulWidget {
  final double? marginRight;

  const TileWidget({
    Key? key,
    this.marginRight,
  }) : super(key: key);

  @override
  _TileWidgetState createState() => _TileWidgetState();
}

class _TileWidgetState extends State<TileWidget> {
  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: const EdgeInsets.symmetric(horizontal: 12.0, vertical: 4.0),
      child: Card(
        margin: EdgeInsets.only(
            right: widget.marginRight == null ? 0 : widget.marginRight!),
        elevation: 5,
        shape: RoundedRectangleBorder(
            borderRadius: BorderRadius.only(
                topLeft: Radius.circular(25), bottomLeft: Radius.circular(25))),
        child: InkWell(
          onTap: () => _showModal(),
          child: ClipPath(
            clipper: ShapeBorderClipper(
                shape: RoundedRectangleBorder(
                    borderRadius: BorderRadius.only(
                        topLeft: Radius.circular(25),
                        bottomLeft: Radius.circular(25)))),
            child: Container(
                height: 180,
                decoration: BoxDecoration(
                  border: Border(
                    left: BorderSide(
                        color: AppColors.primarySwatch[500]!, width: 24),
                  ),
                ),
                padding: EdgeInsets.all(20.0),
                alignment: Alignment.centerLeft,
                child: Container(
                  child: Row(
                    children: [
                      Expanded(
                          flex: 3,
                          child: Column(
                            crossAxisAlignment: CrossAxisAlignment.start,
                            mainAxisAlignment: MainAxisAlignment.center,
                            children: [
                              Padding(
                                padding: const EdgeInsets.only(bottom: 14.0),
                                child: Text(
                                  'TKSDHFJKSDHJKFHDSJKHFJKDSHKJDHGJKHFDJKGHKJFDHGKKKKKK',
                                  style: AppTextStyles.normal2.merge(TextStyle(
                                      fontWeight: FontWeight.bold,
                                      fontSize: 20)),
                                ),
                              ),
                              Text(
                                'AwQerqbasTs5hXasa6789',
                                style: AppTextStyles.normal2
                                    .merge(TextStyle(fontSize: 14)),
                              ),
                            ],
                          )),
                      Expanded(
                        flex: 2,
                        child: Padding(
                          padding: const EdgeInsets.symmetric(horizontal: 12.0),
                          child: Column(
                            crossAxisAlignment: CrossAxisAlignment.end,
                            mainAxisAlignment: MainAxisAlignment.center,
                            children: [
                              Padding(
                                padding: const EdgeInsets.only(bottom: 15.0),
                                child: Row(
                                  mainAxisAlignment: MainAxisAlignment.end,
                                  crossAxisAlignment: CrossAxisAlignment.center,
                                  children: [
                                    Padding(
                                      padding: const EdgeInsets.all(8.0),
                                      child: Icon(
                                        Icons.star,
                                        color: Colors.amber,
                                      ),
                                    ),
                                    Text(
                                      '4.2',
                                      style: AppTextStyles.normal2.merge(
                                        TextStyle(
                                          fontSize: 27,
                                        ),
                                      ),
                                    )
                                  ],
                                ),
                              ),
                              Text('18/07/2020',
                                  style: AppTextStyles.normal2
                                      .merge(TextStyle(fontSize: 16))),
                            ],
                          ),
                        ),
                      ),
                    ],
                  ),
                )),
          ),
        ),
      ),
    );
  }

  _showModal() async {
    // String? response = formRating.response;
    // String dataCriacao =
    //     DateFormat('dd-MM-yyyy HH:mm').format(formRating.creationDate!);

    // String? dataAtualizacao = formRating.updateDate == null
    //     ? null
    //     : DateFormat('dd-MM-yyyy HH:mm').format(formRating.updateDate!);

    await showModalBottomSheet(
        isDismissible: true,
        isScrollControlled: true,
        context: context,
        builder: (context) {
          return Container(
            height: 600,
            child: Padding(
              padding: const EdgeInsets.only(top: 50.0),
              child: SingleChildScrollView(
                child: Column(
                  crossAxisAlignment: CrossAxisAlignment.center,
                  children: [
                    Padding(
                      padding: const EdgeInsets.all(8.0),
                      child: RatingBar.builder(
                        itemSize: 42,
                        initialRating: 4.5,
                        direction: Axis.horizontal,
                        allowHalfRating: true,
                        itemCount: 5,
                        itemPadding: EdgeInsets.symmetric(horizontal: 4.0),
                        itemBuilder: (context, _) => Icon(
                          Icons.star_rounded,
                          color: Colors.amber,
                        ),
                        ignoreGestures: true,
                        onRatingUpdate: (_) => {},
                      ),
                    ),
                    Text(
                      '4.5',
                      style: GoogleFonts.robotoCondensed(
                        fontSize: 23.0,
                        fontWeight: FontWeight.bold,
                      ),
                    ),
                    Padding(
                      padding: const EdgeInsets.all(16.0),
                      child: Wrap(
                        children: [
                          Text(
                            'Descrição do feedback dada pelo usuário',
                            style: GoogleFonts.roboto(fontSize: 21.0),
                            textAlign: TextAlign.center,
                          ),
                        ],
                      ),
                    ),
                    Padding(
                      padding: const EdgeInsets.only(top: 12.0),
                      child: Text(
                        'Campus Lagarto',
                        style: GoogleFonts.roboto(),
                      ),
                    ),
                    Padding(
                      padding: const EdgeInsets.all(12.0),
                      child: Text(
                        'Data de criação 01/01/2000',
                        style: GoogleFonts.roboto(color: Colors.grey),
                      ),
                    ),
                    Padding(
                      padding: const EdgeInsets.symmetric(horizontal: 27.0),
                      child: Divider(
                        thickness: 1,
                      ),
                    ),
                    Padding(
                        padding: const EdgeInsets.only(top: 23.0),
                        child: Text(
                          'Resposta',
                          style: GoogleFonts.roboto(fontSize: 20.0),
                        )),
                    Padding(
                      padding: const EdgeInsets.all(12.0),
                      child: Text(
                        'Nenhuma resposta até o momento...',
                        style: GoogleFonts.roboto(
                            fontSize: 14.0, color: Colors.grey),
                      ),
                    ),
                  ],
                ),
              ),
            ),
          );
        },
        shape: RoundedRectangleBorder(
          borderRadius: BorderRadius.only(
              topLeft: Radius.circular(42.0), topRight: Radius.circular(42.0)),
        ));
  }
}
