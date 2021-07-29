import 'package:flutter/material.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:ifeeds_app/core/app_colors.dart';
import 'package:ifeeds_app/core/app_text_styles.dart';

class ListCategoryWidget extends StatefulWidget {
  int? category;
  String? campus;

  ListCategoryWidget({this.category, this.campus});

  @override
  _ListCategoryWidgetState createState() => _ListCategoryWidgetState();
}

class _ListCategoryWidgetState extends State<ListCategoryWidget> {
  @override
  Widget build(BuildContext context) {
    return _buildCategoryList(context);
  }

  // Widget _buildCategory(BuildContext context, int category, String campus) {
  //   return StreamBuilder<QuerySnapshot>(
  //     stream: FirebaseFirestore.instance
  //         .collection('rating')
  //         .where('category', isEqualTo: category)
  //         .where('campus', isEqualTo: campus)
  //         .snapshots(),
  //     builder: (context, snapshot) {
  //       if (snapshot.hasData) {
  //         return _buildCategoryList(context, snapshot.data!.docs);
  //       } else if (snapshot.hasError) {
  //         return Center(
  //           child: Text('Erro'),
  //         );
  //       }
  //       return Row(
  //         mainAxisAlignment: MainAxisAlignment.center,
  //         crossAxisAlignment: CrossAxisAlignment.center,
  //         children: [
  //           CircularProgressIndicator(),
  //         ],
  //       );
  //     },
  //   );
  // }

