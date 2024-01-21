function CreateMonthAndProjectCountChartOptions(MonthAndProjectCount) {
    var chartData = {
        series: [{
            name: 'Брой проекти',
            data: MonthAndProjectCount.map(function (item) { return item.projectCount; })
        }],
        xaxis: {
            categories: MonthAndProjectCount.map(function (item) { return item.monthName; })
        }
    };

    var chartOptions = {
        chart: {
            type: 'bar',
            height: 350,        
        },
        colors: ['#008FFB'],
        series: chartData.series,
        xaxis: chartData.xaxis
    };
    return chartOptions;
}

function CreateMonthAndProjectPriceSumChartOptions(MonthAndProjectCount) {
    var chartData = {
        series: [{
            name: 'Брой проекти',
            data: MonthAndProjectCount.map(function (item) { return item.price;})
        }],
        xaxis: {
            categories: MonthAndProjectCount.map(function (item) { return item.monthName; })
        }
    };

    var chartOptions = {
        chart: {
            type: 'bar',
            height: 350,
        },
        colors: ['#008FFB'],
        series: chartData.series,
        xaxis: chartData.xaxis
    };
    return chartOptions;
}

function CreatePieChartForTaskTypes(TypeProjectCountData) {
    var PieData = {
        series: [TypeProjectCountData.map(function (item) { return item.projectCount; })],
        labels: [TypeProjectCountData.map(function (item) { return item.type; })]
    };

    var PieOptions = {
        series: PieData.series.join(',').split(',').map(Number),
        chart: {
            width: '100%',
            type: 'pie',
        },
        labels: PieData.labels.join(',').split(','),
        theme: {
            monochrome: {
                enabled: true
            }
        },
        plotOptions: {
            pie: {
                dataLabels: {
                    offset: -5
                }
            }
        },
        dataLabels: {
            formatter(val, opts) {
                const name = opts.w.globals.labels[opts.seriesIndex]
                return [name, val.toFixed(1) + '%']
            }
        },
        legend: {
            show: true
        }
    };
    return PieOptions;
}

function ChangeMinWidth(count) {
    var MonthProjectCountArticle = document.getElementById('MonthProjectCountArticle');
    var MonthProjectSumPriceArticle = document.getElementById('MonthProjectSumPriceArticle');

    MonthProjectCountArticle.style.minWidth = count + 'em';
    MonthProjectSumPriceArticle.style.minWidth = count + 'em';
}