  _buildCategoryList(BuildContext contex) {
    return Container(
      child: Column(
        children: [
          Align(
            alignment: Alignment.centerLeft,
            child: Padding(
              padding: const EdgeInsets.symmetric(horizontal: 21.0),
              child: Text(
                _getCategoryName(),
                style: AppTextStyles.categoria,
              ),
            ),
          ),
          Divider(),
          Expanded(
            child: ListView(scrollDirection: Axis.horizontal, children: [
              Card(
                child: Padding(
                  padding: const EdgeInsets.all(8.0),
                  child: SizedBox(
                    height: 350,
                    width: 300,
                    child: InkWell(
                      hoverColor: AppColors.primarySwatch[50],
                      splashColor: AppColors.primarySwatch[300],
                      onTap: () => {},
                      child: Column(
                        children: [
                          Padding(
                            padding: EdgeInsets.all(3.0),
                            child: Container(
                              color: Colors.blue,
                              height: 100,
                            ),
                          ),
                          Padding(
                            padding: EdgeInsets.all(3.0),
                            child: Row(
                              children: [
                                Expanded(
                                  child: Column(
                                    crossAxisAlignment:
                                        CrossAxisAlignment.start,
                                    children: [
                                      Padding(
                                          padding: const EdgeInsets.all(5.0),
                                          child: Text(
                                              'Avaliação ou Sub-categoria segundo Kaiki',
                                              style: AppTextStyles.categoria2)),
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
                                        'teste',
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
                        ],
                      ),
                    ),
                  ),
                ),
              ),
              Card(
                child: Padding(
                  padding: const EdgeInsets.all(8.0),
                  child: SizedBox(
                    height: 350,
                    width: 300,
                    child: InkWell(
                      hoverColor: AppColors.primarySwatch[50],
                      splashColor: AppColors.primarySwatch[300],
                      onTap: () => {},
                      child: Column(
                        children: [
                          Padding(
                            padding: EdgeInsets.all(3.0),
                            child: Container(
                              color: Colors.blue,
                              height: 100,
                            ),
                          ),
                          Padding(
                            padding: EdgeInsets.all(3.0),
                            child: Row(
                              children: [
                                Expanded(
                                  child: Column(
                                    crossAxisAlignment:
                                        CrossAxisAlignment.start,
                                    children: [
                                      Padding(
                                          padding: const EdgeInsets.all(5.0),
                                          child: Text(
                                              'Avaliação ou Sub-categoria segundo Kaiki',
                                              style: AppTextStyles.categoria2)),
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
                                        'teste',
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
                        ],
                      ),
                    ),
                  ),
                ),
              ),
              Card(
                child: Padding(
                  padding: const EdgeInsets.all(8.0),
                  child: SizedBox(
                    height: 350,
                    width: 300,
                    child: InkWell(
                      hoverColor: AppColors.primarySwatch[50],
                      splashColor: AppColors.primarySwatch[300],
                      onTap: () => {},
                      child: Column(
                        children: [
                          Padding(
                            padding: EdgeInsets.all(3.0),
                            child: Container(
                              color: Colors.blue,
                              height: 100,
                            ),
                          ),
                          Padding(
                            padding: EdgeInsets.all(3.0),
                            child: Row(
                              children: [
                                Expanded(
                                  child: Column(
                                    crossAxisAlignment:
                                        CrossAxisAlignment.start,
                                    children: [
                                      Padding(
                                          padding: const EdgeInsets.all(5.0),
                                          child: Text(
                                              'Avaliação ou Sub-categoria segundo Kaiki',
                                              style: AppTextStyles.categoria2)),
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
                                        'teste',
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
                        ],
                      ),
                    ),
                  ),
                ),
              ),
              Card(
                child: Padding(
                  padding: const EdgeInsets.all(8.0),
                  child: SizedBox(
                    height: 350,
                    width: 300,
                    child: InkWell(
                      hoverColor: AppColors.primarySwatch[50],
                      splashColor: AppColors.primarySwatch[300],
                      onTap: () => {},
                      child: Column(
                        children: [
                          Padding(
                            padding: EdgeInsets.all(3.0),
                            child: Container(
                              color: Colors.blue,
                              height: 100,
                            ),
                          ),
                          Padding(
                            padding: EdgeInsets.all(3.0),
                            child: Row(
                              children: [
                                Expanded(
                                  child: Column(
                                    crossAxisAlignment:
                                        CrossAxisAlignment.start,
                                    children: [
                                      Padding(
                                          padding: const EdgeInsets.all(5.0),
                                          child: Text(
                                              'Avaliação ou Sub-categoria segundo Kaiki',
                                              style: AppTextStyles.categoria2)),
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
                                        'teste',
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
                        ],
                      ),
                    ),
                  ),
                ),
              ),
              Card(
                child: Padding(
                  padding: const EdgeInsets.all(8.0),
                  child: SizedBox(
                    height: 350,
                    width: 300,
                    child: InkWell(
                      hoverColor: AppColors.primarySwatch[50],
                      splashColor: AppColors.primarySwatch[300],
                      onTap: () => {},
                      child: Column(
                        children: [
                          Padding(
                            padding: EdgeInsets.all(3.0),
                            child: Container(
                              color: Colors.blue,
                              height: 100,
                            ),
                          ),
                          Padding(
                            padding: EdgeInsets.all(3.0),
                            child: Row(
                              children: [
                                Expanded(
                                  child: Column(
                                    crossAxisAlignment:
                                        CrossAxisAlignment.start,
                                    children: [
                                      Padding(
                                          padding: const EdgeInsets.all(5.0),
                                          child: Text(
                                              'Avaliação ou Sub-categoria segundo Kaiki',
                                              style: AppTextStyles.categoria2)),
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
                                        'teste',
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
                        ],
                      ),
                    ),
                  ),
                ),
              ),
              Card(
                child: Padding(
                  padding: const EdgeInsets.all(8.0),
                  child: SizedBox(
                    height: 350,
                    width: 300,
                    child: InkWell(
                      hoverColor: AppColors.primarySwatch[50],
                      splashColor: AppColors.primarySwatch[300],
                      onTap: () => {},
                      child: Column(
                        children: [
                          Padding(
                            padding: EdgeInsets.all(3.0),
                            child: Container(
                              color: Colors.blue,
                              height: 100,
                            ),
                          ),
                          Padding(
                            padding: EdgeInsets.all(3.0),
                            child: Row(
                              children: [
                                Expanded(
                                  child: Column(
                                    crossAxisAlignment:
                                        CrossAxisAlignment.start,
                                    children: [
                                      Padding(
                                          padding: const EdgeInsets.all(5.0),
                                          child: Text(
                                              'Avaliação ou Sub-categoria segundo Kaiki',
                                              style: AppTextStyles.categoria2)),
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
                                        'teste',
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
                        ],
                      ),
                    ),
                  ),
                ),
              ),
              Card(
                child: Padding(
                  padding: const EdgeInsets.all(8.0),
                  child: SizedBox(
                    height: 350,
                    width: 300,
                    child: InkWell(
                      hoverColor: AppColors.primarySwatch[50],
                      splashColor: AppColors.primarySwatch[300],
                      onTap: () => {},
                      child: Column(
                        children: [
                          Padding(
                            padding: EdgeInsets.all(3.0),
                            child: Container(
                              color: Colors.blue,
                              height: 100,
                            ),
                          ),
                          Padding(
                            padding: EdgeInsets.all(3.0),
                            child: Row(
                              children: [
                                Expanded(
                                  child: Column(
                                    crossAxisAlignment:
                                        CrossAxisAlignment.start,
                                    children: [
                                      Padding(
                                          padding: const EdgeInsets.all(5.0),
                                          child: Text(
                                              'Avaliação ou Sub-categoria segundo Kaiki',
                                              style: AppTextStyles.categoria2)),
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
                                        'teste',
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
                        ],
                      ),
                    ),
                  ),
                ),
              ),
              Card(
                child: Padding(
                  padding: const EdgeInsets.all(8.0),
                  child: SizedBox(
                    height: 350,
                    width: 300,
                    child: InkWell(
                      hoverColor: AppColors.primarySwatch[50],
                      splashColor: AppColors.primarySwatch[300],
                      onTap: () => {},
                      child: Column(
                        children: [
                          Padding(
                            padding: EdgeInsets.all(3.0),
                            child: Container(
                              color: Colors.blue,
                              height: 100,
                            ),
                          ),
                          Padding(
                            padding: EdgeInsets.all(3.0),
                            child: Row(
                              children: [
                                Expanded(
                                  child: Column(
                                    crossAxisAlignment:
                                        CrossAxisAlignment.start,
                                    children: [
                                      Padding(
                                          padding: const EdgeInsets.all(5.0),
                                          child: Text(
                                              'Avaliação ou Sub-categoria segundo Kaiki',
                                              style: AppTextStyles.categoria2)),
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
                                        'teste',
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
                        ],
                      ),
                    ),
                  ),
                ),
              ),
              Card(
                child: Padding(
                  padding: const EdgeInsets.all(8.0),
                  child: SizedBox(
                    height: 350,
                    width: 300,
                    child: InkWell(
                      hoverColor: AppColors.primarySwatch[50],
                      splashColor: AppColors.primarySwatch[300],
                      onTap: () => {},
                      child: Column(
                        children: [
                          Padding(
                            padding: EdgeInsets.all(3.0),
                            child: Container(
                              color: Colors.blue,
                              height: 100,
                            ),
                          ),
                          Padding(
                            padding: EdgeInsets.all(3.0),
                            child: Row(
                              children: [
                                Expanded(
                                  child: Column(
                                    crossAxisAlignment:
                                        CrossAxisAlignment.start,
                                    children: [
                                      Padding(
                                          padding: const EdgeInsets.all(5.0),
                                          child: Text(
                                              'Avaliação ou Sub-categoria segundo Kaiki',
                                              style: AppTextStyles.categoria2)),
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
                                        'teste',
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
                        ],
                      ),
                    ),
                  ),
                ),
              ),
              Card(
                child: Padding(
                  padding: const EdgeInsets.all(8.0),
                  child: SizedBox(
                    height: 350,
                    width: 300,
                    child: InkWell(
                      hoverColor: AppColors.primarySwatch[50],
                      splashColor: AppColors.primarySwatch[300],
                      onTap: () => {},
                      child: Column(
                        children: [
                          Padding(
                            padding: EdgeInsets.all(3.0),
                            child: Container(
                              color: Colors.blue,
                              height: 100,
                            ),
                          ),
                          Padding(
                            padding: EdgeInsets.all(3.0),
                            child: Row(
                              children: [
                                Expanded(
                                  child: Column(
                                    crossAxisAlignment:
                                        CrossAxisAlignment.start,
                                    children: [
                                      Padding(
                                          padding: const EdgeInsets.all(5.0),
                                          child: Text(
                                              'Avaliação ou Sub-categoria segundo Kaiki',
                                              style: AppTextStyles.categoria2)),
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
                                        'teste',
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
                        ],
                      ),
                    ),
                  ),
                ),
              ),
              Card(
                child: Padding(
                  padding: const EdgeInsets.all(8.0),
                  child: SizedBox(
                    height: 350,
                    width: 300,
                    child: InkWell(
                      hoverColor: AppColors.primarySwatch[50],
                      splashColor: AppColors.primarySwatch[300],
                      onTap: () => {},
                      child: Column(
                        children: [
                          Padding(
                            padding: EdgeInsets.all(3.0),
                            child: Container(
                              color: Colors.blue,
                              height: 100,
                            ),
                          ),
                          Padding(
                            padding: EdgeInsets.all(3.0),
                            child: Row(
                              children: [
                                Expanded(
                                  child: Column(
                                    crossAxisAlignment:
                                        CrossAxisAlignment.start,
                                    children: [
                                      Padding(
                                          padding: const EdgeInsets.all(5.0),
                                          child: Text(
                                              'Avaliação ou Sub-categoria segundo Kaiki',
                                              style: AppTextStyles.categoria2)),
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
                                        'teste',
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
                        ],
                      ),
                    ),
                  ),
                ),
              ),
            ]),
          ),
        ],
      ),
    );
  }

  _getCategoryName() {
    if (this.widget.category == 1) {
      return 'Infraestrutura';
    } else if (this.widget.category == 2) {
      return 'Serviços';
    } else if (this.widget.category == 3) {
      return 'Eventos';
    }
  }
}
